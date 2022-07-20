using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactable : MonoBehaviour
{
    

    [SerializeField] private GameObject prefabInstance;
    [SerializeField] private GameObject btnCreateGroupInstance;
    private GameObject resName;
    // Start is called before the first frame update
    public void Selected()
    {
        
        var res = prefabInstance.transform.Find("indicator").gameObject;
        var isEnabled = res.GetComponent<MeshRenderer>().enabled;
        var material = res.GetComponent<Renderer>();
        Color orange = new Color(1.0f, 0.64f, 0.0f);


        
        //resName = res.transform.Find("avNameCanvas/avName").gameObject;
        //resName.GetComponent<TextMeshProUGUI>().text = Globals.groupUsers[c].ToString();


        if (isEnabled)
        {
            res.GetComponent<MeshRenderer>().enabled = false;
            Globals.numSelected -= 1;            
        } else
        {
            res.GetComponent<MeshRenderer>().enabled = true;
            Globals.numSelected += 1;
            /*material.material.SetColor("_Color" +
                "", Color.yellow);*/
        }


        //Globals.selectedUsers[Globals.selectedUsers.Length] = "SHE IS CRAZY";

    }

    public void ClickButtonCreateGroup()
    {
        var res = prefabInstance.transform.Find("indicator").gameObject;
        //Debug.Log(Globals.selectedUsers[0]);
        //var selected=res.GetComponents<MeshRenderer>().
        //Debug.Log("I CLICKED THE BUTTON");
    }
}
