using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MovementAgent : MonoBehaviour
{

    [SerializeField] private float mSpeed = 5f;
    [SerializeField] private Vector3 mTarget = new Vector3(10f, 0f, 10f);

    private const float Tolerance = 0.1f;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (mTarget - transform.position).magnitude;
        if (distance < Tolerance)
        {
            return;
        }
        
        Vector3 dir = (mTarget - transform.position).normalized;
        Vector3 delta = dir * (mSpeed * Time.deltaTime);
        transform.Translate(delta);
    }
}
