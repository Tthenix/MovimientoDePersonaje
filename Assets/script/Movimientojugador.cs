using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientojugador : MonoBehaviour
{
    public float speed = 4f;
    public int direction = 1;
    public bool isTouchingWall = false;

    void Start()
    {
        
    }       

    void Update()
    {
        if (isTouchingWall) {
            direction *= -1;
        }
        
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            isTouchingWall = true;
            Debug.Log("Se ha detectado la colisión con la pared.");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            isTouchingWall = false;
        }
    }
}
