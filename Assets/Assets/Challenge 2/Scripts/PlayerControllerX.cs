using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool timer = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = false;
            Invoke("MakeTrue",1);
        }
    }
    void MakeTrue()
    {
        timer = true;
    }
}
