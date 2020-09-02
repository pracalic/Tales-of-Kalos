using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pracalic
{


    public class Field : MonoBehaviour
    {
        [SerializeField]
        TEAM fieldTeam = TEAM.RED;
        [SerializeField]
        SpriteRenderer sr = null;

        Camera cam;

        public void SetTeam(TEAM t)
        {
            fieldTeam = t;
        }

        private void SetFieldColor()
        {
            if (fieldTeam == TEAM.RED)
            {
                sr.color = Color.red;
            }
            else
            {
                sr.color = Color.blue;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            //if (fieldTeam == TEAM.RED)
            //{
            //    GetComponent<SpriteRenderer>().color = Color.red;
            //}
            //else
            //{
            //    GetComponent<SpriteRenderer>().color = Color.blue;
            //}

           // cam = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {
            //RaycastHit2D hit;
            //Vector2 ray = cam.ScreenToWorldPoint(Input.mousePosition);

            //if (Physics2D.Raycast(ray, out hit))
            //{
            //    Transform objectHit = hit.transform;

            //    // Do something with the object that was hit by the raycast.
            //}
            if (Input.GetButtonDown("Fire1"))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.collider != null)
                {
                    Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                }
            }
        }
    }
}
