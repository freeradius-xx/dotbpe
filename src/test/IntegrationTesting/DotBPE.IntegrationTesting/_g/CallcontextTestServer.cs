// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: callcontext_test.proto
#region Designer generated code

using System;
using System.Threading.Tasks;
using DotBPE.Rpc;
using DotBPE.Protocol.Amp;
using Google.Protobuf;

namespace DotBPE.IntegrationTesting
{

    //start for class AbstractCallContextTest
    public abstract class CallContextTestBase : ServiceActor
    {
        protected override int ServiceId => 50001;
        //调用委托
        private async Task<AmpMessage> ProcessTestAsync(AmpMessage req)
        {
            VoidReq request = null;
            if (req.Data == null)
            {
                request = new VoidReq();
            }
            else
            {
                request = VoidReq.Parser.ParseFrom(req.Data);
            }
            var data = await TestAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
            response.Sequence = req.Sequence;
            response.Data = data.ToByteArray();
            return response;
        }

        //抽象方法
        public abstract Task<CommonRsp> TestAsync(VoidReq request);
        public override Task<AmpMessage> ProcessAsync(AmpMessage req)
        {
            switch (req.MessageId)
            {
                //方法CallContextTest.Test
                case 1: return this.ProcessTestAsync(req);
                default: return base.ProcessNotFoundAsync(req);
            }
        }
    }
    //end for class AbstractCallContextTest
}

#endregion

