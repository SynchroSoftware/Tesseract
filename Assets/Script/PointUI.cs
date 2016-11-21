using UnityEngine;
//using System.Collections;

public class PointUI : MonoBehaviour 
{

    PointData pointData = null; 

	//variable for test
	public GameObject point;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}

/*
	static public GameObject AddPoint (string strName, Vector3 anPos, float nRadius, Color color)
	{
		//Qa.Trace(">AddSphere("+strName+", "+anPos+", "+nRadius+", "+color+")");
		GameObject rgo = Project.GetRootGameObject ();
		GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere); 
		sphere.transform.parent = rgo.transform;
		sphere.name = strName;
		sphere.transform.position = anPos;
		sphere.transform.localScale = new Vector3 (nRadius, nRadius, nRadius);
		MeshRenderer meshRenderer = sphere.GetComponent<MeshRenderer> ();
		meshRenderer.material.color = color;
		sphere.SetActive (true);
		return sphere;
		}
	*/
}



