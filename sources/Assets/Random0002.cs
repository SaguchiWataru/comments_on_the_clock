using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random0002 : StateMachineBehaviour 
{
	int hashRandom = Animator.StringToHash("random");

	override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
		animator.SetInteger(hashRandom,  Random.Range (0, 11));
	}
}