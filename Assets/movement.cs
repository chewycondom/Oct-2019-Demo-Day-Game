using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    bool touchingfloor = true;
    public GameObject floordetector;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.W) && touchingfloor==true)
        {
            //transform.Translate(0, 3f * Time.deltaTime, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, jumpForce, 0));
        }
      if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -3f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(2 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-2 * Time.deltaTime, 0, 0);
        }
    }
    void OnTriggerEnter2D()
    {
        touchingfloor = true;
    }
    void OnTriggerExit2D()
    {
        touchingfloor = false;
    }
}
