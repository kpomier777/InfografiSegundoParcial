using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esqueleto : MonoBehaviour
{
    // Start is called before the first frame update
   public float moveSpeed;
    private Rigidbody2D myrigidbody;
    public bool iswalking;
    public float walkTime;
    private float walkCounter;
public float waitTime;
private float waitCounter;
    private int walkDirection;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        waitCounter = waitTime;
        walkCounter = walkTime;

    }

    // Update is called once per frame
    void Update()
    {
    if (iswalking){
        walkCounter-= Time.deltaTime;
        
        switch (walkDirection)
        {
            case 0:
            myrigidbody.velocity=new Vector2(0,moveSpeed);
                break;
            case 1:
            myrigidbody.velocity=new Vector2(moveSpeed,0);
                break;
            case 2:
            myrigidbody.velocity=new Vector2(0,-moveSpeed);
                break;
            case 3:
            myrigidbody.velocity=new Vector2(-moveSpeed,0);
                break;
        }
        if(walkCounter<0){
            iswalking=false;
            waitCounter=waitTime;
        }
        
    }else{
        waitCounter-=Time.deltaTime;
        myrigidbody.velocity=Vector2.zero;
        if (waitCounter<0){
            ChooseDirection();

        }
    }

    }
    void ChooseDirection()
    {
        walkDirection=Random.Range(0,4);
        iswalking=true;
        walkCounter=walkTime;
        
    }

   
}
