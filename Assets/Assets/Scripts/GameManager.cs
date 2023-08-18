using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Addlives(int value){
        lives += value;
        if(lives <= 0){
            Debug.Log("Game Over");
        }
        Debug.Log("Lives =" + lives);
    }
    public void Addscore(int value){
        score += value;
        Debug.Log("Score =" + score);
    }
}
