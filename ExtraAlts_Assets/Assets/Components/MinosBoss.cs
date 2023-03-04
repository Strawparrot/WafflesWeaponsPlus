using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MinosBoss : MonoBehaviour
{

    public Transform head;
    public int phase = 1;

    public Transform rightArm;
    public Transform rightHand;

    public Transform leftArm;
    public Transform leftHand;

    public GameObject windupSound;
    public GameObject bigHurtSound;
    public GameObject punchExplosion;

    public bool onRight;
    public bool onMiddle;
    public bool onLeft;
    public GameObject blackHole;
    public Transform blackHoleSpawnPos;

    public GameObject[] eyes;
    public Material eyeless;

    public GameObject[] parasites;

    public UnityEvent onDeathImpact;
    public UnityEvent onDeathOver;
    public bool parryChallenge;

    public void SwingStart()
{}
    public void SpecialDeath()
{}
    public void Impact()
{}
    public void DeathOver()
{}
    public void SwingEnd()
{}
    public void SpawnBlackHole()
{}
    public void LaunchBlackHole()
{}
    public void GotParried()
{}
    public void ResetColliders()
{}
    public void StopAction()
{}
    public void PlayerInZone(int zone)
{}
    public void PlayerExitZone(int zone)
{}
    public void ShutEye(int eye)
{}
    public void SpawnParasites()
{}
    public void PlayerBeenHit()
{}}
