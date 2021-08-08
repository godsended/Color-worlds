using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public HashSet<Rigidbody> affectedBodies = new HashSet<Rigidbody>();
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _gravityPower;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            affectedBodies.Add(other.attachedRigidbody);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            affectedBodies.Add(other.attachedRigidbody);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            affectedBodies.Remove(other.attachedRigidbody);
        }
    }

    private void FixedUpdate()
    {
        if (affectedBodies.Count > 0)
        {
            foreach (Rigidbody body in affectedBodies)
            {
                Vector3 forceDirection = (transform.position - body.position).normalized;
                float distanceSqr = (transform.position - body.position).sqrMagnitude;
                float strength = _gravityPower * _rigidbody.mass * body.mass / distanceSqr;

                body.AddForce(forceDirection * strength);
            }
        }
    }
}