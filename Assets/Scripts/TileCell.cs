using UnityEngine;

public class TileCell : MonoBehaviour
{
    public Vector2Int coordinates { get; set; } // cell coordinant
    public Tile tile { get; set; } // 2, 4, 8, 16 ...

    public bool Empty => tile == null;
    public bool Occupied => tile != null;
}
