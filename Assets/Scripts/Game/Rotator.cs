using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float maxRotation = 45f;

    private void Update()
    {
        // get input
        Vector3 inputAxis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        // calculate rotation change
        Vector3 rotationModifier = new Vector3(inputAxis.x, 0, inputAxis.z) * rotationSpeed * Time.deltaTime;

        // get current rotation
        Vector3 currentRotation = transform.rotation.eulerAngles;

        // convert unsigned to signed rotation
        Vector3 signedRotation = FixRotation(rotationModifier + currentRotation);

        // clamp rotation
        Vector3 clampedRotation = Clamp(signedRotation, maxRotation);

        // apply
        transform.rotation = Quaternion.Euler(clampedRotation);
    }

    // converts unsigned rotation to signed
    private Vector3 FixRotation(Vector3 rotation)
    {
        for (int i = 0; i < 3; i++)
        {
            float axis = rotation[i];

            // if half of full rotation
            if (axis > 180f)
            {
                // change sign
                axis = axis - 360f;

                // apply
                rotation[i] = axis;
            }
       }
        return rotation;
    }

    // clamps each coord in vector
    private Vector3 Clamp(Vector3 v, float maxValue)
    {
        for (int i = 0; i < 3; i++)
        {
            v[i] = Mathf.Clamp(v[i], -maxValue, maxValue);
        }

        return v;
    }
}
