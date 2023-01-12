Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array=new int[num];
for (int index = 1; index <= num; index++)
{
    array[index] = (index +1)* (index+1) * (index+1);
    Console.WriteLine(array[index]);
}

