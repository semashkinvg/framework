﻿ 
// Accord Math Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2015
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

// ======================================================================
// This code has been generated by a tool; do not edit manually. Instead,
// edit the T4 template Distance.tt so this file can be regenerated. 
// ======================================================================

namespace Accord.Math
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Accord.Math.Distances;

    /// <summary>
    ///   Static class Distance. Defines a set of methods defining distance measures.
    /// </summary>
    /// 
    public static partial class Distance
    {

        /// <summary>
        ///   Gets the SquareMahalanobis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The SquareMahalanobis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double SquareMahalanobis(double[] x, double[] y)
        {
            return cacheSquareMahalanobis.Distance(x, y);
        }

        /// <summary>
        ///   Gets the SquareMahalanobis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="chol"></param>
        /// 
        /// <returns>The SquareMahalanobis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double SquareMahalanobis(double[] x, double[] y, Accord.Math.Decompositions.CholeskyDecomposition chol)
        {
            return new SquareMahalanobis(chol).Distance(x, y);
        }

        /// <summary>
        ///   Gets the SquareMahalanobis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="svd"></param>
        /// 
        /// <returns>The SquareMahalanobis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double SquareMahalanobis(double[] x, double[] y, Accord.Math.Decompositions.SingularValueDecomposition svd)
        {
            return new SquareMahalanobis(svd).Distance(x, y);
        }

        /// <summary>
        ///   Gets the SquareMahalanobis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="precision"></param>
        /// 
        /// <returns>The SquareMahalanobis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double SquareMahalanobis(double[] x, double[] y, double[,] precision)
        {
            return new SquareMahalanobis(precision).Distance(x, y);
        }

        private static readonly SquareMahalanobis cacheSquareMahalanobis = new SquareMahalanobis();


        /// <summary>
        ///   Gets the Canberra distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Canberra distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Canberra(double[] x, double[] y)
        {
            return cacheCanberra.Distance(x, y);
        }

        private static readonly Canberra cacheCanberra = new Canberra();


        /// <summary>
        ///   Gets the Modular distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="modulo"></param>
        /// 
        /// <returns>The Modular distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Modular(double x, double y, int modulo)
        {
            return new Modular(modulo).Distance(x, y);
        }

        /// <summary>
        ///   Gets the Modular distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="modulo"></param>
        /// 
        /// <returns>The Modular distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Modular(int x, int y, int modulo)
        {
            return new Modular(modulo).Distance(x, y);
        }

        /// <summary>
        ///   Gets the Manhattan distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Manhattan distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Manhattan(int[] x, int[] y)
        {
            return cacheManhattan.Distance(x, y);
        }

        /// <summary>
        ///   Gets the Manhattan distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Manhattan distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Manhattan(double[] x, double[] y)
        {
            return cacheManhattan.Distance(x, y);
        }

        private static readonly Manhattan cacheManhattan = new Manhattan();


        /// <summary>
        ///   Gets the Hamming distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Hamming distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Hamming(byte[] x, byte[] y)
        {
            return cacheHamming.Distance(x, y);
        }

        /// <summary>
        ///   Gets the Hamming distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Hamming distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Hamming(double[] x, double[] y)
        {
            return cacheHamming.Distance(x, y);
        }

        /// <summary>
        ///   Gets the Hamming distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Hamming distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Hamming(System.Collections.BitArray x, System.Collections.BitArray y)
        {
            return cacheHamming.Distance(x, y);
        }

        private static readonly Hamming cacheHamming = new Hamming();


        /// <summary>
        ///   Gets the Hellinger distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Hellinger distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Hellinger(double[] x, double[] y)
        {
            return cacheHellinger.Distance(x, y);
        }

        private static readonly Hellinger cacheHellinger = new Hellinger();


        /// <summary>
        ///   Gets the Mahalanobis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Mahalanobis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Mahalanobis(double[] x, double[] y)
        {
            return cacheMahalanobis.Distance(x, y);
        }

        /// <summary>
        ///   Gets the Mahalanobis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="chol"></param>
        /// 
        /// <returns>The Mahalanobis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Mahalanobis(double[] x, double[] y, Accord.Math.Decompositions.CholeskyDecomposition chol)
        {
            return new Mahalanobis(chol).Distance(x, y);
        }

        /// <summary>
        ///   Gets the Mahalanobis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="svd"></param>
        /// 
        /// <returns>The Mahalanobis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Mahalanobis(double[] x, double[] y, Accord.Math.Decompositions.SingularValueDecomposition svd)
        {
            return new Mahalanobis(svd).Distance(x, y);
        }

        /// <summary>
        ///   Gets the Mahalanobis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="precision"></param>
        /// 
        /// <returns>The Mahalanobis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Mahalanobis(double[] x, double[] y, double[,] precision)
        {
            return new Mahalanobis(precision).Distance(x, y);
        }

        private static readonly Mahalanobis cacheMahalanobis = new Mahalanobis();


        /// <summary>
        ///   Gets the Chessboard distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Chessboard distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Chessboard(int[] x, int[] y)
        {
            return cacheChessboard.Distance(x, y);
        }

        /// <summary>
        ///   Gets the Chessboard distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Chessboard distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Chessboard(double[] x, double[] y)
        {
            return cacheChessboard.Distance(x, y);
        }

        private static readonly Chessboard cacheChessboard = new Chessboard();


        /// <summary>
        ///   Gets the Cosine distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Cosine distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Cosine(double[] x, double[] y)
        {
            return cacheCosine.Distance(x, y);
        }

        private static readonly Cosine cacheCosine = new Cosine();


        /// <summary>
        ///   Gets the Minkowski distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="p"></param>
        /// 
        /// <returns>The Minkowski distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Minkowski(int[] x, int[] y, double p)
        {
            return new Minkowski(p).Distance(x, y);
        }

        /// <summary>
        ///   Gets the Minkowski distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="p"></param>
        /// 
        /// <returns>The Minkowski distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Minkowski(double[] x, double[] y, double p)
        {
            return new Minkowski(p).Distance(x, y);
        }

        /// <summary>
        ///   Gets the BrayCurtis distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The BrayCurtis distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double BrayCurtis(double[] x, double[] y)
        {
            return cacheBrayCurtis.Distance(x, y);
        }

        private static readonly BrayCurtis cacheBrayCurtis = new BrayCurtis();


        /// <summary>
        ///   Gets the Chebyshev distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Chebyshev distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Chebyshev(double[] x, double[] y)
        {
            return cacheChebyshev.Distance(x, y);
        }

        private static readonly Chebyshev cacheChebyshev = new Chebyshev();


        /// <summary>
        ///   Gets the SquareEuclidean distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The SquareEuclidean distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double SquareEuclidean(double[] x, double[] y)
        {
            return cacheSquareEuclidean.Distance(x, y);
        }

        /// <summary>
        ///   Gets the SquareEuclidean distance between two points.
        /// </summary>
        /// 
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// 
        /// <returns>The SquareEuclidean distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double SquareEuclidean(double x1, double y1, double x2, double y2)
        {
            return cacheSquareEuclidean.Distance(x1, y1, x2, y2);
        }

        private static readonly SquareEuclidean cacheSquareEuclidean = new SquareEuclidean();


        /// <summary>
        ///   Gets the Levenshtein distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Levenshtein distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Levenshtein(string x, string y)
        {
            return cacheLevenshtein.Distance(x, y);
        }

        private static readonly Levenshtein cacheLevenshtein = new Levenshtein();


        /// <summary>
        ///   Gets the Euclidean distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Euclidean distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Euclidean(double[] x, double[] y)
        {
            return cacheEuclidean.Distance(x, y);
        }

        /// <summary>
        ///   Gets the Euclidean distance between two points.
        /// </summary>
        /// 
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// 
        /// <returns>The Euclidean distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Euclidean(double x1, double y1, double x2, double y2)
        {
            return cacheEuclidean.Distance(x1, y1, x2, y2);
        }

        /// <summary>
        ///   Gets the Euclidean distance between two points.
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// 
        /// <returns>The Euclidean distance between x and y.</returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static double Euclidean(System.Tuple<double,double> x, System.Tuple<double,double> y)
        {
            return cacheEuclidean.Distance(x, y);
        }

        private static readonly Euclidean cacheEuclidean = new Euclidean();

    }
}

