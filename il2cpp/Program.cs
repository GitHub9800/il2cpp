﻿using System;
using System.Text;

namespace il2cpp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Il2cppContext context = new Il2cppContext(@"testCS.exe");
			context.AddEntry(context.Module.EntryPoint);
			context.Process();

			HierarchyDump dumper = new HierarchyDump(context);
			StringBuilder sb = new StringBuilder();

			sb.Append("* MethodTables:\n");
			dumper.DumpMethodTables(sb);

			sb.Append("* Types:\n");
			dumper.DumpTypes(sb);

			Console.Write(sb.ToString());
		}
	}
}