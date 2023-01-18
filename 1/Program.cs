//TASK 1
Random rand=new Random();
int r=rand.Next(100,1000);
System.Console.WriteLine($"Взято случайное число {r}");
System.Console.WriteLine($"Вторая цифра числа взятая методом перевода в строку {r.ToString()[1]}");
System.Console.WriteLine($"Вторая цифра числа взятая математическим методом {(r-(r/100*100)-r%10)/10}");