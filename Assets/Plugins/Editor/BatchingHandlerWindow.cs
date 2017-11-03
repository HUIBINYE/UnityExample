/****************************************************************************
 * Copyright (c) 2017 yuanhuibin@putao.com
 ****************************************************************************/

using System.CodeDom.Compiler;
using UnityEditor;
using UnityEngine;

public class BatchingHandlerWindow:EditorWindow
{
    private Vector3 mPosition;
    private Vector3 mRotation;
    private Vector3 mScale;
    private int mNumber;
   
    [MenuItem("Tools/Batching")]
    public static void ShowWindow()
    {
        BatchingHandlerWindow window = (BatchingHandlerWindow)EditorWindow.GetWindow(typeof(BatchingHandlerWindow),true,"版权声明");
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("这个工程主要是针对自己在工作过程使用到的例子进行一些总结,方便以后再遇到类似的时候进行参考");

        if (GUILayout.Button("关闭"))
        {
            Close();
        }

//        mPosition = EditorGUILayout.Vector3Field("Position", mPosition);
//
//        mRotation = EditorGUILayout.Vector3Field("Rotation", mRotation);
//
//        mScale = EditorGUILayout.Vector3Field("Scale", mScale);
//        
//        EditorGUILayout.Space();
//
//        mNumber = Mathf.Max(EditorGUILayout.IntField("Number", mNumber), 0);
//        
//        EditorGUILayout.Space();
//
//        EditorGUILayout.BeginHorizontal();
//
//        if (GUILayout.Button("Generate"))
//        {
//            Generate();
//        }
//
//        bool isCancel = GUILayout.Button("Cancel");
//        
//        EditorGUILayout.EndHorizontal();
//
//        if (isCancel)
//        {
//            Cancel();
//        }
    }

    private void Generate()
    {
//        GameObject[] selectGameObjects = Selection.gameObjects;
//
//        int len = selectGameObjects.Length;
//
//        for (int i = 0; i < len; i++)
//        {
//            GameObject selectGameObject = selectGameObjects[i];
//
//            for (int j = 0; j < mNumber; j++)
//            {
//                //根据选中对象，实例化对象，然后根据索引和增量，设置移动、旋转、缩放
//                GameObject gameObject = GameObject.Instantiate(selectGameObject);
//
//                gameObject.transform.SetParent(selectGameObject.transform.parent);
//
//                gameObject.transform.localPosition = selectGameObject.transform.localPosition + mPosition * j;
//
//                gameObject.transform.localRotation = selectGameObject.transform.localRotation * Quaternion.Euler(mRotation * j);
//
//                gameObject.transform.localScale = selectGameObject.transform.localScale + mScale * j;
//
//                gameObject.name = selectGameObject.name;
//
//                //Undo是Unity3d用于设置步骤，执行/撤销等
//                //RegisterCreatedObjectUndo是注册一个新创建的对象的步骤，然后名字为“Batching Create GameObject”，用于
//                Undo.RegisterCreatedObjectUndo(gameObject, "Batching Create GameObject");
//            }
//        }
    }

    private void Cancel()
    {
        Undo.PerformUndo();
    }
}
