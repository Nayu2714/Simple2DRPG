using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatusScript : MonoBehaviour
{
    [SerializeField] private string enemyName = "";

    [Space(5)]
    [SerializeField] private int hp;
    [SerializeField] private int maxHp;

    [Space(5)]
    [SerializeField] private int phAtk;
    [SerializeField] private int phDef;
}
