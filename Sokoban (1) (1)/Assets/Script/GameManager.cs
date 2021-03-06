using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject WinUI;
    public GameObject NextPage;
    public ItemBox[] itemBoxes;

    public bool isGameOver;

    
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene("Scenes/MainScene");
            SceneManager.LoadScene(1);
        }

        if(isGameOver == true)
        {
      
            return;
        }

        int count = 0;

        for(int i = 0; i < 3; i++)
        {
            if(itemBoxes[i].isOveraped == true)
            {
                count++;
            }
        }

        if(count >= 3)
        {
            isGameOver = true;
            WinUI.SetActive(true);
            NextPage.SetActive(true);
        }
       
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
 

}
