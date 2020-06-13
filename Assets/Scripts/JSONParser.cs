using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class JSONParser : MonoBehaviour
{
    public string url;
    public DataClass dataClass;
    public  Summary allCountries;
    public string[] countryName;


    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine("LoadData");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetData()
    {

    }

    IEnumerator LoadData()
    {
        WWW getData = new WWW(url);

        yield return getData;

        JsonUtility.FromJsonOverwrite(getData.text, allCountries);

        countryName = new string[allCountries.Countries.Length];

        for (int i=0; i < countryName.Length;i++)
        {
            countryName[i] = allCountries.Countries[i].Country;
        }

        Debug.Log("Total Confirmed : " + allCountries.Global.TotalConfirmed);
        Debug.Log("Total Deaths : " + allCountries.Global.TotalDeaths);
        Debug.Log("Total Recovered : " + allCountries.Global.TotalRecovered);

        //Check DataClass.cs for the list to access the variables
    }
}
