using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBehaviour : MonoBehaviour
{
    public GameObject player;
    public int speed;
    private bool isChasing;
    //PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        //isChasing = false;
        if (player)
        { 
            if (isChasing == false)
            {
                if (player.transform.position.x > transform.position.x)
                {
                    Vector3 myVec = new Vector3(1, 0, 0);
                    transform.position += myVec * speed * Time.deltaTime;
                }
                if (player.transform.position.z > transform.position.z)
                {
                    Vector3 myVec = new Vector3(0, 0, 1);
                    transform.position += myVec * speed * Time.deltaTime;
                }
                if (player.transform.position.x < transform.position.x)
                {
                    Vector3 myVec = new Vector3(-1, 0, 0);
                    transform.position += myVec * speed * Time.deltaTime;
                }
                if (player.transform.position.z < transform.position.z)
                {
                    Vector3 myVec = new Vector3(0, 0, -1);
                    transform.position += myVec * speed * Time.deltaTime;
                }
            }
            if (isChasing == true)
            {
                if (player.transform.position.x > transform.position.x)
                {
                    Vector3 myVec = new Vector3(-1, 0, 0);
                    transform.position += myVec * speed * Time.deltaTime;
                }
                if (player.transform.position.z > transform.position.z)
                {
                    Vector3 myVec = new Vector3(0, 0, -1);
                    transform.position += myVec * speed * Time.deltaTime;
                }
                if (player.transform.position.x < transform.position.x)
                {
                    Vector3 myVec = new Vector3(+1, 0, 0);
                    transform.position += myVec * speed * Time.deltaTime;
                }
                if (player.transform.position.z < transform.position.z)
                {
                    Vector3 myVec = new Vector3(0, 0, +1);
                    transform.position += myVec * speed * Time.deltaTime;
                }
            }
        }
        Debug.Log(isChasing);
    }
}
