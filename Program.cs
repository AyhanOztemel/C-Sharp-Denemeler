
//int[] numbers1;
//numbers1 = new int[9];

//string[] seasons;
//seasons = new string[3];
int[] numbers = new int[10] { 11, 2, 5, 30, 4, 8, 10, 88, 90, 6 };
string[] seasons= new string[4] { "spring", "summer", "autumn", "winter" };

Console.WriteLine("-----------int/string array started-----------");
foreach (int number in numbers) Console.WriteLine(number);
foreach (string season in seasons) Console.WriteLine(season);

Console.WriteLine("------------------------------------------");

Console.WriteLine("-----------var started-----------");
var numbers1 = numbers;
var seasons1= seasons;
foreach (var number in numbers1) Console.WriteLine(number);
foreach (int number in numbers1) Console.WriteLine(number);
foreach (dynamic number in numbers1) Console.WriteLine(number);
foreach (var season in seasons1) Console.WriteLine(season);
foreach (string season in seasons1) Console.WriteLine(season);
foreach (dynamic season in seasons1) Console.WriteLine(season);

Console.WriteLine("------------------------------------------");

Console.WriteLine("-----------dynamic started-----------");
dynamic numbers3 = numbers;
dynamic seasons3 = seasons;
//for (int i = 0; i < mevsimler3.lenght; i++)
//{                                            //dynamic does not contain definition for lenght fonk.
//    Console.WriteLine(mevsimler3[i]);
//}
foreach (int number in numbers3) Console.WriteLine(number);
foreach (var number in numbers3) Console.WriteLine(number);
foreach (dynamic number in numbers3) Console.WriteLine(number);
foreach (string season in seasons1) Console.WriteLine(season);
foreach (var season in seasons1) Console.WriteLine(season);
foreach (dynamic season in seasons3) Console.WriteLine(season);
Console.WriteLine("----------------------------------------------");

object seasons2 = seasons;
object numbers2 = numbers;
//for (int i = 0; i < sayilar2.Length; i++) //object type sayilar2 does not contain 
//                                                      lenght function so throws error                                                
//{
//    Console.WriteLine(sayilar2[i]);
//}
//foreach (int sayi in sayilar2) Console.WriteLine(sayi);//object type sayilar2 throws error
//foreach (string mevsim in mevsimler2) Console.WriteLine(mevsim);//object type mevsimler2 throws error 
//foreach (string mevsim in mevsimler2) Console.WriteLine(mevsim);//object type mevsimler2  throws error 
Console.WriteLine("-----------method object finished-----------");

var a = 24;
var b = "ayhan";
object str1 = "Ayhan";
object str2 = "öztemel";
object c = a; // var type assigned to object
object d = 45;
Console.WriteLine("object toplama: "+d+c);
//object f = c + d;
var first = 34;
var last = 41;
var total = first + last;
dynamic num1 = 21;
dynamic num2 = 42;
dynamic num3 = num1 + num2;
Console.WriteLine(first + last + total + 45 + 75+num1+num2+"Hello world");

Console.WriteLine("Hello, World!"+"  "+c+d+"  "+(first+last+total+45+75));
Console.WriteLine(first + last);

Console.WriteLine(num1+num2);
Console.WriteLine(23 + 45);
string hk = "ayhan";
int gh = 23;
int fh = 322;
Console.WriteLine(gh + fh + "  " + hk);
Console.WriteLine("-----------method-----------");
trying(first,last);//first=34 ve last =41  defined with VAR
trying(num1,num2);//num1=21 ve num2=42 defined with DYNAMIC
//trying(c, d); //c=21 ve d=45 defined with OBJECT so throw error

trying1(str1,str2);// str1=ayhan str2=öztemel defined with OBJECT 
trying1(first,last);//first=34 ve last=41 defined with VAR
trying1(c,d); //c = a ve d = 45 defined with OBJECT
trying1(a,b); // a=24 int b="ayhan"  string

trying2(first,last); //first=34 ve last=41 defined with VAR
trying2(c,d); //c =a  ve d = 45 defined with OBJECT
trying2(gh,fh);//gh=23 ve fh=322 int   defined
trying3(c,d);

trying4(str1,str2);


void trying(int arg1, int arg2)=>Console.WriteLine(arg1+arg2);

void trying1 (dynamic arg1, dynamic arg2)=> Console.WriteLine(arg1 + arg2);

void trying2(object arg1, object arg2) => Console.WriteLine((int)arg1 + (int)arg2);
void trying3(object arg1, object arg2) => Console.WriteLine(""+arg1 + arg2);
void trying4(object arg1, object arg2) => Console.WriteLine(""+arg1 + arg2);

// Console.WriteLine(arg1+arg2); throw error 
// data type object dont allow to use oparators
// when start ("") in Cosole.WriteLine firstly  convert to string all data type
// if you want to add operation  you should write int type in Console.WriteLine firstly
Console.ReadKey();