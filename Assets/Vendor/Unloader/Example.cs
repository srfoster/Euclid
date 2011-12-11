using UnityEngine;
using System.Collections;
using System.Threading;

public class Example : MonoBehaviour {
	
	Unloader unloader;
	
	// Use this for initialization
	void Start () {
		unloader = GetComponent("Unloader") as Unloader;
		(new Thread(load)).Start();
	}
	
	void load()
	{
		Thread.Sleep(5000);
		unloader.Loaded();	
	}
	

}
