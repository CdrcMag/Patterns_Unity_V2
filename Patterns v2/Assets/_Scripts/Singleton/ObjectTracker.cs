using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectTracker : MonoBehaviour
{
    private static ObjectTracker _instance;
    public static ObjectTracker Instance
    {
        get
        {
            if (!_instance)
                Debug.LogError("The object tracker is missing.");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public TextMeshProUGUI mainText;


    public void setTextToCube() => mainText.text = "Vous avez cliqué sur un cube.";
    public void setTextToCylindre() => mainText.text = "Vous avez cliqué sur un cylindre.";
    public void setTextToSphere() => mainText.text = "Vous avez cliqué sur une sphere.";



}
