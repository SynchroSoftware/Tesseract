using UnityEngine;
//using System.Collections;

public class PointData
{
	public string Name {get; set;} 
	public float X   {get; set;}
	public float Y   {get; set;}
	public float Z   {get; set;}
	public float R   {get; set;}
	public float G   {get; set;}
	public float B   {get; set;}
	public float A   {get; set;} // Alpha
	public float Rad {get; set;} // Radius
	public float Ts  {get; set;} // Time Start
	public float Te  {get; set;} // Time End
	public Dictionary<string,string> m_mOther = new Dictionary<string,string>(); // other data key value pairs associated with the PointData

	public PointData(string strName, float nX,float nY,float nZ,float nR,float nG,float nB,float nA,float nRad,float nTs = Float.min ,float nTe = Float.max, Dictionary mOtherData = null)
	{
		// When creating a new PointData each numerical
		// dimension should have a normalized value between 0f and 1f
		X =  nX;
		Y =  nY;
		Z =  nZ;
		R =  nR;
		G =  nG;
		B =  nB;
		A =  nA;
		Rad =  nRad;
		Ts =  nTs;
		Te =  nTe;
		Name = strName;
		m_mOther = mOtherData;
	}
}
