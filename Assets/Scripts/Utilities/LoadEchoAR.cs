using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadEchoAR : MonoBehaviour
{
    public CanvasGroup fadePanel;
    public GameObject coronaObj, loadingObj;
    public GameObject aboutPanel, infoPanel;
    public Text informationTxt, aboutTxt;
    public string urlInfo;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        LeanTween.alphaCanvas(fadePanel, 0f, 2f);
        yield return new WaitForSeconds(2f);
        fadePanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TouchObject();
    }

    void TouchObject()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "CoronaParent")
                    {
                        hit.transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (hit.transform.name == "About")
                    {
                        infoPanel.SetActive(false);
                        aboutPanel.SetActive(true);
                    }
                    else if (hit.transform.name == "Info")
                    {
                        infoPanel.SetActive(true);
                        aboutPanel.SetActive(false);
                    }
                }
                else
                {
                    infoPanel.SetActive(false);
                    aboutPanel.SetActive(false);
                }
            }
        }
    }

    public void LoadScene()
    {
        StartCoroutine("DelayLoadScene");
    }

    IEnumerator DelayLoadScene()
    {
        fadePanel.gameObject.SetActive(true);
        LeanTween.alphaCanvas(fadePanel, 1f, 1f);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }

    public void OpenLink()
    {
        Application.OpenURL(urlInfo);
    }

    public void SetPosition()
    {
        coronaObj.transform.GetChild(1).localPosition = Vector3.zero;
    }
}
