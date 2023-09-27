using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snake
{
    public class AppleManager
    {
        private GameObject _appleItem;
        public GameObject AppleItem
        {
            get
            {
                if(_appleItem == null)
                {
                    _appleItem = Resources.Load<GameObject>("Prefab/Apple");
                }

                return _appleItem;
            }
        }

        private GameObject currentApple;

        private Vector2 prevPosition = new Vector2(-99, -99);

        public GameObject SpawnApple()
        {
            if (currentApple != null) Object.Destroy(currentApple);

            int x = (int) prevPosition.x;
            int y = (int)prevPosition.y;

            while (x == prevPosition.x && y == prevPosition.y)
            {
                x = Random.Range(-10, 9);
                y = Random.Range(-5, 5);
            }

            prevPosition = new Vector2(x, y);
            
            currentApple = Object.Instantiate(AppleItem, new Vector3(x, -0.3f, y), Quaternion.identity);

            return currentApple;
        
        }
    }
}

