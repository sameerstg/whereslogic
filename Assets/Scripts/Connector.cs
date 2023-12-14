using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Connector : MonoBehaviour
{
    public Wire wire;
    private void OnMouseDown()
    {
        if (wire == null)
        {
        Iterate:
            if (PoolManager._instance.extra.wire.Count == 0)
            {
                wire = Instantiate(Resources.Load<GameObject>("wire")).GetComponent<Wire>();
            }
            else
            {
                wire = PoolManager._instance.extra.wire[0];
                PoolManager._instance.extra.wire.RemoveAt(0);
                if (wire == null)
                {
                    goto Iterate;

                }
                wire.gameObject.SetActive(true);
            }
        }
        else
        {
            wire.gameObject.SetActive(false);
            wire.gameObject.SetActive(true);
        }
        var newWire = this.wire;

        newWire.transform.position = transform.position;
        foreach (var item in newWire.connector)
        {
            item.wire = null;
        }
        newWire.connector.Clear();
        newWire.connector.Add(this);
    }
    private void OnMouseEnter()
    {
        InputHandler.hoveredConnector = this;
    }
    private void OnMouseExit()
    {
        InputHandler.hoveredConnector = null;
    }
}
