using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownRight : MonoBehaviour
{
    public bool moveRigth;

    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (moveRigth)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;
        }
    }
}
