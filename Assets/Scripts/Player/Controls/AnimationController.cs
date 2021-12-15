using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Controls
{
    public class AnimationController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        private bool _walking;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _walking = true;
                _animator.SetTrigger("Walk");
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                _walking = false;
                _animator.SetTrigger("Idle");
            }

            if (_walking)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    _animator.SetTrigger("Run");
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    _animator.SetTrigger("Walk");
                }
            }

            if (Input.GetMouseButton(0))
            {
                _animator.SetTrigger("Attack");
            }
        }
    }
}
