using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tile state")]
public class TileState : ScriptableObject
{
    public int number;
    public Color backgroundColor;
    public Color textColor;
}
