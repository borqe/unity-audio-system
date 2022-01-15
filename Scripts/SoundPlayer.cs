using UnityEngine;
using System.Collections.Generic;

namespace borqe.UnitySoundSystem
{
    public class SoundPlayer: MonoBehaviour
    {
        [SerializeField] private int _maxSoundSources = 12;
        [SerializeField] private static List<AudioSource> _sources;
        [SerializeField] private List<SoundBank> _soundBanks;

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            for (var i = 0; i < _maxSoundSources / 2; i++)
            {
                var gObject = new GameObject();
                _sources.Add(gObject.AddComponent<AudioSource>());
                gObject.transform.parent = transform;
            }
            
            Debug.Log("Audio Engine Initialized.");           
        }

        public static void PlayOneShot(string soundEventName)
        {
            Debug.LogFormat("Sound {0} should be played now.", soundEventName);
        }
    }
}