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
        //이미지 조작 색 그림
        img.color = Color.gray;
        //버튼조작 활성화 이벤트연결
        btn.interactable = true;
        btn.interactable = false;
        //슬라이더 조작 활성화
        slider.interactable = true;
        slider.interactable = false;
        slider.value = 50;
        slider.minValue = 0;
        slider.maxValue = 100;
        //텍스트
        text.text = "안녕하세요";
        text.fontStyle = FontStyle.Italic;
        text.fontSize = 30;
        text.color = Color.black;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
