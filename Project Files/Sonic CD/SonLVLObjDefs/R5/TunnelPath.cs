using SonicRetro.SonLVL.API;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace SCDObjectDefinitions.R5
{
	// (all these values are taken directly from each object's respective giant case switch)
	
	class TunnelPath1 : R5.TunnelPath
	{
		public override int[] GetPath()
		{
			return new int[] {
				0xDA00, 0xBA00,
				0xDA00, 0xABA00,
				0xDA00, 0x14BA00,
				0xDA00, 0x1EBA00,
				0xDA00, 0x28BA00,
				0xDA00, 0x32BA00,
				0xDA00, 0x38BA00,
				0xADA00, 0x403A00,
				0x14DA00, 0x47BA00,
				0x1EDA00, 0x4F3A00,
				0x20DA00, 0x503A00,
				0x16DA00, 0x52BA00,
				0xCDA00, 0x553A00,
				0x2DA00, 0x57BA00,
				-0x72600, 0x5A3A00,
				-0x112600, 0x5CBA00,
				-0x1B2600, 0x5F3A00,
				-0x252600, 0x61BA00,
				-0x2F2600, 0x643A00,
				-0x392600, 0x66BA00,
				-0x432600, 0x693A00,
				-0x4D2600, 0x6BBA00,
				-0x572600, 0x6E3A00,
				-0x5F2600, 0x703A00,
				-0x552600, 0x72BA00,
				-0x4B2600, 0x753A00,
				-0x412600, 0x77BA00,
				-0x372600, 0x7A3A00,
				-0x2D2600, 0x7CBA00,
				-0x232600, 0x7F3A00,
				-0x192600, 0x81BA00,
				-0xF2600, 0x843A00,
				-0x52600, 0x86BA00,
				0x4DA00, 0x893A00,
				0xEDA00, 0x8BBA00,
				0x18DA00, 0x8E3A00,
				0x20DA00, 0x903A00,
				0x16DA00, 0x92BA00,
				0xCDA00, 0x953A00,
				0x2DA00, 0x97BA00,
				-0x72600, 0x9A3A00,
				-0x112600, 0x9CBA00,
				-0x1B2600, 0x9F3A00,
				-0x252600, 0xA1BA00,
				-0x2F2600, 0xA43A00,
				-0x392600, 0xA6BA00,
				-0x432600, 0xA93A00,
				-0x4D2600, 0xABBA00,
				-0x572600, 0xAE3A00,
				-0x5F2600, 0xB03A00,
				-0x552600, 0xB2BA00,
				-0x4B2600, 0xB53A00,
				-0x412600, 0xB7BA00,
				-0x372600, 0xBA3A00,
				-0x2D2600, 0xBCBA00,
				-0x232600, 0xBF3A00,
				-0x192600, 0xC1BA00,
				-0xF2600, 0xC43A00,
				-0x52600, 0xC6BA00,
				0x4DA00, 0xC93A00,
				0xEDA00, 0xCBBA00,
				0x18DA00, 0xCE3A00,
				0x20DA00, 0xD03A00,
				0x2ADA00, 0xE0BA00,
				0x34DA00, 0xE87200
			};
		}
	}
	
	class TunnelPath2 : R5.TunnelPath
	{
		public override int[] GetPath()
		{
			return new int[] {
				0x7600, 0x3700,
				0x7600, 0xA3700,
				0x7600, 0x143700,
				0x7600, 0x1E3700,
				0x7600, 0x203700,
				0xA7600, 0x243700,
				0x147600, 0x283700,
				0x1E7600, 0x2C3700,
				0x287600, 0x303700,
				0x327600, 0x343700,
				0x3C7600, 0x383700,
				0x467600, 0x3C3700,
				0x507600, 0x403700,
				0x467600, 0x42B700,
				0x3C7600, 0x453700,
				0x327600, 0x47B700,
				0x287600, 0x4A3700,
				0x1E7600, 0x4CB700,
				0x147600, 0x4F3700,
				0xA7600, 0x51B700,
				0x7600, 0x543700,
				-0x98A00, 0x56B700,
				-0x138A00, 0x593700,
				-0x1D8A00, 0x5BB700,
				-0x278A00, 0x5E3700,
				-0x2F8A00, 0x603700,
				-0x258A00, 0x62B700,
				-0x1B8A00, 0x653700,
				-0x118A00, 0x67B700,
				-0x78A00, 0x6A3700,
				0x27600, 0x6CB700,
				0xC7600, 0x6F3700,
				0x167600, 0x71B700,
				0x207600, 0x743700,
				0x2A7600, 0x76B700,
				0x347600, 0x793700,
				0x3E7600, 0x7BB700,
				0x487600, 0x7E3700,
				0x507600, 0x803700,
				0x467600, 0x82B700,
				0x3C7600, 0x853700,
				0x327600, 0x87B700,
				0x287600, 0x8A3700,
				0x1E7600, 0x8CB700,
				0x147600, 0x8F3700,
				0xA7600, 0x91B700,
				0x7600, 0x943700,
				-0x98A00, 0x96B700,
				-0x138A00, 0x993700,
				-0x1D8A00, 0x9BB700,
				-0x278A00, 0x9E3700,
				-0x2F8A00, 0xA03700,
				-0x258A00, 0xA2B700,
				-0x1B8A00, 0xA53700,
				-0x118A00, 0xA7B700,
				-0x78A00, 0xAA3700,
				0x27600, 0xACB700,
				0xC7600, 0xAF3700,
				0x167600, 0xB1B700,
				0x207600, 0xB43700,
				0x2A7600, 0xB6B700,
				0x347600, 0xB93700,
				0x3E7600, 0xBBB700,
				0x487600, 0xBE3700,
				0x507600, 0xC03700,
				0x467600, 0xC2B700,
				0x3C7600, 0xC53700,
				0x327600, 0xC7B700,
				0x287600, 0xCA3700,
				0x1E7600, 0xCCB700,
				0x147600, 0xCF3700,
				0xA7600, 0xD1B700,
				0x7600, 0xD43700,
				-0x98A00, 0xD6B700,
				-0x138A00, 0xD93700,
				-0x1D8A00, 0xDBB700,
				-0x278A00, 0xDE3700,
				-0x2F8A00, 0xE03700,
				-0x258A00, 0xE41A00,
				-0x1B8A00, 0xE7FD00,
				-0x118A00, 0xEBE000,
				-0x78A00, 0xEFC300,
				0x27600, 0xF3A600,
				0xC7600, 0xF78900,
				0x167600, 0xFB6C00,
				0x207600, 0xFF4F00,
				0x2A7600, 0x1033200,
				0x347600, 0x1071500,
				0x3E7600, 0x10AF800,
				0x487600, 0x10EDB00,
				0x527600, 0x112BE00,
				0x5C7600, 0x116A100,
				0x607600, 0x118A100,
				0x607600, 0x122A100,
				0x607600, 0x12CA100,
				0x607600, 0x136A100,
				0x607600, 0x138A100,
				0x657600, 0x142A100,
				0x657600, 0x14CD900,
				0x657600, 0x1574900,
				0x657600, 0x161F100
			};
		}
	}
	
	class TunnelPath3 : R5.TunnelPath
	{
		public override int[] GetPath()
		{
			return new int[] {
				0xC800, 0xEE00,
				0xC800, 0xAEE00,
				0xC800, 0x14EE00,
				0xC800, 0x1EEE00,
				0xC800, 0x20EE00,
				0xAC800, 0x244300,
				0x14C800, 0x279800,
				0x1EC800, 0x2AED00,
				0x28C800, 0x2E4200,
				0x32C800, 0x319700,
				0x3CC800, 0x34EC00,
				0x46C800, 0x384100,
				0x50C800, 0x3B9600,
				0x5AC800, 0x3EEB00,
				0x60C800, 0x40EB00,
				0x56C800, 0x436B00,
				0x4CC800, 0x45EB00,
				0x42C800, 0x486B00,
				0x38C800, 0x4AEB00,
				0x2EC800, 0x4D6B00,
				0x24C800, 0x4FEB00,
				0x1AC800, 0x526B00,
				0x10C800, 0x54EB00,
				0x6C800, 0x576B00,
				-0x33800, 0x59EB00,
				-0xD3800, 0x5C6B00,
				-0x173800, 0x5EEB00,
				-0x1F3800, 0x60EB00,
				-0x153800, 0x636B00,
				-0xB3800, 0x65EB00,
				-0x13800, 0x686B00,
				0x8C800, 0x6AEB00,
				0x12C800, 0x6D6B00,
				0x1CC800, 0x6FEB00,
				0x26C800, 0x726B00,
				0x30C800, 0x74EB00,
				0x3AC800, 0x776B00,
				0x44C800, 0x79EB00,
				0x4EC800, 0x7C6B00,
				0x58C800, 0x7EEB00,
				0x60C800, 0x80EB00,
				0x56C800, 0x836B00,
				0x4CC800, 0x85EB00,
				0x42C800, 0x886B00,
				0x38C800, 0x8AEB00,
				0x2EC800, 0x8D6B00,
				0x24C800, 0x8FEB00,
				0x1AC800, 0x926B00,
				0x10C800, 0x94EB00,
				0x6C800, 0x976B00,
				-0x33800, 0x99EB00,
				-0xD3800, 0x9C6B00,
				-0x173800, 0x9EEB00,
				-0x1F3800, 0xA0EB00,
				-0x153800, 0xA36B00,
				-0xB3800, 0xA5EB00,
				-0x13800, 0xA86B00,
				0x8C800, 0xAAEB00,
				0x12C800, 0xAD6B00,
				0x1CC800, 0xAFEB00,
				0x26C800, 0xB26B00,
				0x30C800, 0xB4EB00,
				0x3AC800, 0xB76B00,
				0x44C800, 0xB9EB00,
				0x4EC800, 0xBC6B00,
				0x58C800, 0xBEEB00,
				0x60C800, 0xC0EB00,
				0x56C800, 0xC36B00,
				0x4CC800, 0xC5EB00,
				0x42C800, 0xC86B00,
				0x38C800, 0xCAEB00,
				0x2EC800, 0xCD6B00,
				0x24C800, 0xCFEB00,
				0x1AC800, 0xD26B00,
				0x10C800, 0xD4EB00,
				0x6C800, 0xD76B00,
				-0x33800, 0xD9EB00,
				-0xD3800, 0xDC6B00,
				-0x173800, 0xDEEB00,
				-0x1F3800, 0xE0EB00,
				-0x153800, 0xE36B00,
				-0xB3800, 0xE5EB00,
				-0x13800, 0xE86B00,
				0x8C800, 0xEAEB00,
				0x12C800, 0xED6B00,
				0x1CC800, 0xEFEB00,
				0x26C800, 0xF26B00,
				0x30C800, 0xF4EB00,
				0x3AC800, 0xF76B00,
				0x44C800, 0xF9EB00,
				0x4EC800, 0xFC6B00,
				0x58C800, 0xFEEB00,
				0x60C800, 0x100EB00,
				0x6AC800, 0x1076B00,
				0x74C800, 0x1112300
			};
		}
	}
	
	class TunnelPath4 : R5.TunnelPath
	{
		public override int[] GetPath()
		{
			return new int[] {
				0xC100, 0x83000,
				0xC100, 0x123000,
				0xC100, 0x1C3000,
				0xC100, 0x203000,
				0xAC100, 0x243000,
				0x14C100, 0x283000,
				0x1EC100, 0x2C3000,
				0x28C100, 0x303000,
				0x32C100, 0x343000,
				0x3CC100, 0x383000,
				0x46C100, 0x3C3000,
				0x50C100, 0x403000,
				0x46C100, 0x42B000,
				0x3CC100, 0x453000,
				0x32C100, 0x47B000,
				0x28C100, 0x4A3000,
				0x1EC100, 0x4CB000,
				0x14C100, 0x4F3000,
				0xAC100, 0x51B000,
				0xC100, 0x543000,
				-0x93F00, 0x56B000,
				-0x133F00, 0x593000,
				-0x1D3F00, 0x5BB000,
				-0x273F00, 0x5E3000,
				-0x2F3F00, 0x603000,
				-0x253F00, 0x62B000,
				-0x1B3F00, 0x653000,
				-0x113F00, 0x67B000,
				-0x73F00, 0x6A3000,
				0x2C100, 0x6CB000,
				0xCC100, 0x6F3000,
				0x16C100, 0x71B000,
				0x20C100, 0x743000,
				0x2AC100, 0x76B000,
				0x34C100, 0x793000,
				0x3EC100, 0x7BB000,
				0x48C100, 0x7E3000,
				0x50C100, 0x803000,
				0x46C100, 0x82B000,
				0x3CC100, 0x853000,
				0x32C100, 0x87B000,
				0x28C100, 0x8A3000,
				0x1EC100, 0x8CB000,
				0x14C100, 0x8F3000,
				0xAC100, 0x91B000,
				0xC100, 0x943000,
				-0x93F00, 0x96B000,
				-0x133F00, 0x993000,
				-0x1D3F00, 0x9BB000,
				-0x273F00, 0x9E3000,
				-0x2F3F00, 0xA03000,
				-0x253F00, 0xA2B000,
				-0x1B3F00, 0xA53000,
				-0x113F00, 0xA7B000,
				-0x73F00, 0xAA3000,
				0x2C100, 0xACB000,
				0xCC100, 0xAF3000,
				0x16C100, 0xB1B000,
				0x20C100, 0xB43000,
				0x2AC100, 0xB6B000,
				0x34C100, 0xB93000,
				0x3EC100, 0xBBB000,
				0x48C100, 0xBE3000,
				0x50C100, 0xC03000,
				0x46C100, 0xC2B000,
				0x3CC100, 0xC53000,
				0x32C100, 0xC7B000,
				0x28C100, 0xCA3000,
				0x1EC100, 0xCCB000,
				0x14C100, 0xCF3000,
				0xAC100, 0xD1B000,
				0xC100, 0xD43000,
				-0x93F00, 0xD6B000,
				-0x133F00, 0xD93000,
				-0x1D3F00, 0xDBB000,
				-0x273F00, 0xDE3000,
				-0x2F3F00, 0xE03000,
				-0x253F00, 0xE2B000,
				-0x1B3F00, 0xE53000,
				-0x113F00, 0xE7B000,
				-0x73F00, 0xEA3000,
				0x2C100, 0xECB000,
				0xCC100, 0xEF3000,
				0x16C100, 0xF1B000,
				0x20C100, 0xF43000,
				0x2AC100, 0xF6B000,
				0x34C100, 0xF93000,
				0x3EC100, 0xFBB000,
				0x48C100, 0xFE3000,
				0x50C100, 0x1003000,
				0x46C100, 0x102B000,
				0x3CC100, 0x1053000,
				0x32C100, 0x107B000,
				0x28C100, 0x10A3000,
				0x1EC100, 0x10CB000,
				0x14C100, 0x10F3000,
				0xAC100, 0x111B000,
				0xC100, 0x1143000,
				-0x93F00, 0x116B000,
				-0x133F00, 0x1193000,
				-0x1D3F00, 0x11BB000,
				-0x273F00, 0x11E3000,
				-0x2F3F00, 0x1203000,
				-0x253F00, 0x122B000,
				-0x1B3F00, 0x1253000,
				-0x113F00, 0x127B000,
				-0x73F00, 0x12A3000,
				0x2C100, 0x12CB000,
				0xCC100, 0x12F3000,
				0x16C100, 0x131B000,
				0x20C100, 0x1343000,
				0x2AC100, 0x136B000,
				0x34C100, 0x1393000,
				0x3EC100, 0x13BB000,
				0x48C100, 0x13E3000,
				0x50C100, 0x1403000,
				0x46C100, 0x142B000,
				0x3CC100, 0x1453000,
				0x32C100, 0x147B000,
				0x28C100, 0x14A3000,
				0x1EC100, 0x14CB000,
				0x14C100, 0x14F3000,
				0xAC100, 0x151B000,
				0xC100, 0x1543000,
				-0x93F00, 0x156B000,
				-0x133F00, 0x1593000,
				-0x1D3F00, 0x15BB000,
				-0x273F00, 0x15E3000,
				-0x2F3F00, 0x1603000,
				-0x253F00, 0x162B000,
				-0x1B3F00, 0x1653000,
				-0x113F00, 0x167B000,
				-0x73F00, 0x16A3000,
				0x2C100, 0x16CB000,
				0xCC100, 0x16F3000,
				0x16C100, 0x171B000,
				0x20C100, 0x1743000,
				0x2AC100, 0x176B000,
				0x34C100, 0x1793000,
				0x3EC100, 0x17BB000,
				0x48C100, 0x17E3000,
				0x50C100, 0x1803000,
				0x46C100, 0x182B000,
				0x3CC100, 0x1853000,
				0x32C100, 0x187B000,
				0x28C100, 0x18A3000,
				0x1EC100, 0x18CB000,
				0x14C100, 0x18F3000,
				0xAC100, 0x191B000,
				0xC100, 0x1943000,
				-0x93F00, 0x196B000,
				-0x133F00, 0x1993000,
				-0x1D3F00, 0x19BB000,
				-0x273F00, 0x19E3000,
				-0x2F3F00, 0x1A03000,
				-0x253F00, 0x1A67000,
				-0x1B3F00, 0x1ACB000,
				-0x113F00, 0x1B2F000,
				-0x73F00, 0x1B93000,
				0x2C100, 0x1BF7000,
				0xCC100, 0x1C5B000,
				0x16C100, 0x1CBF000,
				0x20C100, 0x1D23000,
				0x2AC100, 0x1D87000,
				0x34C100, 0x1DEB000,
				0x3EC100, 0x1E4F000,
				0x48C100, 0x1EB3000
			};
		}
	}
	
	class TunnelPath5 : R5.TunnelPath
	{
		public override int[] GetPath()
		{
			return new int[] {
				0x100, 0x8AF00,
				0xA0100, 0xDAF00,
				0x140100, 0x12AF00,
				0x1E0100, 0x17AF00,
				0x280100, 0x1CAF00,
				0x320100, 0x21AF00,
				0x3C0100, 0x26AF00,
				0x460100, 0x2BAF00,
				0x500100, 0x30AF00,
				0x5A0100, 0x35AF00,
				0x640100, 0x3AAF00,
				0x6E0100, 0x3FAF00,
				0x780100, 0x44AF00,
				0x820100, 0x49AF00,
				0x8C0100, 0x4EAF00,
				0x900100, 0x50AF00,
				0x860100, 0x532F00,
				0x7C0100, 0x55AF00,
				0x720100, 0x582F00,
				0x680100, 0x5AAF00,
				0x5E0100, 0x5D2F00,
				0x540100, 0x5FAF00,
				0x4A0100, 0x622F00,
				0x400100, 0x64AF00,
				0x360100, 0x672F00,
				0x2C0100, 0x69AF00,
				0x220100, 0x6C2F00,
				0x180100, 0x6EAF00,
				0x100100, 0x70AF00,
				0x1A0100, 0x732F00,
				0x240100, 0x75AF00,
				0x2E0100, 0x782F00,
				0x380100, 0x7AAF00,
				0x420100, 0x7D2F00,
				0x4C0100, 0x7FAF00,
				0x560100, 0x822F00,
				0x600100, 0x84AF00,
				0x6A0100, 0x872F00,
				0x740100, 0x89AF00,
				0x7E0100, 0x8C2F00,
				0x880100, 0x8EAF00,
				0x900100, 0x90AF00,
				0x860100, 0x932F00,
				0x7C0100, 0x95AF00,
				0x720100, 0x982F00,
				0x680100, 0x9AAF00,
				0x5E0100, 0x9D2F00,
				0x540100, 0x9FAF00,
				0x4A0100, 0xA22F00,
				0x400100, 0xA4AF00,
				0x360100, 0xA72F00,
				0x2C0100, 0xA9AF00,
				0x220100, 0xAC2F00,
				0x180100, 0xAEAF00,
				0x100100, 0xB0AF00,
				0x1A0100, 0xB32F00,
				0x240100, 0xB5AF00,
				0x2E0100, 0xB82F00,
				0x380100, 0xBAAF00,
				0x420100, 0xBD2F00,
				0x4C0100, 0xBFAF00,
				0x560100, 0xC22F00,
				0x600100, 0xC4AF00,
				0x6A0100, 0xC72F00,
				0x740100, 0xC9AF00,
				0x7E0100, 0xCC2F00,
				0x880100, 0xCEAF00,
				0x900100, 0xD0AF00,
				0x860100, 0xD32F00,
				0x7C0100, 0xD5AF00,
				0x720100, 0xD82F00,
				0x680100, 0xDAAF00,
				0x5E0100, 0xDD2F00,
				0x540100, 0xDFAF00,
				0x4A0100, 0xE22F00,
				0x400100, 0xE4AF00,
				0x360100, 0xE72F00,
				0x2C0100, 0xE9AF00,
				0x220100, 0xEC2F00,
				0x180100, 0xEEAF00,
				0x100100, 0xF0AF00,
				0x1A0100, 0xF32F00,
				0x240100, 0xF5AF00,
				0x2E0100, 0xF82F00,
				0x380100, 0xFAAF00,
				0x420100, 0xFD2F00,
				0x4C0100, 0xFFAF00,
				0x560100, 0x1022F00,
				0x600100, 0x104AF00,
				0x6A0100, 0x1072F00,
				0x740100, 0x109AF00,
				0x7E0100, 0x10C2F00,
				0x880100, 0x10EAF00,
				0x900100, 0x110AF00,
				0x860100, 0x1132F00,
				0x7C0100, 0x115AF00,
				0x720100, 0x1182F00,
				0x680100, 0x11AAF00,
				0x5E0100, 0x11D2F00,
				0x540100, 0x11FAF00,
				0x4A0100, 0x1222F00,
				0x400100, 0x124AF00,
				0x360100, 0x1272F00,
				0x2C0100, 0x129AF00,
				0x220100, 0x12C2F00,
				0x180100, 0x12EAF00,
				0x100100, 0x130AF00,
				0x1A0100, 0x1332F00,
				0x240100, 0x135AF00,
				0x2E0100, 0x1382F00,
				0x380100, 0x13AAF00,
				0x420100, 0x13D2F00,
				0x4C0100, 0x13FAF00,
				0x560100, 0x1422F00,
				0x600100, 0x144AF00,
				0x6A0100, 0x1472F00,
				0x740100, 0x149AF00,
				0x7E0100, 0x14C2F00,
				0x880100, 0x14EAF00,
				0x900100, 0x150AF00,
				0x860100, 0x1532F00,
				0x7C0100, 0x155AF00,
				0x720100, 0x1582F00,
				0x680100, 0x15AAF00,
				0x5E0100, 0x15D2F00,
				0x540100, 0x15FAF00,
				0x4A0100, 0x1622F00,
				0x400100, 0x164AF00,
				0x360100, 0x1672F00,
				0x2C0100, 0x169AF00,
				0x220100, 0x16C2F00,
				0x180100, 0x16EAF00,
				0x100100, 0x170AF00,
				0x1A0100, 0x1782F00,
				0x240100, 0x17FAF00,
				0x2E0100, 0x1872F00,
				0x380100, 0x18EAF00,
				0x420100, 0x1962F00,
				0x4C0100, 0x19DAF00,
				0x560100, 0x1A52F00,
				0x600100, 0x1ACAF00,
				0x6A0100, 0x1B42F00,
				0x740100, 0x1BBAF00,
				0x7E0100, 0x1C32F00,
				0x880100, 0x1CAAF00
			};
		}
	}
	
	abstract class TunnelPath : ObjectDefinition
	{
		private Sprite sprite;
		private Sprite debug;
		
		public abstract int[] GetPath();
		
		public override void Init(ObjectData data)
		{
			sprite = new Sprite(LevelData.GetSpriteSheet("Global/Display.gif").GetSection(173, 67, 16, 16), -8, -8);
			
			debug = DrawPath(GetPath());
		}

		public override ReadOnlyCollection<byte> Subtypes
		{
			get { return new ReadOnlyCollection<byte>(new List<byte>()); }
		}
		
		public override bool Debug
		{
			get { return true; }
		}
		
		public override string SubtypeName(byte subtype)
		{
			return null;
		}

		public override Sprite Image
		{
			get { return sprite; }
		}

		public override Sprite SubtypeImage(byte subtype)
		{
			return sprite;
		}

		public override Sprite GetSprite(ObjectEntry obj)
		{
			return sprite;
		}
		
		public override Sprite GetDebugOverlay(ObjectEntry obj)
		{
			return debug;
		}
		
		private Sprite DrawPath(int[] path)
		{
			int xmin = 0x7fff;
			int ymin = 0x7fff;
			int xmax = -0x7fff;
			int ymax = -0x7fff;
			
			for (int i = 0; i < path.Length; i += 2)
			{
				xmin = Math.Min(xmin, path[i] >> 16);
				ymin = Math.Min(ymin, path[i+1] >> 16);
				xmax = Math.Max(xmax, path[i] >> 16);
				ymax = Math.Max(ymax, path[i+1] >> 16);
			}
			
			BitmapBits bitmap = new BitmapBits(xmax - xmin + 1, ymax - ymin + 1);
			
			for (int i = 2; i < path.Length; i += 2)
				bitmap.DrawLine(6, (path[i-2] >> 16) - xmin, (path[i-1] >> 16) - ymin, (path[i] >> 16) - xmin, (path[i+1] >> 16) - ymin); // LevelData.ColorWhite
			
			return new Sprite(bitmap, xmin, ymin);
		}
	}
}