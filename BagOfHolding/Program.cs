namespace MyGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a bag that can hold any type of GameItem
            BagOfHolding<GameItem> mixedBag = new BagOfHolding<GameItem>();
            mixedBag.Add(new Weapon("Sword", 15));
            mixedBag.Add(new Food("Apple", 5));
            mixedBag.Add(new Key("Dungeon", 1));
            mixedBag.Add(new Key("Treasure", 2));

            // Display the contents of the bag
            Console.WriteLine("Mixed bag count: " + mixedBag.Count());
            List<GameItem> all = mixedBag.GetAll();
            int i;
            for (i = 0; i < all.Count; i++)
            {
                Console.WriteLine(all[i].ToString());
            }

            // Ask the user if they want to activate a key
            Console.WriteLine("\nDo you want to activate a key from your bag");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes" || response.ToLower() == "y")
            {
                Console.WriteLine("Which key do you want to activate?");
                string keyName = Console.ReadLine();
                mixedBag.ActivateKey(keyName);



            }
            else
            {
                Console.WriteLine("No key activated.");




















            }
        }
    }
}
