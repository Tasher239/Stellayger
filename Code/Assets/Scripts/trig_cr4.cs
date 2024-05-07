using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig_cr4 : MonoBehaviour
{
    public GameObject go2;
    public GameObject manager;
    LineRenderer line;
    public bool flag;

    public SpriteRenderer spriteRenderer1;
    public Sprite newSprite1;
    public SpriteRenderer spriteRenderer2;
    public Sprite newSprite2;
    public Sprite newSprite3;

    void Start()
    {
        flag = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            GameObject go1 = manager.GetComponent<game_manager>().go1;
            GameObject[,] lst_pairs = manager.GetComponent<game_manager>().lst_pairs;

            for (int i = 0; i < 7; i++)
            {
                if (go1 == lst_pairs[i, 0] && go2 == lst_pairs[i, 1] && manager.GetComponent<game_manager>().flag == true)
                {
                    if (flag == false)
                    {
                        line = transform.GetComponent<LineRenderer>();
                        line.SetVertexCount(2);
                        line.SetPosition(0, go1.transform.position);
                        line.SetPosition(1, go2.transform.position);
                        line.SetWidth(2.5f, 2.5f);
                        manager.GetComponent<game_manager>().go1 = go2;
                        flag = true;

                        spriteRenderer1.sprite = newSprite1;
                        spriteRenderer2.sprite = newSprite2;

                    }

                    else
                    {
                        line = transform.GetComponent<LineRenderer>();
                        line.SetVertexCount(4);
                        line.SetPosition(2, go1.transform.position);
                        line.SetPosition(3, go2.transform.position);
                        line.SetWidth(2.5f, 2.5f);
                        manager.GetComponent<game_manager>().go1 = go2;
                        spriteRenderer1.sprite = newSprite3;
                    }
                }
            }
        }
    }
}
