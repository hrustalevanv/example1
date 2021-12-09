﻿using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"// возьмите текст
              .Replace("(", "")//замените в нем скобочки
              .Replace(")", "")//замените в нем вторые скобочки
              ;

Console.WriteLine(text);
var data = text.Split (" ")//возьми текст, разбей (Split)
              .Select(item => item.Split(','))// сделай выборку, для которой нужно будет сделать новое разбиение на несколько элементов с символом ','
              .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))// сделай выборку из текущего массива (e), 
              //первая координату будет взята из певого массива (int.Parse(e[0]))и превращена сразу в число, то же самое и со второй
              .Where (e => e.x % 2 == 0)// делаем проверку условия, что дайте нам такие пары, для которых первая координата четная
              .Select(point => (point.x*10, point.y))//дайте нам набор, что мы получили на предыдущем этапе и для него увеличения координаты (point.x*10)
              .ToArray();// превращаем в массив

for (int i = 0; i < data.Length; i++)// и запускаем цикл
{
    Console.WriteLine(data[i]);
    
}             
