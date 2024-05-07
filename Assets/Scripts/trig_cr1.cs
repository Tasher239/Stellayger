using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig_cr1 : MonoBehaviour
{
    public GameObject go1;
    public GameObject manager;
    LineRenderer line;

    public SpriteRenderer spriteRenderer1;
    public Sprite newSprite1;
    public SpriteRenderer spriteRenderer2;
    public Sprite newSprite2;

    void Start()
    {
        spriteRenderer1 = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            manager.GetComponent<game_manager>().go1 = go1;
            manager.GetComponent<game_manager>().flag = true;
            // SpriteRenderer spr = GetComponent<SpriteRenderer>();
            // ChangeSprite(red);
            spriteRenderer1.sprite = newSprite1;
            spriteRenderer2.sprite = newSprite2;
        }
    }
}
