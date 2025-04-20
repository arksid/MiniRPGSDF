using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //상수
    const string AttackTigger = "Attack";
    const string HitTigger = "Hit";
    const string DieTigger = "Die";
    //변수
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
    //몬스터공격
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
        Invoke(nameof(EnemyAttack), 2);
        uienemyInfo.ChangeEnemyInfo(enemyHP);
    }
}
