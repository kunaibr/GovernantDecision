using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{

    public List<GameObject> listCards;
    public Text debug;
    public int index = 0;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            
            var posTouch = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            Collider2D hit = Physics2D.OverlapPoint(new Vector2(posTouch.x, posTouch.y));

            if(hit != null)
            {
                if(Input.GetTouch(0).deltaPosition.x > 10)
                {
                    listCards[index].GetComponent<CardDisplay>().GotoRight();
                 
                }
                if (Input.GetTouch(0).deltaPosition.x < -10)
                {
                    listCards[index].GetComponent<CardDisplay>().GotoLeft();
                 
                }


            }
        }

        if(listCards[index].GetComponent<CardDisplay>().active == false)
        {
            listCards[index].GetComponent<CardDisplay>().ActiveCard();
        }
    }

   
}
