using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    public Renderer carRenderer;
    public Color hoverColor;
    public Color SelectedColor;
    public Color defaultColor;

    public bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = carRenderer.material.color;
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
}
