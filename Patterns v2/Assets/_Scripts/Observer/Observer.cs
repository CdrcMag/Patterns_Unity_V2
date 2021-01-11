using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    
    //When enabled, subscribes the event to the function
    private void OnEnable() => Cube.onCubeClicked += HasClickedOnCube;

    //When disabled, unsubscribes the event from the function
    private void OnDisable() => Cube.onCubeClicked -= HasClickedOnCube;

    //private void HasClickedOnCube()
    //{
    //    cptClic += 1;
    //    print("You clicked on a cube. Total : " + cptClic);
    //}

    private void HasClickedOnCube(GameObject o)
    {
        Color c = new Color(Random.value, Random.value, Random.value);

        o.GetComponent<MeshRenderer>().material.color = c;
    }


}
