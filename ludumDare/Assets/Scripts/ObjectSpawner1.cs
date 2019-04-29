using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner1 : MonoBehaviour
{
    public float timer = 1;
    public Slider lifevalue;
    public float objNum;
    public GameObject hochhaus;
    public SphereCollider sc;
    public GameObject fabrik;
    public GameObject einfamilienhaus;
    public GameObject supermarkt;
    public GameObject trees;
    public float hochhaustracker=0;
    public float fabriktracker=0;
    public float einfamilienhaustracker = 0;
    public float supermarkttracker = 0;
    public int maxTrees = 20;
    public int treeTracker = 4;
    public float timer1=6;
    public float timer2 = 1;
    public float life=100;
    public bool holzcheck = true;
    float holz=0;
    float holza;
    public Text holzt;
    public Text holzadd;
   
    #region Singleton

    public static ObjectSpawner1 Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    void Start()
    {
        sc = GetComponent<SphereCollider>();

    }

    private void Update()
    {
        holzt.text = holz.ToString();
        lifevalue.value = life;
        timer -= Time.deltaTime;
        timer2 -= Time.deltaTime;
        if (treeTracker < 0)
        {
            treeTracker = 0;
        }
        if (timer <= 0)
        {
            createTrees();
            timer = 1;
        }

        if (life > 100)
        {
            life = 100;
        }

        timer1 -= Time.deltaTime;

        if (timer1 <= 0)
        {
            life -= 3*hochhaustracker;
            life -= 10 * fabriktracker;
            life -= 3 * einfamilienhaustracker;
            life -= 1.5f * supermarkttracker;
            life += 1* treeTracker;
            timer1 = 6;
            
        }
        if (holzcheck == false)
        {
            holza = Random.Range(5, 20);
            holz += holza;
            holzcheck = true;
            
            holzadd.text = "+" + holza.ToString();
            holzadd.enabled = true;
            timer2 = 1;
        }

        if (timer2 <= 0)
        {
            holzadd.enabled = false;
            
        }
        
        


    }


    public void Hochhaus()
    {

        if (holz >= 600)
        {
            hochhaustracker++;
            Vector3 origin = this.transform.position / 0.5f;

            Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x + 6);


            GameObject newGO = Instantiate(hochhaus, onPlanet, Quaternion.identity) as GameObject;





            newGO.transform.SetParent(this.transform);
            newGO.transform.LookAt(this.transform.position);
            newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(-90, 0, 90);
            holz -= 10;
        }
             
            
            
    }
    public void Fabrik()
    {
        if (holz >= 1200)
        {
            fabriktracker++;
            Vector3 origin = this.transform.position / 0.5f;

            Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x - 2.5f);


            GameObject newGO = Instantiate(fabrik, onPlanet, Quaternion.identity) as GameObject;
            newGO.transform.SetParent(this.transform);
            newGO.transform.LookAt(this.transform.position);
            newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(0, 180, 0);
            holz -= 10;
        }
        
        

    }
    public void Einfamilienhaus()
    {
        if (holz >= 60)
        {

            einfamilienhaustracker++;
            Vector3 origin = this.transform.position / 0.5f;

            Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x );


            GameObject newGO = Instantiate(einfamilienhaus, onPlanet, Quaternion.identity) as GameObject;
            newGO.transform.SetParent(this.transform);
            newGO.transform.LookAt(this.transform.position);
            newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(90, -90, 90);
            holz -= 60;
          
        }
        

    }

    public void Supermarkt()
    {
        if (holz >= 200)
        {
            supermarkttracker++;
            Vector3 origin = this.transform.position / 0.5f;

            Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x  +2);


            GameObject newGO = Instantiate(supermarkt, onPlanet, Quaternion.identity) as GameObject;
            newGO.transform.SetParent(this.transform);
            newGO.transform.LookAt(this.transform.position);
            newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(90, -90, 90);
            holz -= 200;
        }

    }
   

    public void createTrees() {

        if (treeTracker < maxTrees)
        {
            treeTracker++;


            Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x -1);

            GameObject newGO = Instantiate(trees, onPlanet, Quaternion.identity) as GameObject;
            newGO.transform.SetParent(this.transform);
            newGO.transform.LookAt(this.transform.position);
            newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(90, -90, 90);
        }     

    }

    public void respawn(string name)
    {

        if (name.Contains("Hochhaus"))
        {
            Hochhaus();
        }
        if (name.Contains("Fabrik"))
        {
            Fabrik();
        }
        if (name.Contains("Market"))
        {
            Supermarkt();
        }
        if (name.Contains("Family"))
        {
            Einfamilienhaus();
        }

    }

}