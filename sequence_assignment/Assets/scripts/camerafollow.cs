using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;
    public float smoothFollow;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,player.position,Time.deltaTime * smoothFollow);
    }
}
