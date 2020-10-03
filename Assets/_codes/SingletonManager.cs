using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    static public SingletonManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SingletonManager>();
                GameObject Container = new GameObject("SingletonManager");
                _instance = Container.AddComponent<SingletonManager>();
            }
            return _instance;
        }
    }

    static protected SingletonManager _instance = null;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _instance)
            {
                Destroy(this.gameObject);
            }
        }
    }
   
    public bool IsOptionMenuActive
    {
        get { return _isOptionMenuActive; }
        set { _isOptionMenuActive = value; }
    }

    protected bool _isOptionMenuActive = false;
    //public bool MusicEnabled { get; set; }
    //public bool SFXEnabled { get; set; }

}
