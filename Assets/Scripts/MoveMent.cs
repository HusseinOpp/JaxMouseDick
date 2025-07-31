using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
public class MoveMent : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private float Runspeed = 8f;
    [SerializeField] private float mouseSensitv = 2f;
    [SerializeField] private Transform playeCamera;
    private Rigidbody rb;
    [Header("Demon")]
    private float verticalRotation = 0f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        // MouseMovement
        float mousex = Input.GetAxis("Mouse X") * mouseSensitv;
        float mousey = Input.GetAxis("Mouse Y") * mouseSensitv;

        transform.Rotate(Vector3.up * mousex);
        verticalRotation -= mousey;
        verticalRotation = Mathf.Clamp(verticalRotation, -80f, 80f);
        playeCamera.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }

    void FixedUpdate()
    {
        // PlayerMovement
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * movex + transform.forward * movey).normalized;
        float currentspeed = Input.GetKey(KeyCode.LeftShift) ? Runspeed : speed;

        
        Vector3 targetVelocity = move * currentspeed;
        targetVelocity.y = rb.linearVelocity.y; 

        rb.linearVelocity = Vector3.Lerp(rb.linearVelocity, targetVelocity, 0.15f); 
    }
}
