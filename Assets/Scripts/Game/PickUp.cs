using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 50f;
    [SerializeField] GameObject effect;
    [SerializeField] TriggerDetector triggerDetector;

    [SerializeField] PickUpCounter counter;

    void Start()
    {
        triggerDetector.onEnter += OnPickUp;
        counter = Game.Instance.PickUpCounter;
        counter.AddTotal();
    }

    private void OnPickUp(Collider other)
    {
        Instantiate(effect, transform.position + effect.transform.position, transform.rotation);
        Destroy(gameObject);
        counter.AddCollected();
    }

    void Update()
    {
        transform.Rotate (Vector3.up, rotateSpeed*Time.deltaTime);
    }

}
