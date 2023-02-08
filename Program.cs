// See https://aka.ms/new-console-template for more information
int number1 = 0;
int number2 = 0;
Console.WriteLine("DIGITE EL PRIMER NÚMERO:");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("DIGITE EL SEGUNDO NÚMERO:");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("VALOR ABSOLUTO DE " + number1 + " : " + Math.Abs(number1));
Console.WriteLine("VALOR ABSOLUTO DE " + number2 + " : " + Math.Abs(number2));
Console.WriteLine("POTENCIA DE " + number1 + " : " + Math.Pow(number1, number1));
Console.WriteLine("POTENCIA DE " + number2 + " : " + Math.Pow(number2, number2));
Console.WriteLine("RAIZ CUADRADA DE " + number1 + " : " + (number1 * number1));
Console.WriteLine("RAIZ CUADRADA DE " + number2 + " : " + (number2 * number2));
Console.WriteLine("SENO DE " + number1 + " : " + Math.Sin(number1));
Console.WriteLine("SENO DE " + number2 + " : " + Math.Sin(number2));
Console.WriteLine("COSENO DE " + number1 + " : " + Math.Cos(number1));
Console.WriteLine("COSENO DE " + number2 + " : " + Math.Cos(number2));
Console.WriteLine("NÚMERO MÁXIMO DE " + number1 + " Y " + number2 + " : " + Math.Max(number1, number2));
Console.WriteLine("NÚMERO MÍNIMO DE " + number1 + " Y " + number2 + " : " + Math.Min(number1, number2));
Console.WriteLine("PARTE ENTERA DE " + number1 + " : " + Math.Truncate(Convert.ToDecimal(number1)));
Console.WriteLine("PARTE ENTERA DE " + number2 + " : " + Math.Truncate(Convert.ToDecimal(number2)));
Console.WriteLine("REDONDEO DE " + number1 + " : " + Math.Round(Math.Truncate(Convert.ToDecimal(number1))));
Console.WriteLine("REDONDEO DE " + number2 + " : " + Math.Round(Math.Truncate(Convert.ToDecimal(number2))));

