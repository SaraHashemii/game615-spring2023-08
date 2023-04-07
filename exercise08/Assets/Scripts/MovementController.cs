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


    public void MoveForward()
    {
        if (gm.selectedCar != null && gm.selectedCar.tag == "Selected")
        {
            if (gm.canMove)
            {
                gm.selectedCar.transform.Translate(0f, 0f, 1f);
            }
        }
    }

    public void MoveBackward()
    {
        if (gm.selectedCar != null)
        {
            if (gm.canMove)
            {
                gm.selectedCar.transform.Translate(0f, 0f, -1f);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hasCollider")
        {
            gm.canMove = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "hasCollider")
        {
            gm.canMove = true;
        }
    }
}
