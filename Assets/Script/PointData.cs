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
	public List<string> m_astAllData = null; // other data key value pairs associated with the PointData

	bool VerifyInRange(float nVal)
	{
		return ((0f < nVal)&&(1f > nVal));
	}

	public PointData(string strName, List<float> anDimensions, List<string> astAllData)
	{
		// When creating a new PointData each numerical
		// dimension should have a normalized value between 0f and 1f
		
		Name = strName;
		// Validate each  anDimensions member to ensure it is normalized
		foreach (float nCoordinate in anDimensions)
		{
			bool bInRange = VerifyInRange(nCoordinate);
			///
		
		}
		// Set each dimension member from anDimensions or default it.
		int nIndex = 0;
		foreach (float nCoordinate in anDimensions)
		{
			switch (nIndex)
			{
				

			}

			++nIndex;
		}
		
		m_astAllData = astAllData;
	}
}
