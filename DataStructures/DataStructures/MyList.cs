using System;

namespace DataStructures
{
    public class MyList
    {
        public int Count { get; set; }
        public int Capacity { get; set; }
        public int LastValueIndex { get; set; }

        private int[] _myListArray = new int[0];

        public void Add(int item)
        {
            Insert(LastValueIndex++, item);
        }

        public int this[int index]
        {
            get { return _myListArray[index]; }
        }

        public void Insert(int index, int item)
        {
            if (Capacity == Count)
                Capacity = Capacity == 0 ? 1 : Capacity + 1;

            var tempArray = new int[Capacity];
            _myListArray.CopyTo(tempArray, 0);

            tempArray[index] = item;

            for (var i = index; i < Capacity - 1; i++)
            {
                tempArray[i + 1] = _myListArray[i];
            }

            _myListArray = tempArray;
            Count++;
        }

        public void Sort()
        {
            Quicksort(_myListArray, _myListArray.GetLowerBound(0), _myListArray.GetUpperBound(0));
        }

        public static void Quicksort(int[] items, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = items[(left + right) / 2];
 
            while (i <= j)
            {
                while (items[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (items[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i > j) continue;

                // Swap
                var tmp = items[i];
                items[i] = items[j];
                items[j] = tmp;
 
                i++;
                j--;
            }
 
            // Recursive calls
            if (left < j)
            {
                Quicksort(items, left, j);
            }
 
            if (i < right)
            {
                Quicksort(items, i, right);
            }
        }

        public int[] ToArray()
        {
            return _myListArray.Clone() as int[];
        }
    }
}