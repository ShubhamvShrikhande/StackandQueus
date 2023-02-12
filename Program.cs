namespace StackandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.display();
            queue.Dequeue();
            queue.display();
            queue.Dequeue();
            queue.display();
            queue.Dequeue();
            queue.display(); ;
        }
    }
}