using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class extracts audio data

public class AudioSpectrum : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        m_audioSpectrum = new float[512];
    }

    // Update is called once per frame
    private void Update()
    {
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming);
        if(m_audioSpectrum != null && m_audioSpectrum.Length >0)
        {
            spectrumValue = m_audioSpectrum[0] * 100; //Right now this only reads frequency band 0-39
        }
    }

    public static float spectrumValue { get; private set; }
    private float[] m_audioSpectrum;
}

