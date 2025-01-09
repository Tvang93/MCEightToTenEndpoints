using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCEightToTen.Services
{
    public class MagicEightBallServices
    {
        Random rng = new Random();
        public string MagicEightBall()
        {
            int randomNumber = rng.Next(8);
            switch (randomNumber)
            {
                case 0:
                    return "Affirmative.";
                case 1:
                    return "You shall not pass!";
                case 2:
                    return "INDEED!";
                case 3:
                    return "Fo Sho.";
                case 4:
                    return "Never say Never";
                case 5:
                    return "Patience, young padawan.";
                case 6:
                    return "try again later";
                default:
                    return "The princess is at another castle...";
            }
        }

    }
}