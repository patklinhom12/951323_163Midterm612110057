using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonGameManagement : Singleton<SingletonGameManagement>
{
    public bool IsOptionMenuActive
    {
        get { return _isOptionMenuActive; }
        set { _isOptionMenuActive = value; }      
    }
    protected bool _isOptionMenuActive = false;

    public bool MusicEnable { get; set; } = true;
    public bool SFXEnabled { get; set; } = true;
}
