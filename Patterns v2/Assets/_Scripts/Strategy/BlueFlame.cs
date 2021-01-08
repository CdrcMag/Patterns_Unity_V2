using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlueFlame : MonoBehaviour, IFlame
{
    GameObject fire = default;

    public void ShowFlame()
    {
        Vector3 pos = new Vector3(0, -2.6f, -2.47f);

        fire = Instantiate(Resources.Load("Flame-blue", typeof(GameObject))) as GameObject;
        fire.transform.parent = transform;

        fire.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        fire.transform.position = pos;
    }

    public void DestroyFlame()
    {
        Destroy(fire);
    }
}

