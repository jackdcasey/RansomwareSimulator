# ✨✨✨ RansomwareSimulator ✨✨✨
A cross-platform tool for testing ransomware protection

```
    ____
   / __ \ ____ _ ____   _____ ____   ____ ___  _      __ ____ _ _____ ___
  / /_/ // __ `// __ \ / ___// __ \ / __ `__ \| | /| / // __ `// ___// _ \
 / _, _// /_/ // / / /(__  )/ /_/ // / / / / /| |/ |/ // /_/ // /   /  __/
/_/ |_| \__,_//_/ /_//____/ \____//_/ /_/ /_/ |__/|__/ \__,_//_/    \___/
   _____  _                    __        __
  / ___/ (_)____ ___   __  __ / /____ _ / /_ ____   _____
  \__ \ / // __ `__ \ / / / // // __ `// __// __ \ / ___/
 ___/ // // / / / / // /_/ // // /_/ // /_ / /_/ // /
/____//_//_/ /_/ /_/ \__,_//_/ \__,_/ \__/ \____//_/


Please select an option:

1: Run simulation
2: Clean up old simulations
3: Exit

```

# Build & Run Instructions

Ensure [.net core framework](https://dotnet.microsoft.com/download/dotnet-core/3.1) is installed  

Run the following commands on Windows, macOS or Linux:
```
git clone https://github.com/jackdcasey/RansomwareSimulator.git
cd RansomwareSimulator
dotnet run
```
# How To Use
After starting you should have 3 options:

1. **Run simulation** *Start a simulation*
2. **Clean up old simulations** *Clean up any remaining files and directories from previous simulations*
3. **Exit** *Exit the tool*

# Output Example

Here's an example of an Anti-Virus program stopping the encryption:
```
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0001.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0002.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0003.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0004.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0005.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0006.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0007.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0008.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0009.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0010.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0011.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0012.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0013.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0014.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0015.pdf
Encrypting: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0001.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0001.pdf.aes
Removing: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0001.pdf
Encrypting: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0002.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0002.pdf.aes
Removing: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0002.pdf
Encrypting: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0003.pdf
Creating: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0003.pdf.aes
Removing: /Users/jackcasey/Desktop/RansomwareSimulator20200320T133719/TestFile0003.pdf
Exception during test:

One or more errors occurred. (Could not load file or assembly 'System.Resources.ResourceManager, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'. Access is denied.)

   at System.Threading.Tasks.Task`1.GetResultCore(Boolean waitCompletionNotification)
   at System.Threading.Tasks.Task`1.get_Result()
   at RansomwareSimulator.Program.Main(String[] args)
```

# How does this work?
1. A new directory is created on the users desktop
2. 15 PDFs are written into this folder 
3. The executable will encrypt the PDFs, then delete them
