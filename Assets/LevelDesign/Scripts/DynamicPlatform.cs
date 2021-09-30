using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicPlatform : MonoBehaviour
{
    public List<Transform> targets;
    public float speed;
    private int target = 0;
    private float diff;
    private Vector3 direction;

    void Start()
    {
        target = -1;
        NextTarget();
    }

    void NextTarget()
    {
        target = (target < targets.Count - 1) ? target + 1 : 0;
        Debug.Log("target: " + target);
        diff = (transform.localPosition - targets[target].localPosition).magnitude;
        direction = (targets[target].localPosition - transform.localPosition).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        print(targets.Count);
        transform.localPosition += direction * Time.deltaTime * speed;
        if((transform.localPosition - targets[target].localPosition).magnitude < 0.1f)
        {
            NextTarget();
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Player")
            c.transform.SetParent(transform);
    }

    void OnCollisionExit(Collision c)
    {
        if(c.gameObject.tag == "Player")
            c.transform.SetParent(null);
    }
}
