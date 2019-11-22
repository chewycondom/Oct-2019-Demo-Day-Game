using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thanospoop : MonoBehaviour
{
    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("fuck you" + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            print("Player got hit");
            Destroy(collision.gameObject);
        }
    }
}
