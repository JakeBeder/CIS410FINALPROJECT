using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{

    private Rigidbody rb;

    public Transform[] target;

    public float speed;

    private int current;

    public Text gameOver;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        { 
            current = (current + 1) % target.Length;
        }

        //Jake code for moving object.
        // transform.Translate(Vector3.forward * speed);

        //rb.AddForce(movement * speed);
    }

    // Jake code for deleting ball if we hit the blue circle.

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Endpoint"))
        {
            gameObject.SetActive(false);
            gameOver.text = "Game Over!";

        }
    }

}
