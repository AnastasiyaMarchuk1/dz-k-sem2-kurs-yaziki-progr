Console.WriteLine("Vvedi dvuznachnoye chislo:");
int num = Convert.ToInt32(Console.ReadLine());
if (num>=10 && num<=99)
{
  int firstdigit=num/10;
  int seconddigit=num%10;
  if (firstdigit>seconddigit)
  {
    Console.WriteLine("Pervaya cifra bolshe vtoroy");
  }  
  else if (firstdigit<seconddigit)
  {
    Console.WriteLine("Pervaya cifra menshe vtoroy");
  }
  else
  {
  Console.WriteLine("Pervaya i vtoraya cifri ravny");  
  }  
  }
else
{
    Console.WriteLine("Chislo ne prinadlezhit zadannomu promezhutku");
}