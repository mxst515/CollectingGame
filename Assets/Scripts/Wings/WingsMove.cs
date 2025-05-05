using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingsMove : MonoBehaviour {
    [SerializeField] BoxCollider2D boxcoll2D;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start() {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "Ground") {
            Destroy(gameObject);
        }

        if(collision.gameObject.name == "Player") {
            logic.addSpeed();
            Destroy(gameObject);
        }
    }

}
