using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HandleScore : MonoBehaviour
{
    public Text scoreText;
    public Score totalPickups;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      scoreText.text = "Collect: "+ totalPickups.toCollect;
    }
}
