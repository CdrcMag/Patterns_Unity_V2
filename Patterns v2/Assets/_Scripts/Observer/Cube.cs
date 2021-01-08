using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cube : MonoBehaviour
{

    public static event Action onCubeClicked;

    //Sets a random color at start
    private void Start() => setRandomColor();

    //On mouse down, calls this event
    private void OnMouseDown() => onCubeClicked?.Invoke();




    private void setRandomColor()
    {
        //Generates 3 floats
        float r = UnityEngine.Random.Range(0f, 100f) / 100;
        float g = UnityEngine.Random.Range(0f, 100f) / 100;
        float b = UnityEngine.Random.Range(0f, 100f) / 100;

        //Applies them as a color
        Color c = new Color(r, g, b);
        GetComponent<Renderer>().material.color = c;
    }

}
