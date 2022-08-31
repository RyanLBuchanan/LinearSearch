// See https://aka.ms/new-console-template for more information

var generator = new Random();
var data = new int[10];

// Fill array with random integers in range of 10-99
//for (var i = 0; i < data.Length; i++)
//{
//    data[i] = generator.Next(10, 100);
//}

GenerateRandomInts();

Console.WriteLine("Enter an integer value (-1 to quit): ");
var searchInt = int.Parse(Console.ReadLine());

// Repeatedly input an integer; -1 terminates the app
//while (searchInt != -1)
for (int i = 0; i < 5; i++)
{
    // Perform linear search
    int position = LinearSearch(data, searchInt);

    if (position != -1) // The integer was found
    {
        Console.WriteLine($"The integer {searchInt} was found in " +
            $"position {position}.\n");

        //GenerateRandomInts();
    }
    else // Integer was not found
    {
        Console.WriteLine($"The integer {searchInt} was not found.\n");
    }
    // Input next integer from user
    Console.Write("Enter an integer value (-1 to quit): ");
    searchInt = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    Console.Write(data[i] + " ");
}

Console.WriteLine();



static int LinearSearch(int[] values, int searchKey)
{
    // Loop through array sequentially
    for (var index = 0; index < values.Length; index++)
    {
        if (values[index] == searchKey)
        {
            return index; // Return the element's index
        }
    }

    return -1; // Integer was not found
}

int[] GenerateRandomInts()
{
    // Fill array with random integers in range of 10-99
    for (var i = 0; i < data.Length; i++)
    {
        data[i] = generator.Next(10, 100);
    }
    return data;
}
