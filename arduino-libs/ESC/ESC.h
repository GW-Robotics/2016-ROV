/*
	ESC.h - Arduino library for controlling a brushless motor with an ESC.
	Created by Nam N. Tran, 2/25/2016
	Last Updated on 2/25/2016
	Released into the public domain under an MIT License
 */

#ifndef ESC_h
#define ESC_h

#include "Arduino.h"
#include "Servo.h"

class ESC {
	public:
		ESC(int signalPin);
		void runForTime(int millisecs);
		void setSpeed(float speed);
	private:
		int speed;
		Servo esc;
};

#endif
