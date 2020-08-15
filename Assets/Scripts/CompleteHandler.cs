using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteHandler : MonoBehaviour
{

  private int currentLevel;


  public void nextLevel() {
    currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
    currentLevel++;
    PlayerPrefs.SetInt("CurrentLevel", currentLevel);

    Debug.Log(currentLevel);
    SceneManager.LoadScene("Level1");
  }

  public void StartGame()
  {
    SceneManager.LoadScene("Level1");
  }
}
