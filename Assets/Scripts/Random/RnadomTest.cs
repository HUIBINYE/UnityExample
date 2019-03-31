using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 测试：官方文档上说是包含最小值和最大值的
/// 但是我在实际测试中只发现了最小值，并没有发现最大值
/// </summary>
public class RnadomTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		int value = Random.Range(0, 10);
		if (value == 10)
		{
			Debug.LogError(value);
		}
		if (value == 0)
		{
			Debug.LogWarning(value);
		}
	}
}
