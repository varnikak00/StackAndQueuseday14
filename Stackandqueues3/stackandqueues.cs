using System;
using System.Collections.Generic;
using System.Text;

namespace Stackandqueues3
{
    class stackandqueues_uc3_uc4
    {
        NodeQueue head, tail;
        private NodeQueue temp;

        public void Queue()
        {
            this.head = this.tail = null;
        }

        //UC3 to add a queue
        public void enqueue(int key)
        {


          


            if (this.tail == null)
            {
                this.head = this.tail = temp;
                return;
            }


            this.tail.next = temp;
            this.tail = temp;

        }

        void PrintQueue()
        {
            throw new NotImplementedException();
        }

    }
}
