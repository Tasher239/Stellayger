using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class render : MonoBehaviour
{
    LineRenderer line;
    public GameObject cr1;
    public GameObject cr2;

    void Start()
    {
        line = transform.GetComponent<LineRenderer>();
        line.SetVertexCount(2);
        line.SetPosition(0, cr1.transform.position);
        line.SetPosition(1, cr2.transform.position);
        
        line.SetWidth(1f, 2f);

    }
}
