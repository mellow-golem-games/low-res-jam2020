using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class HandleTinderPickup : MonoBehaviour
{

    private UnityEngine.Experimental.Rendering.Universal.Light2D PlayerLight;
    // Start is called before the first frame update
    void Start()
    {
      PlayerLight = GameObject.FindWithTag("PlayerLight").GetComponent<Light2D>();
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
