using System;

/// <summary>
/// A class reguarding matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a matrix
    /// </summary>
    /// <param name="matrix">The matrix to find the determinate of</param>
    /// <returns>The determinant or -1</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (-1);
        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
            return (-1);

        if (matrix.GetLength(0) == 2)
            return (Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2));

        double a = matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1];
        double b = matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0];
        double c = matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0];

        return (Math.Round(matrix[0, 0] * a - matrix[0, 1] * b + matrix[0, 2] * c, 2));
    }
}
