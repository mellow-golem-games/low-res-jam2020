using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public float moveSpeed = 2f;

    private Transform targetTransform;

    // Start is called before the first frame update
    void Start()
    {
      targetTransform = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate() {
      float step = moveSpeed * Time.deltaTime;
      Vector2 position = gameObject.transform.position;
      Vector2 targetPos = targetTransform.position;

      // move sprite towards the target location
      gameObject.transform.position = Vector2.MoveTowards(transform.position, targetPos, step);
    }

    private void OnTriggerEnter2D(Collider2D collider) {
      if (collider.gameObject.name == "Player") {
        Debug.Log("Handle enemy collision");
      }
    }
}
