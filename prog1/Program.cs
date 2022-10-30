string [] array = {"hello", "2", "world", ":-)"};
var resultArray = new string[array.Length];
int index = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        resultArray[index] = value;
        index++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, resultArray, 0, index));