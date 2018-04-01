﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectiveManager : MonoBehaviour {

    public mainObjectivesList mainList;

	void Start ()
    {
        objective parent = new objective("test", "This is objective 1", 0, null, null);
        objective child = new objective("test2", "This is nested objective 1", 0, null, null);
        objective child2 = new objective("test3", "This is nested objective 2", 0.5f, "fuckoff", null);
        objective grandChild1 = new objective("grandChildof11", "this is a grandchild objective", 0, null, null);
        objective grandChild2 = new objective("grandChildof11", "this is a grandchild objective 2", 0, null, null);
        objective grandGrandChild = new objective("child of 112", "dbdbdb", 0, null, null);
        mainList = new mainObjectivesList();

        parent.MakeChild(child);
        parent.MakeChild(child2);
        parent.PrintContents();
        parent.GetChild(0).PrintContents();
        parent.GetChild(1).PrintContents();

        parent.GetChild(0).MakeChild(grandChild1).PrintContents();
        parent.GetChild(0).MakeChild(grandChild2).PrintContents();

        parent.GetChild(0).GetChild(0).PrintContents();
        parent.GetChildWithSerial(112).MakeChild(grandGrandChild);
        parent.GetChildWithSerial(1121).PrintContents();

        mainList.AddTree(parent);
        mainList.Delete(1121);

        //mainList.GetObjectiveWithSerial(1121).PrintContents(); --> now fails
	}
}
