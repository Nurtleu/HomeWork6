using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Array
    {
        private int[] array = new int[20];
        public int this[int i]
        {
            get
            {
                return array[i];
            }

            set
            {
                array[i] = (value * value);
            }

        }
    }
}
