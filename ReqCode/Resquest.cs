
using NetMQ;
using NetMQ.Sockets;

namespace ReqCode
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

            using (var requestSocket = new RequestSocket("tcp://127.0.0.1:55555"))
            {

                requestSocket.SendFrame("Desks and Security cmd");

                msg = requestSocket.ReceiveFrameString();

            }
        }
    }
}
