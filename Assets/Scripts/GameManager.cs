using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region static‚©‚ÂƒVƒ“ƒOƒ‹ƒgƒ“‚É‚·‚é
    public static GameManager Instance { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public float InputH { get; set; } = 0;
    public float InputV { get; set; } = 0;

    public void SetInputHV(float h, float v)
    {
        InputH = h;
        InputV = v;
    }
}
