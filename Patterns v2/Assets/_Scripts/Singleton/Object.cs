using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour, IObject
{
    public string type;

    public void Type()
    {
        switch(type)
        {
            case "Sphere": ObjectTracker.Instance.setTextToSphere(); break;
            case "Cube": ObjectTracker.Instance.setTextToCube(); break;
            case "Cylindre": ObjectTracker.Instance.setTextToCylindre(); break;
            default: break;
        }
    }


    private void OnMouseDown() => Type();


}
