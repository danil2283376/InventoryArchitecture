using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationMove : MonoBehaviour
{
    public GameObject endPositionMove;

    private RectTransform m_RectTransform;
    private void Start()
    {
        m_RectTransform = GetComponent<RectTransform>();

        m_RectTransform.DOMove(endPositionMove.transform.position, 1.5f).SetEase(Ease.OutSine);
    }
}
