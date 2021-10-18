using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Renderer fondo;
    public bool gameOver,state = false;
    public GameObject menuGameOver, menuPuase, menuNextLevel;
    // Start is called before the first frame update
    void Start()
    {
        menuNextLevel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        fondo.material.mainTextureOffset += new Vector2(0.1f,0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.P))
        {
            state = state ? false : true;
        }

        if(Helio.helio <=0)
        {
            Helio.helio = 0;         
        }
        else if (Helio.helio >= 500)
        {
            gameOver = true;
        }

        if (gameOver)
        {
            if (Helio.helio >= 500)
            {
                menuNextLevel.SetActive(true);
            }
            else
            {
                menuGameOver.SetActive(true);
            }
            
            pause();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Helio.helio = 15;
                resume();
            }
        }
        else
        {
            menuGameOver.SetActive(false);
        }

     

        if (state)
        {
            pause();
        }
        else 
        {
            if(gameOver == false)
            {
                resume();
            }
            
        }
    }

    public void pause()
    {
        
        Time.timeScale = 0;
        if(gameOver == false)
        {
            menuPuase.SetActive(true);
        }
        
    }
    public void resume()
    {
        Time.timeScale = 1;
        if (gameOver == false)
        {
            menuPuase.SetActive(false);
        }
    }

}
