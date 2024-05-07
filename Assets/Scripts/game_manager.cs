using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    
    public List<GameObject> lst;
    public List<GameObject> stars;
    // public List<bool> visit;
    public List<Vector3> pos = new List<Vector3>();

    public GameObject[,] lst_pairs;
    // public GameObject rocket;
    public GameObject cr1;
    public GameObject cr2;
    public GameObject cr3;
    public GameObject cr4;
    public GameObject cr5;
    public GameObject cr6;
    public GameObject cr7;
    public GameObject go1;
    public GameObject go2;
    public bool flag;
    // LineRenderer line;

    void Start()
    {
        lst = new List<GameObject>();
        lst_pairs = new GameObject[7,2] { { cr1, cr2 }, { cr2, cr3 }, { cr3, cr4 }, { cr4, cr5 }, { cr5, cr6 }, { cr6, cr7 }, { cr7, cr4 } }; // массив правильных пар звезд
        flag = false; // проверка, посещена ли первая звезда
        // visit = new List<bool> { false, false, false, false, false, false };
        // stars = new List<GameObject>(); // массив звезд, которых коснулась ракета
        //stars.Add(go1);
        //stars.Add(go2);
        // pos.Add(go1.transform.position); // начальный пункт построения линии
        // pos.Add(go2.transform.position); // конечный пункт построения линии
    }

    /*
    void update ()
    {
        for (int i = 0; i < 6; i++)
        {
            if (go1 == lst_pairs[i, 0] && go2 == lst_pairs[i, 1])
            {
                line = transform.GetComponent<LineRenderer>();
                line.SetVertexCount(2);
                line.SetPosition(0, go1.transform.position);
                line.SetPosition(1, go2.transform.position);
                go1 = go2;

                
                LineRenderer l = go2.AddComponent<LineRenderer>();
                l.startWidth = 2f;
                l.endWidth = 2f;
                l.SetPositions(pos.ToArray());
                l.useWorldSpace = true;
                
               
            }
        }
      */
            
      
            


    /*
    for (int i = 0; i < 6; i++)
    {
        lst[i].color = new Color32(0, 0, 0, 0);
    }
    */
}
 