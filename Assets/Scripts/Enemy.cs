using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Enemy : ScriptableObject
{
    [SerializeField] private new string name;
    [SerializeField] private int ID;
    [SerializeField, Multiline(2)] private string description;

    [Space(5)]
    [SerializeField] Sprite artwork;

    [Header("Status")]
    [SerializeField] private int maxHp;
    [SerializeField] private int hp;

    [Space(5)]
    [SerializeField] private int phAtk;
    [SerializeField] private int phDef;
    [SerializeField] private int maAtk;
    [SerializeField] private int maDef;


}
