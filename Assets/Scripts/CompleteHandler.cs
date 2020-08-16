using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteHandler : MonoBehaviour
{

  private int currentLevel;
  private string nextLevelString;


  public void nextLevel() {
    currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
    Debug.Log(currentLevel);
    if (currentLevel != 3) {

      currentLevel++;
      PlayerPrefs.SetInt("CurrentLevel", currentLevel);

      nextLevelString = "Level" + currentLevel;
      SceneManager.LoadScene(nextLevelString);
    } else {
      PlayerPrefs.SetInt("CurrentLevel", 1);
      SceneManager.LoadScene("Level1");
    }
  }

  public void StartGame()
  {
    SceneManager.LoadScene("Level1");
  }
}
