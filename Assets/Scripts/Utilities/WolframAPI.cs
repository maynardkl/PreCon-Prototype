using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class WolframAPI : MonoBehaviour
{
    private string url = "https://api.wolframalpha.com/v2/query?input=";
    private string formatOptions = "plaintext";
    private string outputResponse = "JSON";
    private string appId = ""; //register first at Wolfram Website to get your API

    public WolframDataJSON receivedData;
    public string speechInput = "";

    public Text resultToShow;
    public GameObject mapButton;
    private string mapUrl;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLoadData()
    {
        StartCoroutine("LoadData");
    }

    private IEnumerator LoadData()
    {
        mapButton.SetActive(false);
        resultToShow.text = "";
        speechInput = speechInput.Replace(" ", "+");
        print(speechInput);
        WWWForm form = new WWWForm();
        form.AddField("format", formatOptions);
        form.AddField("output", outputResponse);
        form.AddField("appid", appId);
        WWW getData = new WWW(url + speechInput + "%3F", form);

        while (!getData.isDone)
            yield return null;

        JsonUtility.FromJsonOverwrite(getData.text, receivedData);

        //Debug.Log(receivedData.queryresult.success);
        if (receivedData.queryresult.success)
        {
            resultToShow.text = receivedData.queryresult.pods[1].subpods[0].plaintext;
            for (int i = 0; i < receivedData.queryresult.numpods; i++)
            {
                if (receivedData.queryresult.pods[i].title == "Map")
                {
                    mapUrl = receivedData.queryresult.pods[i].infos.links.url;
                    mapButton.SetActive(true);
                }
            }
        }
        else
        {
            resultToShow.text = "Please try again";
        }
        
    }

    public void OpenMap()
    {
        Application.OpenURL(mapUrl);
    }
}


