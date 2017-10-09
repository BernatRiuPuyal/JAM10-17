using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subparticle : MonoBehaviour {


    [HideInInspector]
    public Vector2 velocity = Vector2.zero;

    public int initialAng = 90;


    CircleCollider2D trigger;

    public particle _particle;
    
    bool canDie = false;

    public bool firstball  = false;

    // Use this for initialization
    void Start()
    {

        trigger = GetComponent<CircleCollider2D>();

        canDie = firstball;

        if (firstball)
        {
            float velMag = _particle.velocityMag;
            velocity = new Vector3(velMag * Mathf.Cos(initialAng * Mathf.Deg2Rad), velMag * Mathf.Sin(initialAng * Mathf.Deg2Rad));
        }

}

    // Update is called once per frame
    void Update()
    {


        //movement

        gameObject.transform.position += new Vector3(velocity.x, velocity.y, 0) * Time.deltaTime;


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (canDie)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!(trigger.IsTouchingLayers(0)))
        { canDie = true;
            print("potMorir"); }
    }
}
