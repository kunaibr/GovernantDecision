using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{

    public List<GameObject> listCards;
    public Text debug;
  
    void Update()
    {
        if (Input.touchCount > 0)
        {
            

            var posTouch = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            Collider2D hit = Physics2D.OverlapPoint(new Vector2(posTouch.x, posTouch.y));

            if(hit != null)
            {
              debug.text = Input.GetTouch(0).deltaPosition.ToString();
               
            }
        }
    }

   
}
