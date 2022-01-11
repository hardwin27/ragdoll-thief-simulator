using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform player;

    private void Start()
    {
        player = GameObject.Find("Player").transform.Find("Hip").transform;
    }

    private void Update()
    {
        if(player == null)
        {
            print("LOL");
            return;
        }
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
