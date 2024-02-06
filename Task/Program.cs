//////////HOMETASK////////////

/////  1 - Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//int n = 21; 
//if (n % 3 == 0 && n % 7 == 0)
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}

// 2 - n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//int n = 2;
//int m = 4;
//int sum = 0;

//if (n % 2 == 0 && m % 2 == 0)
//{
//    sum = n + m;
//}

//Console.WriteLine(sum);

// 3 -  Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//int n = 1;
//int m = 10;
//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

// 4 - Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int[] numbers = { 1, 2, 3, 4, 5, 9, 13 };
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 1)
//    {
//        sum += numbers[i];
//    }
//}
//Console.WriteLine(sum);

// 5 - Verilmish arrayin icindeki cut ededlerin sayini tapin.

//int[] numbers = { 2, 4, 6, 3, 5 };
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

// 6 - Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int n = 1;
//int m = 10;
//int count = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

// 7 - Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//int n = 2;
//int m = 16;
//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if(i%2==0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

// 8 - Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//int n = 1;
//int m = 12;
//int count = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

// 9 -  Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//int n = 3;
//int count = 0;

//if (n < 2)
//{
//    Console.WriteLine("Ne sade,ne de murekkeb");
//}
//else if (n == 2)
//{
//    Console.WriteLine("Sade");
//}
//else
//{
//    for (int i = 2; i < n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//        }
//    }
//    if (count == 2)
//    {
//        Console.WriteLine("Murekkeb");
//    }
//    else
//    {
//        Console.WriteLine("Sade");
//    }
//}



////////CLASSWORK//////////

//int n = 10;
//int m = 20;
//int sum;

//sum = n + m;

//Console.WriteLine(sum);

/////// - Boolun yoxlanilmasi

//bool isMarried = true;

//if (isMarried = true)
//{
//    Console.WriteLine("Evlidir");
//}
//else
//{
//    Console.WriteLine("Subay");
//}

//// - Arrayin indeksler ve arrayin elementleri goster

//int[] arr = { 1, 2, 3, 4 };

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr [i]);
//}

/////// - 1 ve 100 arasindaki reqemleri goster

//for (int i = 1; i < 100; i++)
//{
//    Console.WriteLine(i);
//}

//////// - 1 ve 100 arasindaki tek ededleri goster

//int a = 1;
//int b = 100;

//for(int i = a; i <= b; i++)
//{
//    if (i % 2 == 1)
//    {
//        Console.WriteLine(i);
//    }
//}

////// - 1 ve 100 arasindaki tek ededlerin cemi

//int a = 1;
//int b = 100;
//int sum = 0;

//for (int i = a; i < b; i++)
//{
//    if (i % 2 != 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

////// - Verilmis arr terkibinde nece dene Salam sozunun olmasini say

//string[] words = { "Salam", "Salam", "Sagol" };
//int count = 0;

//for(int i = 0; i < words.Length; i++)
//{
//    if (words[i] == "Salam")
//    {
//      count++;
//    }
//}
//Console.WriteLine(count);
