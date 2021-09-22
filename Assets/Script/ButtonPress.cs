using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Main");

        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnButtonBack()
    {
        SceneManager.LoadScene("Start");

        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnButtonNext()
    {
        SceneManager.LoadScene("End");

        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnButtonEnd()
    {
        SceneManager.LoadScene("Main");

        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }
}
