// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: math.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using Google.Protobuf; 

namespace MathCommon {

//start for class AbstractMath
public abstract class MathBase : ServiceActor 
{
protected override int ServiceId => 10005;
//调用委托
private async Task<AmpMessage> ProcessAddAsync(AmpMessage req)
{
AddReq request = null;
if(req.Data == null ){
   request = new AddReq();
}
else {
request = AddReq.Parser.ParseFrom(req.Data);
}
var data = await AddAsync(request);
var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
response.Data = data.ToByteArray();
return response;
}

//抽象方法
public abstract Task<AddRes> AddAsync(AddReq request);
public override Task<AmpMessage> ProcessAsync(AmpMessage req)
{
switch(req.MessageId){
//方法Math.Add
case 1: return this.ProcessAddAsync(req);
default: return base.ProcessNotFoundAsync(req);
}
}
}
//end for class AbstractMath
}

#endregion

