using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Box
{
    internal class BoxSameProp : EqualityComparer<Box>
    {
        public override bool Equals(Box x, Box y)
        {
            if(x.Height == y.Height && x.Width == y.Width && x.Length == y.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box obj)
        {
            return obj.GetHashCode();
        }
    }
}
