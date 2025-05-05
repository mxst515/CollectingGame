using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private GameObject point;
    [SerializeField] private float spawnRate=2;
    private float timer=0;

    // Start is called before the first frame update
    void Start()
    {
        Spawn_point();
        spawnRate = Random.Range(1f, 2.5f);
    }

    private void Spawn_point(){
        Instantiate(point, new Vector3(Random.Range(-7f,7f), 6f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }
        else{
            Spawn_point();
            spawnRate = Random.Range(1f, 2.5f);
            timer = 0;
        }
    }

    private void FixedUpdate() {
        
    }


}
