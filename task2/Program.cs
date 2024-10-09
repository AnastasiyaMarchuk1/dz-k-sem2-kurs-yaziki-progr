Console.WriteLine("Введи koordinatu x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи koordinatu y:");
int y = Convert.ToInt32(Console.ReadLine());
if (x>0 || x<0 && y>0 || y<0)
{
if (x>0 && y>0)
{
    Console.WriteLine($"Tochka ({x};{y}) nahoditsa v 1 koord chetverti");
}
else if (x<0 && y>0)
{
    Console.WriteLine($"Tochka ({x};{y}) nahoditsa vo 2 koord chetverti");
}
else if (x<0 && y<0)
{
    Console.WriteLine($"Tochka ({x};{y}) nahoditsa v 3 koord chetverti");
}
else if (x>0 && y>0)
{
    Console.WriteLine($"Tochka ({x};{y}) nahoditsa v 4 koord chetverti");
}
}
else
{
    Console.WriteLine("Tochka nahoditsa na styke koord chetvertey");
}