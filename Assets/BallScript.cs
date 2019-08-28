using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float Force;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Random.insideUnitCircle * Force);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision coll)
    {
        //GetComponent<Rigidbody>().AddForce(new Vector3(-50, 0, 0));
        Debug.Log("Hit!");
        if (coll.gameObject.name == "RightPaddle")
        {
            rb.AddForce(new Vector3(-1f, transform.position.y - coll.transform.position.y, 0)*Force);
        }
        if (coll.gameObject.name == "LeftPaddle")
        {
            rb.AddForce(new Vector3(1f, transform.position.y - coll.transform.position.y, 0) * Force);
        }
        if (coll.gameObject.name == "ScoreLeft")
        {
            GameManager.PlayerLeftScore++;
            Reset();
        }
        if (coll.gameObject.name == "ScoreRight")
        {
            Reset();
        }
    }

    void Reset()
    {
        this.transform.position = Vector3.zero;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
