#include <RH_ASK.h>
#include <SPI.h> // Not actually used but needed to compile

RH_ASK driver;
    uint8_t *data;
    uint8_t sensorValue;
void setup()
{
    Serial.begin(9600);  // Debugging only
     
    if (!driver.init())
         Serial.println("init failed");
}

void loop()
{
    sensorValue = analogRead(A0);
    Serial.println(sensorValue);
    data = &sensorValue;
    driver.send(data, sizeof(sensorValue));
    driver.waitPacketSent();
    }
