using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCamera : MonoBehaviour
{
    GameObject targetObj;
    Vector3 targetPos;
    public float y = 2.12f, z = -3.07f;
    public Quaternion cameraY;
    //ActionAnimator action;
    // Start is called before the first frame update
    void Start()
    {
        targetObj = GameObject.FindWithTag("Player");
        //action = targetObj.GetComponent<ActionAnimator>();
        targetPos = targetObj.transform.position;
        transform.position = targetPos + new Vector3(0,y,z);
        cameraY = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;
        //if(action.shot == false){
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            transform.position += transform.forward * scroll;
        //}

        if(Input.GetMouseButton(1)){
            float mouseInputX = Input.GetAxis("Mouse X");
            float mouseInputY = Input.GetAxis("Mouse Y");
            transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200f);
            transform.RotateAround(targetPos, -transform.right, mouseInputY * Time.deltaTime * 200f);
            cameraY *= Quaternion.Euler(0,mouseInputX * Time.deltaTime * 200f,0);
        }
    }
}
