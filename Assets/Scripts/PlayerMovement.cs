using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    private int currentLevel;

    Vector2 movement;

    // Update is called once per frame
    void Awake() {
      currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);

      if (currentLevel == 0) {
        PlayerPrefs.SetInt("CurrentLevel", 1);
      }
    }

    void Update()
    {
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
