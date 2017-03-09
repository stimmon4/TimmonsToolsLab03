using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredLine : MonoBehaviour {
    public string beginColor = "The line before the colored line";
    [ColorLine(10, 320, 255, 0, 0)]
    public string endColor = "The line after the colored line";
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
