double H, B, area;

Console.Write("Base....: ");
B = Convert.ToDouble(Console.ReadLine());

Console.Write("Altura..: ");
H = Convert.ToDouble(Console.ReadLine());

area = (B * H) / 2;

Console.WriteLine($"\nÁrea....: {area:N3}");

