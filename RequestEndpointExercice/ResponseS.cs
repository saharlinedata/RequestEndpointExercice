using NetMQ;
using NetMQ.Sockets;
using RequestEndpointExercice;

namespace RepCode
{
   public class ResponseS
    {
        public void SendReponse()
        {
            using (var responseSocket = new ResponseSocket("tcp://127.0.0.1:55554"))

            {
                var message = responseSocket.ReceiveFrameString();
                if (message.Equals("Desks and Security cmd"))
                {
                    var cmd = new CreateOrderMsg();
                    responseSocket.SendFrame(cmd.GetMsg());

                }

            }
        }
    }
}
