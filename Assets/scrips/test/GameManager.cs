using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //�÷��̾�����
    public int playerHP;
    public int playerMp;

    public int[] playerAtk;
    public int[] playerCost;


    //����Ʈ
    public string[] effectName;
    
    //����
    public AudioSource[] Audio;


    public bool canAttack = true;
    public Enemy enemy;
    public UIUserInfo uiUserInfo;
    private void Start()
    {
        uiUserInfo.Setup(playerHP, playerMp);

    }


    //�÷��̾����1
    public void Attack(int index )
    {
        int playerCost = this.playerCost[index]; 
        int playerAtk = this.playerAtk[index];
        string EffectName = this.effectName[index];
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
        //4���� ���ݰ��� Invoke
        Invoke(nameof(DelayReset), 4);
        
    }
    
   
    //������
    void DelayReset()
    {
        canAttack = true;
    }
    //���Ͱ���
    public void Hit(int damage)
    {
        
        playerHP -= damage;
        if (playerHP <= 0)
        {
            playerHP = 0;
            //���ӿ���
        }
        uiUserInfo.ChangeUserInfo(playerHP, playerMp);
    }

}
