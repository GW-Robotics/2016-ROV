#include <Gamepad.h>

#define ledPin 13

Gamepad gamepad = Gamepad();

void setup() {
  // put your setup code here, to run once:
  pinMode(13, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly: 
    if (gamepad.isPressed(gamepad.a)) {
      digitalWrite(13, HIGH);
    }

    if (gamepad.isPressed(gamepad.b)) {
      digitalWrite(ledPin, LOW);
    }
}
