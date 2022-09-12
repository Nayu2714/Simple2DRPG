using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Group", menuName = "Enemy Group")]
public class EnemyGroup : ScriptableObject
{
    public Enemy[] enemy = new Enemy[3];
    public int enemyCount;
}
