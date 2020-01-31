using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerShipStatus", menuName = "ScriptableObject/PlayerShip")]
public class PlayerShipStatus : ScriptableObject
{
    [Range(1, 3)] public int manaLevel;
    [Range(1, 5)] public int speedLevel;
    [Range(1, 5)] public int healthLevel;
    [Range(1, 5)] public int attackLevel;

    [Range(1, 5)] public int megaBombLevel;
    [Range(1, 5)] public int lazerLevel;
    [Range(1, 5)] public int fireLevel;
}
