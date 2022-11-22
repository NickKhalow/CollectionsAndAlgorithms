namespace CollectionsAndAlgorithms
{
    public class StackAndQueue
    {
        public void Example()
        {
            var stack1 = new Stack<int>(); //FIFO
            stack1.Push(10); //add 10
            stack1.Push(5); //add 5
            var peek1 = stack1.Peek(); //look at last inserted element 5
            var pop = stack1.Pop(); //get and remove last inserted element 5

            var queue1 = new Queue<int>(); //FILO
            queue1.Enqueue(10); //add 10
            queue1.Enqueue(5); //add 5
            var peek2 = queue1.Peek(); //look at first element 10
            var dequeued = queue1.Dequeue(); //get and remove first element 5
        }
    }
}