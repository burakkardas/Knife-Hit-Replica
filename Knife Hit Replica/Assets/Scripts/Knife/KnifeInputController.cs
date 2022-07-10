using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInputController : MonoBehaviour
{
    [SerializeField] private KnifeDataTransmitter knifeDataTransmitter;

    private void Update()
    {
        HandleTouchInput();
    }


    private void HandleTouchInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            knifeDataTransmitter.isTouch = true;
        }
    }
}
