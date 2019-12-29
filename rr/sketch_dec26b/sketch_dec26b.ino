#include <RH_ASK.h>
#include <SPI.h> // Not actualy used but needed to compile

RH_ASK driver;

void setup()
{
    Serial.begin(9600);  // Debugging only
    if (!driver.init())
         Serial.println("init failed");
}

void loop() {
  uint8_t buf[4];
  uint8_t buflen = sizeof(buf);
  int value;

  if (driver.recv(buf, &buflen)) {
    driver.printBuffer("Received:", buf, buflen); //prints 1.
    value = value = buf[0]; //my attempt to cast
    Serial.println(value); // the output is 2233, so this is wrong.
 
  }
}
