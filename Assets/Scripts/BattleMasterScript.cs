using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleMasterScript : MonoBehaviour
{
    //Hero,Enemy取得用変数
    public Hero hero;
    public EnemyGroup enemyGroup;//EnemyGroup内にEnemyデータを格納、そこからデータを取得してくる。

    [Space(3),Header("GameObjects")]
    //HPSP用TMP
    [SerializeField] private GameObject heroHpObject;
    [SerializeField] private GameObject heroSpObject;
    private TextMeshProUGUI heroHpText;
    private TextMeshProUGUI heroSpText;

    //Animation用
    [SerializeField] private GameObject heroImageObject;

    private void Start()
    {
        //Debug.Log(enemyGroup.enemy.Length);
        heroHpText = heroHpObject.GetComponent<TextMeshProUGUI>();
        heroSpText = heroSpObject.GetComponent<TextMeshProUGUI>();

        StatusUpdate();
    }

    private void Update()
    {
        
    }

    private void StatusUpdate()
    {
        heroHpText.text = $"HP   {hero.Hp} / {hero.MaxHp}";
        heroSpText.text = $"SP   {hero.Sp} / {hero.MaxSp}";
    }
}
