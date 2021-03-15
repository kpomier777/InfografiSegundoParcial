using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class personaje : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
   // Vector2 spawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);


    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag=="bomba" || collider.gameObject.tag=="esqueleto" ){
           SceneManager.LoadScene("Level1");
        }

        if(collider.gameObject.tag=="puerta"){
           SceneManager.LoadScene("Level2");
        }
        if(collider.gameObject.tag=="Finish"){
           SceneManager.LoadScene("Level3");
        }
    }


}
