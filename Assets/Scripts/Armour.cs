using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Armour : ScriptableObject
{
    [SerializeField] private string Name;
    [SerializeField, Multiline(2)] private string information;

    [Space(5)]
    [SerializeField] private int defence;
}
