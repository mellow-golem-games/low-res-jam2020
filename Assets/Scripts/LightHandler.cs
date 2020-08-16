using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;

public class LightHandler : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D PlayerLight;

    // Update is called once per frame
    void Update()
    {
      PlayerLight.pointLightOuterRadius = PlayerLight.pointLightOuterRadius - 0.001f;


      if (PlayerLight.pointLightOuterRadius <= 0) {
        SceneManager.LoadScene("GameOver");
      }
    }
}
