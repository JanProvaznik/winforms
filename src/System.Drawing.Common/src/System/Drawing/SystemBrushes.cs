﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Drawing;

public static class SystemBrushes
{
#if NET9_0_OR_GREATER
#pragma warning disable SYSLIB5002 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
    private static bool s_colorSetOnLastAccess = SystemColors.UseAlternativeColorSet;
#pragma warning restore SYSLIB5002 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#endif
    private static readonly object s_systemBrushesKey = new();

    public static Brush ActiveBorder => FromSystemColor(SystemColors.ActiveBorder);
    public static Brush ActiveCaption => FromSystemColor(SystemColors.ActiveCaption);
    public static Brush ActiveCaptionText => FromSystemColor(SystemColors.ActiveCaptionText);
    public static Brush AppWorkspace => FromSystemColor(SystemColors.AppWorkspace);

    public static Brush ButtonFace => FromSystemColor(SystemColors.ButtonFace);
    public static Brush ButtonHighlight => FromSystemColor(SystemColors.ButtonHighlight);
    public static Brush ButtonShadow => FromSystemColor(SystemColors.ButtonShadow);

    public static Brush Control => FromSystemColor(SystemColors.Control);
    public static Brush ControlLightLight => FromSystemColor(SystemColors.ControlLightLight);
    public static Brush ControlLight => FromSystemColor(SystemColors.ControlLight);
    public static Brush ControlDark => FromSystemColor(SystemColors.ControlDark);
    public static Brush ControlDarkDark => FromSystemColor(SystemColors.ControlDarkDark);
    public static Brush ControlText => FromSystemColor(SystemColors.ControlText);

    public static Brush Desktop => FromSystemColor(SystemColors.Desktop);

    public static Brush GradientActiveCaption => FromSystemColor(SystemColors.GradientActiveCaption);
    public static Brush GradientInactiveCaption => FromSystemColor(SystemColors.GradientInactiveCaption);
    public static Brush GrayText => FromSystemColor(SystemColors.GrayText);

    public static Brush Highlight => FromSystemColor(SystemColors.Highlight);
    public static Brush HighlightText => FromSystemColor(SystemColors.HighlightText);
    public static Brush HotTrack => FromSystemColor(SystemColors.HotTrack);

    public static Brush InactiveCaption => FromSystemColor(SystemColors.InactiveCaption);
    public static Brush InactiveBorder => FromSystemColor(SystemColors.InactiveBorder);
    public static Brush InactiveCaptionText => FromSystemColor(SystemColors.InactiveCaptionText);
    public static Brush Info => FromSystemColor(SystemColors.Info);
    public static Brush InfoText => FromSystemColor(SystemColors.InfoText);

    public static Brush Menu => FromSystemColor(SystemColors.Menu);
    public static Brush MenuBar => FromSystemColor(SystemColors.MenuBar);
    public static Brush MenuHighlight => FromSystemColor(SystemColors.MenuHighlight);
    public static Brush MenuText => FromSystemColor(SystemColors.MenuText);

    public static Brush ScrollBar => FromSystemColor(SystemColors.ScrollBar);

    public static Brush Window => FromSystemColor(SystemColors.Window);
    public static Brush WindowFrame => FromSystemColor(SystemColors.WindowFrame);
    public static Brush WindowText => FromSystemColor(SystemColors.WindowText);

    public static Brush FromSystemColor(Color c)
    {
        if (!c.IsSystemColor)
        {
            throw new ArgumentException(SR.Format(SR.ColorNotSystemColor, c.ToString()));
        }

#if NET9_0_OR_GREATER
#pragma warning disable SYSLIB5002 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
        if (s_colorSetOnLastAccess != SystemColors.UseAlternativeColorSet)
        {
            s_colorSetOnLastAccess = SystemColors.UseAlternativeColorSet;

            // We need to clear the SystemBrushes cache, when the ColorMode had changed.
            Gdip.ThreadData.Remove(s_systemBrushesKey);
        }
#pragma warning restore SYSLIB5002 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#endif

        if (!Gdip.ThreadData.TryGetValue(s_systemBrushesKey, out object? tempSystemBrushes)
            || tempSystemBrushes is not Brush[] systemBrushes)
        {
            systemBrushes = new Brush[(int)KnownColor.WindowText + (int)KnownColor.MenuHighlight - (int)KnownColor.YellowGreen];
            Gdip.ThreadData[s_systemBrushesKey] = systemBrushes;
        }

        int idx = (int)c.ToKnownColor();
        if (idx > (int)KnownColor.YellowGreen)
        {
            idx -= (int)KnownColor.YellowGreen - (int)KnownColor.WindowText;
        }

        idx--;

        Debug.Assert(idx >= 0 && idx < systemBrushes.Length, "System colors have been added but our system color array has not been expanded.");

        return systemBrushes[idx] ??= new SolidBrush(c, true);
    }
}
