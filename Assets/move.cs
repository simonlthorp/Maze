using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float thrust;
    private Rigidbody rb;
    private BoxCollider col;
    private bool m_isAxisInUse = false;
    float speed = 10.0f;

    public float turnSpeed = 1.0f;
    public Transform player;

    private Vector3 offset;

    public float speedH;
    public float speedV;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start() {

        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
//       rb.AddForce(transform.forward);

        col = GetComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Fire1") != 0) {
            if (Input.GetAxisRaw("Fire1") != 0) {
                col.enabled = !col.enabled;
            }
        }

    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);


        rb.transform.Translate(movement / 7.5f);


    }
}
