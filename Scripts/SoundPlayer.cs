using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace borqe.UnitySoundSystem
{
    /// <summary>
    /// This class the the "manager". It handles AudioSource lifecycle & places sounds into those based on
    /// various parameters.
    /// </summary>
    public class SoundPlayer: MonoBehaviour
    {
        [SerializeField] private int _maxSoundSources = 12;
        [SerializeField] private static List<AudioSource> _sources;
        [SerializeField] private static List<SoundBank> _soundBanks;

        // TODO! Sound Event caching 
        private static List<SoundEvent> _soundEvents;

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
            var soundEvent = new SoundEvent(
                GetSoundFromBank(_soundBanks[0], soundEventName), 
                AvailableAudioSource()
            );
            _soundEvents.Add(soundEvent);
        }

        private static AudioSource AvailableAudioSource()
        {
            return _sources[0];
        }

        private static Sound GetSoundFromBank(SoundBank bank, string soundName)
        {
            return bank.soundsList.FirstOrDefault(sb => sb.name == soundName);
        }
    }
}