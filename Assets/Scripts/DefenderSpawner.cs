using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField]
    public StarDisplay starDisplay;

    public GameObject DefenderPrefab { get; set; }

    private void OnMouseDown()
    {
        Debug.Log("Mouse Clicked");
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float x = Mathf.RoundToInt(rawWorldPos.x);
        float y = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(x, y);
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        if (DefenderPrefab != null)
        {
            GameObject defender = Instantiate(DefenderPrefab, worldPos, Quaternion.identity);
        }
    }
}
