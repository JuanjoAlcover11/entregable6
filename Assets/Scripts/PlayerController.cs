using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;
    public GameObject player;

    void Update()
    {  //Llamamos a la funcion e indicamos las rotaciones
        SpawnProjectile(KeyCode.UpArrow, axis: new Vector3(0, 0, 0));
        SpawnProjectile(KeyCode.RightArrow, axis: new Vector3(0, 0, -90));
        SpawnProjectile(KeyCode.DownArrow, axis: new Vector3(0, 0, 180));
        SpawnProjectile(KeyCode.LeftArrow, axis: new Vector3(0, 0, 90));
    
        
    }
    //Cambiamos la rotacion dependiendo de la tecla pulsada por el usuario y indicamos la posicion y rotacion del proyectil
    public void SpawnProjectile(KeyCode key, Vector3 axis)
    {
       if (Input.GetKeyDown(key))
        {
            transform.rotation = Quaternion.Euler(axis);
            Instantiate(projectile, transform.position,
                player.transform.rotation);
        }

    }
}
