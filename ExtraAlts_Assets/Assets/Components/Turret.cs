﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Turret : MonoBehaviour
{
    public bool stationary;
    public Color defaultLightsColor;
    public Color attackingLightsColor;

    [Header("Defaults")]
    [SerializeField] Transform torso;
    [SerializeField] Transform turret;
    [SerializeField] Transform shootPoint;
    [SerializeField] LineRenderer aimLine;
    [SerializeField] RevolverBeam beam;
    [SerializeField] GameObject warningFlash;
    [SerializeField] ParticleSystem antennaFlash;
    [SerializeField] Light antennaLight;
    [SerializeField] AudioSource antennaSound;
    [SerializeField] Animator anim;
    [SerializeField] Machine mach;
    [SerializeField] EnemyIdentifier eid;
    [SerializeField] GameObject head;
    [SerializeField] NavMeshAgent nma;
    public GameObject antenna;
    public List<Transform> interruptables = new List<Transform>();

    [SerializeField] AudioSource interruptSound;
    [SerializeField] AudioSource cancelSound;
    [SerializeField] AudioSource footStep;
    [SerializeField] AudioSource extendSound;
    [SerializeField] AudioSource thunkSound;
    [SerializeField] AudioSource kickWarningSound;
    [SerializeField] AudioSource aimWarningSound;

    [SerializeField] GameObject rubble;
    [SerializeField] GameObject rubbleLeft;
    [SerializeField] GameObject rubbleRight;

    [SerializeField] SkinnedMeshRenderer smr;
    [SerializeField] GameObject unparryableFlash;
    [SerializeField] SwingCheck2 sc;
    [SerializeField] TrailRenderer tr;

    private void Update() { }

    public void CancelAim(bool instant = false) { }

    public void LodgeFoot(int type) { }

    public void UnlodgeFoot(int type) { }

    public void Unlodge() { }

    public void Interrupt() { }

    public void OnDeath() { }

    public void UnparryableFlash() { }
    
    public void DamageStart() { }

    public void DamageStop() { }

    public void ChangeLightsColor(Color target) { }

    public void ChangeLightsIntensity(float amount) { }
}
