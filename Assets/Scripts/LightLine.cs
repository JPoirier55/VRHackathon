using UnityEngine;
using System.Collections;

public class LightLine : MonoBehaviour {
    public GameObject sphere1;
   
	// Use this for initialization
	void Start () {
        Debug.Log("World running script");
        sphere1 = GameObject.Find("Sphere");

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(sphere1.GetComponent<Renderer>().material.color);
        //Debug.Log(Color.blue);
        if(sphere1.GetComponent<Renderer>().material.color == Color.blue)
        {
            Debug.Log("Blue");
            gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            gameObject.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.red);
        }
        else if (sphere1.GetComponent<Renderer>().material.color == Color.red)
        {
            Debug.Log("Red");
            gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            gameObject.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.blue);
        }
    }
}
