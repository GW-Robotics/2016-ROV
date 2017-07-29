//Written by Jeremey Waldron

#include <Servo.h>

// Creates motors for example:  FRMMotor is Front Right Middle Motor
Servo FRMotor, FLMotor,FRMMotor, FLMMotor, BRMotor, BLMotor, BRMMotor, BLMMotor;


// Sending signals to servos:
// 90 is no servo movement (mid-point)
// 0 is full speed forward
// 180 is full speed backward
int FRMotor_speed = 90;//none
int FLMotor_speed = 90;
int FRMMotor_speed = 90;
int FLMMotor_speed = 90;
int BRMotor_speed = 90;
int BLMotor_speed = 90;
int BLMMotor_speed = 90;
int BRMMotor_speed = 90;

//commands and keyboard bindings
//gives all commands to be able to "fly" the ROV
#define MOVE_FORWARD 'w'
#define MOVE_BACK 's'
#define STRAFE_LEFT 'd'
#define STRAFE_RIGHT 'a'
#define YAW_LEFT 'x'
#define YAW_RIGHT 'z'
#define ROLL_LEFT 'q'
#define ROLL_RIGHT 'e'
#define PITCH_UP 'i'
#define PITCH_DOWN 'k'
#define MOVE_DOWN '1'
#define MOVE_UP '2'
#define FULL_STOP  'j'


void setup() {
  Serial.begin(9600); 
  // Attach the servos on Arduino PWM pin 3 and PWM pin 5
  FRMotor.attach(13);
  FLMotor.attach(12);
  FRMMotor.attach(11);
  FLMMotor.attach(10);
  BRMMotor.attach(9);
  BLMMotor.attach(8);
  BRMotor.attach(7);
  BLMotor.attach(6);

 //makes motors start at full stop
  FRMotor.write(90);//good
  FLMotor.write(90);//good
  FRMMotor.write(90);//good
  FLMMotor.write(90);
  BRMotor.write(90);//good
  BLMotor.write(90);//good
  BRMMotor.write(90);//good
  BLMMotor.write(90);
}

