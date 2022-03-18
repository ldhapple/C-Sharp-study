using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMgr : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartBtn()
    {
        Debug.Log("click Button");
        SceneManager.LoadScene("MainScene");
    }

    public void OnClickNextBtn1()
    {
        Debug.Log("click Button");
        SceneManager.LoadScene("MainScene2");
    }
    public void OnClickNextBtn2()
    {
        Debug.Log("click Button");
        SceneManager.LoadScene("MainScene3");
    }
    public void OnClickFinshBtn()
    {
        Debug.Log("click Button");
        SceneManager.LoadScene("MenuScene");
    }
    public void OnClickExitBtn()
    {
        Debug.Log("click Button");
        Application.Quit();
    }
}
