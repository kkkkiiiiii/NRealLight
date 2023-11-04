using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    private Animator _zombieAnimator;
    private CharacterController _characterController;
    public VariableJoystick joystickLeft;
    public VariableJoystick joystickRight;
    private float _moveInputX;
    private float _moveInputY;
    private Vector3 _movement;
    public float speed;
    private void Start()
    {
        _zombieAnimator = GetComponent<Animator>();
        _characterController = GetComponent<CharacterController>();

    }

    private void Update()
    {
        _moveInputX = joystickLeft.Direction.x;
        _moveInputY = joystickLeft.Direction.y;
        if (_moveInputX != 0 && _moveInputY != 0) _zombieAnimator.SetBool("IsWalking", true);
        else _zombieAnimator.SetBool("IsWalking", false);
    }

    private void FixedUpdate()
    {
        // zombie movement
        _movement = new Vector3(_moveInputY * -speed, 0, _moveInputX * speed);
        _characterController.Move(_movement);
        
        // zombie rotation
        if (_moveInputX != 0 || _moveInputY != 0)
        {
            Vector3 lookDir = new Vector3(_movement.x, 0, _movement.z);
            transform.rotation = Quaternion.LookRotation(lookDir);    
        }
    }

    public void Attack()
    {
        _zombieAnimator.SetTrigger("Attack");
    }
}
