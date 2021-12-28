using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private Camera _camera;
	[SerializeField] private NavMeshAgent _navMeshAgent;

	private void Start()
	{
		_camera = Camera.main;
		_navMeshAgent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out RaycastHit hit))
			{
				_navMeshAgent.SetDestination(hit.point);
			}
		}
	}
}
