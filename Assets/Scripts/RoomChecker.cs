using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChecker : MonoBehaviour
{

    bool Room1check = true;
    bool Room2check = true;
    bool Room3check = true;
    bool Room4check = true;
    bool Room5check = true;

    int Roomcount = 0;

    public GameObject Finaleroom;



    // Start is called before the first frame update
    void Start()
    {
        Finaleroom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Roomcount >= 6 && Room1check == false && Room2check == false && Room3check == false && Room4check == false && Room5check == false)
        {
            Finaleroom.SetActive(true);
        
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Room 1")
        {
            Room1check = false;
            Roomcount++;
        }
        else if (other.gameObject.tag == "Room 2")
        {
            Room2check = false;
            Roomcount++;
        }
        else if (other.gameObject.tag == "Room 3")
        {
            Room3check = false;
            Roomcount++;
        }
        else if (other.gameObject.tag == "Room 4")
        {
            Room4check = false;
            Roomcount++;
        }
        else if (other.gameObject.tag == "Room 5")
        {
            Room5check = false;
            Roomcount++;
        }

    }
    
    

    

    




}
