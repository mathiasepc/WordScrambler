using UndervisningUdeFra;

ConsoleKeyInfo key;

string svar;

Logik logik = new();

while (true)
{
    //laver et loop, sådan så vi kan kører alle ord igennem. "i<logik.answer1.length"
    for (int i = 0; i < logik.answer1.Length; i++)
    {
        //skal kører indtil at ordet der kommer som output har random placeret bogstaver.
        while (logik.check == false)
        {
            Console.Clear();
            Console.Write("Try and guess the word: ");
            Console.WriteLine(logik.Scrambler(logik.answer1[i]));
        }
        svar = Console.ReadLine().ToLower();

        //svar er gætten og i er index på array.
        Console.WriteLine(logik.CompareAnswer(svar, i) + "\n");

        //resetter min check.
        logik.check = false;
    }


    //hvor mange rigtige
    Console.WriteLine($"You answered {logik.score} out of {logik.answer1.Length} correct.");

    Console.WriteLine("Try again? (Y/N)");
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.N)
    {
        break;
    }

    logik.score = 0;
    Console.Clear();
}