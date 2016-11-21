public class Project
{
    public List <List <string>> aastrRawData = null; // raw data from a spread sheet
    public Dictionary <int, int> m_mRawIndexToDimensionIndex = Dictionary <int, int> (); // a map of column indices to PointData dimension indices
    public Dictionary <string, PointData> m_mNormalizedValues = null; // A normalized point data object for each row of raw data

    public Project()
    {

    }

    GameObject GetRootGameObject ()
    {
        return null;   //todo get from the scene.
    }

    // under development
    void Normalize()
    {
        // go through all of the raw values that are associated with a numerical dimension
        // find the high and low value for each dimension
        if (null= aastrRawData)
        {
            foreach (List <string> record in aastrRawData
            )
            {
                int nKeyIndex = 0;
                foreach (int nIndex in m_mRawIndexToDimensionIndex.Keys)
                {
                    try
                    {
                        // store the min and max values for each dimension 
                    }
                    catch (System.Exception)
                    {
                       // If the string could not be converted to a float  then 
                       // nIndex from m_mRawIndexToDimensionIndex.Keys is not properly chosen
                       // or the aastrRawData are not set up properly
                    }

                    nKeyIndex++;
                }
            }
        }
        // Using the min and max values for each dimension, establish the corresponding float value on the range 
        // 0f to 1f for each dimension of each record.
        // add all original values to the PointData dictionary.

    }
}