using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //���
    const string AttackTigger = "Attack";
    const string HitTigger = "Hit";
    const string DieTigger = "Die";
    //����
    public GameManager gm;
    public UIEnemyInfo uienemyInfo;
    public UIClearPopUp uiClearPopUp;
    public Animator enemyAnimater;
    public int enemyHP;
    public int enemyAtk;

    
    private void Start()
    {   
        enemyAnimater.GetComponent<Animator>();
        uienemyInfo.Setup(enemyHP);
    }
    //���Ͱ���
    public void EnemyAttack()
    {

        enemyAnimater.SetTrigger(AttackTigger);

        gm.Hit(enemyAtk);
    }
    public void Hit(int damage)
    {
        enemyAnimater.SetTrigger(HitTigger);

        enemyHP -= damage;
        if (enemyHP <= 0)
        {
            enemyAnimater.SetTrigger(DieTigger);
            enemyHP = 0;
            uiClearPopUp.gameObject.SetActive(true);
        }
        Invoke("EnemyAttack", 2);
        uienemyInfo.ChangeEnemyInfo(enemyHP);
    }
}
