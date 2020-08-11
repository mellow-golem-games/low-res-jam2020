using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightHandler : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D PlayerLight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      // Debug.Log(PlayerLight.pointLightOuterRadius);
      PlayerLight.pointLightOuterRadius = PlayerLight.pointLightOuterRadius - 0.001f;
    }
}
