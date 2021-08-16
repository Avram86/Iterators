using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class ThreeElemCollection<T> : IEnumerable<T>
    {
        public ThreeElemCollection(T elem1, T elem2, T elem3)
        {
            Elem1 = elem1;
            Elem2 = elem2;
            Elem3 = elem3;
        }
        public T Elem1 { get; }
        public T Elem2 { get; }
        public T Elem3 { get; }
       
        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorInternal();
        }
        private IEnumerator<T> GetEnumeratorInternal()
        {
            //va fi 0
            Console.WriteLine("Iteration beginning");
            yield return default;

            Console.WriteLine("Iteration 1");
            yield return Elem1;

            Console.WriteLine("Iteration 2");
            yield return Elem2;

            Console.WriteLine("Iteration 3");
            yield return Elem3;

            Console.WriteLine("Iteration end");
        }

    }
}
