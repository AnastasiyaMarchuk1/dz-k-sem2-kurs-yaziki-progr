Console.WriteLine("Введи число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0) 
{
       if (num % 23 == 0)
       {
        Console.WriteLine($"Число {num} одновременно кратно и 7, и 23.");
       } 
}
else
{
    Console.WriteLine($"Число {num} одновременно не кратно и 7, и 23.");
}