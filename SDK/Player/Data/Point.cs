// MIT License - Copyright (C) The Mono.Xna Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

namespace PixelVision8.Player
{
    /// <summary>
    /// Describes a 2D-point.
    /// </summary>
    public struct Point
    {
        
        /// <summary>
        /// The x coordinate of this <see cref="Point"/>.
        /// </summary>
        // [DataMember]
        public int X;

        /// <summary>
        /// The y coordinate of this <see cref="Point"/>.
        /// </summary>
        // [DataMember]
        public int Y;
        private readonly int _blockSize;

        public int C 
        {
            get { return X / _blockSize; }
            set { X = value * _blockSize; }
        } 
        public int R
        {
            get { return Y / _blockSize; }
            set { Y = value * _blockSize; }
        }

        /// <summary>
        /// Constructs a point with X and Y from two values.
        /// </summary>
        /// <param name="x">The x coordinate in 2d-space.</param>
        /// <param name="y">The y coordinate in 2d-space.</param>
        public Point(int x, int y, int blockSize = Constants.SpriteSize)
        {
            X = x;
            Y = y;
            _blockSize = blockSize;
        }

        /// <summary>
        /// Returns a <see cref="string"/> representation of this <see cref="Point"/> in the format:
        /// {X:[<see cref="X"/>] Y:[<see cref="Y"/>]}
        /// </summary>
        /// <returns><see cref="string"/> representation of this <see cref="Point"/>.</returns>
        public override string ToString()
        {
            return "{X:" + X + " Y:" + Y + "}";
        }

    }
}


