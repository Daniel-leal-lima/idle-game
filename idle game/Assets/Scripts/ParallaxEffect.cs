using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cameraPlayer;
    private float lengh, startPos;
    public float speedParallax;
    void Start()
    {
        startPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //Movimenta sprites pra esquerda

        transform.Translate(Vector3.left * Time.deltaTime * speedParallax);
    }

    public void ResetPosition()
    {
        transform.position = new Vector3(startPos, transform.position.y, transform.position.z);
    }
}
