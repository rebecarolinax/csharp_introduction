﻿Console.WriteLine($"Digite o placar do time 1:");
int time1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o placar do time 2:");
int time2 = int.Parse(Console.ReadLine()!);


if ( time1 < time2)
{
    Console.WriteLine($"Vitória do time 2.");
}

else if ( time2 < time1)
{
    Console.WriteLine($"Vitória do time 1.");
}

 else if ( time1 == time2)
{
    Console.WriteLine($"Empate");
}