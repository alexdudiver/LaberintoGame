using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{    //variables
    public GameObject GameOverPanel, StarGamePanel;
    public Movimiento player;

    // Start is called before the first frame update
    void Start()
    {
        StarGamePanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void GameOverMenu()

    {
        GameOverPanel.SetActive(true);
        player.speed = 0f;
        player.RestartPlayerPosition();
    }

    public void StartThegame()
    {
        StarGamePanel.SetActive(false);
        player.speed = 9.0f;
    }
    public void QuitThegame()
    {
        Application.Quit();
    }
    
        
}    
    
        
    


