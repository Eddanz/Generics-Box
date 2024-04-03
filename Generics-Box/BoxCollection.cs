using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Box
{
    internal class BoxCollection : ICollection<Box>
    {
        List<Box> innerBoxList;

        public BoxCollection()
        {
            innerBoxList = new List<Box>();
        }

        public Box this[int index]
        {
            get { return (Box)innerBoxList[index]; }
            set { innerBoxList[index] = value; }
        }

        public int Count
        {
            get
            {
                return innerBoxList.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerBoxList.Add(item);
            }
            else
            {
                Console.WriteLine("Box already exists!\n");
            }
        }

        public void Clear()
        {
            innerBoxList.Clear();
        }

        public bool Contains(Box item)
        {
            bool result = false;
            if (innerBoxList.Contains(item)) 
            {
                result = true;
            }
            return result;
        }

        public bool Contains(Box item, EqualityComparer<Box> compare)
        {
            bool result = false;
            foreach (Box box in innerBoxList)
            {
                if(compare.Equals(box, item))
                {
                    result = true;
                }
            }
            return result;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool removed = false;
            if (Contains(item))
            {
                innerBoxList.Remove(item);
                removed = true;
            }
            else
            {
                Console.WriteLine("Box dosen't exist");
            }
            return removed;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}
