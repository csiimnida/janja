using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickChange : MonoBehaviour
{
    private STackInfo _stick;
    private SpriteRenderer _renderer;
    [SerializeField]private Sprite[] _sprites;

    private void Awake()
    {
        _stick = GetComponent<STackInfo>();
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.sprite = _stick.Powwer > 0 ? _sprites[0] : _sprites[1];

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _stick.Powwer = -_stick.Powwer;
            _renderer.sprite = _stick.Powwer > 0 ? _sprites[0] : _sprites[1];
        }
    }
}
