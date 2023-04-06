using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform ballsTransform;

    // Kameranýn topu takip etmesini istiyorum ama y ekseninde deðil.
    void Update()
    {
        transform.position = new Vector3(ballsTransform.position.x-2, ballsTransform.position.y+1, transform.position.z);
    }
}
