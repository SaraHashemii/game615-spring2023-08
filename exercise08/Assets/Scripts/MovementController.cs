using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gmObj = GameObject.Find("GameManager");
        gm = gmObj.GetComponent<GameManager>();
    }


    public void MoveUp()
    {
        if (gm.selectedCar != null && gm.selectedCar.CompareTag("Vertical"))
        {
            gm.selectedCar.transform.Translate(0f, 0f, 1f);
          
        }

    }
    public void MoveDown()
    {
        if (gm.selectedCar != null && gm.selectedCar.CompareTag("Vertical"))
        {
            gm.selectedCar.transform.Translate(0f, 0f, -1f);
           
        }
    }
    public void MoveLeft()
    {
        if (gm.selectedCar != null && gm.selectedCar.CompareTag("Horizontal"))
        {
            gm.selectedCar.transform.Translate(0f, 0f, -1f);
            
        }
    }
    public void MoveRight()
    {
        if (gm.selectedCar != null && gm.selectedCar.CompareTag("Horizontal"))
        {
            gm.selectedCar.transform.Translate(0f, 0f, 1f);
           
        }
    }
}
