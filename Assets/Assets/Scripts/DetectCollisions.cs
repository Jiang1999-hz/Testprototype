using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
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
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }else if(other.CompareTag("Animal")){
            gameManager.Addscore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
