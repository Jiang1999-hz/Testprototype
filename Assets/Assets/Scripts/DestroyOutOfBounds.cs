using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float bottomBound = -10;
    private float sideBound = 21;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //call GameManager into gameManager to use Addlive Addscore
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if an object go path or hit the player remove it and lives -1
        if(transform.position.z > topBound){
            Destroy(gameObject);
        } else if(transform.position.z < bottomBound){
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }else if(transform.position.x > sideBound){
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }else if(transform.position.x < -sideBound){
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
    }
}
