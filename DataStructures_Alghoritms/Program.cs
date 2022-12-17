using DataStructures_Alghoritms.Collections;
using System.Collections;
using static System.Console;
using static System.Math;
using static System.Random;
MyList<int> list = new MyList<int>();
list.Add(187);
list.Add(123);
list.Add(123);
list.Add(223);
list.Remove(123);
WriteLine(list.Count);
WriteLine(list[0]);
foreach (var item in list.Data)
{
    WriteLine(item);
}
