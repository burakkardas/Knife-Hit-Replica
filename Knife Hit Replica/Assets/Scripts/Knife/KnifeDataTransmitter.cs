using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeDataTransmitter : MonoBehaviour
{
    [SerializeField] private KnifeInputController knifeInputController;
    [SerializeField] private KnifeShootController knifeShootController;

    public bool isTouch;

    public void SetKnifeMovementForce(float value)
    {
        knifeShootController.movementForce = value;
    }
}
