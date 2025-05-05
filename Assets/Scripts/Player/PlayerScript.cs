using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] private BoxCollider2D boxcoll2D;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private Animator anim;

    [SerializeField] public float player_speed;

    private float horizontal_move;

    // Start is called before the first frame update
    void Start()
    {
        player_speed = 10f;
    }

    private void InputHandle(){
        horizontal_move = Input.GetAxisRaw("Horizontal");
    }

    private void AnimHandle(){
        anim.SetBool("MovingLeft", horizontal_move == -1);
        anim.SetBool("MovingRight", horizontal_move == 1);
    }

    // Update is called once per frame
    void Update()
    {
        InputHandle();
        AnimHandle();
    }

    private void FixedUpdate() {
        rb2D.velocity = new Vector2(horizontal_move, 0f) * player_speed;
    }

}
