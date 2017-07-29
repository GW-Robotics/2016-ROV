/*
	Gamepad.h - Arduino library for reading gamepad input from a PC.
	Created by Nam N. Tran, 2/25/2016
	Last Updated on 2/25/2016
	Released into the public domain under an MIT License
 */

#ifndef Gamepad_h
#define Gamepad_h

#include "Arduino.h"

#define button_count 14
#define joystick_axis_count 6

class Gamepad {
	public:
		Gamepad();
		bool isPressed(int button);
		float getJoystickValue(int axis);
		void readStream();
		bool hasSerial();
		const static int a        =0;
		const static int b        = 1;
		const static int x        = 2;
		const static int y        = 3;
		const static int select     = 4;
		const static int start      = 5;
		const static int up       = 6;
		const static int down       = 7;
		const static int left       = 8;
		const static int right      = 9;
		const static int leftThumb    = 10;
		const static int rightThumb   = 11;
		const static int leftShoulder   = 12;
		const static int rightShoulder  = 13;
		const static int leftX      = 0;
		const static int leftY      = 1;
		const static int rightX     = 2;
		const static int rightY     = 3;
		const static int leftTrigger  = 4;
		const static int rightTrigger   = 5;
	private:
		bool buttonStatuses[button_count];
		float joystickValues[joystick_axis_count];
		
		String serialInput;
};

#endif
