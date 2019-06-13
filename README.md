<h1>MultiLogger</h1>
<h3>A logging tool for Unity</h3>
To use this script, copy this script to your project then create a new instance of it in each script you want to log from
  and call the methods.
  
<h3>Methods:</h3>

`WriteToLog(string logMessage)`
Call this method and pass a $ formatted string by itself to inject a string that contains other values to log the string to the
  log file on disk.
<br>
`WriteToConsole(string optionalMessage = "", int optionalInt = -400, float optionalFloat = -400)`
Call this method and pass the optional values to log those values to the console.
