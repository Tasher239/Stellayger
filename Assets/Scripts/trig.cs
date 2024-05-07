using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig : MonoBehaviour
{
    
    public GameObject go1;
    public GameObject go2;
    
    private void OnTriggerEnter2D(Collider2D other) 

    {
        if(other.tag == "Player")
        {
            
            LineRenderer l = gameObject.AddComponent<LineRenderer>();

            List<Vector3> pos = new List<Vector3>();
            pos.Add(go1.transform.position);
            pos.Add(go2.transform.position);
            l.startWidth = 2.5f;
            l.endWidth = 2.5f;
            l.SetPositions(pos.ToArray());
            l.useWorldSpace = true;

        }
    }

}
