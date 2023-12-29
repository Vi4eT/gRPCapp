namespace accdbTools
{
	internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Editor s = new();
                s.JSONfile = s.JSONfile.Replace("gRPCapp\\gRPCservice", "gRPCapp\\Table.json");
				s.SetCurrentTable(args[0]);
                if (args.Length == 1)
                    s.SaveJSON();
                else
                    s.EditTable(args);
			}
            else
            {
				ApplicationConfiguration.Initialize();
				Application.Run(new Editor());
			}
        }
    }
}