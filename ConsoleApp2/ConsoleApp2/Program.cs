//1

//int number =Convert.ToInt32(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("number is positive");
//}
//else
//{
//    Console.WriteLine("number is negative");
//}

//2

//int sum = 0;

//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());
//int number3 = Convert.ToInt32(Console.ReadLine());
//int number4 = Convert.ToInt32(Console.ReadLine());
//int number5 = Convert.ToInt32(Console.ReadLine());

//sum = +number1 + number2 + number3 + number4 + number5;
//Console.WriteLine(sum); 

//3

//int num = Convert.ToInt32(Console.ReadLine());
//int square = num * num;
//Console.WriteLine(square);

//4

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//if (a > b && b > c)
//{
//    Console.WriteLine("a en boyuk ededdir");
//}
//else if (b > c)
//{
//    Console.WriteLine("b en boyuk ededdir");
//}
//else if (a == b && b == c)
//{
//    Console.WriteLine("her 3 eded beraberdir");
//}
//else
//{
//    Console.WriteLine("c en boyuk ededdir");
//}

//5

//    int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//int cube = a * a * a;

//if (cube > b)
//{
//    Console.WriteLine("1 ededin kubu 2 ededden boyukdur");
//}
//else if (cube < b)
//{ 
//    Console.WriteLine("1 ededin kubu 2 ededden kicikdir");
//}

//6

//int number = Convert.ToInt32(Console.ReadLine());

//if (number % 3 == 0 && number % 5 == 0)
//{
//    Console.WriteLine("eded hem 3 hem 5 bolunur");
//}
//else if (number % 3 == 0)
//{
//    Console.WriteLine("eded ancaq 3 bolunur");
//}
//else if (number % 5 == 0)
//{
//    Console.WriteLine("eded ancaq 5 bolunur");
//}
//else
//{
//    Console.WriteLine("eded ne 3 nede 5 bolunmur");
//}    

//7

//int kart_meblegi = Convert.ToInt32(Console.ReadLine());
//int mehsul_meblegi = Convert.ToInt32(Console.ReadLine());   

//if (kart_meblegi > mehsul_meblegi)
//{
//    Console.WriteLine("kartdaki mebleg yeterlidir");
//}
//else if (kart_meblegi < mehsul_meblegi)
//{
//    Console.WriteLine("kartdaki mebleg yeterli deyil");
//}

//else if (kart_meblegi == mehsul_meblegi)
//{
//    Console.WriteLine("kartdaki mebleg ile mehsulun mebleyi eynidir");
//}


//8


//int Riyaziyyat = Convert.ToInt32(Console.ReadLine());
//int Azerbaycan_dili = Convert.ToInt32(Console.ReadLine());
//int Biologiya = Convert.ToInt32(Console.ReadLine());
//int Kimya = Convert.ToInt32(Console.ReadLine());
//int Fizika = Convert.ToInt32(Console.ReadLine());

//int sum = 0;

//sum = Riyaziyyat + Azerbaycan_dili + Biologiya + Kimya + Fizika;

//while (sum / 5 < 65)

//    if ((sum) / 5 < 65 && sum >=0 || sum <= 100)
//    {
//        Console.WriteLine("ortalama bal 65 kicikdir");
//        break;
//    }

//while (sum / 5 > 65)

//    if ((sum) / 5 > 65 && sum >= 0 || sum <= 100)
//    {
//        Console.WriteLine("ortalama bal 65 yuksekdir");
//        break;
//    }

//while (sum / 5 == 65)

//    if ((sum) / 5 == 65 && sum >= 0 || sum <= 100)
//    {
//        Console.WriteLine("ortalama bal 65");
//        break;
//    }


//9

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine("birinci eded ikinci ededden boyukdur");  
//}
//else
//{
//    Console.WriteLine("birinci eded ikinci ededden kicikdir");
//}

//10 

//Console.WriteLine("Temperaturu daxil edin: ");
//int Temp = Convert.ToInt32(Console.ReadLine());

// if (Temp > 0)

//    Console.WriteLine("suyun temperaturu donma temperaturundan yuksekdir");

