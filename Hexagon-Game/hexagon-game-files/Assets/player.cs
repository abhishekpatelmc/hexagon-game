using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    //public float moveSpeed = 600f;

    private Vector3 target = new Vector3(5.0f,0.0f,0.0f);
    
    //float movement = 0f;
    
    // Update is called once per frame
    void Update()
    {
        //movement = Input.GetAxisRaw("Horizontal");       
    }

    public void Pico()
    {
        //transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
        
        transform.RotateAround(target, Vector3.up, 30 * Time.deltaTime);
        Debug.Log("Hello");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
