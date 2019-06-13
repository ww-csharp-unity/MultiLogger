#MultiLogger
##A logging tool for Unity

To use this script, copy this script to your project then create a new instance of it in each script you want to log from
  and call the methods.
  
###Methods:
`WriteToLog(string logMessage)`
Call this method and pass a $ formatted string by itself to inject a string that contains other values to log the string to the
  log file on disk.

`WriteToConsole(string optionalMessage = "", int optionalInt = -400, float optionalFloat = -400)`
Call this method and pass the optional values to log those values to the console.
