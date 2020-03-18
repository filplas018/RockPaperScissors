
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissors.Model;


namespace RockPaperScissors.Services
{
    public class RpsLogic
    {

        private readonly Random _random;

        public RpsLogic(Random random)
        {
            _random = random;
            UserData = new Rps();
        }
        public Rps UserData { get; set; }
        public void GameRound(Choice player)
        {
            if (player == Choice.None) return;
            UserData.Computer = (Choice)_random.Next(1, 4);
            UserData.Player = player;

            if (UserData.Computer == Choice.Rock && UserData.Player == Choice.Paper ||
                UserData.Computer == Choice.Paper && UserData.Player == Choice.Scissors ||
                UserData.Computer == Choice.Scissors && UserData.Player == Choice.Rock)
            {
                UserData.Wins++;
                UserData.PlayerIsWinner = true;
                UserData.Round++;
            }
            else if (UserData.Computer == UserData.Player)
            {
                UserData.Draw++;
                UserData.PlayerIsWinner = null;
                UserData.Round++;
            }
            else
            {
                UserData.Loss++;
                UserData.PlayerIsWinner = false;
                UserData.Round++;
            }
        }
    }
}
