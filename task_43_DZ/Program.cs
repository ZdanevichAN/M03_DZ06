// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
double Prompt(string message){//метод ввода данных от пользователя double
    double result = 0;
        try{
            Console.Write(message);
            result = double.Parse(Console.ReadLine());
        }
        catch{Console.Write("Ошибка ввода данных методу Prompt");}
    return result;
}

double[] GetStraight(double b1,double k1,double b2,double k2){//метод  пересечения прямых
    double[] result = new double[2];double x=0;double y =0;
        try{
            result[0] = Math.Round((-(b1-b2)/(k1-k2)),2);
            result[1] = Math.Round((k1*result[0]+b1),2);
        }
        catch{Console.WriteLine("\n Ошибка ввода данных методу GetStraight");}
    return result;
}

double[] cross  = GetStraight(Prompt("\n для уравнения первой прямой (y = k1 * x + b1), введите b1: "),
                           Prompt("\n для уравнения первой прямой (y = k1 * x + b1), введите k1: "),
                           Prompt("\n для уравнения второй прямой (y = k2 * x + b2), введите b2: "),
                           Prompt("\n для уравнения второй прямой (y = k2 * x + b2), введите k2: "));
Console.WriteLine($"\n координаты пересечения: [{String.Join(" | ",cross)}]");