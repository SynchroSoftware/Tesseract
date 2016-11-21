using UnityEngine;
//using System.Collections;

public class PointUI : MonoBehaviour 
{

    public PointData pointData = null;

	GameObject point;

	// Use this for initialization
	void Start () 
	{
		if (null==pointData)
		{
			point = AddPoint  
			(
				pointData.Name, 
				new Vector3(pointData.X,pointData.Y,pointData.Z)
				pointData.Rad,
				new Color (pointData.R,pointData.G,pointData.B,pointData.A)
			);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	static public GameObject AddPoint (string strName, Vector3 anPos, float nRadius, Color color)
	{
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
}



