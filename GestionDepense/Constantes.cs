using System;
namespace GestionDepense
{
	public class Constantes
	{
		public const string databaseName = "depense.db3";
		public string databasePath = Path.Combine(FileSystem.AppDataDirectory, databaseName);
	}
}

