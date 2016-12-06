using UnityEngine;
using System.Collections;
using VRTK;

public class SequenceChanger : MonoBehaviour {

    public Sequencer seq;
    public string button;
    public bool toggle;
    public bool highlighted;
    public int index;
    private MeshRenderer col;
    private GameObject controller;
    private VRTK_SimplePointer simplePointer;
    public Material mat1; // activated
    public Material mat2; // deactivated
    public Material mat3; // glow blue when highlited by raycast
    public Material mat4; // glow blue green if active AND highlighted by raycast

    // Use this for initialization
    void Start () {
        col = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {


        seq.sequence[index] = toggle;

        if(Input.GetKeyDown(button)){
            toggle = !toggle;
        }
        if (toggle){
            col.material = mat1;
        }
        else{
            col.material = mat2;
        }           
    }
}
