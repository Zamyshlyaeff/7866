/* Заменить все вхождения подстроки w в строке st на строку v. 
Вывести на экран первоначальную строку и конечную строку*/

string s=Console.ReadLine();
char[] s1=s.ToCharArray();
for (int i=0;i<s.Length;i++)
{
    if (s[i]=='w')
    s1[i]='v';
    
}
Console.WriteLine(s);
Console.WriteLine(s1);
