using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MCEightToTen.Services
{
    public class GuessItServices
    {
        Random rng = new Random();
        public List<string> modeList = new();
        public GuessItServices()
        {
            modeList.Add("Easy");
            modeList.Add("Medium");
            modeList.Add("Hard");
        }

        public string EasyGuess(string stringNum)
        {
            int convertedNum;
            bool validNum = int.TryParse(stringNum, out convertedNum);

            if(validNum && convertedNum >= 1 && convertedNum <= 10){
                int randomNumber = rng.Next(11);
                if(convertedNum == randomNumber){
                    return $"You guessed {stringNum}. You got it correct!";
                }else if(convertedNum > randomNumber){
                    return $"You guessed {stringNum}. The correct number is lower.";
                }else{
                    return $"You guessed {stringNum}. The correct number is higher.";
                }
            }else{
                return "Invalid Entry. For easy mode, please type in a number between 1 and 10.";
            }
        }

        public string MediumGuess(string stringNum)
        {
            int convertedNum;
            bool validNum = int.TryParse(stringNum, out convertedNum);

            if(validNum && convertedNum >= 1 && convertedNum <= 50){
                int randomNumber = rng.Next(51);
                if(convertedNum == randomNumber){
                    return $"You guessed {stringNum}. You got it correct!";
                }else if(convertedNum > randomNumber){
                    return $"You guessed {stringNum}. The correct number is lower.";
                }else{
                    return $"You guessed {stringNum}. The correct number is higher.";
                }
            }else{
                return "Invalid Entry. For medium mode, please type in a number between 1 and 50.";
            }
        }

        public string HardGuess(string stringNum)
        {
            int convertedNum;
            bool validNum = int.TryParse(stringNum, out convertedNum);

            if(validNum && convertedNum >= 1 && convertedNum <= 100){
                int randomNumber = rng.Next(101);
                if(convertedNum == randomNumber){
                    return $"You guessed {stringNum}. You got it correct!";
                }else if(convertedNum > randomNumber){
                    return $"You guessed {stringNum}. The correct number is lower.";
                }else{
                    return $"You guessed {stringNum}. The correct number is higher.";
                }
            }else{
                return "Invalid Entry. For hard mode, please type in a number between 1 and 100.";
            }
        }
    }
}