using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLook : MonoBehaviour
{
    [SerializeField] float mouseSens = 10f;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update() 
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime; 

        player.Rotate(Vector3.up * mouseX);
        transform.Rotate(Vector3.left * mouseY);
    }
}
