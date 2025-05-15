namespace DataStructures
{
    public class Program
    {
        static void Main()
        {
            var dynamicArray = new DynamicArray<string>(1);

            dynamicArray.Add("Jose");
            dynamicArray.Add("Cristian");
            dynamicArray.Add("Sergio");

            dynamicArray.InsertAt(1, "Jessica");

            Console.WriteLine($"count {dynamicArray.Count}");

            for (int i = 0; i < dynamicArray.Count; i++)
            {
                Console.WriteLine(dynamicArray.Get(i));
            }
        }
    }
}