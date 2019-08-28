using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rightPaddle;
    public GameObject leftPaddle;

    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation_r = Input.GetAxis("Right") * speed * Time.deltaTime;
        float translation_l = Input.GetAxis("Left") * speed * Time.deltaTime;

        rightPaddle.transform.position = rightPaddle.transform.position + new Vector3(0, translation_r, 0);
        leftPaddle.transform.position = leftPaddle.transform.position + new Vector3(0, translation_l, 0);

    }
}
