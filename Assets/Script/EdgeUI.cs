using UnityEngine;
using System.Collections;

public class EdgeUI : MonoBehaviour 
{
    PointUI pointUi1 = null;
    PointUI pointUi2 = null;
	public GameObject edge;

	// Use this for initialization
	void Start () 
	{
			
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp(KeyCode.Q))
		{
			Vector3 anEdgeDir = GetEdgeDir(point1.transform.position,point2.transform.position);
		}
	}
	Vector3 GetEdgeDir(Vector3 pt1, Vector3 pt2)
	{
		Vector3.Normalize(pt2 - pt1);
		return Vector3.Normalize(pt2 - pt1);
	}

	/*
	static public GameObject AddEdge (string strName, Vector3 anPos, float nRadius, Color color)
	{
		//Qa.Trace(">AddSphere("+strName+", "+anPos+", "+nRadius+", "+color+")");
		GameObject rgo = Project.GetRootGameObject ();
		GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Cylinder); 
		sphere.transform.parent = rgo.transform;
		sphere.name = strName;
		sphere.transform.position = anPos;
		float nS = 3 * nRadius;
		sphere.transform.localScale = new Vector3 (nS, nS, nS);
		MeshRenderer meshRenderer = sphere.GetComponent<MeshRenderer> ();
		meshRenderer.material.color = color;
		sphere.SetActive (true);
		return sphere;
	}
	*/
}