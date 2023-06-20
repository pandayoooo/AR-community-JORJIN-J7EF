using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class pinned_refresh : MonoBehaviour
{
    public Text pin;
    public btn_flip FL;
    public btn_flip FR;
    public GameObject[] paintnow;   
    public Text getf;
    public string p;
    // Start is called before the first frame update
    void Start()
    {
        globall.paintname="";
        pin=(GameObject.Find("pin_text")).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() 
    {
        p=globall.paintname;
        Debug.Log(p);
        if(p != "")
        {            
            switch (p)
            {
                case "paint_cafe":
                    paintnow = GameObject.FindGameObjectsWithTag("cafe");
                    FR.max=6;
                    FL.max=6;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_selfie":
                    paintnow = GameObject.FindGameObjectsWithTag("selfie");
                    FR.max=2;
                    FL.max=2;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_flower":
                    paintnow = GameObject.FindGameObjectsWithTag("flower");
                    FR.max=3;
                    FL.max=3;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_irises":
                    paintnow = GameObject.FindGameObjectsWithTag("irises");
                    FR.max=6;
                    FL.max=6;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_potato":
                    paintnow = GameObject.FindGameObjectsWithTag("potato");
                    FR.max=3;
                    FL.max=3;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_blossom":
                    paintnow = GameObject.FindGameObjectsWithTag("blossom");
                    FR.max=5;
                    FL.max=5;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_church":
                    paintnow = GameObject.FindGameObjectsWithTag("church");
                    FR.max=7;
                    FL.max=7;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_wheatfield":
                    paintnow = GameObject.FindGameObjectsWithTag("wheatfield");
                    FR.max=8;
                    FL.max=8;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_treeroots":
                    paintnow = GameObject.FindGameObjectsWithTag("treeroots");
                    FR.max=2;
                    FL.max=2;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_starrynight":
                    paintnow = GameObject.FindGameObjectsWithTag("starrynight");
                    FR.max=7;
                    FL.max=7;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                case "paint_bandaged":
                    paintnow = GameObject.FindGameObjectsWithTag("bandaged");
                    FR.max=6;
                    FL.max=6;
                    foreach(GameObject g in paintnow)
                    {
                        if(g.name =="descr_text")
                        {
                            getf=g.GetComponent<Text>();                        
                        }
                    }
                    break;
                default:
                    break;
            }
        refresh(getf,pin);
        }
    }
    public void refresh(Text getfrom,Text segetfo)
    {
        segetfo.text=getfrom.text;
    }
}
