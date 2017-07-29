/*
	Gamepad.cpp - Arduino library for reading gamepad input from a PC.
	Created by Nam N. Tran, 2/25/2016
	Last Updated on 2/25/2016
	Released into the public domain under an MIT License
 */
 
 #include "Arduino.h"
 #include "Gamepad.h"
 
 Gamepad::Gamepad() {
	Serial.begin(9600);
 }
 
 bool Gamepad::isPressed(int button) {
	return buttonStatuses[button];
 }
 
 bool Gamepad::hasSerial() {
	 return Serial.available() > 0;
 }
 
 float Gamepad::getJoystickValue(int axis) {
	return joystickValues[axis];
 }
 
 void Gamepad::readStream() {
	if (Serial.available() > 0) {
		serialInput = Serial.readStringUntil('<');

		if (serialInput.charAt(0) == '!') {
		    switch(serialInput.charAt(1)) {
				case '0':
					buttonStatuses[a] = (serialInput.substring(3) == "True");
					break;
				case '1':
					switch(serialInput.charAt(2)) {
						case '0':
							buttonStatuses[leftThumb] = (serialInput.substring(3) == "True");
							break;
						case '1':
							buttonStatuses[rightThumb] = (serialInput.substring(3) == "True");
							break;
						case '2':
							buttonStatuses[leftShoulder] = (serialInput.substring(3) == "True");
							break;
						case '3':
							buttonStatuses[rightShoulder] = (serialInput.substring(3) == "True");
							break;
						case ':':
							buttonStatuses[b] = (serialInput.substring(3) == "True");
							break;
						default:
							break;
					}
				break;
			  case '2':
					buttonStatuses[x] = (serialInput.substring(3) == "True");
					break;
			  case '3':
					buttonStatuses[y] = (serialInput.substring(3) == "True");
					break;
			  case '4':
					buttonStatuses[select] = (serialInput.substring(3) == "True");
					break;
			  case '5':
					buttonStatuses[start] = (serialInput.substring(3) == "True");
					break;
			  case '6':
					buttonStatuses[up] = (serialInput.substring(3) == "True");
					break;
			  case '7':
					buttonStatuses[down] = (serialInput.substring(3) == "True");
					break;
			  case '8':
					buttonStatuses[left] = (serialInput.substring(3) == "True");
					break;
			  case '9':
					buttonStatuses[right] = (serialInput.substring(3) == "True");
					break;
			  default:
				  break;
			}
		} else if (serialInput.charAt(0) == '#') {
			switch(serialInput.charAt(1)) {
				case '0':
					joystickValues[leftX] = serialInput.substring(3).toFloat();
					break;
				case '1':
					joystickValues[leftY] = serialInput.substring(3).toFloat();
					break;
				case '2':
					joystickValues[rightX] = serialInput.substring(3).toFloat();
					break;
				case '3':
					joystickValues[rightY] = serialInput.substring(3).toFloat();
					break;
				case '4':
					joystickValues[leftTrigger] = serialInput.substring(3).toFloat();
					break;
				case '5':
					joystickValues[rightTrigger] = serialInput.substring(3).toFloat();
					break;
				default:
					break;
			}
		} else {
			// Unknown input
		}
	}
}
