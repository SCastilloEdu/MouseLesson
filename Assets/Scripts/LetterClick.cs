using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterClick : MonoBehaviour
{
	private SpriteRenderer sr;
	private Sprite s;
	
	public List<Sprite> letter;
	public GameObject obj;
	public int current = 0;
	
    // Start is called before the first frame update
    void Start()
    {
		sr = obj.GetComponent<SpriteRenderer>();
    }
	
	private void OnMouse()
	{
		
	}
	
	private void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0)) // On left click cycle sprites forward
		{
			current++;
			sr.sprite = letter[current%letter.Count];
		}
		if (Input.GetMouseButtonDown(1)) // On left click cycle sprites backward
		{
			if (current<=0){current=letter.Count;}
			current--;
			sr.sprite = letter[current%letter.Count];
		}
	}
	
	private void OnMouseUp()
	{
		
	}
}
