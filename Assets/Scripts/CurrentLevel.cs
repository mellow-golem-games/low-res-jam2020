using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentLevel : MonoBehaviour
{

   public int currentLevel;

    public void nextLevel() {
      currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
      PlayerPrefs.SetInt("CurrentLevel", currentLevel++);
      SceneManager.LoadScene("Level1");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
