using System.Collections.Generic;
using UnityEngine;

namespace borqe.UnitySoundSystem
{
    [CreateAssetMenu(order = 1, fileName = "SoundBank", menuName = "unity-audio-system/SoundBank")]
    public class SoundBank: ScriptableObject
    {
        public List<Sound> soundsList = new List<Sound>();
        public Dictionary<string, Sound> sounds = new Dictionary<string, Sound>();
    }
}