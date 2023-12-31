using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal Input
       horizontalInput = Input.GetAxis("Horizontal"); 
       //Player movement x axis*input*t*speed
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
       //check if player is over bound, let x constant
       if(transform.position.x < -xRange){
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
       }
       if(transform.position.x > xRange){
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
       }
       //Lauch a projectile from the player
       if(Input.GetKeyDown(KeyCode.Space)){
        Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
       }
    }
}
