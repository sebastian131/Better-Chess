using UnityEngine;
using System.Collections;

public class pawn : MonoBehaviour {
	public GameObject WhitePawn;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void CreateSphere (float _posX, float _posY, float _posZ)
	{
		GameObject.Instantiate (WhitePawn, new Vector3 (_posX, _posY, _posZ), Quaternion.identity);
	}
}
