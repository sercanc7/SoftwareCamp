namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int,int>Person = new MyDictionary<string,int,int>();

            Person.Add("Sercan", 1, 2);
            Person.Add("Koray", 3, 4);
            Person.Add("Neşe", 5, 6);
            Person.Add("Selçuk", 7, 8); ;


        }
    }
}