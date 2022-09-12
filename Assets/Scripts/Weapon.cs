using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ScriptableObject
{
    [SerializeField] private string Name;
    [SerializeField, Multiline(2)] private string information;

    [Space(5)]
    [SerializeField] private int power;
}