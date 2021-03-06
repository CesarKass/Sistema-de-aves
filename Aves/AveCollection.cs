using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aves
{
    class AveCollection<T>
    {
        // Declare an array to store the data elements.
       private T[] arr = new T[100];

       // Define the indexer to allow client code to use [] notation.
       public T this[int i]
       {
           get { return arr[i]; }
           set { arr[i] = value; }
       }
    }
}
