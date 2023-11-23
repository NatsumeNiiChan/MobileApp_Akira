using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
