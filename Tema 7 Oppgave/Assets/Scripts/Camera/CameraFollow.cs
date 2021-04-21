using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 cameraFollowPosition;
    public void Setup(Vector3 cameraFollowPosition)
	{
        this.cameraFollowPosition = cameraFollowPosition;
	}
    void Update()
    {
        Vector3 cameraFollowPosition = new Vector3(0, 0);
        cameraFollowPosition.z = transform.position.z;
        transform.position = cameraFollowPosition;
    }
}
