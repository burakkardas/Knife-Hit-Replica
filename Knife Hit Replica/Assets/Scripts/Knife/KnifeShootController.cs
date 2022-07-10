using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeShootController : MonoBehaviour
{
    [SerializeField] private KnifeDataTransmitter knifeDataTransmitter;
    [SerializeField] private Rigidbody2D rb;
    public float movementForce;


    void FixedUpdate()
    {
        AddForceKnifeUpMovement();
    }


    private void AddForceKnifeUpMovement()
    {
        if (knifeDataTransmitter.isTouch)
        {
            rb.AddForce(Vector2.up * movementForce * Time.fixedDeltaTime);
        }
    }
}
