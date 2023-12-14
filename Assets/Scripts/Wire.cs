using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public bool set;
    public List<Connector> connector = new();
    LineRenderer lineRenderer;
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    private void OnEnable()
    {
        StartCoroutine(StartWire());
    }
    private IEnumerator StartWire()
    {
        lineRenderer.SetPosition(0, transform.position);
        while (Input.GetMouseButton(0))
        {
            lineRenderer.SetPosition(1, InputHandler.mousePosition);
            yield return null;
        }
        if (InputHandler.hoveredConnector != null)
        {
            connector.Add(InputHandler.hoveredConnector);
            set = true;
            foreach (var item in connector)
            {
                item.wire= (this);
            }
        }
        else
        {
            gameObject.SetActive(false);
            PoolManager._instance.extra.wire.Add(this);
            connector[0].wire = null;
            connector.Clear();
        }
    }
}
