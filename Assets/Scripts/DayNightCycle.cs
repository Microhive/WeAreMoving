using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class DayNightCycle : MonoBehaviour
{
    public GameObject sun;
    public GameObject moon;

    public Light2D GlobalLight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotation = sun.transform.rotation.z;

        var lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(rotation, 1));

        // if (rotation < 180 && rotation > 90) {
        //     light.color = new Color(1f, 0f, 0f, 1f);
        // }
        // else 
        // {
        //     light.color = new Color(1f, 1f, 1f, 1f);
        // }
        // }
        // // when sun moves from 180-90 it is reddish
        // light.color = new Color(1f, 0f, 0f, 1f);

        // // when sun moves from 90-0 it is white
        // light.color = new Color(1f, 1f, 1f, 1f);

        // // when sun moves from 360-270 it is reddish
        // light.color = new Color(1f, 0f, 0f, 1f);

        // // when sun moves from 270-180 it is blue
        // light.color = new Color(0f, 0f, 1f, 1f);

        GlobalLight.color = lerpedColor;
    }
}
