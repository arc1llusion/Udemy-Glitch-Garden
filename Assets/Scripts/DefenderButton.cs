using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour {

    [SerializeField]
    GameObject defenderPrefab;

    [SerializeField]
    DefenderSpawner defenderSpawner;

    private SpriteRenderer spriteRenderer;
    private Color defaultColor = Color.white;

	void Start () {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.defaultColor = this.spriteRenderer.color;
    }


    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(var b in buttons)
        {
            b.GetComponent<SpriteRenderer>().color = this.defaultColor;
        }

        this.spriteRenderer.color = Color.white;

        defenderSpawner.DefenderPrefab = defenderPrefab;
    }
}
