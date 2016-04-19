using UnityEngine;
using System.Collections;

public class LogMessages : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World!");
        Debug.Log("Hello World 2");
        Debug.LogWarning("Hello Warn");
        Debug.LogError("Hello Error");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
