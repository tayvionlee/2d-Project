using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;


    void Start()
    {
        startpos = transform.position.x; // setting the start position to whatever x is
        length = GetComponent<SpriteRenderer>().bounds.size.x; // get length of sprite
    }


    void Update()
    {
        // how far you fomve relative to the camera
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
       
    }
}
