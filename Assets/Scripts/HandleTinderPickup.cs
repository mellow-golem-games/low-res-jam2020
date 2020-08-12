using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTinderPickup : MonoBehaviour
{

    public UnityEngine.Experimental.Rendering.Universal.Light2D PlayerLight;
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("stick good");
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collider) {

      if(collider.gameObject.name == "Player") {
        PlayerLight.pointLightOuterRadius = PlayerLight.pointLightOuterRadius += 0.5f;
        Destroy(gameObject);
      }
    }
}
