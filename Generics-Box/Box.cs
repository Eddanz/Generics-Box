using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Box
{
    internal class Box : IEquatable<Box>
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public Box(int height, int width, int length) 
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
        }

        public bool Equals(Box? other)
        {
            if(new BoxSameProp().Equals(this, other))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public override string ToString()
        {
            return $"Box with dimensions: Height = {Height}, Length = {Length}, Width = {Width}";
        }
    }
}
