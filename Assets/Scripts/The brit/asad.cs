using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asad : MonoBehaviour
{
    Vector3 Goal;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Goal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Goal, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            ActionDecider(1, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ActionDecider(-1, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ActionDecider(0, -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ActionDecider(0, 1);
        }
    }
    void ActionDecider(int y, int x)
    {
        if(transform.position == Goal)
            Goal += new Vector3(x, y, 0);
    }
}
