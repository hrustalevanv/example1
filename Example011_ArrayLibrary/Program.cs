/* Перепишем данную задачу с помощью методов и генератором псевдо случайных чисел
1. возьмем метод, передать в него массив и заполнить массив необходимым количеством элементов
2. Описание метода, который будет выводить все элементы по порядку
3. Превратим код поиска нужного нам индекса в метод
*/

void FillArray(int[] collection)//метод void, далее даем наименование методу FillArray,
//в качестве аргумента int[] collection
{ 
    int length = collection.Length;//длинна массива collection.Length
    int index = 0;// создаем переменную
    while (index < length)//запускаем цикл
    {
        collection[index] = new Random().Next(1, 10);//обращаемся к аргументу и 
        //кладем новое случайное целое число new Random из диапазона 1,10 
        index = index + 1;
    }


}

void PrintArray(int[] col)// второй метод, который будет печатать массив
{
    int count = col.Length;//количество элементов
    int position = 0;//создаем переменную
    while (position < count)
    {
        Console.WriteLine(col[position]);//выводим значение текущего элемента
        position++;
    }
}
// находим позицию нужного нам элемента в массиве с использованием метода
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;//определяем количество элементов count
    int index = 0;//создаем переменную
    int position = -1;//создаем переменную
    while (index < count)
    {
        if(collection[index] == find)// == совпал
        {
            position = index;//тогда нужно сохранить позицию в position кладем значение index
            break;
        }
        index++;  
    }
    return position;//ожидаем нашу позицию элемента
}

int[] array = new int[10];

FillArray(array);//наименование нашего массива
array[4] = 4;
array[6] = 4;

PrintArray(array);//распечатывает наш массив
Console.WriteLine();

int pos = IndexOf(array, 444);//определили переменную и положили ва нее IndexOf
Console.WriteLine(pos);