void loop(){
  char byte = 0;
  // press p to cancel and exit
  while (byte != 'p') {
    Serial.readBytes(&byte, 1);
    // press w to move forward
    if (byte == MOVE_FORWARD) {
      
      FRMotor_speed = FRMotor.read();
      FRMotor_speed += 5;  
      FRMotor.write(FRMotor_speed); 

      FLMotor_speed = FLMotor.read();
      FLMotor_speed += 5;  // Increase speed by 5
      FLMotor.write(FLMotor_speed);
      Serial.print("move forward \n");
      byte = 0;
    }
    if (byte == MOVE_BACK) {
      
      BRMotor_speed = BRMotor.read();
      BRMotor_speed += 5;  
      BRMotor.write(BRMotor_speed); 

      BLMotor_speed = BLMotor.read();
      BLMotor_speed += 5;  // Increase speed by 5
      BLMotor.write(BLMotor_speed);
      Serial.print("move back \n");
      byte = 0;
    }
    if (byte == STRAFE_RIGHT) {
      
      FRMotor_speed = FRMotor.read();
      FRMotor_speed += 5;  
      FRMotor.write(FRMotor_speed); 

      BRMotor_speed = BRMotor.read();
      BRMotor_speed += 5;  // Increase speed by 5
      BRMotor.write(BRMotor_speed);
      Serial.print("strafe left \n");
      byte = 0;
    }
    if (byte == STRAFE_LEFT) {
      
      FLMotor_speed = FLMotor.read();
      FLMotor_speed += 5;  
      FLMotor.write(FLMotor_speed); 

      BLMotor_speed = BLMotor.read();
      BLMotor_speed += 5;  // Increase speed by 5
      BLMotor.write(BLMotor_speed);
      Serial.print("strafe right \n");
      byte = 0;
    }
    
     if (byte == YAW_LEFT) {
      
      FLMotor_speed = FLMotor.read();
      FLMotor_speed += 5;  
      FLMotor.write(FLMotor_speed); 

      BRMotor_speed = BRMotor.read();
      BRMotor_speed += 5;  // Increase speed by 5
      BRMotor.write(BRMotor_speed);
      Serial.print("yaw left \n");
      byte = 0;
    }
     if (byte == YAW_RIGHT) {
      
      FRMotor_speed = FRMotor.read();
      FRMotor_speed += 5;  
      FRMotor.write(FRMotor_speed); 

      BLMotor_speed = BLMotor.read();
      BLMotor_speed += 5;  // Increase speed by 5
      BLMotor.write(BLMotor_speed);
      Serial.print("yaw right \n");
      byte = 0;
  }
  if (byte == ROLL_RIGHT) {
      
      FLMMotor_speed = FLMMotor.read();
      FLMMotor_speed += 5;  
      FLMMotor.write(FLMMotor_speed); 

      BLMMotor_speed = BLMMotor.read();
      BLMMotor_speed += 5;  // Increase speed by 5
      BLMMotor.write(BLMMotor_speed);
      Serial.print("roll right \n");
      byte = 0;
  }
  if (byte == ROLL_LEFT) {
      
      FRMMotor_speed = FRMMotor.read();
      FRMMotor_speed += 5;  
      FRMMotor.write(FRMMotor_speed); 

      BRMMotor_speed = BRMMotor.read();
      BRMMotor_speed += 5;  // Increase speed by 5
      BRMMotor.write(BRMMotor_speed);
      Serial.print("roll left \n");
      byte = 0;
  }
    if (byte == PITCH_UP) {
      
      FRMMotor_speed = FRMMotor.read();
      FRMMotor_speed += 5;  
      FRMMotor.write(FRMMotor_speed); 

      FLMMotor_speed = FLMMotor.read();
      FLMMotor_speed += 5;  
      FLMMotor.write(FLMMotor_speed); 
      Serial.print("pitch up \n");
      byte = 0;
  }
  if (byte == PITCH_DOWN) {
      
      BRMMotor_speed = BRMMotor.read();
      BRMMotor_speed += 5;  // Increase speed by 5
      BRMMotor.write(BRMMotor_speed);

      BLMMotor_speed = BLMMotor.read();
      BLMMotor_speed += 5;  // Increase speed by 5
      BLMMotor.write(BLMMotor_speed);
      Serial.print("pitch down \n");
      byte = 0;
  }
    if (byte == MOVE_DOWN) {
      
      BRMMotor_speed = BRMMotor.read();
      BRMMotor_speed -= 5;  // Increase speed by 5
      BRMMotor.write(BRMMotor_speed);

      BLMMotor_speed = BLMMotor.read();
      BLMMotor_speed -= 5;  // Increase speed by 5
      BLMMotor.write(BLMMotor_speed);
      
      FRMMotor_speed = FRMMotor.read();
      FRMMotor_speed -= 5;  
      FRMMotor.write(FRMMotor_speed); 

      FLMMotor_speed = FLMMotor.read();
      FLMMotor_speed -= 5;  
      FLMMotor.write(FLMMotor_speed); 
      Serial.print("move down \n");
      byte = 0;
  }
      if (byte == MOVE_UP) {
      
      BRMMotor_speed = BRMMotor.read();
      BRMMotor_speed += 5;  // Increase speed by 5
      BRMMotor.write(BRMMotor_speed);

      BLMMotor_speed = BLMMotor.read();
      BLMMotor_speed += 5;  // Increase speed by 5
      BLMMotor.write(BLMMotor_speed);
      
      FRMMotor_speed = FRMMotor.read();
      FRMMotor_speed += 5;  
      FRMMotor.write(FRMMotor_speed); 

      FLMMotor_speed = FLMMotor.read();
      FLMMotor_speed += 5;  
      FLMMotor.write(FLMMotor_speed); 
      Serial.print("move up \n");
      byte = 0;
  }

  if (byte == FULL_STOP) {
  
      FRMotor.write(90);
      FLMotor.write(90);
      FRMMotor.write(90);
      FLMMotor.write(90);
      BRMotor.write(90);//
      BLMotor.write(90);
      BRMMotor.write(90);
      BLMMotor.write(90);

      Serial.print("full stop");
      byte = 0;
  }
  Serial.print("Done \n");

}
}
