using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Færibreytur
    private float speed = 24.0f;
    private float turnspeed = 55.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        // Fylgist með innslátti
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Færir bílin áfram með forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Stýrir bílnum með horizontal input
        transform.Rotate(Vector3.up * turnspeed * horizontalInput * Time.deltaTime);
    }
}
