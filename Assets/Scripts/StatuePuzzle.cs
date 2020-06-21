using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuePuzzle : MonoBehaviour
{
    GameObject[] goodArray = new GameObject[5];
    GameObject[] actualArray = new GameObject[5];

    public GameObject statue1;
    public GameObject statue2;
    public GameObject statue3;
    public GameObject statue4;
    public GameObject statue5;
    public GameObject orb;

    private int index = 0;

   

    void Start()
    {
        goodArray[0] = statue1;
        goodArray[1] = statue2;
        goodArray[2] = statue3;
        goodArray[3] = statue4;
        goodArray[4] = statue5;

    }




    void Update()
    {

         if (statue1.GetComponent<StatueScript>().isClicked)
         {
            print (index);
             actualArray[index] = statue1;
            
             index++;
            statue1.GetComponent<StatueScript>().isClicked = false;



         }

         if (statue2.GetComponent<StatueScript>().isClicked)
         {
             actualArray[index] = statue2;
             index++;
            statue2.GetComponent<StatueScript>().isClicked = false;

        }

         if (statue3.GetComponent<StatueScript>().isClicked)
         {
             actualArray[index] = statue3;
             index++;
            statue3.GetComponent<StatueScript>().isClicked = false;
        }

         if (statue4.GetComponent<StatueScript>().isClicked)
         {
             actualArray[index] = statue4;
             index++;
            statue4.GetComponent<StatueScript>().isClicked = false;
        }

         if (statue5.GetComponent<StatueScript>().isClicked)
         {
             actualArray[index] = statue5;
             index++;
            statue5.GetComponent<StatueScript>().isClicked = false;
        }


       
        if (actualArray[4] != null)
        {

            if (ArrayCheck())
            {
                print("victory pls");

                Victory();

            }
            else
            {
                print("nonono");
                FindObjectOfType<AudioManager>().Play("StatueFail");
            }

            ResetStatues();
        }


    }

    bool ArrayCheck()
    {
        for (int i = 0; i < goodArray.Length; i++)
        {
            if (goodArray[i] != actualArray[i])
            
                return false;
        }

        return true;
    
    }
    

    void ResetStatues()
    {
       
        index = 0;
        for(int i = 0; i < actualArray.Length; i ++)
        {
            actualArray[i] = null;
        }




    }

    void Victory()
    {
        
        Instantiate(orb, gameObject.GetComponent<Transform>());
        FindObjectOfType<AudioManager>().Play("PuzzleSolve");

    }


}
