using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Box
{
    internal class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection _boxCollection;
        private int currentIndex;
        private Box currentBox;

        public BoxEnumerator(BoxCollection boxCollection)
        {
            this._boxCollection = boxCollection;
            this.currentIndex = -1;
            currentBox = default(Box);
        }

        public Box Current
        {
            get { return currentBox; }
        }

        object IEnumerator.Current => Current;

        public int Count
        {
            get
            {
                return _boxCollection.Count;
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(++currentIndex >= _boxCollection.Count)
            {
                return false;
            }
            else
            {
                currentBox = _boxCollection[currentIndex];
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
