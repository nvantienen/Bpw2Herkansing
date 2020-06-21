using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    public float movePlayerDown;

    Vector2 movement;

    private void Start()

    {
        if (SceneManager.GetActiveScene().name == "level1")
        {
            GameObject enterTree = GameObject.Find("enterTree");
            if(sceneData.wasinTree == true)
        {
                gameObject.transform.position = enterTree.transform.position + new Vector3(0, movePlayerDown, 0);
            }
        }
            


    }


    // Update is called once per frame
    void Update()
    {
        movement.x =Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement *moveSpeed * Time.fixedDeltaTime);
    }
}
