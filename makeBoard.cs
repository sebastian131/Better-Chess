using UnityEngine;
using System.Collections; 
public class makeBoard : MonoBehaviour {
	private static GameObject[,]tiles = new GameObject[11, 11];
public GameObject redCube;
public GameObject greyCube;
	// Use this for initialization
	void Start () {
		Debug.Log (tiles [1, 1]);
		for (int i = 0; i < 121; i++) 
		{
			CreateCube(i/11, 0, i%11, i);
			
		}
	}
	void CreateCube(int _posX, int _posY, int _posZ, int _CColor)
	{
		if (_CColor % 2 == 0) {
			GameObject.Instantiate (redCube, new Vector3 (_posX, _posY, _posZ), Quaternion.identity);
		} 
		else {
			GameObject.Instantiate (greyCube, new Vector3 (_posX, _posY, _posZ), Quaternion.identity);
		}
		
	} 
	GameObject getTile (int x, int y)
	{
		return tiles[x,y]; 	
	}
	void setTile (int x, int y, GameObject piece)
	{
		tiles [x, y] = piece;
	}
}
