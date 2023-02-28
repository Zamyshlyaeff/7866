/* C клавиатуры вводится строка разделенная точкой. 
Подсчитать количество символов до точки*/

int k=0;
string s=Console.ReadLine();
char[]s1=s.ToCharArray();
for(int i=0;i<s1.Length;i++)
if (s[k]!='.')
k++;
Console.WriteLine($"{k}");

