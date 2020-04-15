using System;
using System.Collections.Generic;
using System.Text;
using NetMQ;
using NetMQ.Sockets;

namespace RequestEndpointExercice
{
    public class Resquest
    {
        string msg;
        public string GetMsg()
        {
            return msg;
        }
        public void SendRequest()
        {

            using (var requestSocket = new RequestSocket("tcp://127.0.0.1"))
            {

                requestSocket.SendFrame("Desks and Security cmd");

                msg = requestSocket.ReceiveFrameString();

            }
        }
    }
}
