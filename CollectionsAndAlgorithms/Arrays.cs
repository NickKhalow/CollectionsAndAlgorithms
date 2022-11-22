namespace CollectionsAndAlgorithms
{
    public class Arrays
    {
        public void Example()
        {
            var ofInts1 = new int[10];//10 free cells
            var ofInts2 = new int[] {0, 5};//2 elements 0 and 5

            var element1 = ofInts1[0]; // first element 0
            var element2 = ofInts2[2]; // exception! out of range

            ofInts1[5] = 100; //set 100 at 6'th cell of array
        }
    }
}