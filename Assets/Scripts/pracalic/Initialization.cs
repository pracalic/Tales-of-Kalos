using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pracalic
{
    public class Initialization : MonoBehaviour
    {
        [SerializeField]
        int boardWidth, boardHeight;

        [SerializeField]
        Field fieldPrefab = null;
        [SerializeField]
        Transform fieldParent = null;
        private void Awake()
        {
            // new GameManager();
            // new GameManager(boardWidth, boardHeight);
            new GameManager(boardWidth, boardHeight, fieldPrefab, fieldParent);
        }
    }
}
