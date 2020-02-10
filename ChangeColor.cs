using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public Color defaultcolor;
    public Color newcolor;
    public Renderer render;
    private Rigidbody rb;
    

    // CAMBIO COLOR AL PASAR CLICK
    public void OnMouseOver()
    {
        render = GetComponent<Renderer>();
        render.material.color = newcolor;
    }

    private void OnMouseExit()
    {
        render = GetComponent<Renderer>();
        render.material.color = defaultcolor;
    }

    // APLICAR FUERZA PARA QUE SE MUEVAN LOS CUBOS AL HACER CLICK

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(myRay, out hit);
        rb.AddForce(hit.normal * -150f);
        rb.useGravity = true;
    }
}
