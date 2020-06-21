using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class orbDelivery : MonoBehaviour
{
    [HideInInspector]
    public bool isClicked = false;
    private float distance;
    private Transform player;
    public float goodDistance;
    GameObject orbClone;



    void Start()
    {
       orbClone = GameObject.Find("Tree_orb(Clone)");
       player = GameObject.Find("Player").GetComponent<Transform>();
    }


    void Update()
    {
        distance = Vector3.Distance(gameObject.GetComponent<Transform>().position, player.position);


        if (Input.GetKeyDown(KeyCode.E) && distance < goodDistance && sceneData.hasorb )
        {
            Destroy(orbClone);
            SceneManager.LoadScene("Ending");

        }
    }
}
