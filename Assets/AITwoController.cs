using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AITwoController : MonoBehaviour
{

	public Transform Player;
	int MoveSpeed = 15;
	int MaxDist = 30;
	int MinDist = 1;




	void Start()
	{

	}

	void Update()
	{
		transform.LookAt(Player);

		if (Vector3.Distance(transform.position, Player.position) >= MinDist)
		{

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;



			if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
			{

			}

		}
	}
}
