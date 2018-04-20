using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    string str = string.Empty;

#if UNITY_ANDROID
        AndroidJavaClass ajc = new AndroidJavaClass("SDK");
        str = ajc.Call<string>("method");  
#elif UNITY_IOS
        
#endif


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
