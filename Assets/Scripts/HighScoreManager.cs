using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Snake
{
    public class HighScoreManager : MonoBehaviour
    {
        private int score = 0;

        public void ResetScore()
        {
            score = 0;
        }

        public void AddScore()
        {
            score += 1;
        }

        public int GetScore()
        {
            return score;
        }
    }
}

