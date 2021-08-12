using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GravityObject : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    public new Rigidbody rigidbody
    {
        get 
        { 
            if(_rigidbody == null)
            {
                _rigidbody = GetComponent<Rigidbody>();
            }
            return _rigidbody;
        }
        set
        {
            _rigidbody = value;
        }
    }
    private void Awake()
    {
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void FixedUpdate()
    {
        GlobalGravityAttractor.Instance.Attaract(this);
    }
}
