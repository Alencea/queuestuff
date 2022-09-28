using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queuestuff
{
    internal interface IQ
    {
        public void Enqueue(int item);

        public int? Dequeue();

        public int? Peek();

        public void Clear();

        public int Count();
    }
    internal class myQueue : IQ
    {
       
        int?[] _queue = new int?[10];
        int currentSpot = 1;
       

        public void Clear()
        {
            Array.Clear(_queue, 0, _queue.Length);
            //foreach(var item in _queue)
            //{
            //    Dequeue();
            //}
            currentSpot = 0;
        }

        public int Count()
        {
            int tmp = currentSpot;
            tmp++;
            return tmp;
        }

        public int? Dequeue()
        {

        

        int? temp = _queue[currentSpot];
            
        for (int i = 0; i < _queue.Length-1 && queuestuff[i +1] != null; i++)
			{
                _queue[i] = _queue[i + 1];
                
			}

            currentSpot = Math.Max(--currentSpot, 0);

            return temp;
        }

        public void Enqueue(int item)
        {
            _queue[currentSpot] = item;
            currentSpot++;
        
        }

        public int? Peek() => _queue[0];
            /*
        {
           int? tmp = _queue[0];
            return tmp;
        }
            */
    }
}
