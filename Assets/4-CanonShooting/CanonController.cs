﻿using UnityEngine;

/// <summary>
/// 砲台 (Canon) を制御するコンポーネント
/// </summary>
public class CanonController : MonoBehaviour
{
    [SerializeField] Transform m_crosshairtransform = null;
    /// <summary>砲弾として生成するプレハブ</summary>
    [SerializeField] GameObject m_shellPrefab = default;
    /// <summary>砲口を指定する</summary>
    [SerializeField] Transform m_muzzle = default;
    AudioSource m_audio = default;

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        this.gameObject.transform.up = m_crosshairtransform.position - this.transform.position;
        if (Input.GetButtonDown("Fire1"))
        {
            m_audio.Play();
            Instantiate(m_shellPrefab, m_muzzle.position, this.transform.rotation);
        }
    }
}
