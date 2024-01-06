# ToggleSnip

Not much to say.

The Apps only emulate the keyboard to change the SnipingTool settings.

By default the settings is on to autosave all screenshot in the following (default) folder:
      C:\Users\JohnDoe\Pictures\Screenshots

Running the Apps will toggle the settings

The Apps rigth now does not do any checking if SnippingTool is installed and in which directory.


Why?
I cannot find any easy settings to do it any other way.
The settings seem to be store in a Apps registry file which is compressed.
When the Apps his started the registry file seems to embed the username.
Therefore cannot copy it from another account.
The username 'stored' seems to be in cleat text and not UUID or else.
IF I copy the file from one local account to another computer local account with the same name the settings do stick.

the settings are (seem to be) stored in this location
      %LOCALAPPDATA%\Packages\Microsoft.ScreenSketch_8wekyb3d8bbwe\Settings\
the file is called settings.dat

You can open the dat file to make it 'readable' by doing this
RegFileExport.exe settings.dat settings.txt
RegFileExport is from Nirsoft.
Of course some info might be missing like (may be username or else) since you only get the relevant 'keys'

