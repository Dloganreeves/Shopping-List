bool runProgram = true;
decimal sum = 0;
    Dictionary<string, decimal> StoreMenu = new Dictionary<string, decimal>
{
    { "milk", 1.99m },
    { "apple", 0.99m },
    { "cake", 10.00m },
    { "water", 8.00m },
    { "cookies", 5.69m },
    { "carrots", 3.45m },
    { "chips", 2.99m },
    { "kale", 4.50m }
}; List<string> ShoppingList = new List<string>();
Console.WriteLine("Item      Price");
    foreach (KeyValuePair<string, decimal> kvp in StoreMenu)
    {
        
        Console.WriteLine($"{kvp.Key}      ${kvp.Value}");
    }
Console.WriteLine("Welcome to the Market");
//displays the dictionary
while (runProgram)
{

      
    //saves items user wishes to buy to a list

    
    Console.WriteLine("Please select a menu item to purchase.");
    string choice = Console.ReadLine().ToLower().Trim();
    if (StoreMenu.ContainsKey(choice))
    {
        ShoppingList.Add(choice);
        Console.WriteLine($" Adding {choice} to cart at ${StoreMenu[choice]}");
    }
    else
    {
        Console.WriteLine("Sorry we do not have those. Please select item from the menu.");
    }
    Console.WriteLine("Would you like to purchase anything else? 'yes' or 'no'");
    string choice2 = Console.ReadLine().ToLower().Trim();  
     if (choice2 == "yes") 
    {
        
    }
     else if (choice2 == "no")
    {
        Console.WriteLine("Thanks for your order!");
        Console.WriteLine("Here is your receipt:");
        foreach (string Item in ShoppingList)
        {
            Console.WriteLine($"{Item}   {StoreMenu[Item]}");
            sum += StoreMenu[Item];
        }
        Console.WriteLine($"Your total is {sum}");
        runProgram = false;

    }
}
