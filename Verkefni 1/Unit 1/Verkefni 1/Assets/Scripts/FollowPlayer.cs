using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Færibreytur
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    void Start()
    {
        
    }


    void Update()
    {
        // Fylgir stöðu leikmansins
        transform.position = player.transform.position + offset;
    }
}
