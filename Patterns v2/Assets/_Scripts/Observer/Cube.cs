using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cube : MonoBehaviour
{

    public static event Action<GameObject> onCubeClicked;

    //On mouse down, calls this event
    private void OnMouseDown() => onCubeClicked?.Invoke(gameObject);

    

}
