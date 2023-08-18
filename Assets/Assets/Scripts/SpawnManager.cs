using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX  = 20;
    public float spawnRangeZ  = 20;
    public float spawnPosZ  = 20;
    public float spawnPosX  = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Reapter("SpawnRandomAnimal");
        Reapter("SpawnLeftAnimal");
        Reapter("SpawnRightAnimal");
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void SpawnRandomAnimal(){
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex],new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ),animalPrefabs[animalIndex].transform.rotation);
        }
    void SpawnLeftAnimal(){
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX,0,Random.Range(0,spawnRangeZ));
        Vector3 rotation = new Vector3(0,90,0);
        Instantiate(animalPrefabs[animalIndex],spawnPos,Quaternion.Euler(rotation));
    }
    void SpawnRightAnimal(){
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX,0,Random.Range(0,spawnRangeZ));
        Vector3 rotation = new Vector3(0,-90,0);
        Instantiate(animalPrefabs[animalIndex],spawnPos,Quaternion.Euler(rotation));
    }
    void Reapter(string Function){
        InvokeRepeating(Function,startDelay,spawnInterval);
    }
}
