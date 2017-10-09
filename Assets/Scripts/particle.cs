using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class particle : MonoBehaviour {


    public List<int> subparticles;

    public GameObject subparticlePrefab;

    public float velocityMag;

    bool exploded = false;

    static int particleCount = 0;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {


        particleCount++;




        }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!exploded)
        {
            for (int i = 0; i < subparticles.Count; i++)

            {
                Vector2 InstVel = new Vector2(Mathf.Cos(subparticles[i] * Mathf.Deg2Rad), Mathf.Sin(subparticles[i] * Mathf.Deg2Rad));

                GameObject fill = Instantiate(subparticlePrefab, GetComponent<Transform>().position/* + (new Vector3(InstVel.x,InstVel.y,0)*radi*2)*/, GetComponent<Transform>().rotation);






                InstVel *= velocityMag;

                fill.GetComponent<subparticle>().velocity = InstVel;

            }

            Destroy(gameObject.GetComponent<MeshRenderer>());
            exploded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!(gameObject.GetComponent<CircleCollider2D>().IsTouchingLayers(0)))
        {
            Destroy(gameObject);
            print("i die");
        }
    }
}
