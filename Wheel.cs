# dz4
car 4
using System;
using UnityEngine;

public class Wheel : MonoBehaviour
{
   public Transform Model;
   public WheelCollider Collider;
   private float _defaultRotation;

   public void Steer(float angle)
   {
     // Collider.GetWorldPose( out _, out var rotation);
     // Model.rotation = rotation;
     
     Collider.steerAngle = angle;
   }
   public void Torgue(float power)
   {
      Collider.motorTorque = power;
   }

   private void Start()
   {
       _defaultRotation = Model.rotation.eulerAngles.y;
   }

   private void Update()
   {
       Collider.GetWorldPose( out _, out var rotation);
       Model.rotation = rotation;
       Model.Rotate(Vector3.up, _defaultRotation);
   }
}
