using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
	public class MockCommandAPIRepo : ICommandAPIRepo
	{
		public void CreateCommand(Command cmd)
		{
			throw new System.NotImplementedException();
		}
		
		public void DeleteCommand(Command cmd)
		{
			throw new System.NotImplementedException();
		}
		
		public void UpdateCommand(Command cmd)
		{
			throw new System.NotImplementedException();
		}
		public bool SaveChanges()
		{
			throw new System.NotImplementedException();
		}
		
		public Command GetCommandById(int id)
		{
			return new Command
			{
				Id=0, HowTo="How to generate a migration",
				CommandLine="dotnet ef migrations",
				Platform=".Net Core EF"
			};
		}//end of function GetCommandById
		
		public IEnumerable<Command> GetAllCommands()
		{
			var commands = new List<Command>
			
			{
				new Command
				{
					Id=0, HowTo="How to generate a migration",
					CommandLine="dotnet ef migrations",
					Platform=">Net Core EF"				
				},
				
				new Command
				{
					Id=1, HowTo="Run Migrations",
					CommandLine="dotnet ef database update",
					Platform=">Net Core EF"				
				},
				
				new Command
				{
					Id=2, HowTo="List active migrations",
					CommandLine="dotnet ef migrations list",
					Platform=">Net Core EF"				
				},
			};
			return commands;
		}//end of function GetAllCommands function
	}//end of class MockcommandAPIRepo
}