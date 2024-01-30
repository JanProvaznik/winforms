﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace System.Drawing.Imaging;

/// <summary>
///  Defines a 5 x 5 matrix that contains the homogeneous coordinates for the RGBA space.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public sealed class ColorMatrix
{
    private float _matrix00;
    private float _matrix01;
    private float _matrix02;
    private float _matrix03;
    private float _matrix04;
    private float _matrix10;
    private float _matrix11;
    private float _matrix12;
    private float _matrix13;
    private float _matrix14;
    private float _matrix20;
    private float _matrix21;
    private float _matrix22;
    private float _matrix23;
    private float _matrix24;
    private float _matrix30;
    private float _matrix31;
    private float _matrix32;
    private float _matrix33;
    private float _matrix34;
    private float _matrix40;
    private float _matrix41;
    private float _matrix42;
    private float _matrix43;
    private float _matrix44;

    /// <summary>
    ///  Initializes a new instance of the <see cref='ColorMatrix'/> class.
    /// </summary>
    public ColorMatrix()
    {
        // Setup identity matrix by default

        _matrix00 = 1.0f;
        // matrix01 = 0.0f;
        // matrix02 = 0.0f;
        // matrix03 = 0.0f;
        // matrix04 = 0.0f;
        // matrix10 = 0.0f;
        _matrix11 = 1.0f;
        // matrix12 = 0.0f;
        // matrix13 = 0.0f;
        // matrix14 = 0.0f;
        // matrix20 = 0.0f;
        // matrix21 = 0.0f;
        _matrix22 = 1.0f;
        // matrix23 = 0.0f;
        // matrix24 = 0.0f;
        // matrix30 = 0.0f;
        // matrix31 = 0.0f;
        // matrix32 = 0.0f;
        _matrix33 = 1.0f;
        // matrix34 = 0.0f;
        // matrix40 = 0.0f;
        // matrix41 = 0.0f;
        // matrix42 = 0.0f;
        // matrix43 = 0.0f;
        _matrix44 = 1.0f;
    }

    /// <summary>
    ///  Represents the element at the 0th row and 0th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix00
    {
        get => _matrix00;
        set => _matrix00 = value;
    }

    /// <summary>
    ///  Represents the element at the 0th row and 1st column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix01
    {
        get => _matrix01;
        set => _matrix01 = value;
    }

    /// <summary>
    ///  Represents the element at the 0th row and 2nd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix02
    {
        get => _matrix02;
        set => _matrix02 = value;
    }

    /// <summary>
    ///  Represents the element at the 0th row and 3rd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix03
    {
        get => _matrix03;
        set => _matrix03 = value;
    }

    /// <summary>
    ///  Represents the element at the 0th row and 4th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix04
    {
        get => _matrix04;
        set => _matrix04 = value;
    }

    /// <summary>
    ///  Represents the element at the 1st row and 0th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix10
    {
        get => _matrix10;
        set => _matrix10 = value;
    }

    /// <summary>
    ///   Represents the element at the 1st row and 1st column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix11
    {
        get => _matrix11;
        set => _matrix11 = value;
    }

    /// <summary>
    ///  Represents the element at the 1st row and 2nd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix12
    {
        get => _matrix12;
        set => _matrix12 = value;
    }

    /// <summary>
    ///  Represents the element at the 1st row and 3rd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix13
    {
        get => _matrix13;
        set => _matrix13 = value;
    }

    /// <summary>
    ///  Represents the element at the 1st row and 4th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix14
    {
        get => _matrix14;
        set => _matrix14 = value;
    }

    /// <summary>
    ///  Represents the element at the 2nd row and 0th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix20
    {
        get => _matrix20;
        set => _matrix20 = value;
    }

    /// <summary>
    ///  Represents the element at the 2nd row and 1st column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix21
    {
        get => _matrix21;
        set => _matrix21 = value;
    }

    /// <summary>
    ///  Represents the element at the 2nd row and 2nd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix22
    {
        get => _matrix22;
        set => _matrix22 = value;
    }

    /// <summary>
    ///  Represents the element at the 2nd row and 3rd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix23
    {
        get => _matrix23;
        set => _matrix23 = value;
    }

    /// <summary>
    ///  Represents the element at the 2nd row and 4th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix24
    {
        get => _matrix24;
        set => _matrix24 = value;
    }

    /// <summary>
    ///  Represents the element at the 3rd row and 0th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix30
    {
        get => _matrix30;
        set => _matrix30 = value;
    }

    /// <summary>
    ///  Represents the element at the 3rd row and 1st column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix31
    {
        get => _matrix31;
        set => _matrix31 = value;
    }

    /// <summary>
    ///  Represents the element at the 3rd row and 2nd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix32
    {
        get => _matrix32;
        set => _matrix32 = value;
    }

    /// <summary>
    ///  Represents the element at the 3rd row and 3rd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix33
    {
        get => _matrix33;
        set => _matrix33 = value;
    }

    /// <summary>
    ///  Represents the element at the 3rd row and 4th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix34
    {
        get => _matrix34;
        set => _matrix34 = value;
    }

    /// <summary>
    ///  Represents the element at the 4th row and 0th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix40
    {
        get => _matrix40;
        set => _matrix40 = value;
    }

    /// <summary>
    ///  Represents the element at the 4th row and 1st column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix41
    {
        get => _matrix41;
        set => _matrix41 = value;
    }

    /// <summary>
    ///  Represents the element at the 4th row and 2nd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix42
    {
        get => _matrix42;
        set => _matrix42 = value;
    }

    /// <summary>
    ///  Represents the element at the 4th row and 3rd column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix43
    {
        get => _matrix43;
        set => _matrix43 = value;
    }

    /// <summary>
    ///  Represents the element at the 4th row and 4th column of this <see cref='ColorMatrix'/>.
    /// </summary>
    public float Matrix44
    {
        get => _matrix44;
        set => _matrix44 = value;
    }

    /// <summary>
    ///  Initializes a new instance of the <see cref='ColorMatrix'/> class with the elements in the specified matrix.
    /// </summary>
    [CLSCompliant(false)]
    public ColorMatrix(float[][] newColorMatrix)
    {
        _matrix00 = newColorMatrix[0][0];
        _matrix01 = newColorMatrix[0][1];
        _matrix02 = newColorMatrix[0][2];
        _matrix03 = newColorMatrix[0][3];
        _matrix04 = newColorMatrix[0][4];
        _matrix10 = newColorMatrix[1][0];
        _matrix11 = newColorMatrix[1][1];
        _matrix12 = newColorMatrix[1][2];
        _matrix13 = newColorMatrix[1][3];
        _matrix14 = newColorMatrix[1][4];
        _matrix20 = newColorMatrix[2][0];
        _matrix21 = newColorMatrix[2][1];
        _matrix22 = newColorMatrix[2][2];
        _matrix23 = newColorMatrix[2][3];
        _matrix24 = newColorMatrix[2][4];
        _matrix30 = newColorMatrix[3][0];
        _matrix31 = newColorMatrix[3][1];
        _matrix32 = newColorMatrix[3][2];
        _matrix33 = newColorMatrix[3][3];
        _matrix34 = newColorMatrix[3][4];
        _matrix40 = newColorMatrix[4][0];
        _matrix41 = newColorMatrix[4][1];
        _matrix42 = newColorMatrix[4][2];
        _matrix43 = newColorMatrix[4][3];
        _matrix44 = newColorMatrix[4][4];
    }

#if NET9_0_OR_GREATER
    /// <summary>
    ///  Initializes a new instance of the <see cref='ColorMatrix'/> class with the elements in the specified matrix.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="newColorMatrix"/> did not have 25 values.</exception>
    public unsafe ColorMatrix(ReadOnlySpan<float> newColorMatrix)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(newColorMatrix.Length, 25, nameof(newColorMatrix));

        fixed (float* f = &_matrix00)
        {
            newColorMatrix.CopyTo(new Span<float>(f, 25));
        }
    }
#endif

    /// <summary>
    ///  Gets or sets the value of the specified element of this <see cref='ColorMatrix'/>.
    /// </summary>
    public unsafe float this[int row, int column]
    {
        get
        {
            if (row is < 0 or > 4)
            {
                throw new IndexOutOfRangeException(nameof(row));
            }

            if (column is < 0 or > 4)
            {
                throw new IndexOutOfRangeException(nameof(column));
            }

            fixed (float* f = &_matrix00)
            {
                return f[row * 5 + column];
            }
        }
        set
        {
            if (row is < 0 or > 4)
            {
                throw new IndexOutOfRangeException(nameof(row));
            }

            if (column is < 0 or > 4)
            {
                throw new IndexOutOfRangeException(nameof(column));
            }

            fixed (float* f = &_matrix00)
            {
                f[row * 5 + column] = value;
            }
        }
    }

    internal ref float GetPinnableReference() => ref _matrix00;
}