//else if (Temp < 0)

//    Console.WriteLine("suyun temperaturu donma temperaturundan ashaqidir");

//else if (Temp != 0)
//    Console.WriteLine("su donma temperaturundadir");

//11

//for (int i = 0; i < 51; i++)
//{
//    Console.WriteLine(i);
//}

//12

//for (int i = 0; i < 41; i++)
//    if (i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }

//13

//for (int i = 0; i < 101; i++)
//    if (i % 3 == 0 && i % 7 == 0)
//    {
//        Console.WriteLine(i);
//    }

//14

//Console.WriteLine("eded daxil et : ");
//int num = Convert.ToInt32(Console.ReadLine());

//int digit_count = 1;
//int TempNum = num;

//if (num == 0)

//    digit_count = 1;

//else

//    while (TempNum != 0)


//        TempNum /= 10;
//        digit_count++;


//Console.WriteLine(digit_count);

//15

//Console.WriteLine("Eded daxil edin: ");
//string input = Console.ReadLine();
//char[] inputarray = input.ToCharArray();
//Array.Reverse(inputarray);
//string output = new string(inputarray);
//Console.WriteLine(output);

//16

//Console.WriteLine("eded daxil edin");
//int Num = Convert.ToInt32(Console.ReadLine());
//int a = 1;
//int b;

//for (int i = 1; i <= Num; i++)

//    a = a * i;

//Console.WriteLine("Factorial: " + a);

//17

//Console.WriteLine("Eded daxil edin: ");
//int Num = Convert.ToInt32(Console.ReadLine());

//if (Num >= 1 && Num <= 9)
//{
//    Console.WriteLine("Eded sadedir");
//}
//else if (Num > 9)
//{
//    Console.WriteLine("Eded Murekkebdir");
//}

//18

//Console.WriteLine("Eded daxil edin: ");
//int number = int.Parse(Console.ReadLine());

//int Max = 0;

//while (number > 0)
//{
//    int digit = number % 10;
//    if (digit > Max)
//        Max = digit;
//    number /= 10;
//}

//Console.WriteLine($"Ededin en boyuk reqemi - {Max}");

//19

//for (int i = 70; i > 0; i -= 2)
//{
//    Console.WriteLine(i);
//}

//20

//Console.WriteLine("ay daxil edin: ");
//int Ay = Convert.ToInt32(Console.ReadLine());   
//switch (Ay)
//{
//    case 1:
//        Console.WriteLine("yanvar, qish fesilidir");
//        break;
//    case 2:
//        Console.WriteLine("fevral, qish fesilidir");
//        break;
//    case 3:
//        Console.WriteLine("mart, yaz fesilidir");
//        break;
//    case 4:
//        Console.WriteLine("aprel, yaz fesilidir");
//        break;
//    case 5:
//        Console.WriteLine("may, yaz fesilidir");
//        break;
//    case 6:
//        Console.WriteLine("iyun, yay fesilidir");
//        break;
//    case 7:
//        Console.WriteLine("iyul, yay fesilidir");
//        break;
//    case 8:
//        Console.WriteLine("avqust, yay fesilidir");
//        break;
//    case 9:
//        Console.WriteLine("sentyabr, payiz fesilidir");
//        break;
//    case 10:
//        Console.WriteLine("oktyabr, payiz fesilidir");
//        break;
//    case 11:
//        Console.WriteLine("noyabr, payiz fesilidir");
//        break;
//    case 12:
//        Console.WriteLine("dekabr, qish fesilidir");
//        break;
//    default:
//        break;
//}

//21

//int size = 5;

//for (int i = 0; i < size; i++)
//{
//    for (int x = 0; x < size; x++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}

//22

//int size = 9;
//int Star = 1;

//for (int i = 0; i < size; i++)
//{
//    for (int j = 0; j < Star; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();

//    Star++;
//}

//23

//int size = 9;
//int Star = 1;

//for (int i = 0; i < size; i++)
//{
//    for (int j = size - i; j > 0; j--)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();

//    Star++;
//}