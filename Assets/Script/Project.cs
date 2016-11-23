public class Project
{
    public List <List <string>> aastrRawData = null; // raw data from a spread sheet
    public List <string> astrHeaders = null;
    public List <int> astrDimensions = null;
    public List <PointUi> aPointUi =  null;

    public Project()
    {
        LoadPointDataSet("SampleData.csv");
        CreateNormalizedPointUis();


    }

    public Log (string strMessage)
    {
        print (strMessage);
    }

    void LoadPointDataSet(string strDataSetName)
    {
        astrHeaders = new List <string> ();
        aastrRawData = new List <List <string>> ();
        string strFileType = "csv"; //todo -- compute from strDataSetName
        switch (strFileType)
        {
            case "csv":
            {
				StreamReader reader = File.OpenText(strDataSetName);
				string line;
                bool bHaveHeaders = false;

				while ((line = reader.ReadLine()) != null) 
				{
					string[] fields = line.Split(',');
                    List<string> = aStrRow = new List<string>();
                    if (!bHaveHeaders)
                    {
                        // todo--if all are not strings, then create faux headers
                        foreach(string strField in fields)
                            astrHeaders.Add(strField);
                        bHaveHeaders = true;
                    }
                    else
                    {
                        foreach(string strField in fields)
                            aStrRow.Add(strField);
                        aastrRawData.Add(aStrRow);
                    }
				}
				reader.Close();
				//ProjectAccount.nFileOpenCount--;
				//Qa.Trace (" Read "+strFile+" End " + ProjectAccount.nFileOpenCount);
			}
            break;

            default:
            Log("Unknown file type "+ strFileType)+".");
            break;
        }
    }

    GameObject GetRootGameObject ()
    {
        return GameObject.Find ("MainSceneROotObject"); 
    }

    /// needs to create, init, and store, the PointUI objects
    void CreateNormalizedPointUis()
    {
        // todo go through all of the raw values that are associated with a numerical dimension
        // find the high and low value for each dimension
        List<float> anMin = new List<float> ();
        List<float> anMax = new List<float> ();
        bool bMissalignedData = false;
        Dictionary <string, List <int> > mMissalignedFields =  Dictionary <string, List <int> > ();
        if (null!=aastrRawData)
        {
            bool bHaveFLoatIndices = false;
            foreach (List <string> record in aastrRawData)
            {
                if (!bHaveFloatIndices)
                {
                    // go through the record and identify the first 11 Floats
                    // and make a list of the float indices to be used  
                    int nCount = 0
                    int nIndex = 0
                    foreach(string strfield in record)
                    {
                        if (11>nCount)
                        {
                            try
                            {
                                float nVal = Convert.Float(strfield);
                                astrDimensions.Add(nIndex);
                            }
                            catch (Exception ex)
                            {
                                ;
                            }
                            ++nCount;
                        }
                         ++nIndex;
                    }
                    bHaveFloatIndices = true;
                    // initialize the min and max vals for each dimensions column
                    foreach (int nIndex in astrDimensions)
                    {
                        anMin.Add(float.MaxValue);
                        anMax.Add(float.MinValue);
                    }
                }
                string strId = record[0];
                m_MissalignedFields[strId] = new List<int>(); // first field must be a unique record ID
                foreach(string strfield in record)
                {
                    int nIndex = 0;
                    foreach (int nIndex in astrDimensions)
                    {
                        try
                        {
                            float nVal = Convert.Float(strfield);
                            if (anMin[nIndex] > nVal)
                                nMin[nIndex] = nVal;
                            if (anMax[nIndex] < nVal)
                                anMax[nIndex] = nVal;
                        }
                        catch (System.Exception ex)
                        {
                            mMissalignedFields[strId].Add(nIndex);
                            bMissalignedData = true;
                        }
                        nIndex++;
                    }
                }
            }
            if (bMissalignedData)
            {
                Log("CANNOT LOAD POINT DATA SET");
                string strRecord = "";
                foreach (string strKey in mMissalignedFields.Keys)
                {
                    strRecord += strKey + " has non float data in columns: ";
                    foreach (int nColumn in m_MissalignedFields[strKey])
                    {
                        strRecord += " " + nColumn;
                    }
                    strRecord += ".";
                    Log(strRecord);
                }
                return; 
            }
            foreach (List <string> record in aastrRawData)
            {
                string strId = record[0];
                bool bGoodData = true; // that the data is good should have been predetermined.  But just in case...
                int nCount = record.Count;
                List<string> astRawData = new List<string>();
                List<float> aDimensions = new   List<float> ();
                for (int nIndex = 0; nIndex<nCount ;++nIndex)
                {
                    if (astrDimensions.Contains(nIndex))
                    {
                        string strField = record[nColumn];
                        astRawData.Add(strField);
                        try
                        {
                            float nMin =  anMin[nIndex];
                            float nMax = anMax[nIndex];
                            float nVal = Convert.Float(strField);
                            if ((nMin > nVal)||(nMax < nVal))
                            {
                                bGoodData = false;
                                Log("Value ("+nVal+") is out of the precalculated range ["+anMin[nIndex] +","+anMax[nIndex] +"]");
                            }
                            if (bGoodData)
                                aDimensions.Add(nVal);
                        }
                        catch (Exception ex)
                        {
                            Log("Unexpected conversion failure in record "+strId+" column "+ astrHeaders[nColumn]);
                            bGoodData = false;
                        }
                    }
                }
                if (!bGoodData)
                    return;
                PointData pd = new PointData(strId,astrDimensions,astRawData); 
                // todo
                // create point UI and set its pd
                // attach it to the root object
            }
        }
    }
}