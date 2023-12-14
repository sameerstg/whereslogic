using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager _instance;
    public Pool extra = new();
    private void Awake()
    {
        _instance = this;
    }

}
