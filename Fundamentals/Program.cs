// ------------------------------------------ FUNDAMENTALS 1 ------------------------------------------
// print from 1 to 255
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

// Generate 5 random numbers between 10 and 20
Random rand = new Random();
for (int i = 0; i < 5; i++)
{
    long randNum = rand.NextInt64(10, 20);
    Console.WriteLine(randNum);
}

// Modify the previous loop to add the random values together and print the sum after the loop finishes.
long sum = 0;
for (int i = 0; i < 5; i++)
{
    long randNum = rand.NextInt64(10, 20);
    sum = randNum + sum;
}
Console.WriteLine(sum);

// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.
for (int i = 1; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
for (int i = 1; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}

// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
for (int i = 1; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}

// ------------------------------------------ FUNDAMENTALS 2 ------------------------------------------

// Three Basic Arrays

int[] oneThruNine = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

string[] names = { "Tim", "Martin", "Nikki", "Sara" };

bool[] boolList = new bool[10];
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        boolList[i] = true;
    }
    else
    {
        boolList[i] = false;
    }
}
foreach (var item in boolList)
{
    Console.WriteLine(item);
}

List<string> flavorList = new List<string>
{
    "Chocolate",
    "Vanilla",
    "Cookie Dough",
    "Strawberry",
    "White Chocolate"
};
Console.WriteLine(flavorList.Count);
Console.WriteLine(flavorList[2]);
flavorList.RemoveAt(2);
Console.WriteLine(flavorList.Count);

Dictionary<string, string> dictList = new Dictionary<string, string>();

for (int i = 0; i < names.Length; i++)
{
    long randInt = rand.Next(1, 4);
    int convert = (int)randInt;
    dictList.Add(names[i], flavorList[convert]);
}
foreach (var item in dictList)
{
    Console.WriteLine(item.Key + " : " + item.Value);
}

// ------------------------------------------ FUNDAMENTALS 3 ------------------------------------------

static void PrintList(List<string> MyList)
{
    for (int i = 0; i < MyList.Count; i++)
    {
        Console.WriteLine(MyList[i]);
    }
    foreach (var item in MyList)
    {
        Console.WriteLine(item);
    }
    int num = 0;
    while(num < MyList.Count)
    {
        Console.WriteLine(MyList[num]);
        num++;
    }
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);

static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        sum = sum + IntList[i];
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);

static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    for (int i = 0; i < IntList.Count; i++)
    {
        if (IntList[i] > max)
        {
            max = IntList[i];
        }
    }
    Console.WriteLine(max);
    return max;
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
FindMax(TestIntList2);

static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] = IntList[i] * IntList[i];
    }
    foreach (var item in IntList)
    {
        Console.WriteLine(item);
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    foreach (var item in IntArray)
    {
        Console.WriteLine(item);
    }

    return IntArray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);

static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (var item in MyDictionary)
    {
        Console.WriteLine(item.Key + " : " + item.Value);
    }
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    foreach (var item in MyDictionary)
    {
        if(item.Key.Equals(SearchTerm))
        {
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> dict = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        dict.Add(Names[i], Numbers[i]);
    }

    return dict;
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here

List<string> testNames = new List<string>
{
    "Julie",
    "Harold",
    "James",
    "Monica"
};
List<int> testNumbers = new List<int>
{
    6,
    12,
    7,
    10
};

Dictionary<string, int> testDictionary = new Dictionary<string, int>();
testDictionary = GenerateDictionary(testNames, testNumbers);
foreach (var item in testDictionary)
{
    Console.WriteLine(item.Key + " : " + item.Value);
}