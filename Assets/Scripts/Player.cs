using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float steeringSpeed = 0.3f;
    public float garakeSpeed = 1f;
    public float moveSpeed = 3f;

    Camera cum;
    // Start is called before the first frame update
    void Start()
    {
        cum = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var xInput = Input.GetAxis("Horizontal");
        var yInput = Input.GetAxis("Vertical");

        transform.position += (Vector3.up * moveSpeed + Vector3.right * xInput * steeringSpeed) * Time.deltaTime;

        var cumPosition = cum.transform.position;
        cumPosition.y = transform.position.y;
        cum.transform.position = cumPosition;
    }
}
