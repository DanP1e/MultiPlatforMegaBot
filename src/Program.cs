using System;

namespace MultiPlatforMegaBot
{
    class Program
    {
        static void Main(string[] args)
        {
            TextPresenter presenter = new TextPresenter();
            Console.WriteLine(presenter.GetAnswer(Answers.Initialization));
            Console.WriteLine(presenter.GetAnswer(Answers.Loading));
            Console.WriteLine(presenter.GetAnswer(Answers.ProgramLoaded));
        }
    }
}
