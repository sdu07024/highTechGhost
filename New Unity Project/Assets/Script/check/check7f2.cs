﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check7f2 : MonoBehaviour
{

    public GameObject Panel;
    public Text t;
    
    public void hidePanel()
    {
        Panel.gameObject.SetActive(true);
    }

    void OnMouseDown()
    {
        Debug.Log("clicked");
        hidePanel();
        t.GetComponent<Text>().text = "next";
        DialogDataAlert alert = new DialogDataAlert("7층 - 옥상정원", "이 문은 저층부 옥상으로 가는 문이야!", delegate () {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "그럴게요!";
            DialogDataAlert garden = new DialogDataAlert("7층 - 옥상정원", "밤에 와서 후문 야경과 달을 보면\n정말 예쁘단다! 꼭 보러와", delegate () {
                Debug.Log("OK Pressed!");

            });
            DialogManager.Instance.Push(garden);

        });
        DialogManager.Instance.Push(alert);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}