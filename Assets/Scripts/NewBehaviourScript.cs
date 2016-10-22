using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    Color c;
    GameObject sphere1;
    GameObject sphere2;
    GameObject sphere3;
    // Use this for initialization
    void Start () {

        Debug.Log("Im alive");
        InvokeRepeating("Change", 0.0f, 1.0f);
        c = Color.red;
        sphere1 = GameObject.Find("Sphere1");
        sphere2 = GameObject.Find("Sphere2");
        sphere3 = GameObject.Find("Sphere3");
        Debug.Log(sphere1.name);
        Debug.Log(sphere2.name);
        Debug.Log(sphere3.name);

    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void Change()
    {
        //Debug.Log(gameObject.tag);
        
        if(c == Color.red)
        {
            sphere1.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere2.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere3.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere1.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.red);
            sphere2.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.yellow);
            sphere3.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.green);
            gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            gameObject.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.blue);
            c = Color.blue;

        }
        else if(c == Color.blue)
        {
            sphere1.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere2.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere3.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere1.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.blue);
            sphere2.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.green);
            sphere3.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.red);
            gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            gameObject.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.yellow);
            c = Color.yellow;
        }
        else if (c == Color.yellow)
        {
            sphere1.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere2.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere3.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere1.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.yellow);
            sphere2.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.red);
            sphere3.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.blue);
            gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            gameObject.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.green);
            c = Color.green;
        }
        else if (c == Color.green)
        {
            sphere1.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere2.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere3.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            sphere1.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.green);
            sphere2.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.blue);
            sphere3.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.yellow);
            gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Specular");
            gameObject.GetComponent<Renderer>().material.SetColor("_SpecColor", Color.red);
            c = Color.red;
        }
    }
}
