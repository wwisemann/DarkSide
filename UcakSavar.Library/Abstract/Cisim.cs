using DarkSide.Library.Enum;
using DarkSide.Library.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DarkSide.Library.Abstract
{
    internal abstract class Cisim : PictureBox, IMoved
    {
        public Size MovementSpaceSizes { get; }

        public int MovementDistance { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom 
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }
        protected Cisim(Size movementSpaceSizes)
        {
            Image = Image.FromFile($@"Icon\{GetType().Name}.png");
            MovementSpaceSizes = movementSpaceSizes;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public bool MoveIt(Direction direction)
        {
            switch (direction)
            {
                case Direction.up:
                    return MoveUp();                   
                case Direction.right:
                    return MoveRight();
                case Direction.down:
                    return MoveDown();
                case Direction.left:
                    return MoveLeft();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        private bool MoveLeft()
        {
            if (Left == 0) return true;

            var newLeft = Left - MovementDistance;
            var willItOwerflow = newLeft < 0;
            Left = willItOwerflow ? 0 : newLeft;

            return Left == 0;
        }

        private bool MoveDown()
        {
            var newBottom = Bottom + MovementDistance;
            var willItOwerflow = newBottom > MovementSpaceSizes.Height;

            Bottom = willItOwerflow ? MovementSpaceSizes.Height : newBottom;

            return Bottom == MovementSpaceSizes.Height;
        }

        private bool MoveRight()
        {
            if (Right == MovementSpaceSizes.Width) return true;
            {
                var newRight = Right + MovementDistance;
                var willItOwerflow = newRight > MovementSpaceSizes.Width;

                Right = willItOwerflow ? MovementSpaceSizes.Width : newRight;
                
                return Right == MovementSpaceSizes.Width;
            }
        }

        private bool MoveUp()
        {
            if (Top == 0) return true;

            var newTop = Top - MovementDistance;
            var willItOwerflow = newTop < 0;
            Top = willItOwerflow ? 0 : newTop;

            return Top == 0;
        }
    }
}
