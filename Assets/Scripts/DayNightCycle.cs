using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class DayNightCycle : MonoBehaviour
{
    public GameObject sun;
    public GameObject moon;

    public Light2D GlobalLight;

    public Color color;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotation = sun.transform.rotation.z;
        var lerpedColor = Color.Lerp(Color.white, color, Mathf.PingPong(rotation, 1));
        GlobalLight.color = lerpedColor;
    }
}
