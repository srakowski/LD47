using System;

namespace LD47
{
	public static class Program
	{
		[STAThread]
		static void Main()
		{
			using (var game = new TbdGame())
				game.Run();
		}
	}
}
