using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(VoiceController))]
public class VoiceTest : MonoBehaviour {

    public Text uiText;
    public WolframAPI wolframScript;

    VoiceController voiceController;

    public void GetSpeech() {
        voiceController.GetSpeech();
    }

    void Start() {
        voiceController = GetComponent<VoiceController>();
    }

    //private void Update()
    //{
            
    //}

    void OnEnable() {
        VoiceController.resultRecieved += OnVoiceResult;
    }

    void OnDisable() {
        VoiceController.resultRecieved -= OnVoiceResult;
    }

    void OnVoiceResult(string text) {
        if (text != "")
        {
            wolframScript.speechInput = text;
            uiText.text = text;
            wolframScript.StartLoadData();
        }
    }
}
