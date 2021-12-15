using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Camera
{
    [CreateAssetMenu(fileName = "CameraSetting", menuName = "Player/Settings/Camera/CameraSetting")]
    public class CameraSetting : ScriptableObject
    {
        public Vector3 CameraDistance;
        public float CameraSpeed;
        public float MouseSensitivity;
    }
}
