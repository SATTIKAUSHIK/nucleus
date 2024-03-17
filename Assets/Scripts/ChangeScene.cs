using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void introScene()
    {
        SceneManager.LoadScene("Intro");

    }

    public void endScene()
    {
        SceneManager.LoadScene("End");
    }
}
