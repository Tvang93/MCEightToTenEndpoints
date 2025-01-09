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
    public class MagicEightBallController : ControllerBase
    {
        private readonly MagicEightBallServices _magicEightBallServices;

        public MagicEightBallController(MagicEightBallServices magicEightBallServices)
        {
            _magicEightBallServices = magicEightBallServices;
        }

        [HttpGet]
        [Route("MagicEightBall/{question}")]
        public string MagicEightBall()
        {
            return _magicEightBallServices.MagicEightBall();
        }
    }
}