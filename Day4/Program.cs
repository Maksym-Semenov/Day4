int[] values = { 10, 123, 56, 39, 67, 188 };
int result = 0;
for (int i = 0; i < values.Length; i++)
{
    result += values[i]; 
}
Console.WriteLine("Сума вашого масиву " + result);
Console.ReadLine();