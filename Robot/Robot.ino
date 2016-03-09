#include <Servo.h>
#include <ESC.h>
#include <Gamepad.h>

#define escFrontLeft  2
#define escFrontRight 3
#define escBackLeft   4
#define escBackRight  5
#define ledPin        13

ESC frontLeft = ESC(escFrontLeft), frontRight = ESC(escFrontRight), backLeft = ESC(escBackLeft), backRight = ESC(escBackRight);
Gamepad gamepad;

void setup() {
  // put your setup code here, to run once:
  gamepad = Gamepad();
  pinMode(13, OUTPUT);
}

void loop() {
  gamepad.readStream();
  // put your main code here, to run repeatedly: 
    if (gamepad.isPressed(gamepad.a)) {
      digitalWrite(13, HIGH);
    }

    if (gamepad.isPressed(gamepad.b)) {
      digitalWrite(ledPin, LOW);
    }
}
