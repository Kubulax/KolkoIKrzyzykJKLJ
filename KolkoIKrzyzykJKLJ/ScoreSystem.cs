using System;
using System.Collections.Generic;
using System.Text;

namespace KolkoIKrzyzykJKLJ
{
    public static class ScoreSystem
    {
        private static int[] score = new int[2];

        public static void AddPoint(string player)
        {
            if(player == "×")
            {
                score[0]++;
            }
            else if(player == "○")
            {
                score[1]++;
            }
        }

        public static void ResetScore() 
        {
            score = new int[2];
        }

        public static string DrawScoreDisplay()
        {
            return "× " + score[0] + ":" + score[1] + " ○";
        }
    }
}
