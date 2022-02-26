
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    [Header("Base Skill")]
    public string skillName;
    public float animationDuration;

    public GameObject effectPrfb;

    public bool selfInflicted;

    protected Fighter emitter;
    protected Fighter receiver;

    protected Queue<string> messages;
    
    void Awake()
    {
        this.messages = new Queue<string>();
    }

    private void Animate()
    {
        var go = Instantiate(this.effectPrfb, receiver.transform.position, Quaternion.identity);
        Destroy(go, this.animationDuration);
    }
    private void Animate2()
    {
        var go = Instantiate(this.effectPrfb, receiver.transform.position, Quaternion.identity);
        Destroy(go, this.animationDuration);
    }
    

    public void Run()
    {
        if (this.selfInflicted)
        {
            this.receiver = this.emitter;
           
        }
            this.Animate();
            this.OnRun(); 
    }
    public void SetEmitterandReceiver(Fighter _emitter, Fighter _receiver)
    {
        this.emitter = _emitter;
        this.receiver = _receiver;
    }

    public string GetNextMessage()
    {
        if (this.messages.Count != 0)
        return this.messages.Dequeue();
        else
        return null;
    }

    protected abstract void OnRun();
}
