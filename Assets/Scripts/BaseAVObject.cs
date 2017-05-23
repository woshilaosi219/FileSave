using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LeanCloud;

public class BaseAVObject
{
	public AVObject m_AVObject;

    private string m_strKey = null;
    private object m_strVal = null;

    public virtual string GetKey()
    {
        return m_strKey;
    }

    public virtual object GetVal()
    {
        return m_strVal;
    }


    [AVFieldName("playerId")]
    public string PlayerId
    {
        get
        {
            return m_AVObject.Get<string>("playerId");
        }
        set
        {
            m_AVObject["playerId"] = value;
        }
    }

    public BaseAVObject()
    {
    }

    public BaseAVObject(string name)
    {
        m_AVObject = new AVObject(name);
    }
    public BaseAVObject(AVObject obj)
    {
        m_AVObject = obj;
    }
}
