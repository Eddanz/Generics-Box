namespace Generics_Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxCollection = new BoxCollection();
            boxCollection.Add(new Box(10, 10, 10));
            boxCollection.Add(new Box(20, 20, 20));
            boxCollection.Add(new Box(30, 30, 30));
            boxCollection.Add(new Box(40, 40, 40));
            boxCollection.Add(new Box(10, 10, 10)); //Lägger till dubblett för att säkerställa att den ignorerar den

            Display(boxCollection);

            Console.WriteLine("\n----------------------------------------------------------\n");

            boxCollection.Remove(new Box(20, 20, 20));

            Display(boxCollection);

            Console.WriteLine("\n----------------------------------------------------------\n");

            if (boxCollection.Contains(new Box(10, 10, 10)))
            {
                Console.WriteLine("\nBox exists");
            }
            else
            {
                Console.WriteLine("\nBox doesn't exist");
            }
        }

        public static void Display(BoxCollection boxColl)
        {
            foreach (Box box in boxColl)
            {
                Console.WriteLine(box);
            }
        }
    }
}
