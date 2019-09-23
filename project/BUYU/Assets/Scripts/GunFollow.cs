using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollow : MonoBehaviour
{
    public RectTransform RectTransform;
    public Camera Camera;

    void Update()
    {
        Vector3 vector3;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(RectTransform, new Vector2
            (
            Input.mousePosition.x,
            Input.mousePosition.y
            ), Camera, out vector3);

        var z = Vector3.Angle(Vector3.up, vector3 - transform.position) *
            (
                vector3.x > transform.position.x ? -1 : 1
            );

        transform.localRotation = Quaternion.Euler(0, 0, z);

    }
}
