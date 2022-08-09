// Очищаем консоль и запрашиваем у пользователя текст с элементами массива
Console.Clear(); 
Console.WriteLine("Введите текст, или элементы массива через пробел: \n");
string textInput = Console.ReadLine();

// Формируем массив из элементов текста
string[] textArray = textInput.Split(' ');

// Создаём и формируем новый массив из элементов массива выше, удовлетворяющих условию <= 3 символа
int k = 0;
string[] selectArray = new string[textArray.Length];
for (int i = 0; i < textArray.Length; i++)
{
    if (textArray[i].Length <= 3)
    {
        selectArray[k] = textArray[i];
        k++;
    }
}

// Перезаписываем массив исключая пустые элементы и выводим в консоль
Array.Resize(ref selectArray, k);
Console.WriteLine("\n[" + string.Join(", ", textArray) + "] -> [" + string.Join(", ", selectArray) + "]\n");
