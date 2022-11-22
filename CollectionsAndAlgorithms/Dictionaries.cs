namespace CollectionsAndAlgorithms
{
    public class Dictionaries
    {
        public void Example()
        {
            var grades1 = new Dictionary<string, int>(); //empty dictionary
            var grades2 = new Dictionary<string, int> //2 notes,
            {
                ["Egor"] = 5, //egor has 5 grade
                ["Mike"] = 3  //mike has 3 grade
            }; 

            var element1 = grades1["John"]; // exception, no John in dictionary
            grades1.Add("Anton", 4); //add Anton's grade

            grades1["Anton"] = 2; //Rewrite data by Anton's key
        }
    }
}