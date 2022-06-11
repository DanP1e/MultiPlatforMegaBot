using System.Collections.Generic;

namespace MultiPlatforMegaBot
{
    public class TextPresenter
    {
        private List<string> _answers = new List<string>() 
        { "Initialisation...", "Loading.....", "Loaded! Good luck:)" };

        public string GetAnswer(Answers answer)
            => _answers[(int)answer];
    }
}
