using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_rend : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go1;
    public GameObject go2;

    void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();

        List<Vector3> pos = new List<Vector3>();
        pos.Add(go1.transform.position);
        pos.Add(go2.transform.position);
        l.startWidth = 2f;
        l.endWidth = 2f;
        l.SetPositions(pos.ToArray());
        l.useWorldSpace = true;






    }

}