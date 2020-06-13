using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>
    public LoadEchoAR sceneHandler;
    public string informationTitle, informationLink, about;
    private float scale; private string scaleTemp;


    // Use this for initialization
    void Start()
    {
        sceneHandler = GameObject.Find("[SceneHandler]").GetComponent<LoadEchoAR>();
        // Add RemoteTransformations script to object and set its entry
        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;
        
        entry.getAdditionalData().TryGetValue("scale", out scaleTemp);
        scale = float.Parse(scaleTemp);

        // Qurey additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }
        sceneHandler.loadingObj.SetActive(false);
        StartCoroutine("TakeOutChild");
    }

    // Update is called once per frame
    void Update()
    {
        if (entry.getAdditionalData() != null)
        {
            entry.getAdditionalData().TryGetValue("info", out informationTitle);
            entry.getAdditionalData().TryGetValue("infoLink", out informationLink);
            entry.getAdditionalData().TryGetValue("about", out about);

            sceneHandler.informationTxt.text = informationTitle;
            sceneHandler.urlInfo = informationLink;
            sceneHandler.aboutTxt.text = about;
        }
    }

    IEnumerator TakeOutChild()
    {
        yield return new WaitForSeconds(0.5f);
        transform.GetChild(0).localScale = new Vector3(scale, scale, scale);
        transform.GetChild(0).SetParent(GameObject.Find("CoronaParent").transform);
        yield return new WaitForSeconds(0.5f);
        sceneHandler.SetPosition();

    }
}