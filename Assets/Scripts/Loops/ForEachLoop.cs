using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour
{
	public List<GameObject> objects; // Objects to be disabled on Start
	public bool doThing = true;
	
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in objects)
		{
			obj.SetActive(false);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
