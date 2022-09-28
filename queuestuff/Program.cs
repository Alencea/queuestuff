namespace queuestuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IQ queue_ = new myQueue();

            queue_.Enqueue(7);
            queue_.Enqueue(4);
            queue_.Enqueue(29);
            queue_.Enqueue(64);

            Console.WriteLine(queue_.Dequeue());
            Console.WriteLine(queue_.Dequeue());
            Console.WriteLine(queue_.Dequeue());
            Console.WriteLine(queue_.Dequeue());
            Console.WriteLine(queue_.Dequeue());

            queue_.Enqueue(45);
            queue_.Enqueue(8);
            queue_.Enqueue(8);
            queue_.Enqueue(16);

            Console.WriteLine(queue_.Dequeue());
            Console.WriteLine(queue_.Dequeue());
            Console.WriteLine(queue_.Dequeue());
            Console.WriteLine(queue_.Dequeue());
        }
    }
}