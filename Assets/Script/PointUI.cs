using UnityEngine;
//using System.Collections;

public class PointUI : MonoBehaviour 
{

    PointData pointData = null; 

	//variable for test
	public GameObject point1;
	public GameObject point2;
	public GameObject edge;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Q))
		{
			GetPointsDir(point1.transform.position,point2.transform.position);
		}
	
	}

	Vector3 GetPointsDir(Vector3 pt1, Vector3 pt2)
	{
		Vector3.Normalize(pt2 - pt1);
		return Vector3.Normalize(pt2 - pt1);
	}



}



