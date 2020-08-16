using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CompelteText : MonoBehaviour
{
    public Text endText;
    private int currentLevel;
    // Start is called before the first frame update
    void Awake()
    {
      currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
      Debug.Log(currentLevel);
      if (currentLevel == 3) {
        endText.text = "Game Complete Click To Play Again!";
      }
    }


}
