using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Threading;

namespace MessageingPipeAppTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //run app
            runTwoPipes();
        }
       static public void runTwoPipes()
        {

            Console.Write("Attempting to connect to Client...");
            //This will run the resevie message in a separate thread so that the the app can send and resevie at the same time 
            Thread thread = new Thread(ResevieMessage);
            thread.Start();
            //Infinite loop
            bool AplicationExit = false;
            while (!AplicationExit)
            {
               SendMessage();
            }
            

        }
        static public void SendMessage()
        {
         
            // Open a one-way pipe for sending data to the client. (PipeDirection.Out)
            using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("testpipeone", PipeDirection.Out))
            {
                // Wait for a client to connect    
                pipeServer.WaitForConnection();

                // So it looks nices
                Console.Write(Environment.NewLine + "Client Connected "+ Environment.NewLine + "Enter text: ");

                try
                {
                    // Read one line of user input from the console and sends that to the client process.
                    using (StreamWriter sw = new StreamWriter(pipeServer))
                    {
                        sw.AutoFlush = true;
                        sw.WriteLine(Console.ReadLine());
                    }
                }
                // This server program finishes after it has written the text line to the named pipe.
                catch (IOException e) // Catch the IOException that is raised if the pipe is broken or disconnected.
                {
                    Console.WriteLine("ERROR: {0}", e.Message);
                }
             

            }
        }
        static public void ResevieMessage()
        {
            //Infinite loop 
            bool AplicationExit = false;
            while (!AplicationExit)
            {
                // Open the one-way named pipe to reads data from. (PipeDirection.In)
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "testpipe", PipeDirection.In))
                {
                    // Connect to the pipe or wait until the pipe is available.
                    pipeClient.Connect();

                    // Now read the text stream that comes in via the named pipe
                    using (StreamReader sr = new StreamReader(pipeClient))
                    {
                        //read in message 
                        string temp;
                        while ((temp = sr.ReadLine()) != null)
                        {
                            //desplay message 
                            Console.WriteLine("Received from server: {0}", temp);
                            
                        }
                    }
                }
                    
            }
    
        }
       
        
    }
}
