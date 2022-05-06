/* Написать программу, которая из имеющегося массива строк формирует массив
из строк, длина которых меньше либо равно 3 символа. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
решении не рекоммендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.*/

string[] array1 = new string[6] { "abcd", "!!", "123", "NLO", "10", "hello" };
string[] array2 = new string[array1.Length];
int count = 0;

CreateNewArray(array1, array2);
PrintArray(array2);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
}
void CreateNewArray(string[] array, string[] array2)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}





