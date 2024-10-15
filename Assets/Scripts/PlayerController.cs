using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;            
    public Rigidbody rb;
    public GameObject projectilePrefab;
    public Transform shootPoints;


    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");    

        
        movement = new Vector3(moveX, 0 , moveZ).normalized;
    }
    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Fire(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Fire(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Fire(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Fire(Vector3.back);
        }
    }
    void Fire(Vector3 direction)
    {
        GameObject bullet = Instantiate(projectilePrefab, shootPoints.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().velocity = direction * bullet.GetComponent<Bullet>().speed; // Adjust the Bullet script accordingly
    }


    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }
}
