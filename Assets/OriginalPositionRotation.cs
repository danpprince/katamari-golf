using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OriginalPositionRotation : MonoBehaviour
{
    public Vector3 originalPosition;
    public Quaternion originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
