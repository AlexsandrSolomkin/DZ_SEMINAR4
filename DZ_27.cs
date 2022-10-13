// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

//====================================================================================================================

//Решение:

// Console.WriteLine("Введите целое, положительное число, для получения суммы всех его элементов: ");
// int num = int.Parse(Console.ReadLine()!);
// string numArray = Convert.ToString(num);

// Console.WriteLine($"Ответ: {SumElementNum(num, numArray.Length)}");

// double SumElementNum(double array, int arrayLength){
//     double res = 0;
//     int i2 = 1;
//     for (int i = 0; i < arrayLength; i++){
//         double elementArray = Math.Floor(array / i2) % 10;
//         i2 *= 10;
//         res = res + elementArray;
//     }
//     return res;
// }

//====================================================================================================================