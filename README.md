<h1>MultiLogger</h1>
<h3>A logging tool for Unity</h3>
To use this script, copy this script to your project and place it on any object that will be live throughout the entire game. Then just call the methods as they are static. <b>This may require a singleton.</b>

IE:
`Logger.WriteToLog("test test");`
  
<h3>Methods:</h3>

`WriteToLog(string logMessage)`
Call this method and pass a $ formatted string by itself to inject a string that contains other values to log the string to the
  log file on disk.


`WriteToConsole(string optionalMessage = "", int optionalInt = -400, float optionalFloat = -400)`
Call this method and pass the optional values to log those values to the console.
