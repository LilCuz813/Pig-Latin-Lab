/*
 * Pig Latin Translation Rules
 * 
 * If a word starts with a vowel add the word "way" at the end of the word 
 * Ex: awesome = awesome + way = awesomeway
 * 
 * If a word starts with a consonant and a vowel, put the first letter of the word at the end of the word and add "ay"
 * Ex: happy = appyh + ay = appyhay
 * 
 * If a word starts with two consonants move the two consonants to the end of the word and add "ay"
 * Ex: child = ildch + ay = ildchay
 */


Console.WriteLine("The Pig Latin Translator");
Console.WriteLine();

bool runWhile = true;
while (runWhile)
{
    Console.WriteLine("Please enter a word you would like to translate:");
    string word = Console.ReadLine();
    string stringSpace = Console.ReadLine();
    string result = stringSpace.Replace(" ", " ");
    string[] words = stringSpace.Split("");
    int VowelP = -1;
    foreach(char letter in word)
    {
        VowelP = VowelP + 1;
        if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
        break;
        }
    }

        string PigLatin = "";
        string BeforeL = "";
        string AfterL = "";
        switch (VowelP)
        {
            case 0:
                PigLatin = word + "way";
                break;
            case 1:
                BeforeL = word.Substring(0, 1);
                AfterL = word.Substring(1);
                PigLatin = AfterL + BeforeL + "ay";
                break;
            case 2:
            BeforeL = word.Substring(0, 2);
            AfterL = word.Substring(2);
            PigLatin = AfterL + BeforeL + "ay";
                break;
            default:
                PigLatin = "unable to translate";
                break;

        }

        Console.WriteLine(PigLatin);
        Console.WriteLine();


        Console.WriteLine("Do you wish to continue? y/n ");
        string choice = Console.ReadLine().ToLower();
        if (choice == "n")
        {
            runWhile = false;
        }
}
