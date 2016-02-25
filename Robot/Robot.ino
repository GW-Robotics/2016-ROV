#define ledPin 13
#define button_count 14
#define joystick_axis_count 6

String serialInput;

bool buttonStatuses[button_count];
const int a = 0, b = 1, x = 2, y = 3, select = 4, start = 5, up = 6, down = 7, left = 8, right = 9, leftThumb = 10, rightThumb = 11, leftShoulder = 12, rightShoulder = 13;
float joystickValues[joystick_axis_count];
const int leftX = 0, leftY = 1, rightX = 2, rightY = 3, leftTrigger = 4, rightTrigger = 5;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  pinMode(13, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
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
    
    if (buttonStatuses[a]) {
      digitalWrite(13, HIGH);
    }

    if (buttonStatuses[b]) {
      digitalWrite(ledPin, LOW);
    }
  }
}
