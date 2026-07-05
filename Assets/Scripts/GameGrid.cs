using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{
    public int columnLength, rowLength;

    public float x_Space, z_Space;

    public GameObject grass;

    public GameObject[] currentGrid;

    public bool gotGrid;

    public GameObject hitted;

    public GameObject field;

    private RaycastHit _hit;

    public bool creatingFields;

    public Texture2D basicCursour, fieldCursour;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    private void Awake()
    {
        Cursor.SetCursor(basicCursour, hotSpot, cursorMode);
    }


    private void Start()
    {
        for (int i = 0; i < columnLength * rowLength; i++)
        {
            Instantiate(grass, new Vector3(x_Space + (x_Space * (i % columnLength)), 0, z_Space + (z_Space * (i / columnLength))), Quaternion.identity, transform);


        }
    }

    private void Update()
    {
        if (gotGrid == false)
        {
            currentGrid = GameObject.FindGameObjectsWithTag("grid");

            gotGrid = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out _hit))
            {
                if (creatingFields == true)
                {
                    if (_hit.transform.tag == "grid")
                    {
                        hitted = _hit.transform.gameObject;
                        Instantiate(field, hitted.transform.position, Quaternion.identity);
                        Destroy(hitted);
                    }

                    Cursor.SetCursor(fieldCursour, hotSpot, cursorMode);
                }
            }
        }
    }

    public void CreateFields()
    {
        creatingFields = true;
    }

    public void returnToNormality()
    {
        creatingFields = false;
    }
}
