﻿using UnityEngine;

public class FloatingRigidBody : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (GameStates.FloatingObjectsEnabled)
            FloatAround();
    }

    private void FloatAround()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * Constants.ZeroGravityFloatStrength);
        transform.Rotate(Constants.ZeroGravityRandomRotationStrength, Constants.ZeroGravityRandomRotationStrength,
            Constants.ZeroGravityRandomRotationStrength);
    }
}