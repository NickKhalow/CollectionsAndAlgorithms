namespace CollectionsAndAlgorithms
{
    public class LinkedLists
    {
        public void Example()
        {
            var ofInts = new LinkedList<int>(new[] {0, 5});
            //2 elements 0 and 5

            var element1 = ofInts.First;
            // first element 0
            ofInts.AddFirst(10); //add to start 5
            ofInts.AddLast(10); //add to end 10
            
            var five = ofInts.Find(5); //get node with 5
            var prev = five!.Previous; //previous from
            var next = five!.Next; //next from
        }
    }
}