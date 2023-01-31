using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    [SerializeField] private float flt_HorizontalSpeed;
    
    [SerializeField] private float flt_Boundry;

    private float flt_HorizontalInput;

    // Update is called once per frame
    void Update()
    {
        GetInput();
        PlayerMotion();
    }

    private void PlayerMotion()
    {
        transform.Translate(Vector3.right * flt_HorizontalInput * flt_HorizontalSpeed * Time.deltaTime);

        float x = transform.position.x;
        x = Math.Clamp(x, -flt_Boundry, flt_Boundry);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
       
    }

    private void GetInput()
    {
        flt_HorizontalInput = Input.GetAxis("Horizontal");

    }
}
