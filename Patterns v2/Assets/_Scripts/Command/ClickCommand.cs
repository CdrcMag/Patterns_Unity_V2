using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand 
{
    private GameObject _cube;
    private Color _color;
    private Color _previousColor;

    //Constructor
    public ClickCommand(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }

    //Saves the previous color, and assigns a new one
    public void Execute()
    {
        _previousColor = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    //Assigns the previous color
    public void Undo()
    {
        _cube.GetComponent<MeshRenderer>().material.color = _previousColor;
    }

    //Sets the cube's color to white
    public void ResetColor()
    {
        _cube.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    
}
