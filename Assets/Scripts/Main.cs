using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Androidtion is to be called");


        var ajc = new AndroidJavaClass("com.narith.androidlib.Helper"); //(1)
        ajc.CallStatic("DoSthInAndroid");                                       //(2)
        Debug.Log("Androidtion is called");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
