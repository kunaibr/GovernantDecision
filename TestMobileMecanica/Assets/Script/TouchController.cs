using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{

    public List<GameObject> listCards;
    public Text debug;
    public GameObject focoCard;
    public Transform cardLocal;
    void Start()
    {
        focoCard = Instantiate(listCards[Random.Range(0, listCards.Count)], cardLocal);

    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            debug.text = Input.GetTouch(0).deltaPosition.x.ToString();

            var posTouch = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
          
                
            if (Input.GetTouch(0).deltaPosition.x > 10)
            {
                 focoCard.GetComponent<CardDisplay>().GotoRight();
            }
            if (Input.GetTouch(0).deltaPosition.x < -10)
            {
                focoCard.GetComponent<CardDisplay>().GotoLeft();

            }



        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            focoCard.GetComponent<CardDisplay>().GotoRight();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            focoCard.GetComponent<CardDisplay>().GotoLeft();

        }


    }

  public void  Next()
    {
        focoCard = Instantiate(listCards[Random.Range(0, listCards.Count)], cardLocal);


    }


}
