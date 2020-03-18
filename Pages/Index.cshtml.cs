using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RockPaperScissors.Model;
using RockPaperScissors.Services;

namespace RockPaperScissors.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;
        private readonly RpsLogic _rpsLogic;
        public IndexModel(RpsLogic rpsLogic)
        {
            _rpsLogic = rpsLogic;

        }
        public string _mess { get; set; }
        [BindProperty]
        public Rps GameD { get; set; }
        [BindProperty]
        public Choice Player
        { get; set; }
        public void OnGet()
        {
           GameD = _rpsLogic.UserData;

        }
        public void OnPost()
        {
            if (this.ModelState.IsValid)
            {
                _rpsLogic.UserData = GameD;
                _rpsLogic.GameRound(Player);
            }
        }
    }
}
