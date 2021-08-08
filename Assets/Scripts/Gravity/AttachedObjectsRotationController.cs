using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachedObjectsRotationController : MonoBehaviour
{
    [SerializeField] private PlanetGravity _planetGravity;

    private void Update()
    {
        foreach(Rigidbody rb in _planetGravity.affectedBodies)
        {
            rb.gameObject.transform.LookAt(_planetGravity.transform);
        }
    }
}
