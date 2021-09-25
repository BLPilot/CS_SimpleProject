using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class BackAndForthPosition : MonoBehaviour
{
    public GameObject obstacle;

    [SerializeField]
    float speed = 1f;

    // Vector coordinates of direction object should move from its current position
    [SerializeField]
    float xDistance = 0f;
    [SerializeField]
    float yDistance = 0f;
    [SerializeField]
    float zDistance = 0f;

    Vector3 startPoint = Vector3.zero;
    Vector3 endPoint = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        obstacle = gameObject;
        startPoint = obstacle.transform.position;
        endPoint = startPoint + new Vector3(xDistance, yDistance, zDistance);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        obstacle.transform.position = Vector3.Lerp(startPoint, endPoint, time);
    }
}
