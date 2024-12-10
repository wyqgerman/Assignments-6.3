namespace Assignments_6._3
{
    class CallQueue
    {
        private LinkedList<string> queue; 
        public CallQueue()
        {
            queue = new LinkedList<string>();
        }

        public void Enqueue(string customer)
        {
            queue.AddLast(customer);
            Console.WriteLine($"Enqueued: {customer}");
        }

        public string Dequeue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("The queue is empty. No customer to dequeue.");
                return null;
            }
            string dequeuedCustomer = queue.First.Value;
            queue.RemoveFirst();
            Console.WriteLine($"Dequeued: {dequeuedCustomer}");
            return dequeuedCustomer;
        }

        public void DisplayQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
                return;
            }

            Console.WriteLine("Current call queue:");
            foreach (var customer in queue)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
