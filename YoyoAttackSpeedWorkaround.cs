using Terraria.ModLoader;

namespace YoyoAttackSpeedWorkaround
{
	class YoyoAttackSpeedWorkaround : Mod
	{
		public YoyoAttackSpeedWorkaround()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
