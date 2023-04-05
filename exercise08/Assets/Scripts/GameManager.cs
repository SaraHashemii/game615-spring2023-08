using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public SelectionManager selectedCar;

    // Start is called before the first frame update
    void Start()
    {

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
    }



}
