using UnityEngine;
//using System.Collections;

public class PointUI : MonoBehaviour 
{

    public Point\Data PointInfo {set; set;}

	GameObject PointGameObject;

	// Use this for initialization
	void Start () 
	{
		if (null==PointInfo)
		{
			PointInfo = AddPointGameObject  
			(
				PointInfo.Name, 
				new Vector3(PointInfo.X,PointInfo.Y,PointInfo.Z)
				PointInfo.Rad,
				new Color (PointInfo.R,PointInfo.G,PointInfo.B,PointInfo.A)
			);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	static public GameObject AddPointGameObject (string strName, Vector3 anPos, float nRadius, Color color)
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



