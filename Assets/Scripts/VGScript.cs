using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VGScript : MonoBehaviour {

    [Range(0f, 5f)]
    [SerializeField]
    float walkSpeed = 3.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * Time.deltaTime * walkSpeed);
    }
}
