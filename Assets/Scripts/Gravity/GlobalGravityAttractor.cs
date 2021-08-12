using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalGravityAttractor : MonoBehaviour
{
    public static GlobalGravityAttractor Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public float gravity = -10;
    public void Attaract(GravityObject body)
    {
        Vector3 gravityUp = (body.rigidbody.position - transform.position).normalized;
        Vector3 localUp = body.transform.up;


        body.rigidbody.AddForce(gravityUp * gravity);

        body.rigidbody.rotation = Quaternion.FromToRotation(localUp, gravityUp) * body.rigidbody.rotation;
    }
}
