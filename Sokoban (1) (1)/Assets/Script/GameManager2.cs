using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    
    public GameObject NextPage2;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Scenes/MainScene2");
            //SceneManager.LoadScene(0);
        }

        if (isGameOver == true)
        {

            return;
        }

        int count = 0;

        for (int i = 0; i < 5; i++)
        {
            if (itemBoxes[i].isOveraped == true)
            {
                count++;
            }
        }

        if (count >= 5)
        {
            isGameOver = true;
            NextPage2.SetActive(true);
        }


    }


}