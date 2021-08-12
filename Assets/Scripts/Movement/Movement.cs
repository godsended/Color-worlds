using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private GameObject _cameraPointAnchor;

    public void Move(Vector3 direction)
    {
        Vector3 forMoveDir = transform.forward * direction.z;

        Vector3 rightMoveDir = transform.right * direction.x;

        Vector3 move = (forMoveDir + rightMoveDir).normalized * _speed * Time.deltaTime;

        _rigidbody.MovePosition(move + _rigidbody.position);
    }
}
