
using System;
using UnityEngine;

public class Car :   MonoBehaviour
{ 
        public float RotateMultiplier = 45f;
        public float TorqueMultiplier = 10000f;
        public Wheel[] Wheels;

        private void Update()
        {
            float moveInput = Input.GetAxis("Vertical");
            float rotateInput = Input.GetAxis("Horizontal");
            TurnWheels(rotateInput);
            Move(moveInput);
        }
        

        private void TurnWheels(float rotateInput)
        {
            foreach (var wheel in Wheels)
            {
                wheel.Steer(rotateInput * RotateMultiplier);
            }
        }

        private void Move(float moveInput)
        {
            foreach (var wheel in Wheels)
            {
                wheel.Torgue(moveInput * TorqueMultiplier);
            }
        }
    }
