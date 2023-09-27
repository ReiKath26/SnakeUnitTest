using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snake
{

    public class GameManager : MonoBehaviour
    {

        public AppleManager _appleManager;
        public HighScoreManager _highScoreManager;
        public SnakeManager _snakeManager;
        public UIManager _uiManager;

        private GameState gameState = GameState.pause;

        private void Start()
        {
            _uiManager.AddActionToButtons(SetGamePlay);
        }

        private void SetGamePlay(bool isPlaying)
        {
            _uiManager.PlayGame(isPlaying);
            if(isPlaying)
            {
                gameState = GameState.play;
            }

            else
            {
                gameState = GameState.pause;
            }
        }

        public GameState GetGameState()
        {
            return gameState;
        }

        private void OnTriggerEnter(Collider other)
        {
            TriggerCollision(other.tag);
        }

        public void TriggerCollision(string collison_tag)
        {
            if (collison_tag == "Wall" || collison_tag == "Body")
            {
                Debug.Log("Game over");
                _snakeManager.InitialSpawn();
                _uiManager.SetHighScoreText(_highScoreManager.GetScore());
                _appleManager.SpawnApple();

            }

            else if (collison_tag == "Apple")
            {
                Debug.Log("Get apple");
                _highScoreManager.AddScore();
                _uiManager.SetScoreText(_highScoreManager.GetScore());
                _appleManager.SpawnApple();
            }
        }
    }
}
