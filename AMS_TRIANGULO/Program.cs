Console.WriteLine("Digite o número :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite um número para o tamanho do triângulo :");
int num2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("");
int j, i;
for ( j = 0; j < num2; j++)
{
  for ( i = j; i < num2; i++)
  {
    
       Console.Write(num1);
       
    
    }
    Console.WriteLine("");
  }
  
Console.WriteLine($" número :{num1} , repetido : {num2}");




