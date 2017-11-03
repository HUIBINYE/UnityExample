/****************************************************************************
 * Copyright (c) 2017 yuanhuibin@putao.com
 ****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColdSkill : MonoBehaviour
{
	[SerializeField] private float mColdTime = 0f;

	private Image mSkillMask;

	private Button mSkillButton;

	private void Start()
	{
		mSkillMask = transform.Find("ImageMask").GetComponent<Image>();
		mSkillButton = GetComponent<Button>();
		
		mSkillButton.onClick.AddListener(delegate
		{
			SkillButtonClick();
		});
	}

	private void SkillButtonClick()
	{
		mSkillMask.gameObject.SetActive(true);
		mSkillButton.enabled = false;
		mSkillMask.DOFillAmount(0, mColdTime).SetEase(Ease.Linear).OnComplete(delegate
		{
			mSkillMask.fillAmount = 1;
			mSkillMask.gameObject.SetActive(false);
			mSkillButton.enabled = true;
		});
	}
}
