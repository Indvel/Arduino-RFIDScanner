# Arduino-RFIDScanner
It shows RFID info using RC522 sensor in Arduino.

You should send data with patterns like this:<br>
RFID Info : <b>"{UID}/{SAK}/{PICC_Type}"</b> <=== "/" is separator<br>
Firmware Version : <b>"{version}-{HexValue}"</b> <=== "-" is separator<br>

아두이노에서 RC522 센서를 이용한 RFID 정보를 보여줍니다.

<img src="/rfidScanner.png">

Translating for non-Koreans:<br>

포트스캔 : Scan SerialPorts<br>
연결 : Connect<br>
연결해제 : Disconnect<br>
가져오기 : Get sensor firmware version<br>
