namespace CollectionsAndAlgorithms
{
    public class Lists
    {
        public void Example()
        {
            var ofInts1 = new List<int>(10); //10 reserved free cells
            var ofInts2 = new List<int> {0, 5}; //2 elements 0 and 5

            var element1 = ofInts1[0]; // exception, first element not exists
            ofInts2.Add(10); //add to end 10

            ofInts1[5] = 100; //set 100 at 6'th cell of array
        }
    }
}