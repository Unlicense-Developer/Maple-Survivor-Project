using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    void Update()
    {
        Vector3 tempPos = new Vector3(transform.position.x, transform.position.y, -10.0f);

        Camera.main.transform.position = tempPos;
    }
}
