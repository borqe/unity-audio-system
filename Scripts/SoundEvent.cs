using System;
using borqe.UnitySoundSystem;
using UnityEngine;
using UnityEngine.Audio;

public class SoundEvent
{
    private Sound _sound;
    private AudioSource _source;
    private AudioMixer _mixer;

    private Vector3 _playPosition;
    private Transform _playParent;
    
    public SoundEvent(Sound sound, AudioSource audioSource)
    {
        _sound = sound;
        _source = audioSource;
    }

    public Action<SoundEvent> OnStop;
    public Action<SoundEvent> OnPlay;

    public SoundEvent Play()
    {
        _source.clip = _sound.audioClip;
        return this;
    }
    
    /// <summary>
    /// Start or restart the playback of the SoundEvent.
    /// Run this after all properties are set
    /// </summary>
    public void Launch()
    {
        _source.Play();
        OnPlay?.Invoke(this);
    }

    public void Stop()
    {
        _source.Stop();
        OnStop?.Invoke(this);
    }

    public void Dispose()
    {
        return;
    }
    
    /// <summary>
    /// Pan the sound instantly or over time. 
    /// </summary>
    /// <param name="stereoPan">Pan position from left (-1.0) to right (1.0)</param>
    /// <param name="time">Pan automation duration time</param>
    /// <returns>The same caller SoundEvent for chaining</returns>
    public SoundEvent Pan(float stereoPan, float time)
    {
        // TODO! implement panning over time
        _source.panStereo = Mathf.Clamp(stereoPan, -1.0f, 1.0f);
        
        return this;
    }

    public SoundEvent FadeVolume(float volume, float time = 0.0f)
    {
        // TODO! implement sound fades
        
        return this;
    }

    public SoundEvent PlayAfter(SoundEvent soundEvent, bool loop = false)
    {
        return this;
    }

    public SoundEvent Delayed(float time = 0.0f)
    {
        return this;
    }

    public SoundEvent SendToChannel(string mixerChannel)
    {
        return this;
    }

    public SoundEvent CrossFade(SoundEvent soundEvent, float time = 0.0f)
    {
        return this;
    }

    public SoundEvent PlayAtDistance(Transform distantObject, float minDistance, float maxDistance,
        bool calculateVolume = false)
    {
        return this;
    }

    public SoundEvent PlayAtPosition(Transform transform, bool parent = false)
    {
        return this;
    }

    public SoundEvent PlayOnCondition(Action condition)
    {
        return this;
    }
}