using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFlame : MonoBehaviour, IFlame
{
    GameObject redFlame = default;

    public void ShowFlame()
    {
        Vector3 pos = new Vector3(0, -2.6f, -2.47f);
        
        redFlame = Instantiate(Resources.Load("Flame-red", typeof(GameObject))) as GameObject;
        redFlame.transform.parent = transform;

        redFlame.transform.rotation = Quaternion.Euler(new Vector3(0,180,0));
        redFlame.transform.position = pos;
    }

    public void DestroyFlame()
    {
        Destroy(redFlame);
    }
}