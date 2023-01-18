//Task2
System.Console.Write("Введите число: ");
int chislo=Convert.ToInt32(Console.ReadLine());
if (chislo.ToString().Length<3){
    System.Console.WriteLine("Длинна числа <3");
}else{
    System.Console.WriteLine($"3-я цифра числа {chislo} = {chislo.ToString()[2]}");
}ss