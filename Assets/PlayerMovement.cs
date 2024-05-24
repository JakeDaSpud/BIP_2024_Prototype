using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// New Input System Import
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5;
    [SerializeField] private float _movementInterpolation = 0.5f;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;
    

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        _rigidbody.velocity = Vector3.Lerp(Vector3.zero, _movementInput * _movementSpeed, _movementInterpolation);
    }

    private void OnMove(InputValue inputValue) {
        _movementInput = inputValue.Get<Vector2>();
    }
}
