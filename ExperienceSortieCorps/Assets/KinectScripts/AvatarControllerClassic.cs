using UnityEngine;
//using Windows.Kinect;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System.Text; 

public class AvatarControllerClassic : AvatarController
{	

	// Public variables that will get matched to bones. If empty, the Kinect will simply not track it.
	public Transform HipCenter;
	public Transform Spine;
	public Transform ShoulderCenter;
	public Transform Neck;
//	public Transform Head;

	public Transform ClavicleLeft;
	public Transform ShoulderLeft;
	public Transform ElbowLeft; 
	public Transform HandLeft;
	public Transform FingersLeft;
//	private Transform FingerTipsLeft = null;
//	private Transform ThumbLeft = null;

	public Transform ClavicleRight;
	public Transform ShoulderRight;
	public Transform ElbowRight;
	public Transform HandRight;
	public Transform FingersRight;
//	private Transform FingerTipsRight = null;
//	private Transform ThumbRight = null;
	
	public Transform HipLeft;
	public Transform KneeLeft;
	public Transform FootLeft;
//	private Transform ToesLeft = null;
	
	public Transform HipRight;
	public Transform KneeRight;
	public Transform FootRight;
//	private Transform ToesRight = null;
	
	public Transform BodyRoot;
	public GameObject OffsetNode;
	

	// If the bones to be mapped have been declared, map that bone to the model.
	protected override void MapBones()
	{
		bones[0] = HipCenter;
		bones[1] = Spine;
		bones[2] = ShoulderCenter;
		bones[3] = Neck;
//		bones[4] = Head;
	
		bones[5] = ShoulderLeft;
		bones[6] = ElbowLeft;
		bones[7] = HandLeft;
		bones[8] = FingersLeft;
//		bones[9] = FingerTipsLeft;
//		bones[10] = ThumbLeft;
	
		bones[11] = ShoulderRight;
		bones[12] = ElbowRight;
		bones[13] = HandRight;
		bones[14] = FingersRight;
//		bones[15] = FingerTipsRight;
//		bones[16] = ThumbRight;
	
		bones[17] = HipLeft;
		bones[18] = KneeLeft;
		bones[19] = FootLeft;
//		bones[20] = ToesLeft;
	
		bones[21] = HipRight;
		bones[22] = KneeRight;
		bones[23] = FootRight;
//		bones[24] = ToesRight;

		// special bones
		bones[25] = ClavicleLeft;
		bones[26] = ClavicleRight;
		
		// body root and offset
		bodyRoot = BodyRoot;
		offsetNode = OffsetNode;

		if(offsetNode == null)
		{
			offsetNode = new GameObject(name + "Ctrl") { layer = transform.gameObject.layer, tag = transform.gameObject.tag };
			offsetNode.transform.position = transform.position;
			offsetNode.transform.rotation = transform.rotation;
			offsetNode.transform.parent = transform.parent;
			
			transform.parent = offsetNode.transform;
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
		}

//		if(bodyRoot == null)
//		{
//			bodyRoot = transform;
//		}
	}
	// Use this for initialization
	void Start () {
		//gameObject.transform.position = new Vector3 (gameObject.transform.position.x - 3.5f, gameObject.transform.position.y, gameObject.transform.position.z - 2.0f);
		//gameObject.transform.position.x = gameObject.transform.position.x - 3.5f;
		//gameObject.transform.position.z = gameObject.transform.position.z - 2.0f;
	}
	
}

