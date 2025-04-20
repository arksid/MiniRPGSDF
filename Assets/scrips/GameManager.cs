using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Animator enemyAnimater;
    public Transform enemyTransform;
    public int enemyHP;
    public int enemyAtk;
    //UI ���ʹ�
    public TMP_Text txtEnermyHpValue;
    public Slider SlidEnermyHP;

    //�÷��̾�����
    public int playerHP;
    public int playerMp;

    public int playerAtk1;
    public int playerCost1;
    public int playerAtk2;
    public int playerCost2;
   
    //UI
    public TMP_Text txtHpValue;
    public Slider HpSlid;
    public TMP_Text txtMpValue;
    public Slider MpSlid;
    public GameObject uiClearPopup;
    
    //����Ʈ
    public string effectName1;
    public string effectName2;
    
    //����
    public AudioSource audio1;
    public AudioSource audio2;

    public bool canAttack = true;
    private void Start()
    {
        SlidEnermyHP.maxValue = enemyHP;
        SlidEnermyHP.value = enemyHP;
        HpSlid.maxValue = playerHP;
        HpSlid.value = playerHP;

        MpSlid.maxValue = playerMp;
        MpSlid.value = playerMp;

        
    }


    //�÷��̾����1
    public void Attack1()
    {
        if (canAttack== false)
            return;

        if (playerMp < playerCost1)
            return;

        enemyAnimater.SetTrigger("Hit");

        playerMp -= playerCost1;

        enemyHP -= playerAtk1;
        if (enemyHP <= 0)
        {
            enemyAnimater.SetTrigger("Die");
            enemyHP = 0;

            canAttack = false;
            
            uiClearPopup.SetActive(true);
            
            CancelInvoke();
        }

        ChangeEnemyInfo();

        audio1.Play();

        GameObject effectRes = Resources.Load<GameObject>(effectName1);
        Instantiate(effectRes, enemyTransform.position + Vector3.back,effectRes.transform.rotation);

        canAttack = false;
        //4���� ���ݰ��� Invoke
        Invoke("DelayReset", 4);
        Invoke("EnemyAttack", 2);

    }
    
    //�÷��̾����2
    public void Attack2()
    {
        //������ ��������
        if (canAttack == false)
            return;

        if (playerMp < playerCost2)
            return;

        enemyAnimater.SetTrigger("Hit");

        playerMp -= playerCost2;

        enemyHP -= playerAtk2;
        if (enemyHP <= 0)
        {
            enemyAnimater.SetTrigger("Die");
            enemyHP = 0;
            
            canAttack = false;
            uiClearPopup.SetActive(true);

            CancelInvoke();
        }
            

        ChangeEnemyInfo();
        ChangePlyerInfo();
        audio2.Play();
        GameObject effectRes = Resources.Load<GameObject>(effectName2);
        Instantiate(effectRes, enemyTransform.position + Vector3.back, effectRes.transform.rotation);

        canAttack = false;
        Invoke("DelayReset", 4);
        Invoke("EnemyAttack", 2);

    }
    //������
    void DelayReset()
    {
        canAttack = true;
    }
    //���Ͱ���
    public void EnemyAttack()
    {
        enemyAnimater.SetTrigger("Attack");
        playerHP -= enemyAtk;
        if (playerHP <= 0)
        {
            playerHP = 0;
            //���ӿ���
        }
        ChangePlyerInfo();
    }

    //������ ü�º�ȭ
    public void ChangeEnemyInfo()
    {
        txtEnermyHpValue.text = enemyHP.ToString();
        SlidEnermyHP.value = enemyHP;
    }
    //�÷��̾� ü�º�ȭ
    //�÷��̾� ������ȯ
    public void ChangePlyerInfo()
    {
        txtHpValue.text = playerHP.ToString();
        HpSlid.value = playerHP;
        txtMpValue.text = playerMp.ToString();
        MpSlid.value = playerMp;    
    }

    public void GoToEnding()
    {
        SceneManager.LoadScene("Ending");
    }
}
