using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePickUps : MonoBehaviour
{
    [SerializeField] GameObject pickUpPrefab;
    void Start()
    {
        InstancePickUp(pickUpPrefab, 8);
    }

  void InstancePickUp (GameObject pickUpPrefab, int Count)
    {
        for (int i = 0; i < Count; i++)
        {
            Instantiate(pickUpPrefab, new Vector3(Random.Range(-4, 4), 0, Random.Range(-4, 4)), Quaternion.identity);
        }
    }
}
