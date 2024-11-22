////ПЕРЕДАЧА ПАРАМЕТРОВ ФУНКЦИИ
////1. Передача параметра по ссылке 
//void SwapRef(ref int x,ref  int y)
//{
//    int temp = x;
//    x = y;
//    y = temp;
//}
//int a = 6, b = 8;
//Console.WriteLine($"a={a} b={b}");
//SwapRef(ref a,ref b );
//Console.WriteLine($"a={a} b={b}");
////2. Передача параметра по значению
//void Swap(int x,int y)
//{
//    int temp = x;
//    x = y;
//    y = temp;
//}
//int A = 6, B = 8;
//Console.WriteLine($"a={A} b={B}");
//Swap(a,b);
//Console.WriteLine($"a={B} b={B}");
////3. Выходные параметры
//int res;    
//void SumOut(int a,int b,out int res)
//{
//    res = a + b;
//}
//SumOut(a,b, out res);
//Console.WriteLine("res="+res);
////Входные параметры. Модификатор In
//int Square(int n)
//{
//    return n * n;
//}
//Console.WriteLine(Square(5));
////Массив параметров и ключевое слово params
//int SumParams(params int[] numbers)
//{
//    int sum = 0;
//    foreach (var item in numbers)
//    {
//        sum += item;
//    }
//    return sum;
//}
//Console.WriteLine(SumParams(5,7,3,7,4,8));
////Массив в качестве параметра
//int SumMas(int[] mas)
//{
//    int sum = 0;
//    foreach (var item in mas)
//    {
//        sum += item;
//    }
//    return sum;
//}
//int[] massive = new int[10];
//for (int i = 0; i < massive.Length; i++)
//{
//    massive[i] = new Random().Next(10, 100);
//    Console.Write(massive[i]+"");
//}
//Console.WriteLine("Sum="+SumMas(massive));
////Рекурсивные функции
////Рекурсия это - представялет ссобой такую конструкцию при которой функция вызывает саму себя это примайа рикурсея
//long Factorial(int n)
//{
//    long F = 1;
//    for (int i = 0; i <= n; i++) F *= i;
//    return F;
//}
////Рекурсивная функция факториала
//long FactorialRecursive(int n)
//{
//    if (n == 1 || n == 0) return 1;
//    else return n*FactorialRecursive(n-1);
//}
//int F1(int n)
//{
//    if (n == 0) return 0;
//    else if (n > 0 && n % 2 == 0) return F1(n / 2);
//    else return 1 + F1(n-1);   
//}
//Console.WriteLine(Factorial(5));
//Console.WriteLine(FactorialRecursive(5));
int SumMas(int[] mas)
{
    int sum = 0;
    foreach (var item in mas)
    {
        sum += item;
    }
    return sum;
}
int[] massive = new int[10];
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(10, 100);
    Console.Write(massive[i] + " ");
}
Console.WriteLine("Sum=" + SumMas(massive));





















