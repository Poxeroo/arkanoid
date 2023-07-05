using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public int vidas = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        vidas--;
        if (vidas <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
