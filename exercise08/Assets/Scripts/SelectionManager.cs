using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectionManager : MonoBehaviour
{
    GameManager gm;

    public Renderer carRenderer;
    public Color hoverColor;
    public Color selectedColor = Color.magenta;
    public Color defaultColor;

    public bool selected = false;


    // Start is called before the first frame update
    void Start()
    {
        defaultColor = carRenderer.material.color;

        GameObject gmObj = GameObject.Find("GameManager");
        gm = gmObj.GetComponent<GameManager>();



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        if (!selected)
        {
            carRenderer.material.color = hoverColor;
        }
    }

    private void OnMouseExit()
    {
        if (!selected)
        {
            carRenderer.material.color = defaultColor;
        }
    }

    private void OnMouseDown()
    {
        if (gm.selectedCar != null)
        {

            gm.selectedCar.selected = false;
            gm.selectedCar.carRenderer.material.color = gm.selectedCar.defaultColor;

        }

        selected = true;
        carRenderer.material.color = selectedColor;
        gm.selectedCar = this;
        this.tag = "Selected";
        if (this.GetComponent<Rigidbody>() == null)
        {
            this.gameObject.AddComponent<Rigidbody>();

            //this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        }
        gm.canMove = true;

    }


}
