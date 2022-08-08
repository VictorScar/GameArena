using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSetup : MonoBehaviour
{
[SerializeField] AudioSource audioSource;
    void Start()
    {
        audioSource.pitch += Random.Range(0.0f, 0.5f);
    }


}
