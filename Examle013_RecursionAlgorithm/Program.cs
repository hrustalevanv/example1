// string[,] table = new string[2, 5];
// // String.Empty для строк по умолчанию инициализация проходит 
// // table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// // table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]



// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++) //количество строк
// {
//    for (int columns = 0; columns < 5; columns++) //количество столбцов
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
       
//    }
// }


//описываем метод, который будет двухмерную матрицу печатать на экран  

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    //for (int i = 0; i < 3; i++) //указываем новый функционал GetLength (количество строк)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        //for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();   
    }
}

//описываем дополнительный метод, который будет 
//заполнять нашу матрицу случайными числами
void FillArray(int[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
     {
          for (int j = 0; j < matr.GetLength(1); j++)
          {
              matr[i,j] = new Random().Next(1,10);//[1,10)
          }
     }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
