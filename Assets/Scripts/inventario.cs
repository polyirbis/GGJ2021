using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour
{
    public int cantidad = 0;
    public Star Meter;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Meter.Health += 0.25f;
            Destroy(collision.gameObject);
            //cambio sprite
        }
        if (collision.gameObject.CompareTag("Benefit"))
        {
            if (Meter.Health <= 1)
            {
                Meter.Health -= 0.25f;
            }
            Destroy(collision.gameObject);
            //cambio sprite           
        }
    }

}
