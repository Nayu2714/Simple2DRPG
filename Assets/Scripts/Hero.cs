using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Hero : ScriptableObject
{
    [SerializeField] private int exp = 0;
    [SerializeField] private int money = 0;
    [Space(5)]

    [SerializeField] private int maxHp;
    [SerializeField] private int hp;
    [SerializeField] private int maxSp;
    [SerializeField] private int sp;
    [Space(5)]

    [SerializeField] private int phPow;
    [SerializeField] private int phDef;
    [SerializeField] private int maPow;
    [SerializeField] private int maDef;

    public int Exp
    {
        get => exp; set => exp = value;
    }

    public int Money
    {
        get => money; set => money = value;
    }

    public int MaxHp
    {
        get => maxHp; set => maxHp = value;
    }

    public int Hp
    {
        get => hp;
        set => hp = Mathf.Max(0, Mathf.Min(MaxHp, value));
    }

    public int MaxSp
    {
        get => maxSp; set => maxSp = value;
    }

    public int Sp
    {
        get => sp;
        set => sp = Mathf.Max(0, Mathf.Min(MaxSp, value));
    }

    public int PhPow
    {
        get => phPow; set => phPow = value;
    }

    public int PhDef
    {
        get => phDef; set => phDef = value;
    }

    public int MaPow
    {
        get => maPow; set => maPow = value;
    }

    public int MaDef
    {
        get => maDef; set => maDef = value;
    }
}