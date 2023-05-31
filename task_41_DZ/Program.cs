// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

int Prompt(string message){//метод запроса ввода данных int от пользователя
    int num = 0;
        try{
            Console.Write(message);
            num = int.Parse(Console.ReadLine());
        }
        catch{Console.Write("\n \n Ошибка ввода данных метода Prompt");}
    return num;
}

int[] GetUserNum(int size){//метод ввода пользователем чисел в массив int
    int[] result = new int[size];
        try{
            for(int i=0;i<size;i++){
                if(i+1!=3 || ((i+1)%10)!=3){result[i] = Prompt($"\n Введите {i+1}-ое число:  ");}
                else{result[i] = Prompt($"\n Введите {i+1}-ье число:  ");}
            }
        }
        catch{Console.WriteLine("\n \n Ошибка ввода переменных метода GetUserNum");}
    return result;
}

void CountPositive(int[] array){//метод подсчета положительных чисел
    int result=0;
        try{
            foreach(var el in array){
                if(el>0){result++;}
            }
        }
        catch{Console.WriteLine("\n \n Ошибка ввода данных методу CountPositive");}
    Console.WriteLine($"\n В массиве [{String.Join(" | ",array)}] \n чисел  больше нуля: {result}");
}

int size = Prompt("Введите количество чисел для ввода: ");
int[] array = GetUserNum(size);
CountPositive(array);