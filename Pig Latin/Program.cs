Console.WriteLine("Welcome to the Pig Latin Simulator!");
Console.WriteLine();

//Looping Program
bool runProgram = true;

while (runProgram)
{

    Console.Write("Please enter a word you'd like to translate: ");
string engword = Console.ReadLine().Trim().ToLower();

//Indexing where the vowel is

int vowelIndex = -1;
foreach (char l in engword)
{
    vowelIndex = vowelIndex + 1;
    if (l == 'a' || l == 'e' || l == 'i' || l == 'o'|| l == 'u')
    {
        break;
    }
}
//Program execution

string PigLatinWord = "";
string BeforeLetters = "";
string AfterLetters = "";
switch (vowelIndex)
{
    case 0:
        PigLatinWord = engword + "way";
        break;
    case 1:
        BeforeLetters = engword.Substring(0, 1);
        AfterLetters = engword.Substring(1);
        PigLatinWord = AfterLetters + BeforeLetters + "ay";
        break;
    case 2:
        BeforeLetters = engword.Substring(0, 2);
        AfterLetters = engword.Substring(2);
        PigLatinWord = AfterLetters + BeforeLetters + "ay";
        break;
    case 3:
        BeforeLetters = engword.Substring(0, 3);
        AfterLetters = engword.Substring(3);
        PigLatinWord = AfterLetters + BeforeLetters + "ay";
        break;
    case 4:
        BeforeLetters = engword.Substring(0, 4);
        AfterLetters = engword.Substring(4);
        PigLatinWord = AfterLetters + BeforeLetters + "ay";
        break;
    case 5:
        BeforeLetters = engword.Substring(0, 5);
        AfterLetters = engword.Substring(5);
        PigLatinWord = AfterLetters + BeforeLetters + "ay";
        break;
    case 6:
        BeforeLetters = engword.Substring(0, 6);
        AfterLetters = engword.Substring(6);
        PigLatinWord = AfterLetters + BeforeLetters + "ay";
        break;
    case 7:
        BeforeLetters = engword.Substring(0, 7);
        AfterLetters = engword.Substring(7);
        PigLatinWord = AfterLetters + BeforeLetters + "ay";
        break;
}

//Program Output
Console.WriteLine(PigLatinWord);

//Program Loop

    while (true)
    {
        Console.WriteLine("Do you want to continue? y/n");
        string choice = Console.ReadLine().Trim().ToLower();

        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            runProgram = false;
            break;
        }
    }
}

Console.WriteLine("Goodbye and thanks for playing!");

