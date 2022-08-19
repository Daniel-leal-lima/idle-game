using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject teste;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera cam = Camera.main;
        float height = 1f * cam.orthographicSize;
        float width = height * cam.aspect;

        if (teste.transform.position.x < width - (teste.GetComponent<SpriteRenderer>().bounds.size.x /2))
        {
            teste.GetComponentInParent<ParallaxEffect>().ResetPosition();
        }

    }
}
