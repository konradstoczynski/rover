using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rovertest
{
    class Grid : IGrid
    {
        private readonly int gridSize;

        public int PointX { get; set; }

        public int PointY { get; set; }

        public Grid(int gridSize)
        {
            this.gridSize = gridSize;

            PointX = 0;
            PointX = 0;
        }

        public void MoveForwardOnXAxis()
        {
            if (PointX < this.gridSize)
            {
                PointX++;
            }
        }

        public void MoveBackwardOnXAxis()
        {
            if (PointX > 0)
            {
                PointX--;
            }
        }

        public void MoveForwardOnYAxis()
        {
            if (PointY < this.gridSize)
            {
                PointY++;
            }
        }

        public void MoveBackwardOnYAxis()
        {
            if (PointY > 0)
            {
                PointY--;
            }
        }
    }
}
