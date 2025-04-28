using System.Diagnostics;

Console.Clear();
double P1,P2,P3,L1,L2,L3,L4,L5,L6, media, mediaListas, mediaProvas, mediaFinal;
const double MEDIA_APROVACAO = 6.0;


Console.Write("Informe a nota da L1:");
L1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Informe a nota da L2:");
L2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Informe a nota da L3:");
L3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da L4:");
L4 = Convert.ToDouble(Console.ReadLine());


Console.Write("Informe a nota da L5:");
L5 = Convert.ToDouble(Console.ReadLine());


Console.Write("Informe a nota da L6:");
L6 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da P1:");
P1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da P2:");
P2 = Convert.ToDouble(Console.ReadLine());

mediaListas = (L1 + L2 + L3 + L4 + L5 + L6) / 6 * 0.2;
mediaProvas = (P1 + P2) / 2 * 0.8 ;
mediaFinal = mediaListas + mediaProvas; 

//media = 0;

//media = (P1 + P2) / 2;

//Console.WriteLine($"Média: {media:N1}");

bool aprovado = mediaFinal >= MEDIA_APROVACAO;

if (aprovado)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Aprovado com média {mediaFinal :N1}");
}
else
{
    Console.Write("Informe a nota da P3:");
    P3 = Convert.ToDouble(Console.ReadLine());
    
    mediaProvas = (Math.Max(P1, P2) + P3) / 2 * 0.8;
    mediaFinal = mediaListas + mediaProvas;

    if (mediaFinal >= MEDIA_APROVACAO)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Aprovado com média {mediaFinal:N1}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Reprovado com média {mediaFinal:N1}");    
    }
}

//Fazer programa não aceitar notas >10
Console.ResetColor();