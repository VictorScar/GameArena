using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    public event Action<Collider> onEnter;
    private void OnTriggerEnter(Collider other)
    {
        onEnter?.Invoke(other);
    }
}
