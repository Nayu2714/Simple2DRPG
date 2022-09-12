using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleMasterScript : MonoBehaviour
{
    //Hero,Enemy�擾�p�ϐ�
    public Hero hero;
    public EnemyGroup enemyGroup;//EnemyGroup����Enemy�f�[�^���i�[�A��������f�[�^���擾���Ă���B

    [Space(3),Header("GameObjects")]
    //HPSP�pTMP
    [SerializeField] private GameObject heroHpObject;
    [SerializeField] private GameObject heroSpObject;
    private TextMeshProUGUI heroHpText;
    private TextMeshProUGUI heroSpText;

    //Animation�p
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
