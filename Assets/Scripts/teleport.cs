using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour
{
    public LayerMask TerrainMask;
    public int FacingDirection; //-1 = left, 1 = right
    public float MaxTeleportDistance; //max distance the player can teleport

    void Teleport()
    {
        RaycastHit2D rayHit = Physics2D.Raycast(transform.position,
        new Vector2(FacingDirection, 0), MaxTeleportDistance, TerrainMask);
        if (rayHit)
        {
            // RayCastHit2D.fraction will give you the length of the ray minus any collision depth
            transform.Translate(new Vector3(FacingDirection * rayHit.fraction, 0, 0));
        }
        else
        {
            transform.Translate(
            new Vector3(FacingDirection * MaxTeleportDistance, 0, 0));
        }
    }
}