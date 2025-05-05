using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsMove : MonoBehaviour
{

    [SerializeField] CircleCollider2D circoll2D;
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "Ground"){
            logic.minusLives();
            Destroy(gameObject);
        }

        if(collision.gameObject.name == "Player"){
            logic.addScore();
            Destroy(gameObject);
        }
    }
}
