using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCEightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCEightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("Easy/{guessNum}")]
        public string EasyGuess(string guessNum)
        {
            return _guessItServices.EasyGuess(guessNum);
        }

        [HttpGet]
        [Route("Medium/{guessNum}")]
        public string MediumGuess(string guessNum)
        {
            return _guessItServices.MediumGuess(guessNum);
        }

        [HttpGet]
        [Route("Hard/{guessNum}")]
        public string HardGuess(string guessNum)
        {
            return _guessItServices.HardGuess(guessNum);
        }
    }
}