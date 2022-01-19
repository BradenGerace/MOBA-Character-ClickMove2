using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public Camera cam;
    private float camFOV;
    public float zoomSpeed;

    private float mouseScrollInput;

    //TD variables
    //public float CurrentZoom = 0;
    //public float ZoomZpeed = 1;
    //public Vector2 zoomRange = new Vector2(-10, 100);
    //private Vector3 initialPosition;
    //private Vector3 initialRotation;
    //public float ZoomRotation = 1;
    //public Vector2 zoomAngleRange = new Vector2(20, 70);
    //private float speed;
    //public float minX = -10f;
    //public float maxX = 80f;
    //public float minZ = -30f;
    //public float maxZ = 80f;
    //private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        camFOV = cam.fieldOfView;

        //Td Controls
        //initialPosition = transform.position;
        //initialRotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        mouseScrollInput = Input.GetAxis("Mouse ScrollWheel");

        camFOV -= mouseScrollInput * zoomSpeed;
        camFOV = Mathf.Clamp(camFOV, 10, 60);

        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, camFOV, zoomSpeed);

        //TD Cam Controls

        //CurrentZoom -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 1000 * ZoomZpeed;

        //CurrentZoom = Mathf.Clamp(CurrentZoom, zoomRange.x, zoomRange.y);

        //transform.position = new Vector3(transform.position.x, transform.position.y - (transform.position.y - (initialPosition.y + CurrentZoom)) * 0.1f, transform.position.z);

        //float x = transform.eulerAngles.x - (transform.eulerAngles.x - (initialRotation.x + CurrentZoom * ZoomRotation)) * 0.1f;
        //x = Mathf.Clamp(x, zoomAngleRange.x, zoomAngleRange.y);

        //transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);



        /* yaw += speedH * Input.GetAxis("Horizontal");
        pitch -= speedV * Input.GetAxis("Vertical");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        */

        //transform.Rotate(0, speed * Time.deltaTime, 0);

        //Vector3 pos = transform.position;

        //pos.x = Mathf.Clamp(pos.x, minX, maxX);
        //pos.z = Mathf.Clamp(pos.z, minZ, maxZ);

        //transform.position = pos;
    }
}
