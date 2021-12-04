int[] array = {1,12,31,4,15,18,16,17,18};//если два и более одинаковые значения, 
//то в выходе покажет консоль их все, в таком случае используем break, 

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //  если выполняется условие, значит стоп
    }
    index++;
}

