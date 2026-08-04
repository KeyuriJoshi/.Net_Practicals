using System;

class ExpenseTracker
{
    static void Main()
    {
        string[] category = new string[10];
        double[] amount = new double[10];
        int count = 0;
        int choice = 0;

        do
        {
            Console.WriteLine("\n===== Expense Tracker =====");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Calculate Total Expense");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            try
            {
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (count == 10)
                        {
                            Console.WriteLine("Expense list is full.");
                            break;
                        }

                        Console.Write("Enter Expense Category: ");
                        category[count] = Console.ReadLine();

                        Console.Write("Enter Expense Amount: ");
                        amount[count] = double.Parse(Console.ReadLine());

                        if (amount[count] < 0)
                        {
                            throw new Exception("Expense amount cannot be negative.");
                        }

                        count++;
                        Console.WriteLine("Expense Added Successfully.");
                        break;

                    case 2:
                        if (count == 0)
                        {
                            Console.WriteLine("No expenses available.");
                        }
                        else
                        {
                            Console.WriteLine("\nCategory\tAmount");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine(category[i] + "\t\t" + amount[i]);
                            }
                        }
                        break;

                    case 3:
                        double total = 0;

                        for (int i = 0; i < count; i++)
                        {
                            total += amount[i];
                        }

                        Console.WriteLine("Total Expense = " + total);
                        break;

                    case 4:
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input! Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        } while (choice != 4);
    }
}
