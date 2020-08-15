using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public Score score;
    public int total = 8;

    void Awake() {
      score.toCollect = total; // each level has it's own number;
    }


    private void OnTriggerEnter2D(Collider2D collider) {
      if(collider.gameObject.name == "Player") {
        if (score.toCollect == 0 ) {
          SceneManager.LoadScene("Complete");
        }
      }
    }
}
