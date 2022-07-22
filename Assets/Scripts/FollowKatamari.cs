using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowKatamari : MonoBehaviour
{
    public GameObject katamari;

    public float followDistance;
    public float cameraHeight;
    [System.NonSerialized]
    public Vector3 originalPosition;
    public Quaternion originalRotation;

    private KatamariMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = katamari.GetComponent<KatamariMovement>();
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion katamariHeading = movement.heading;

        float verticalInput = Input.GetAxis("Vertical");
        cameraHeight -= verticalInput * Time.deltaTime;

        transform.position =
            katamari.transform.position
            - katamariHeading * new Vector3(0, 0, followDistance)
            + new Vector3(0, cameraHeight, 0);

        transform.LookAt(katamari.transform);
    }
}
