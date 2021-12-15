using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Controls
{
    [CreateAssetMenu(fileName = "Data", menuName = "Player/Settings/Controls/ControllerSetting")]
    public class ControllerSetting : ScriptableObject
    {
        public float WalkSpeed;
        public float RunSpeed;
        public float RotateSpeed;
    }
}