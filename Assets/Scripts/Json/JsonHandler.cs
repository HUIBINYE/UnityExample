/****************************************************************************
 * Copyright (c) 2017 yuanhuibin@putao.com
 ****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsonHandler : MonoBehaviour
{
    private Text txtJson;

    private void Awake()
    {
        txtJson = GameObject.FindObjectOfType<Text>();
    }

    private void Start()
    {
        StudentInfo studentInfo = new StudentInfo(100, "huibin", 26);

        string json = JsonUtility.ToJson(studentInfo);

        SaveToJson(studentInfo);

        txtJson.text = json;

        StudentInfo studentInfoFromJson = LoadFromJson<StudentInfo>(txtJson.text);

        Debug.Log("ID:" + studentInfoFromJson.ID + "||||" + "Name:" + studentInfoFromJson.Name + "||||" + "Age" +
                  studentInfoFromJson.Age);
    }

    private void SaveToJson<T>(T t)
    {
        string json = JsonUtility.ToJson(t);

        Debug.Log(json);
    }

    private T LoadFromJson<T>(string json)
    {
        return JsonUtility.FromJson<T>(json);
    }
}
