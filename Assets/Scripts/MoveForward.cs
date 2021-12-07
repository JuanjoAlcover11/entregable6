using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 10f;
    private float Lim = 10f;

    void Update()
    {
        // Movimiento hacia adelante del proyectil
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Proyectil fallido
        if (transform.position.x > Lim)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -Lim)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > Lim)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -Lim)
        {
            Destroy(gameObject);
        }
    }


}
