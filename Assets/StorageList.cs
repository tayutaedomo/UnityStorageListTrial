using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StorageList : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string path = "/Users";

#if UNITY_ANDROID && !UNITY_EDITOR
		path = "/storage";
#endif

		string[] fs = System.IO.Directory.GetDirectories (path);

		foreach (string s in fs) {
			Debug.Log ("StorageList: " + s);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
