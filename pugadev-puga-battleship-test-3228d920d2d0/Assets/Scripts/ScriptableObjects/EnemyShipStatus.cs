using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyShipStatus", menuName = "ScriptableObject/EnemyShip")]
public class EnemyShipStatus : ScriptableObject
{
    [Range(1, 5)] public int enemyLevel;
}
