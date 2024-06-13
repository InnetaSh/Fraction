using Fractions;
Fraction drib1 = new Fraction(4, 8);

Fraction drib2 = new Fraction(1, 2);
Fraction drib3 = new Fraction();

Console.WriteLine($"{drib1}\t{drib2}");
drib1.Simplify();
Console.WriteLine($"{drib1}\t{drib2}");

drib3 = drib1 + drib2;
Console.WriteLine($"{drib1} + {drib2} = {drib3}");
drib3 = drib1 - drib2;
Console.WriteLine($"{drib1} - {drib2} = {drib3}");
drib3 = drib1 * drib2;
Console.WriteLine($"{drib1} * {drib2} = {drib3}");
drib3 = drib1 / drib2;
Console.WriteLine($"{drib1} / {drib2} = {drib3}");
Console.WriteLine($"{drib1} == {drib2} = {drib1 == drib2}");
Console.WriteLine($"{drib1} != {drib2} = {drib1 != drib2}");
