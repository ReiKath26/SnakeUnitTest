using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snake
{
    public class SnakeManager
    {
        [SerializeField] private GameObject _orangeBody;
        [SerializeField] private GameObject _yellowBody;

        private GameObject snekPrefab;
        public GameObject SnekPrefab
        {
            get
            {
                if(snekPrefab == null)
                {
                    snekPrefab = Resources.Load<GameObject>("Prefab/Snake");
                }

                return snekPrefab;
            }
        }
        private GameObject snake;

        private int count = 3;

        public GameObject InitialSpawn()
        {
            if(snake != null)
            {
                Object.Destroy(snake);
            }
            snake = Object.Instantiate(SnekPrefab, new Vector3(9, -0.2f, -2), SnekPrefab.transform.rotation);
            return snake;
        }

        public GameObject SpawnMoreBody()
        {
            GameObject lastBody = snake.transform.GetChild(snake.transform.childCount - 1).gameObject;
            count += 1;

            if(count % 2 == 0)
            {
                GameObject body = Object.Instantiate(_orangeBody, new Vector3(lastBody.transform.position.x, lastBody.transform.position.y, count - 1), lastBody.transform.rotation, snake.transform);
                return body;
            }

            else
            {
                GameObject body = Object.Instantiate(_yellowBody, new Vector3(lastBody.transform.position.x, lastBody.transform.position.y, count - 1), lastBody.transform.rotation, snake.transform);
                return body;
            }
        }

        
    }
}

