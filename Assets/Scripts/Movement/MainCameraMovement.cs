using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MainCameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject _attachedObject, _cameraAnchor;
    [SerializeField] private float _moveTime, _stayHeight, _stayDistance, _lookAngle;
    private void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, _cameraAnchor.transform.rotation, _moveTime * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, _cameraAnchor.transform.position, _moveTime * Time.deltaTime);
    }
}
