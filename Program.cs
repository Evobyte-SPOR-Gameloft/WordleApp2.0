using WordleAppOOP;

bool quit = false;

do
{
    Console.WriteLine();
    Utility.MenuChoices();
    var response = Console.ReadLine();
    Utility.DeletePrevConsoleLine();
    #pragma warning disable CS8602
    response = response.ToUpper();
    Console.WriteLine();
    switch (response[0])
    {
        case 'P':
            GameLoop();
            break;
        case 'Q':
            quit = true;
            break;
        default:
            Utility.WriteToCenterLine("Invalid choice!");
            break;
    }
}
while (quit == false);

static void GameLoop()
{

    //Generates new list for previous guesses
    List<string> previousGuesses = new();

    //Generates new dictionary from text file
    Dictionary fiveLetterWords = new(File.ReadAllLines("dictionary.txt"));

    //Assigns a word from the dictionary to a variable
    string chosenWord = new(fiveLetterWords.WordPicker());

    Utility.PromptUserToGuess();
    Console.WriteLine();
    List<char> letters = new();
    string guessWord;
    int iterations = 0;

    do
    {
        guessWord = Console.ReadLine().ToLower();
        Utility.DeletePrevConsoleLine();

        if (fiveLetterWords.DoesContain(guessWord) && !previousGuesses.Contains(guessWord))
        {
            iterations++;
            letters.Clear();
            previousGuesses.Add(guessWord);
            string guessWordUpper = guessWord.ToUpper();

            PaintBrush greenBrush = new("green");
            PaintBrush orangeBrush = new("orange");
            PaintBrush grayBrush = new("gray");

            //Makes the [ X ] letters align to the center
            Console.SetCursorPosition((Console.WindowWidth / 2) - 15, Console.CursorTop);

            for (int i = 0; i < 5; i++)
            {
                if (guessWord[i] == chosenWord[i])
                {
                    greenBrush.Paint($"[ {guessWordUpper[i]} ]");
                    Console.Write(" ");
                }
                else if (chosenWord.Contains(guessWord[i]) && letters.Count(x => x == guessWord[i]) <chosenWord.Count(x => x == guessWord[i]))
                {
                    orangeBrush.Paint($"[ {guessWordUpper[i]} ]");
                    Console.Write(" ");
                }
                else
                {
                    grayBrush.Paint($"[ {guessWordUpper[i]} ]");
                    Console.Write(" ");
                }
                letters.Add(guessWord[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        else if (guessWord.Length < 5)
        {
            Utility.WriteToCenterLine("We're gonna need a few more letters...");
            Thread.Sleep(2000);
            Utility.DeletePrevConsoleLine();
        }
        else if (guessWord.Length > 5)
        {
            Utility.WriteToCenterLine("Woah.. slow down, that's too many letters");
            Thread.Sleep(2000);
            Utility.DeletePrevConsoleLine();
        }
        else if (previousGuesses.Contains(guessWord))
        {
            Utility.WriteToCenterLine("You've already used that word, dummy!");
            Thread.Sleep(2000);
            Utility.DeletePrevConsoleLine();
        }
        else if (!fiveLetterWords.DoesContain(guessWord))
        {
            Utility.WriteToCenterLine("That word is not in our dictionary!");
            Thread.Sleep(2000);
            Utility.DeletePrevConsoleLine();
        }
        else
        {
            Utility.WriteToCenterLine("Welp.. how did this happen!?");
            Thread.Sleep(2000);
            Utility.DeletePrevConsoleLine();
        }
    }
    while (iterations < 6 && guessWord != chosenWord);

    string betterLuck = "Aww.. better luck next time!";
    string loseFeedback = "The chosen word was:";
    string firstTry = "How the f...!? You got it first try!";
    string win = $"Congratulations! It took you {iterations} tries to win!";

    if (iterations == 1 && guessWord == chosenWord)
    {
        Utility.WriteToCenterLine(firstTry);
        Thread.Sleep(2000);
    }
    else if (iterations < 7 && guessWord == chosenWord)
    {
        Utility.WriteToCenterLine(win);
        Thread.Sleep(2000);
    }
    else
    {
        PaintBrush greenBrush = new("green");
        Utility.WriteToCenterLine(betterLuck);
        Utility.WriteToCenterLine(loseFeedback);
        greenBrush.PaintLineToCenter($"[{chosenWord.ToUpper()}]");
    }
}




