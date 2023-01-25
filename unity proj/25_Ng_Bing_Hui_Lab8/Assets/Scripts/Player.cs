using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        if(transform.position.y >= 4f)
        {
            transform.position = new Vector3(transform.position.x, 4f, transform.position.z);
        }
        if (transform.position.y <= -4f)
        {
            transform.position = new Vector3(transform.position.x, -4f, transform.position.z);
        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("amogus");
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }


}
