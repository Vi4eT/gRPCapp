using Grpc.Core;
using System.Diagnostics;

namespace gRPCservice.Services
{
	public class GreeterService : Greeter.GreeterBase
	{
		private readonly string JSONfile = Directory.GetCurrentDirectory().Replace("gRPCapp\\gRPCservice",
																					"gRPCapp\\Table.json");
		private readonly ProcessStartInfo startInfo = new()
		{
			FileName = Directory.GetCurrentDirectory().Replace("gRPCapp\\gRPCservice",
												"gRPCapp\\accdbTools\\bin\\Debug\\net8.0-windows\\accdbTools.exe"),
			UseShellExecute = false,
		};

		public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
		{
			string? json = null;
			startInfo.Arguments = request.Name;
			Process? p = Process.Start(startInfo);
			if (p != null)
			{
				if (!p.WaitForExit(10000))
					p.Kill();
				StreamReader sr = new(JSONfile);
				json = sr.ReadLine();
				sr.Close();
			}
			return Task.FromResult(new HelloReply { Message = json });
		}
	}
}