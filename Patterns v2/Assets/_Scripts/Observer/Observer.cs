using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{

    private int cptClic = 0;

    //When enabled, subscribes the event to the function
    private void OnEnable() => Cube.onCubeClicked += HasClickedOnCube;

    //When disabled, unsubscribes the event from the function
    private void OnDisable() => Cube.onCubeClicked -= HasClickedOnCube;

    private void HasClickedOnCube()
    {
        cptClic += 1;
        print("You clicked on a cube. Total : " + cptClic);
    }
        

}
