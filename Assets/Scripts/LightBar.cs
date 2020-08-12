using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightBar : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D PlayerLight;
    public Slider slider;

    private float startLightVal;
    private float currentLightVal;


    void Start()
    {
        startLightVal = PlayerLight.pointLightOuterRadius;
    }

    // Update is called once per frame
    void Update()
    {
        currentLightVal = PlayerLight.pointLightOuterRadius;
        float lightRatio = currentLightVal / startLightVal;
        slider.value = lightRatio;
    }
}
