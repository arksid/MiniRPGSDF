using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //플레이어정보
    public int playerHP;
    public int playerMp;

    public int[] playerAtk;
    public int[] playerCost;


    //이펙트
    public string[] effectName;
    
    //사운드
    public AudioSource[] Audio;


    public bool canAttack = true;
    public Enemy enemy;
    public UIUserInfo uiUserInfo;
    private void Start()
    {
        uiUserInfo.Setup(playerHP, playerMp);

    }


    //플래이어공격1
    public void Attack(int index)
    {
        int playerCost = this.playerCost[index]; 
        int playerAtk = this.playerAtk[index];
        string EffectName = effectName[index];
        AudioSource audio = this.Audio[index];
        if (canAttack== false)
            return;

        if (playerMp < playerCost)
            return;

        

        playerMp -= playerCost;

        enemy.Hit(playerAtk);


        uiUserInfo.ChangeUserInfo(playerHP, playerMp);
        audio.Play();

        GameObject effectRes = Resources.Load<GameObject>(EffectName);
        Instantiate(effectRes, enemy.transform.position + Vector3.back,effectRes.transform.rotation);

        canAttack = false;
        //4초후 공격가능 Invoke
        Invoke(nameof(DelayReset), 4);
        

    }
    
   
    //딜레이
    void DelayReset()
    {
        canAttack = true;
    }
    //몬스터공격
    public void Hit(int damage)
    {
        
        playerHP -= damage;
        if (playerHP <= 0)
        {
            playerHP = 0;
            //게임오버
        }
        uiUserInfo.ChangeUserInfo(playerHP, playerMp);
    }

}
