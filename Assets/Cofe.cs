using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Cofe : MonoBehaviour,IDragHandler
{
    public Image Musor;
    public Image Table;
    public GameObject Spawn;
    public String[] ItemTag = {"Water","Milk","Cofe","Cugar"};
    public List<String> Correct;
    
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        if ((transform.position-Musor.transform.position).magnitude<1)
        {
            transform.position = Spawn.transform.position;
            GameObject o;
            (o = gameObject).tag = ItemTag[Random.Range(0,3)];
            Correct.Add(o.tag);
        }
        if ((transform.position-Table.transform.position).magnitude<1)
        {
            transform.position = Spawn.transform.position;
            GameObject o;
            (o = gameObject).tag = ItemTag[Random.Range(0,3)];
            Correct.Add(o.tag);
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
