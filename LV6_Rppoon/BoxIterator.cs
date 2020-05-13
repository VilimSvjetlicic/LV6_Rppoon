using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_Rppoon
{
    class BoxIterator: IBoxIterator
    {
        private Box box;
        private int currentPosition;
        public BoxIterator(Box box)
        {
            this.box = box;
            this.currentPosition = 0;
        }
        public bool IsDone { get { return this.currentPosition >= this.box.Count; } }
        public Product Current { get { return box[currentPosition]; } }
        public Product First() { return box[currentPosition]; }
        public Product Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return box[currentPosition];
            }
        }
    }
}
