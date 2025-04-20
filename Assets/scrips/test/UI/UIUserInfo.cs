using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIUserInfo : MonoBehaviour
{
    //UI
    public TMP_Text txtHpValue;
    public Slider HpSlid;

    public TMP_Text txtMpValue;
    public Slider MpSlid;
    
    public void Setup(int hp, int mp)
    {
        txtHpValue.text = hp.ToString();
        HpSlid.maxValue = hp;
        HpSlid.value = hp;
        txtMpValue.text = mp.ToString();
        MpSlid.maxValue = mp;
        MpSlid.value = mp;
    }

    public void ChangeUserInfo(int hp, int mp)
    {
        txtHpValue.text = hp.ToString();
        HpSlid.value = hp;
        txtMpValue.text = mp.ToString();
        MpSlid.value = mp;
    }
}
