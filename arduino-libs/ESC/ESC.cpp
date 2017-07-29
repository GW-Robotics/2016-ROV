/*
	ESC.cpp - Arduino library for controlling a brushless motor with an ESC.
	Created by Nam N. Tran, 2/25/2016
	Last Updated on 2/25/2016
	Released into the public domain under an MIT License
 */
 
 #include "Arduino.h"
 #include "ESC.h"
 
 ESC::ESC(int signalPin) {
	esc.attach(signalPin);
 }
 
void  ESC::runForTime(int millisecs) {
	 esc.writeMicroseconds(millisecs);
 }
 
 void ESC::setSpeed(float speed) {
	 esc.write((int)(speed * 90) + 90);
 }
