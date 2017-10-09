using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {


    public GameObject initialPart;

    Transform _transform;

    public Transform arrow;



	// Use this for initialization
	void Start () {

        _transform = GetComponent<Transform>();

        _transform.position = initialPart.GetComponent<Transform>().position;

        arrow.position += new Vector3(0, arrow.localScale.y/2, 0);

        
        



	}
	
	// Update is called once per frame
	void Update () {
		
        //_transform.position = 



	}
}
