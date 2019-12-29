
#include <TEA5767N.h>  //https://github.com/mroger/TEA5767
#include <LCD5110_Graph.h> //http://www.rinkydinkelectronics.com/library.php?id=48
#include <RH_ASK.h>
#include <SPI.h> // Not actualy used but needed to compile
LCD5110 lcd(8,9,10,6,5);
TEA5767N radio = TEA5767N();
RH_ASK driver;

extern unsigned char BigNumbers[];
extern unsigned char TinyFont[];

extern uint8_t splash[];
extern uint8_t signal5[];
extern uint8_t signal4[];
extern uint8_t signal3[];
extern uint8_t signal2[];
extern uint8_t signal1[];

int analogPin = 0;
int val = 0; 
int p=0;
int frequencyInt = 0;
float frequency = 0;
float previousFrequency = 0;
int signalStrength = 0;
int led = 0;
  uint8_t buf[4];
  uint8_t buflen = sizeof(buf);
  int myf=0;
void setup() 
{
  if (!driver.init())
      Serial.println("init failed");
  radio.setMonoReception();
  radio.setStereoNoiseCancellingOn();
  initScreen();
  printStereo();
  pinMode(7, INPUT);
  Serial.begin(9600);
}
 
void loop() {


  if(digitalRead(7)== LOW){
  if (driver.recv(buf, &buflen)) {
   // driver.printBuffer("Received:", buf, buflen); //prints 1.
    val = val + buf[0]; //my attempt to cast
    p=buf[0];
    // the output is 2233, so this is wrong.
   
  }else{
     val = val + p; //my attempt to cast
  }
  //   val = analogRead(analogPin); 
    // Serial.println(val);
  
   
  val = val/10;
   
  frequencyInt =  map(val, 0, 25, 8700, 9700);  //Analog value to frequency from 87.0 MHz to 107.00 MHz
  }else{
    frequencyInt=9150;

  }
  Serial.println(val);
    Serial.println(frequencyInt);
  float frequency = frequencyInt/100.0f;
  if(frequency - previousFrequency >= 0.1f || previousFrequency - frequency >= 0.1f)
  {
    lcd.clrScr();
    radio.selectFrequency(frequency);
    
  
    printFrequency(frequency);
    previousFrequency = frequency;    
  }
  
  lcd.clrScr();
 
  
  printFrequency(frequency);
  delay(1000); 
  val = 0;  
 
}

void initScreen()
{
  lcd.InitLCD();
  lcd.setFont(BigNumbers);
  lcd.clrScr();
}



void printFrequency(float frequency)
{
  String frequencyString = String(frequency,1);
  if(frequencyString.length() == 4)
  {
    lcd.setFont(BigNumbers);
    lcd.print(frequencyString,14,12);
    lcd.update();
  }
  else
  {
    lcd.setFont(BigNumbers);
    lcd.print(frequencyString,0,12);
    lcd.update();
  }
}
void printStereo()
{
      lcd.setFont(TinyFont);
      lcd.print("Sudo music",15,2);
}
void printStereof()
{
      lcd.setFont(TinyFont);
      lcd.print("favorite",15,2);
}
