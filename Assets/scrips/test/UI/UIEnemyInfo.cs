using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEnemyInfo : MonoBehaviour
{
    //UI ���ʹ�
    public TMP_Text txtEnermyHpValue;
    public Slider SlidEnermyHP;

    public void Setup(int hp)
    {
        //�����̴� �ִ밪 ����
        SlidEnermyHP.maxValue = hp;
        SlidEnermyHP.value = hp;
        txtEnermyHpValue.text = hp.ToString();

    }
    public void ChangeEnemyInfo(int hp)
    {
        txtEnermyHpValue.text = hp.ToString();
        SlidEnermyHP.value = hp;
    }
}
