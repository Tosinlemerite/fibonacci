// See https://aka.ms/new-console-template for more information

string ans = "yes";
long n = 0;

while (ans.ToLower() == "yes" || ans.ToLower() == "y")
{

  Console.Clear();
  Console.Beep();
  Console.WriteLine("*******************************************U");
  Console.WriteLine("Programe to compute sum of fibonacci numbers");
  Console.WriteLine("********************************************");
  Console.WriteLine();

  {
     int a = 0, b = 1, c, i;
    
      Console.Write("Fibonacci number:");
      n = Convert.ToInt32(Console.ReadLine());
      Console.Write(a+" "+b+" ");
      for(i=2;i<n;++i) {
         c = a + b;
         Console.Write(c+" ");
         a = b;
         b = c;  
   }

   Console.WriteLine();
    Console.Beep();
    Console.Write("Do you want to continue? Yes(Y) | No(N): ");
    ans = Console.ReadLine();
  }

  Console.WriteLine();
  Console.Beep();
  Console.WriteLine("Thank you for using this app.");


}



    