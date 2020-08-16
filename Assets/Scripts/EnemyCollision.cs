using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D collider) {
    if(collider.gameObject.name == "Player") {
      SceneManager.LoadScene("GameOver");
    }
  }
}
