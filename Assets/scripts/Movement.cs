using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }



    void Update()
    {
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //}
        
        

        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");
        if (x != 0 || z != 0)
        {

            transform.forward = new Vector3(x, 0, z);


            transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;




        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("emeny"))
        {
            print("game over");
            
            var sceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sceneName);
        }
    }
}
