/****************************************************************************
 * Copyright (c) 2017 yuanhuibin@putao.com
 ****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{

    public Text txtTips;
    public Slider sliderProgress;

    
    void Start () {
        StartCoroutine(StartLoading(1));
    }
 
    private IEnumerator StartLoading( int scene )
    {
        int displayProgress = 0;
        int toProgress = 0;
        AsyncOperation op =SceneManager.LoadSceneAsync(scene);
        op.allowSceneActivation = false;
        while (op.progress < 0.9f)
        {
            toProgress = ( int )op.progress * 100;
            while (displayProgress < toProgress)
            {
                ++displayProgress;
                SetLoadingPercentage(displayProgress);
                yield return new WaitForEndOfFrame();
            }
        }
 
        toProgress = 100;
        while (displayProgress < toProgress)
        {
            ++displayProgress;
            SetLoadingPercentage(displayProgress);
            yield return new WaitForEndOfFrame();
        }
        op.allowSceneActivation = true;
    }
 
    private void SetLoadingPercentage( int displayProgress )
    {
        txtTips.text = "进度："+displayProgress.ToString()+"%";
        Debug.Log(displayProgress);
        sliderProgress.value = displayProgress;
    }
}
