using System;
using System.Collections.Generic;
using System.Text;
using NetMQ;
using NetMQ.Sockets;

namespace RequestEndpointExercice
{
   public class ResponseS
    {
        public void SendReponse()
        {
            using (var responseSocket = new ResponseSocket("tcp://127.0.0.1"))

            {
                var message = responseSocket.ReceiveFrameString();
                if (message.Equals("Desks and Security cmd"))
                {
                    var cmd = new CreateOrderMsg();
                    responseSocket.SendFrame(cmd.msg);

                }

            }
        }
    }
}
