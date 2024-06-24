# sinal
Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.

Console.Clear();
string[] tipos =
{
   "O Zumbi",
   "O Assassino",
   "O Psicopata",
   "O Palhaço",
   "O Carniceiro",
   "O Matador",
   "O Vampiro",
   "O Maluco",
   "O Vingador",
   "O Monstro",
   "O Bruxo",
   "O Demonio"
};
string[] variedades =
{
   "Endiabrado",
   "Radioativo",
   "Endemoniado",
   "Vermelho",
   "Possuido",
   "Macabro",
   "Sem cabeca",
   "Cadeirante",
   "Sem olhos",
   "Oculto",
   "Caido",
   "Amaldiçado",
   "Invocado",
   "Desconhecido",
   "Esquecido",
   "Costurado",
   "Anormal",
   "Lugebre",
   "Tenebroso",
   "Imortal",
   "Burro",
   "Do inferno",
   "Abandonado",
   "Desconhecido",
   "Do cemiterio",
   "Sem lugar",
   "Da lua cheia",
   "Do velho poço",
   "Do porão",
   "Sanguinario",
   "Pertubado",
};
 
string tipo, variedade;
 
int mes = 0; 
int dia = 0;
 
 
 
while (dia < 1 || dia > 31 )
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(":::::Noite de Terror:::::");
    Console.ResetColor();
    
    Console.Write("\nQual o dia do aniversario da vitima?(1 até 31):");
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia < 1 || dia > 31)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nEsse dia não é compatível");
        Console.ResetColor();
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
                                                                
    }
} 

while (mes < 1 || mes > 12)
{
    Console.Write("Qual o mes do aniversario da vitima?(1 até 12):");
    mes = Convert.ToInt32(Console.ReadLine());
    if (mes < 1 || mes > 12)
    {  
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nEsse mês não é compatível");
        Console.ResetColor();
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    }
}

if (mes<8&&dia>30&&mes%2==0)
{Console.WriteLine("\nDia não bate com mes!");
return;}
else if(mes==2&&dia>29)
{Console.WriteLine("\nDia não bate com mes!");
return;}
if (mes>7&&dia>30&&mes%2==1)
{Console.WriteLine("\nDia não bate com mes!");
return;}
 
tipo = tipos[mes - 1];
variedade = variedades[dia - 1];
 Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\n{tipo} {variedade}");
Console.ResetColor();


kakakakakkakakaka

int conversor = 0;

Console.Write("Digite um número ");
string digitado = Console.ReadLine()!;

if (!int.TryParse(digitado, out conversor))
{
    Console.WriteLine("voce é burro? eu falei pra digitar um número");
    return;
}

if (conversor < 0)
{
    throw new ArgumentException("n existe mes negativo seu jumento");
    return;
}

Console.WriteLine("\nmacaco");
