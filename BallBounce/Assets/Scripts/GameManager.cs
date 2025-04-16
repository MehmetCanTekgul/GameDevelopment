using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    int score;

    public Text scoreText;
    public GameObject gameStartUI;
    
    private void Awake(){
        
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void GameStart(){
        gameStartUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");


    }
    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
