using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonScale : MonoBehaviour
{


    public Vector3 TargetScale = new Vector3(2f, 2f, 2f);
    public GameObject[] Object;
   

    // Start is called before the first frame update
    void Start()
    {

    }
    public void ScaleUp()
    {
        transform.DOScale(TargetScale, 0f).SetEase(Ease.InOutQuad);
    }

    public void ScaleDown()
    {
        transform.DOScale(Vector3.one, 0f).SetEase(Ease.InOutQuad);
    }
    // Update is called once per frame
    void Update()
    {

    }
}