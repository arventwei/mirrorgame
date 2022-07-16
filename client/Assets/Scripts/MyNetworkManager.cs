using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{
	// Start is called before the first frame update
	public override void OnStartServer()
	{
		Debug.Log("OnStartServer");
		//base.OnStartServer();
	}
	public override void OnStopServer()
	{
		//base.OnStopServer();
		Debug.Log("OnStartServer");
	}

	public override void OnClientConnect()
	{
		Debug.Log("OnClientConnect");
		//base.OnClientConnect();
	}
	public override void OnClientDisconnect()
	{
		Debug.Log("OnClientConnect");
		//base.OnClientDisconnect();
	}
}
