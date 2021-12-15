using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Controls
{
    [RequireComponent(typeof(Animator))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private ControllerSetting _controllerSettings;
        private bool _walking;

        void Update()
        {
            _walking = Input.GetKey(KeyCode.W);
            if (_walking)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += transform.forward * (Time.deltaTime * _controllerSettings.RunSpeed);
                }
                else
                {
                    transform.position += transform.forward * (Time.deltaTime * _controllerSettings.WalkSpeed);
                }
                

                if (Input.GetKey(KeyCode.A))
                {
                    transform.Rotate(-transform.up, Time.deltaTime * _controllerSettings.RotateSpeed);
                }

                if (Input.GetKey(KeyCode.D))
                {
                    transform.Rotate(transform.up, Time.deltaTime * _controllerSettings.RotateSpeed);
                }
            }
        }
    }
}
