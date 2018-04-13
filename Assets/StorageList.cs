using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;

public class StorageList : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string path = "/Users";

#if UNITY_ANDROID && !UNITY_EDITOR
		path = "/storage";
#endif

		string[] fs = System.IO.Directory.GetDirectories (path);

		foreach (string s in fs) {
			Debug.Log ("StorageList: " + s + " " + is_matched(s));
		}

		Debug.Log ("StorageList: null " + is_matched(null));
		Debug.Log ("StorageList: /storage/3965-6433 " + is_matched("/storage/3965-6433"));
	}

	bool is_matched(string path) {
		if (path == null) {
			return false;
		}

		return Regex.IsMatch (path, @"^/storage/[0-9]+-[0-9]+");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
