//Made By Silktz 

string ponto;

Console.WriteLine("Fluxograma de Engenharia");
Console.WriteLine("Use o <S> para 'SIM', ou outro para 'NÃO' <N>");

Console.WriteLine("O objeto esta se movendo? ");
bool estaSeMovendo = Console.ReadLine()!.Trim().Substring(0,1).ToUpper() == "S";

Console.Write("Deveria? ");
bool deveria = Console.ReadLine()!.Trim().Substring(0,1).ToUpper() == "S";

if (!estaSeMovendo)
{
    if (!deveria)
    {
     ponto = "Otimo, Sem Problemas.";
    }
    else
    {
     ponto = "use WD-40.";
    }
}
else
{
    if (deveria)
    {
     ponto = "otimo!";
    }
    else
    {
     ponto = "use silver tape.";
    }
}
Console.WriteLine(ponto);
Console.Clear();
