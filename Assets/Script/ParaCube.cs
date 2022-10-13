using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaCube : MonoBehaviour
{
    public int _band;
    public float _startScale, _scaleMultiplier;
    public bool _useBuffer;
    // Start is called before the first frame update
    void Start()
    {
        _startScale =1;
        _scaleMultiplier = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, 
            (AudioPeer._bandBuffer[_band] * _scaleMultiplier) + _startScale, 
            transform.localScale.z);
        }
        if(!_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, 
            (AudioPeer._freqBand[_band] * _scaleMultiplier) + _startScale, 
            transform.localScale.z);
        }
    }
}
