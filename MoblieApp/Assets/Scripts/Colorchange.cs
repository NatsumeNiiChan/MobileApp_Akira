using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void ButtonChangeColor()
    {
        if (GetComponent<Renderer>().material.color == Color.green)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }

        else GetComponent<Renderer>().material.color = Color.green;
    }
}
