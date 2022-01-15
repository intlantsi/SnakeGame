using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using SnakeGame.Models.Enums;

namespace SnakeGame.Models
{
    public class SnakePiece
    {
        readonly int size = 10;
        readonly int dl = Snake.FieldStep;

        public SnakePiece(SnakePiece head)
        {
            Lead = head;
            if (Lead!=null)
            {
                MoveDirection = Lead.MoveDirection;
                CalculateOffset();
            }    
        }

        #region Свойства
        public SnakePiece Lead { get; }
        public Direction MoveDirection { get; set; }
        public Point Position { get; set; }
        #endregion

        #region Методы
        private void CheckHeadDirection()
        {
            if (Lead != null && MoveDirection != Lead.MoveDirection)
            {
                switch (Lead.MoveDirection)
                {
                    case Direction.Up:
                    case Direction.Down:
                        if (Position.X == Lead.Position.X)
                            MoveDirection = Lead.MoveDirection;
                        break;
                    case Direction.Left:
                    case Direction.Right:
                        if (Position.Y == Lead.Position.Y)
                            MoveDirection = Lead.MoveDirection;
                        break;
                    default:
                        break;
                }
            }
        }

        public void CalculatePosition()
        {
            int signX = MoveDirection == Direction.Right ? 1 : MoveDirection == Direction.Left ? -1 : 0;
            int signY = MoveDirection == Direction.Down ? 1 : MoveDirection == Direction.Up ? -1 : 0;

            Position = new Point(Position.X + signX * size, Position.Y + signY * size);
            CheckHeadDirection();
        }

        private void CalculateOffset()
        {
            if (Lead != null)
            {
                int signX = MoveDirection == Direction.Right ? -1 : MoveDirection == Direction.Left ? 1 : 0;
                int signY = MoveDirection == Direction.Down ? -1 : MoveDirection == Direction.Up ? 1 : 0;

                Position = new Point(Lead.Position.X + signX * size, Lead.Position.Y + signY * size);
            }
        }
        #endregion
    }
}
