using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GetText()
    {




        long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        using (UnityWebRequest request = UnityWebRequest.Get("https://reactnative.dev/movies.json"))
        {

            yield return request.SendWebRequest();


            if (request.isNetworkError) // Error
            {
                UnityEngine.Debug.Log(request.error);
            }
            else // Success
            {
                UnityEngine.Debug.Log(request.downloadHandler.text);
            }
        }

    }

    public void UnityWeb()
    {
        UnityEngine.Debug.Log("GetText");
        StartCoroutine(GetText());
    }
}