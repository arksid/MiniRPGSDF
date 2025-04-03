using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiTest : MonoBehaviour
{
    public Image img;
    public Button btn;
    public Slider slider;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        //�̹��� ���� �� �׸�
        img.color = Color.gray;
        //��ư���� Ȱ��ȭ �̺�Ʈ����
        btn.interactable = true;
        btn.interactable = false;
        //�����̴� ���� Ȱ��ȭ
        slider.interactable = true;
        slider.interactable = false;
        slider.value = 50;
        slider.minValue = 0;
        slider.maxValue = 100;
        //�ؽ�Ʈ
        text.text = "�ȳ��ϼ���";
        text.fontStyle = FontStyle.Italic;
        text.fontSize = 30;
        text.color = Color.black;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
