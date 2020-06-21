using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballPickup : MonoBehaviour
{

    public GameObject player;
    public float ballHeight;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.transform.position = player.transform.position + new Vector3(0, ballHeight, 0);
        transform.SetParent(player.transform);
        sceneData.hasorb = true;
    }
}
