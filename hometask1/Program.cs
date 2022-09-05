Console.WriteLine("Пожалуйста Введите число");
 double v;
 double z;
double o;

v = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите сптепень");
z=Convert.ToDouble(Console.ReadLine());

o = Math.Pow(v,z);

Console.WriteLine("вот ваш ответ" +v+ "в степени" +z+ "равно" +o+ "!" ) ;