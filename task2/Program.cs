namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> num = new List<int>();
            string choose;
            do
            
            {
                
                Console.WriteLine("Menu:");

                Console.WriteLine("P - Print numbers");

                Console.WriteLine("A - Add a number");

                Console.WriteLine("M - Display mean of the numbers");

                Console.WriteLine("S - Display the smallest number");

                Console.WriteLine("L - Display the largest number");

                Console.WriteLine("F - Find a number in the list");//task shearch

                Console.WriteLine("C - Clear the list");//task shearch

                Console.WriteLine("Q - Quit");


                Console.Write("Enter your choice: ");

                choose = Console.ReadLine().ToLower();
                if (choose == "p")
                {
                    if (num.Count == 0)
                    {
                        
                    
                        Console.WriteLine("The list is empty");
                    }
                    
                    else
                        
                    {
                        Console.Write("( ");
                        for (int i = 0; i < num.Count; i++)
                            
                        {
                            Console.Write(num[i] + " ");

                        }
                        
                        Console.WriteLine(")");
                    }
                }
                else if (choose == "a")
                {
                    Console.Write("Enter a number to add: ");

                    int Addtonumber = Convert.ToInt32(Console.ReadLine());

                    num.Add(Addtonumber);

                    Console.WriteLine( Addtonumber +  " the number added");
                }

                else if (choose == "m")
                {
                    if (num.Count == 0)
                        
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    
                    else
                        
                    {
                        int sum = 0;

                        for (int i = 0; i < num.Count; i++)
                        {

                            sum += num[i];

                        }
                        double mean = sum / num.Count;

                        Console.WriteLine($"The mean is {mean}");
                    }
                }
                
                else if (choose == "s")
                {
                    if (num.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int smallest = num[0];
                        for (int i = 1; i < num.Count; i++)
                        {
                            if (num[i] < smallest)

                                smallest = num[i];

                        }
                        Console.WriteLine($"The smallest number is {smallest}");
                    }
                }
                else if (choose == "l")
                {
                    if (num.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int largest = num[0];
                        for (int i = 1; i < num.Count; i++)
                        {
                            if (num[i] > largest)
                                largest = num[i];

                        }
                        Console.WriteLine($"The largest number is {largest}");
                    }
                }

                //task shearch:

                else if (choose == "F")
                {
                    if (num.Count == 0)
                    {
                        Console.WriteLine("The list is empty");
                    }
                    else
                    {
                        Console.Write("Enter the number to search for: ");
                        int target = Convert.ToInt32(Console.ReadLine());

                        bool found = false;
                        int index = -1;
                        int i = 0;

                        while (i < num.Count) //or: for(int i=0;i<num.count;i++)
                        {
                            if (num[i] == target)
                            {
                                found = true;
                                index = i;
                                break;
                            }
                            i++;
                        }

                        if (found)
                        {
                            Console.WriteLine($"{target} found at index {index}");
                        }
                        else
                        {
                            Console.WriteLine($"{target} not found in the list");
                        }
                    }
                }
                //task shearch:

                else if (choose == "C")
                {
                    num.Clear();

                    Console.WriteLine("The list has been cleared");

                }





                else if (choose == "q")
                    
                {

                    Console.WriteLine("Goodbye");
                }
                
                else
                    
                {
                  
                    Console.WriteLine("Unknown selection, please try again");
                }
                

            }
            while (choose != "q");

        }

    }
}

