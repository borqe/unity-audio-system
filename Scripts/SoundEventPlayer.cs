using UnityEngine;

namespace borqe.UnitySoundSystem
{
    [CreateAssetMenu(order = 0, fileName = "SoundEventPlayer", menuName = "unity-audio-system/SoundEventPlayer")]
    public class SoundEventPlayer: ScriptableObject
    {
        public void PlaySound(string soundKey = "default")
        {
            SoundPlayer.PlayOneShot(soundKey);
        }
    }
}