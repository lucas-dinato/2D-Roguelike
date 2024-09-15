﻿using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

public class PositionTracker : MonoBehaviour {

	[SerializeField] float trackingDelay = 0f;

	List<Vector3> positionsTracked = new List<Vector3>();

	int lastPositionId = -1;

	void Start () {
		InvokeRepeating("track", 0f, trackingDelay);		
	}

	void track() {
		TelemetryNode playerPosition = new TelemetryNode(
			TelemetryNodeType.Atomic,
			"Player Position",
			transform.position
		);

		if(lastPositionId != -1) {
			playerPosition.setLink(lastPositionId);
		}

//		lastPositionId = TelemetryCore.addNode(playerPosition);
	}
}
