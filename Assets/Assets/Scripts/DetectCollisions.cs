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
        //check if the other tag was the player, if it was remove a life
        if(other.CompareTag("Player")){
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
        //check if the other tag was the Animal, if it was add points to the score
        else if(other.CompareTag("Animal")){
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
        }
    }
}
