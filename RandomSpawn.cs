using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public float SmallTimer = 1f;
    public float BigTimer = 5f;
    public float JumpTimer = 10f;
    public float SlideTimer = 8f;
    public GameObject[] Hazards;
    public Vector3 BoxSpawnValues;
    public Vector3 LBoxSpawnValues;
    public Vector3 JBoxSpawnValues;
    public Vector3 SBoxSpawnValues;

    private float Stime = 1f;
    private float Ltime = 5f;
    private float Jtime = 14f;
    private float Sltime = 8f;

    void Start()
    {

    }


    void FixedUpdate()
    {       

        Stime -= Time.deltaTime;
        if(Stime <= 0)
        {
            Spawn();
            Stime = Random.Range(SmallTimer - .5f, SmallTimer + .5f);
        }

        Ltime -= Time.deltaTime;
        if (Ltime <= 0)
        {
            LSpawn();
            Ltime = Random.Range(BigTimer - 1, BigTimer + 1);
        }

        Jtime -= Time.deltaTime;
        if (Jtime <= 0)
        {
            JSpawn();
            Jtime = Random.Range(JumpTimer - 1, JumpTimer + 1);
        }

        Sltime -= Time.deltaTime;
        if (Sltime <= 0)
        {
            SSpawn();
            Sltime = Random.Range(SlideTimer - 1.5f, SlideTimer + 1.5f);
        }

    }

    void Spawn()
    {
        StartCoroutine(SBox());
    }

    IEnumerator SBox()
    {
        yield return new WaitForSeconds(1f);
        Vector3 spawnPosition = new Vector3(Random.Range(-BoxSpawnValues.x, BoxSpawnValues.x), transform.position.y, transform.position.z);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(Hazards[0], spawnPosition, spawnRotation);
    }

    void LSpawn()
    {
        StartCoroutine(LBox());
    }

    IEnumerator LBox()
    {
        yield return new WaitForSeconds(1f);
        Vector3 spawnPosition = new Vector3(Random.Range(-LBoxSpawnValues.x, LBoxSpawnValues.x), transform.position.y + LBoxSpawnValues.y, transform.position.z + LBoxSpawnValues.z);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(Hazards[1], spawnPosition, spawnRotation);
    }

    void JSpawn()
    {
        StartCoroutine(JBox());
    }

    IEnumerator JBox()
    {
        yield return new WaitForSeconds(1f);
        Vector3 spawnPosition = new Vector3(Random.Range(-JBoxSpawnValues.x, JBoxSpawnValues.x), transform.position.y + JBoxSpawnValues.y, transform.position.z + JBoxSpawnValues.z);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(Hazards[2], spawnPosition, spawnRotation);
    }

    void SSpawn()
    {
        StartCoroutine(SlBox());
    }

    IEnumerator SlBox()
    {
        yield return new WaitForSeconds(1f);
        Vector3 spawnPosition = new Vector3(Random.Range(-SBoxSpawnValues.x, SBoxSpawnValues.x), transform.position.y + SBoxSpawnValues.y, transform.position.z + SBoxSpawnValues.z);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(Hazards[3], spawnPosition, spawnRotation);
    }
}
