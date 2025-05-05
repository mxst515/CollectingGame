using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wings;
    [SerializeField] private float spawnRate = 17;
    private float timer = 0;

    // Start is called before the first frame update
    void Start() {
        spawnRate = Random.Range(13f, 23f);
        //Spawn_wings();
    }

    private void Spawn_wings() {
        Instantiate(wings, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update() {
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            Spawn_wings();
            spawnRate = Random.Range(13f, 23f);
            timer = 0;
        }
    }
}
