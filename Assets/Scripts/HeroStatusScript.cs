using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStatusScript : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private int maxHp;

    [Space(5)]
    [SerializeField] private int sp;
    [SerializeField] private int maxSp;

    [Space(5)]
    [SerializeField] private int phAtk;
    [SerializeField] private int phDef;

    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    private void Update()
    {

    }
}
