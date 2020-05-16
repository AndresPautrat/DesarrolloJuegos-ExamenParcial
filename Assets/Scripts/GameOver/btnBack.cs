using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btnBackScript : MonoBehaviour
{
    [SerializeField]
    Button btnBack;
    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(() => goMenu());
    }

    private void goMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
