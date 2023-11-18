using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public ListController Left, Middle, Right;
    public GameObject CompletePanel;

    public void CheckEndGame()
    {
        if(Left.isDone && Middle.isDone && Right.isDone)
        {
            CompletePanel.SetActive(true);
        }
    }

    public void OnClickYesButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnClickNoButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
