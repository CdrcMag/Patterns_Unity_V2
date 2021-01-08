using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{

    private int cptClic = 0;

    private void OnEnable() => Cube.onCubeClicked += HasClickedOnCube;
    private void OnDisable() => Cube.onCubeClicked -= HasClickedOnCube;

    private void HasClickedOnCube()
    {
        cptClic += 1;
        print("You clicked on a cube. Total : " + cptClic);
    }
        

}
