using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Snake
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private TextMeshProUGUI _highscoreText;
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _pauseButton;

        public void AddActionToButtons(UnityAction<bool> actionPlay)
        {
            _playButton.onClick.AddListener(() => actionPlay(true));
            _pauseButton.onClick.AddListener(() => actionPlay(false));
        }

        public void PlayGame(bool isPlaying)
        {
            _playButton.gameObject.SetActive(!isPlaying);
            _playButton.gameObject.SetActive(isPlaying);
        }

        public void SetScoreText(int score)
        {
            _scoreText.text = "Score: " + score;
        }

        public void SetHighScoreText(int score)
        {
           _highscoreText.text = "Highscore: " + score;
        }


    }
}

