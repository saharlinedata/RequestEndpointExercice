using RequestEndpointExercice;
using System;
using System.Collections.Generic;
using System.Text;
using RepCode;
using ReqCode;
using Xunit;
namespace RequestEndpointTest
{
   public class ReqRespTest
    {
        [Fact]

        public void Req_Rep()
        {
            var Req1 = new Resquest();
            var Rep1 = new ResponseS();
            Rep1.SendReponse();
            Req1.SendRequest();

            var msg = Req1.GetMsg();
            Assert.Equal("cmdMsg", msg);

        }
    }
}
