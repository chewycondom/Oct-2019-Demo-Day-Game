using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class door : MonoBehaviour
{
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            SceneManager.LoadScene(scene);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
