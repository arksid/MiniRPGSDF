using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //ü�� : 100
    // - 0 �����۾����� �α׳���� 
    //����1 : 20
    //����2 : 30
    public Slider enemyHpSlider;
    public Slider PlayerMpSlider;
    public Canvas Victory; 
    public GameObject enemy;
    public Canvas EnemyCanvas;
    public Text PlayerMp;
    public int enemyHp = 100;
    public int playerMP = 50;
    int attackDamage1 = 20;
    int attackDamage2 = 30;
    public void Start()
    {
        Victory.gameObject.SetActive(false);
    }

    public void Attack1()
    {
        enemyHp -= attackDamage1;
        enemyHpSlider.value = enemyHp;
        if(enemyHp <= 0)//0���ϸ� ���͸���ҽ��ϴ� �α����
        {
            Destroy(enemy);
            EnemyCanvas.gameObject.SetActive(false);
            Debug.Log("���͸� ��ҽ��ϴ�");
            Victory.gameObject.SetActive(true);
        }
    }
    public void Attack2()
    {
       
        if(playerMP>=30)
        {
            enemyHp -= attackDamage2;
            playerMP -= 30;
            PlayerMpSlider.value = playerMP;
            enemyHpSlider.value = enemyHp;
            PlayerMp.text = playerMP.ToString();
        }
        else
        {
            Debug.Log("�÷��̾� MP�������մϴ�");
        }
       
        if (enemyHp <= 0)
        {
            Destroy(enemy);
            EnemyCanvas.gameObject.SetActive(false);
            Debug.Log("���͸� ��ҽ��ϴ�");
            Victory.gameObject.SetActive(true);

        }
    }
}
