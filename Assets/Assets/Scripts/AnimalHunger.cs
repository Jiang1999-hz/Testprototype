using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;

    private int currentFedAmount;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //update the current fed amount of the animal;
    public void FeedAnimal(int amount)
    {
        //
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;
        //if the animal is fed enough, add points to the score and destroy the animal
        if(currentFedAmount >= amountToBeFed){
            gameManager.Addscore(amountToBeFed);
            Destroy(gameObject,0.1f);
        }
    }
}
