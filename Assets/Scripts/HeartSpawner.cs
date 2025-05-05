using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpawner : MonoBehaviour
{
    [SerializeField] private GameObject heart;
    [SerializeField] private float spawnRate = 20;
    private float timer = 0;

    // Start is called before the first frame update
    void Start() {
        spawnRate = Random.Range(9f, 19f);
        //Spawn_heart();
    }

    private void Spawn_heart() {
        Instantiate(heart, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update() {
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            Spawn_heart();
            spawnRate = Random.Range(9f, 21f);
            timer = 0;
        }
    }
}
