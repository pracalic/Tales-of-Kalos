using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pracalic
{
    public enum TEAM
    {
        RED,
        BLUE
    }

    public abstract class Entity
    {


    }

    public class GameManager 
    {
        public static GameManager instance = null;

        private TEAM teamTurn = TEAM.RED;
        private int boardWidth, boardHeight;
        private Field[] field;
        private Field[][] fields;
        private Field fieldPref;
        private Transform fieldParent;
        

        public TEAM WhichTurn
        {
            get
            {
                return teamTurn;
            }
        }
        public GameManager()
        {
            InitInstance();
        }

        public GameManager(int width, int height)
        {
            InitInstance();
            InitSize(width, height);          
        }

        public GameManager(int width, int height, Field fieldPrefab, Transform fieldPar)
        {
            InitInstance();
            InitPrefabAndBoardParent(fieldPrefab, fieldPar);
            InitSize(width, height);

        }


        private void InitInstance()
        {
            if (instance == null)
                instance = this;
            else
                return;
        }

        private void InitPrefabAndBoardParent(Field prefab, Transform boardPar)
        {
            fieldPref = prefab;
            fieldParent = boardPar;
        }

        private void InitSize(int width, int height)
        {
            boardWidth = width;
            boardHeight = height;

            SizeErrorFix();

            field = new Field[boardWidth * boardHeight];
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = GameObject.Instantiate(fieldPref, new Vector3(-field.Length/2 + i, -field.Length/2 +i,0), Quaternion.identity, fieldParent).GetComponent<Field>();
            }

            //for (int i = 0; i < boardWidth; i++)
            //{
            //    fields[i] = new Field[boardHeight];
            //}
        }

        private void SizeErrorFix()
        {
            boardWidth = Mathf.Abs(boardWidth);
            boardHeight = Mathf.Abs(boardHeight);

            if (boardWidth == 0)
                boardWidth = 1;
            if (boardHeight == 0)
                boardHeight = 1;

            if (boardWidth % 2 != 0)
            {
                boardWidth++;
                //if (boardWidth == 1)
                //{
                //    boardWidth = 2;
                //}
            }
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
