using System.Collections;
using System.Collections.Generic;
using LeanCloud;
using UnityEngine;

public class GameManager : MonoBehaviour {

	void Start ()
    {
        //Person person = new Person();
        //person.PlayerId = "dfgsdfgsdf";
        //person.m_strName = "sunwanyang";
        //person.m_iAge = 22;
        //person.m_dHeght = 170;
        //person.m_bMating = false;

        //person.m_AVObject.SaveAsync().ContinueWith(t =>
        //{
        //    Debug.LogError("Result : " + t.ToString());
        //});

        UpdateData();
    }
	
	void FindByObjectId () 
    {
        AVQuery<AVObject> query = new AVQuery<AVObject>("Person");
        query.GetAsync("5922c7e45f7cff0058224fd7").ContinueWith(t =>
        {
            Person person = new Person(t.Result);

            Debug.LogError("Name : " + person.m_strName);
            Debug.LogError("Age : " + person.m_iAge);
            Debug.LogError("Heght : " + person.m_dHeght);
            Debug.LogError("Mating : " + person.m_bMating);
        });
	}

    private void UpdateData()
    {
        AVQuery<AVObject> query = new AVQuery<AVObject>("Person");
        query.GetAsync("5922c7e45f7cff0058224fd7").ContinueWith(t =>
        {
            Person person = new Person(t.Result);

            person.m_strName = "11111111111";

            person.m_AVObject.SaveAsync();
        });
    }
}
