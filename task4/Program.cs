
Console.WriteLine("Vvedi naturalnoye chislo");
int num = Convert.ToInt32(Console.ReadLine());
int kolvocifr=1;
int helper=num;
int helper2=num;

if (num<10)
{
   Console.WriteLine(num); 
}
else
{
while (helper>=10)
{
    helper=helper/10;
    kolvocifr=kolvocifr+1;
}
    int[] cifri= new int[kolvocifr]
    i=kolvocifr-1;
while (i>=0)
{
    
    cifri[i]=helper2%10;
    helper2=helper2/10;
    i=i-1;
}
i2=0;
while(i2<kolvocifr-1)
{
  Console.WriteLine(cifri[i2]+", ");
  i2=i2+1;   
}
Console.WriteLine(cifri[i2]);
}






































    
   
   
   
   
   