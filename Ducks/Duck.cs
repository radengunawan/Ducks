﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class Duck : IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public Duck()
        {
           
        }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"A {this.Size} inch {this.Kind}";
        }

        public Duck (KindOfDuck kind, int size)
        {
            this.Kind = kind;
            this.Size = size;
        }

    }
}
