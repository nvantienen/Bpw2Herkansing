using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class exit : MonoBehaviour
{
    public GameObject player;
    public GameObject orb;
    public float ballHeight;
    Quaternion geenRotatie = new Quaternion(0, 0, 0, 0);
    

    private void Start()
    {

       
        if(sceneData.hasorb == true)
        {
            GameObject orbClone = Object.Instantiate(orb, player.transform.position + new Vector3(0, ballHeight ,0 ), geenRotatie );
            orbClone.transform.SetParent(player.transform);
            orbClone.GetComponent<ParticleSystem>().Stop();


        }
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("level1");
    }
}
