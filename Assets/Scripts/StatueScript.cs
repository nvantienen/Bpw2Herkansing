using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueScript : MonoBehaviour
{
    [HideInInspector]
    public bool isClicked = false;
    private float distance;
    private Transform player;
    public float goodDistance;



    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

   
    void Update()
    {
        distance = Vector3.Distance(gameObject.GetComponent<Transform>().position, player.position);
       

        if (Input.GetButtonDown("StatueClick") && distance < goodDistance)
        {
            isClicked = true;
            print(isClicked);
            FindObjectOfType<AudioManager>().Play("StatueClick");

        }
    }
}
