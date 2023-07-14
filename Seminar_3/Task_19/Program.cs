// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");

string number = Console.ReadLine();
int[] array = new int[number.Length];

for (int i = 0; i < number.Length; i++)
{
    array[i] = Convert.ToInt32(number[i].ToString());
}

int k =0;
int j= array.Length-1;
if (array[k]== array[j])
{
k++;
j--;
while  (j <=k );
Console.WriteLine($"Число {number} является палиндромом."); 
}
        
 else{
Console.WriteLine($"Число {number}  не является палиндромом.");
}
