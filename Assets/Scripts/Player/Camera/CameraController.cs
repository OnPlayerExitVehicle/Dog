using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform _player;
        [SerializeField] private CameraSetting _cameraSetting;
        private float _lastMousePos;

        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            _lastMousePos = Input.mousePosition.x;
            transform.position = _player.position + _cameraSetting.CameraDistance;
        }

        void Update()
        {

            //transform.LookAt(_player);
            //transform.position = Vector3.Lerp(transform.position, -_player.position + _cameraSetting.CameraDistance, _cameraSetting.CameraSpeed);

            //transform.position = _player.position + _cameraSetting.CameraDistance;
            transform.RotateAround(_player.position, _player.up, (Input.mousePosition.x - _lastMousePos) * _cameraSetting.MouseSensitivity);
            

            _lastMousePos = Input.mousePosition.x;
        }
    }
}
