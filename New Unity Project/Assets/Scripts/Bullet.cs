using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float moveSpeed = 50f;

    Rigidbody rb;
    public float damage;

    movement target;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindObjectOfType<movement>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);
        //Destroy(gameObject, 3f);

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Enemy hit!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
