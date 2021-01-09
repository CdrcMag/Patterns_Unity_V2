using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    private void Update()
    {
        //On click, shoots a raycast at mouse's position
        if(Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(rayOrigin, out hit))
            {
                if(hit.collider.name == "Cube")
                {
                    Color c = new Color(Random.value, Random.value, Random.value);

                    //Creates a command, with the constructor taking the collider and a color as parameters
                    ICommand click = new ClickCommand(hit.collider.gameObject, c);

                    //Call the Execute method of the interface
                    click.Execute();

                    //Adds the command to the buffer in the CommandManager singleton
                    CommandManager.Instance.AddCommand(click);
                }
            }

        }
    }


}
