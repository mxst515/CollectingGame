using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour {
    [SerializeField] int player_score;
    [SerializeField] Text score_text;
    [SerializeField] PlayerScript player;

    [SerializeField] GameObject live1;
    [SerializeField] GameObject live2;
    [SerializeField] GameObject live3;
    [SerializeField] GameObject live4;
    [SerializeField] GameObject live5;

    [SerializeField] private float lives;
    private int max_lives;
    private int min_lives;
    private float max_player_speed;

    private void Start() {
        lives = 5;
        max_lives = 5;
        min_lives = 0;
        max_player_speed = 25;
    }

    public void addScore() {
        player_score += 1;
        score_text.text = player_score.ToString();
    }

    public void minusLives() {
        if(lives > min_lives){
            lives -= 1f;
        }
    }

    public void addLives() {
        if(lives < max_lives) {
            lives += 1f;
        }
    }

    private void setLivesVisible() {
        if(lives == 5) {
            live1.SetActive(true);
            live2.SetActive(true);
            live3.SetActive(true);
            live4.SetActive(true);
            live5.SetActive(true);
        }
        else if(lives == 4) {
            live1.SetActive(true);
            live2.SetActive(true);
            live3.SetActive(true);
            live4.SetActive(true);
            live5.SetActive(false);
        }
        else if(lives == 3) {
            live1.SetActive(true);
            live2.SetActive(true);
            live3.SetActive(true);
            live4.SetActive(false);
            live5.SetActive(false);
        }
        else if(lives == 2) {
            live1.SetActive(true);
            live2.SetActive(true);
            live3.SetActive(false);
            live4.SetActive(false);
            live5.SetActive(false);
        }
        else if(lives == 1) {
            live1.SetActive(true);
            live2.SetActive(false);
            live3.SetActive(false);
            live4.SetActive(false);
            live5.SetActive(false);
        }
    }

    public void addSpeed(){
        if(player.player_speed < max_player_speed){
            player.player_speed += 1f;
        }
    }

    public void gameOver(int sceneID) {
        SceneManager.LoadScene(sceneID);
    }

    private void Update() {
        setLivesVisible();
        if (lives<=0){
            gameOver(0);
        } 
    }


}
