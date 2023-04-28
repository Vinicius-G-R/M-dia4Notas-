double n1, n2, n3, n4, media;
Console.WriteLine("--- Média ---\n");
Console.WriteLine("Digite suas notas abaixo:");
Console.Write("Digite a 1° nota.: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    
Console.Write("Digite a 2° nota.: ");
    n2 = Convert.ToDouble(Console.ReadLine());
    
Console.Write("Digite a 3° nota.: ");
    n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a 4° nota.: ");
    n4 = Convert.ToDouble(Console.ReadLine());
    
    media = (n1 + n2 + n3 + n4) / 4;

if (n1 > 10 || n1 < 0 ||
    n2 > 10 || n2 < 0 ||
    n3 > 10 || n3 < 0 ||
    n4 > 10 || n4 < 0 ) {

Console.WriteLine("\nDigite somente notas entre 0 e 10.");

  }
else {
if (media > 5) {   
     Console.Write($"\nVocê ficou com média {media}. Resultado: ");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Aprovado.");
Console.ResetColor();

}
  else if (media == 5) {
     Console.Write($"\nVocê ficou com média {media}. Resultado: ");   Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Recuperação.");
Console.ResetColor();
  }
  else {
      Console.Write($"\nVocê ficou com média {media}. Resultado: ");  
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Reprovado.");
Console.ResetColor();
  }
    }