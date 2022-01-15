using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame.Models
{
    public class SnakeStngs
    {

        #region Fields
        Size fieldSize;
        #endregion

        #region MyRegion
        public SnakeStngs()
        {

        }
        #endregion

        #region Properties
        public int Speed { get; set; }
        public Size FieldSize 
        {
            get => fieldSize;
            set
            {
                if (fieldSize!=value)
                {
                    fieldSize = value;
                    StartPoint = new Point(fieldSize.Width / 2, fieldSize.Height / 2);
                }
            }
        }
        public Point StartPoint { get; private set; }
        #endregion
    }
}
