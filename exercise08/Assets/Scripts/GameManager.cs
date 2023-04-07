using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public SelectionManager selectedCar;
    public bool canMove;
    [SerializeField] GameObject winPos;
    [SerializeField] GameObject taxi;
    [SerializeField] GameObject winText;
    [SerializeField] Animator animUI;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray))
            {
                if (selectedCar != null)
                {
                    selectedCar.selected = false;
                    selectedCar.carRenderer.material.color = selectedCar.defaultColor;

                    selectedCar = null;
                }
            }
        }


        if (taxi.transform.position.z >= winPos.transform.position.z)
        {

            selectedCar.selected = false;
            selectedCar.carRenderer.material.color = selectedCar.defaultColor;
            canMove = false;
            animUI.SetBool("WinPos", true);
            Invoke("showWinText", 2f);


        }

    }


    public void showWinText()
    {
        winText.SetActive(true);
    }

}
