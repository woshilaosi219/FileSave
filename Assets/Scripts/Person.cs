using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LeanCloud;

public class Person : BaseAVObject
{
    public Person()
        : base("Person")
    {
        
    }
    public Person(AVObject obj)
    {
        m_AVObject = obj;
    }

    public string m_strName
    {
        get
        {
            return m_AVObject.Get<string>("name");
        }
        set
        {
            m_AVObject["name"] = value;
        }
    }

    public int m_iAge
    {
        get
        {
            return m_AVObject.Get<int>("age");
        }
        set
        {
            m_AVObject["age"] = value;
        }
    }

    public double m_dHeght
    {
        get
        {
            return m_AVObject.Get<double>("hight");
        }
        set
        {
            m_AVObject["hight"] = value;
        }
    }
    public bool m_bMating
    {
        get
        {
            return m_AVObject.Get<bool>("mating");
        }
        set
        {
            m_AVObject["mating"] = value;
        }
    }
}