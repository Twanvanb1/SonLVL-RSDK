using SonicRetro.SonLVL.API;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace S2ObjectDefinitions.EHZ
{
	class HPlatform : EHZ.Platform
	{
		public override Point offset { get { return new Point(64, 0); } }
		public override Dictionary<string, int> names { get { return new Dictionary<string, int>{{ "Right", 0 }, { "Left", 1 }}; } }
	}
	
	class VPlatform : EHZ.Platform
	{
		public override Point offset { get { return new Point(0, 64); } }
		public override Dictionary<string, int> names { get { return new Dictionary<string, int>{{ "Bottom", 0 }, { "Top", 1 }}; } }
	}
	
	class VPlatform2 : EHZ.Platform
	{
		public override Point offset { get { return new Point(0, 32); } }
		public override Dictionary<string, int> names { get { return new Dictionary<string, int>{{ "Bottom", 0 }, { "Top", 1 }}; } }
		
		public override Sprite GetFrame()
		{
			if (LevelData.StageInfo.folder.EndsWith("Zone01"))
				return new Sprite(LevelData.GetSpriteSheet("EHZ/Objects.gif").GetSection(127, 1, 64, 96), -32, -52);
			else
				return new Sprite(LevelData.GetSpriteSheet("MBZ/Objects.gif").GetSection(1, 305, 64, 96), -32, -46);
		}
	}
	
	abstract class Platform : ObjectDefinition
	{
		private Sprite[] sprites = new Sprite[3];
		private Sprite debug;
		private PropertySpec[] properties = new PropertySpec[1];
		
		public virtual Point offset { get { return new Point(0, 0); } }
		public virtual Dictionary<string, int> names { get { return new Dictionary<string, int>{}; } }
		
		public virtual Sprite GetFrame()
		{
			if (LevelData.StageInfo.folder.EndsWith("Zone01"))
				return new Sprite(LevelData.GetSpriteSheet("EHZ/Objects.gif").GetSection(127, 98, 64, 32), -32, -12);
			else
				return new Sprite(LevelData.GetSpriteSheet("MBZ/Objects.gif").GetSection(1, 402, 64, 32), -32, -8);
		}
		
		public override void Init(ObjectData data)
		{
			sprites[2] = GetFrame();
			sprites[0] = new Sprite(sprites[2],  offset.X,  offset.Y);
			sprites[1] = new Sprite(sprites[2], -offset.X, -offset.Y);
			
			BitmapBits bitmap = new BitmapBits((offset.X * 2) + 1, (offset.Y * 2) + 1);
			bitmap.DrawLine(6, 0, 0, offset.X * 2, offset.Y * 2); // LevelData.ColorWhite
			debug = new Sprite(bitmap, -offset.X, -offset.Y);
			
			properties[0] = new PropertySpec("Start From", typeof(bool), "Extended",
				"Which side this platform should start from.", null, names,
				(obj) => (obj.PropertyValue == 1) ? 1 : 0,
				(obj, value) => obj.PropertyValue = (byte)((int)value));
		}

		public override ReadOnlyCollection<byte> Subtypes
		{
			get { return new ReadOnlyCollection<byte>(new byte[] { 0, 1 }); }
		}
		
		public override PropertySpec[] CustomProperties
		{
			get { return properties; }
		}

		public override string SubtypeName(byte subtype)
		{
			return "Start From " + names.GetKey((subtype == 1) ? 1 : 0);
		}

		public override Sprite Image
		{
			get { return sprites[2]; }
		}

		public override Sprite SubtypeImage(byte subtype)
		{
			return sprites[2];
		}

		public override Sprite GetSprite(ObjectEntry obj)
		{
			return sprites[(obj.PropertyValue == 1) ? 1 : 0];
		}
		
		public override Sprite GetDebugOverlay(ObjectEntry obj)
		{
			return debug;
		}
	}
}