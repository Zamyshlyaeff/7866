/*Подсчитать сколько раз определенный символ (например 'a') 
встречается в строке.*/
string a=Console.ReadLine();
int k=0;
for (int i=0;i<a.Length;i++) 
{
    if (a[i]=='a') k++;
}
Console.WriteLine(k);