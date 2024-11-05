using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform camera;
    public Transform player;

    void Update()
    {
        camera.position = new Vector3(player.position.x, player.position.y, camera.position.z);
    }
}
