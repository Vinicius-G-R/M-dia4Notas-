int qtdAdultoNaoBebidaAlcolica, qtdAdultoBebidaAlcolica, qtdCrianca, adultosComESemBebidaAlcolica, todos;
    Console.Write("Digite a quantidade de adultos que NÃO consomem bebida alcoólica: ");
    qtdAdultoNaoBebidaAlcolica = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite a quantidade de adultos que consomem bebida alcoólica: ");
    qtdAdultoBebidaAlcolica = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite a quantidade de crianças: ");
    qtdCrianca = Convert.ToInt32(Console.ReadLine());
    
    Console.Clear();
    
    double carne, acompanhamento, cerveja, refrigerante, agua;
    
    adultosComESemBebidaAlcolica = qtdAdultoNaoBebidaAlcolica + qtdAdultoBebidaAlcolica; todos = adultosComESemBebidaAlcolica + qtdCrianca;
    
    //Calculo
    
    carne = adultosComESemBebidaAlcolica * 0.4 + qtdCrianca * 0.2;
    agua = todos * 0.4; acompanhamento = todos * 0.2;
    cerveja = qtdAdultoBebidaAlcolica * 2;
    refrigerante = (qtdCrianca + qtdAdultoNaoBebidaAlcolica) * 0.5;
    
    //Tabela
    
    Console.ForegroundColor = ConsoleColor.Red;
    
    Console.WriteLine("\n--- Churrasco ---\n");
    Console.ResetColor();
    Console.WriteLine($"Carne.............: {carne:N1} Kl.");
    Console.WriteLine($"Acompanhamentos...: {acompanhamento:N1} Kl.");
    Console.WriteLine($"Cerveja...........: {cerveja:N1} l.");
    Console.WriteLine($"Refrigerante......: {refrigerante:N1} l.");
    Console.WriteLine($"Água..............: {agua:N1} l.");
    
