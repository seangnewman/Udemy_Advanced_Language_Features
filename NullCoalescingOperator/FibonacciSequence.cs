using System.Collections;
using System.Collections.Generic;

namespace AdvancedFeatures
{
    class FibonacciSequence:IEnumerable, IEnumerator
    {
        private int current = 1;
        private int previous = 1;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            int old = current;
            current = current + previous;
            previous = old;
            return current <= 100;
        }

        public void Reset()
        {
            current = 1;
            previous = 1;
        }

        object IEnumerator.Current
        {
            get
            {
                return current;
            }
        }

        


    }

    
}
