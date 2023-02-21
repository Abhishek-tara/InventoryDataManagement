namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Data Management");
            string path = "D:\\c#\\257\\InventoryManagement\\InventoryManagement\\InventoryJson.json";

            FetchInventory fetchInventory = new FetchInventory();

            InventoryDetails data = fetchInventory.Read(path);

            Console.WriteLine("\nTypes of Rice: ");

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine("weight: "+data.typesOfRice[i].weight +"kg");
                Console.WriteLine("price: "+data.typesOfRice[i].price +"/kg");

                int price = data.typesOfRice[i].weight * data.typesOfRice[i].price;
                Console.WriteLine("Price of {0} for {1}kg is {2}: ", data.typesOfRice[i].name, data.typesOfRice[i].weight,price);

                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("\nTypes of Pulses: ");
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine("weight: " + data.typesOfPulses[i].weight+"kg");
                Console.WriteLine("price: " + data.typesOfPulses[i].price+"/kg");

                int price = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;
                Console.WriteLine("Price of {0} for {1}kg is {2}: ", data.typesOfPulses[i].name, data.typesOfPulses[i].weight,price);
                
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("\nTypes of Wheat: ");
            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine("weight: " + data.typesOfWheat[i].weight+"kg");
                Console.WriteLine("price: " + data.typesOfWheat[i].price+"/kg");

                int price = data.typesOfWheat[i].weight * data.typesOfWheat[i].price;

                Console.WriteLine("Price of {0} for {1}kg is {2}: ", data.typesOfWheat[i].name, data.typesOfWheat[i].weight,price);
               
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
