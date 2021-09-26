using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class BackAndForthRotation : MonoBehaviour
{
    public GameObject obstacle;

    [SerializeField]
    float rotationSpeed = 1f;

    // Vector coordinates of angles object should rotate from its current euler angles
    [SerializeField]
    [Range(-360,360)]
    float xAngle = 0f;
    [SerializeField]
    [Range(-360, 360)]
    float yAngle = 0f;
    [SerializeField]
    [Range(-360, 360)]
    float zAngle = 0f;

    Vector3 startAngles = Vector3.zero;
    Vector3 endAngles = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        obstacle = gameObject;
        startAngles = obstacle.transform.eulerAngles;
        endAngles = startAngles + new Vector3(xAngle, yAngle, zAngle);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * rotationSpeed, 1);
        obstacle.transform.eulerAngles = Vector3.Lerp(startAngles, endAngles, time);
    }
}
