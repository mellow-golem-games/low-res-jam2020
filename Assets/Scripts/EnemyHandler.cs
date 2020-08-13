using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{

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

    private void OnTriggerEnter2D(Collider2D collider) {
      Debug.Log("Handle enemy collision");
    }
}
