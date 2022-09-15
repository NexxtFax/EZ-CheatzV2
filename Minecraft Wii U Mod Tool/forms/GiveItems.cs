using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Properties;
using wiiplaza.gecko;
using Minecraft_Wii_U_Mod_Tool.theme;
using System.Threading;

namespace Minecraft_Wii_U_Mod_Tool.forms
{
    public partial class GiveItems : MetroForm
    {
        public GiveItems(MainForm INJI)
        {
            InitializeComponent();
            if (INJI != null)
            {
                StyleManager.Style = this.Style = INJI.StyleManager.Style;
                StyleManager.Theme = this.Theme = INJI.StyleManager.Theme;
            }
        }
		private int numberPlayers;
		public string giveText;
		private string enchantText;
		private string xpText;
		private string enchantString;

		#region enchantments
		public static string[] enchantments = {
            "0",
			"1",
			"2",
			"3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "32",
            "33",
            "34",
            "35",
            "48",
            "49",
            "50",
            "51",
            "61",
            "62",
            "70",
            "71",
            "80",
            "81",
            "82",
            "83"
        };
        #endregion

        private void GiveItems_Load(object sender, EventArgs e)
        {

        }

		private void executeGiveItem()
		{
			string input = "9421ff887c0802a63ce031003d0031009001007c3d4031003d20310093c10070610802143bc00000614a02186129021c60e70210934100609381006893a1006c93e100743fe0109c80e7000063ffd8e48349000083a80000838a000093c1005493610064813f000093c1005081290034812900f8812900c87f69382e480000110067006900760065000000007c8802a63d20020b38610008612908d47d2903a64e8004213d20024661290e54814100107d2903a681210014800100187f47d378808100087f86e3788061000c7fa5eb788161001c3901002891410030912100348141002081210024900100389361004893c1004c90810028388100489061002c386100509161003c91410040912100444e800421811f0000814100503d200304810800346129a5d88161005438810058806808787d2903a6914100589161005c4e8004218001007c83410060836100647c0803a68381006883a1006c83c1007083e10074382100784e80002060000000";
			MainForm.GeckoU.makeAssembly(0x039156C0, input);
			MainForm.GeckoU.CallFunction(0x039156C0, new uint[1]);
		}

		private void executeUpdateWorldInfo()
		{
			MainForm.GeckoU.clearString2(0x30000000, 0x30000100);
			MainForm.GeckoU.clearString2(0x38000000, 0x38000080);
			this.player1Label.Visible = false;
			this.player2Label.Visible = false;
			this.player3Label.Visible = false;
			this.player4Label.Visible = false;
			this.player5Label.Visible = false;
			this.player6Label.Visible = false;
			this.player7Label.Visible = false;
			this.player8Label.Visible = false;
			this.x1Label.Visible = false;
			this.y1Label3.Visible = false;
			this.z1Label3.Visible = false;
			this.x2Label.Visible = false;
			this.y2Label.Visible = false;
			this.z2Label.Visible = false;
			this.x3Label.Visible = false;
			this.y3Label.Visible = false;
			this.z3Label.Visible = false;
			this.x4Label.Visible = false;
			this.y4Label.Visible = false;
			this.z4Label.Visible = false;
			this.x5Label.Visible = false;
			this.y5Label.Visible = false;
			this.z5Label.Visible = false;
			this.x6Label.Visible = false;
			this.y6Label.Visible = false;
			this.z6Label.Visible = false;
			this.x7Label.Visible = false;
			this.y7Label.Visible = false;
			this.z7Label.Visible = false;
			this.x8Label.Visible = false;
			this.y8Label.Visible = false;
			this.z8Label.Visible = false;
			string input = "9421ffb87c0802a63d40109c3d2003189001004c614ad8e46129c87838800000806a00007d2903a64e800421814300c8812300cc7d2a48505529e8ff418200fc930100283f00026d934100303f40100093a1003c3fa010009321002c63bda0e09361003463182edc93810038635a000c93c100407c7c1b7893e100443bc000003fe030003b20001e3b60000057c91838388100087c6a482e7f0903a6932100243bde0001936100083bff0020936100203bbd00044e800421815c00c8813c00cc810100207d2a4850800100085529e8fe8161000c7c1e4840806100108081001480a1001880c1001c80e10024901fffe0917fffe4907fffe8909fffec90bffff090dffff4911ffff890fffffc911dfffc913a00004180ff78830100288321002c83410030836100348381003883a1003c83c1004083e100448001004c382100487c0803a64e800020";
			MainForm.GeckoU.makeAssembly(0x03917290, input);
			MainForm.GeckoU.CallFunction(0x03917290, new uint[1]);
			string input2 = "9421fff87c0802a63d40109c3d2003189001000c6129c878614ad8e47d2903a6806a0000388000004e800421810300c8812300cc7d2848505529e8ff418200407d2903a63d20380081480000392900103908000880ea000080e7005490e9fff080ea000080e7005890e9fff4814a0000814a005c9149fff84200ffd08001000c382100087c0803a64e80002060000000";
			MainForm.GeckoU.makeAssembly(0x039173D8, input2);
			MainForm.GeckoU.CallFunction(0x039173D8, new uint[1]);
			string input3 = "9421FFF87C0802A63D200316612968187C0802A67D2903A69001000C4E800421812300342C09000041820024814900F83D20103061293030814A0154816A0004814A000091690004914900008001000C3D20010F61296AE0382100087D2903A67C0803A64E80002060000000";
			MainForm.GeckoU.makeAssembly(0x03917468, input3);
			MainForm.GeckoU.CallFunction(0x03917468, new uint[1]);
			this.numberPlayers = 0;
			bool flag = MainForm.GeckoU.PeekUInt(0x30000014) == 0x0;
			if (!flag)
			{
				this.numberPlayers++;
			}
			bool flag2 = MainForm.GeckoU.PeekUInt(0x30000034) == 0x0;
			if (!flag2)
			{
				this.numberPlayers++;
			}
			bool flag3 = MainForm.GeckoU.PeekUInt(0x30000054) == 0x0;
			if (!flag3)
			{
				this.numberPlayers++;
			}
			bool flag4 = MainForm.GeckoU.PeekUInt(0x30000074) == 0x0;
			if (!flag4)
			{
				this.numberPlayers++;
			}
			bool flag5 = MainForm.GeckoU.PeekUInt(0x30000094) == 0x0;
			if (!flag5)
			{
				this.numberPlayers++;
			}
			bool flag6 = MainForm.GeckoU.PeekUInt(0x300000B4) == 0x0;
			if (!flag6)
			{
				this.numberPlayers++;
			}
			bool flag7 = MainForm.GeckoU.PeekUInt(0x300000D4) == 0x0;
			if (!flag7)
			{
				this.numberPlayers++;
			}
			bool flag8 = MainForm.GeckoU.PeekUInt(0x300000F4) == 0x0;
			if (!flag8)
			{
				this.numberPlayers++;
			}
			this.numberPlayersLabel.Text = this.numberPlayersText + this.numberPlayers.ToString();
			bool flag9 = this.numberPlayers >= 1;
			if (flag9)
			{
				bool flag10 = MainForm.GeckoU.PeekUInt(0x30000014) <= 0x10000000;
				if (flag10)
				{
					uint num = MainForm.GeckoU.PeekUInt(0x30000002);
					char c = (char)num;
					uint num2 = MainForm.GeckoU.PeekUInt(0x30000004);
					char c2 = (char)num2;
					uint num3 = MainForm.GeckoU.PeekUInt(0x30000006);
					char c3 = (char)num3;
					uint num4 = MainForm.GeckoU.PeekUInt(0x30000008);
					char c4 = (char)num4;
					uint num5 = MainForm.GeckoU.PeekUInt(0x3000000A);
					char c5 = (char)num5;
					uint num6 = MainForm.GeckoU.PeekUInt(0x3000000C);
					char c6 = (char)num6;
					uint num7 = MainForm.GeckoU.PeekUInt(0x3000000E);
					char c7 = (char)num7;
					this.player1Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
					{
						c,
						c2,
						c3,
						c4,
						c5,
						c6,
						c7
					});
				}
				else
				{
					uint num8 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) - 0x2);
					char c8 = (char)num8;
					uint num9 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014));
					char c9 = (char)num9;
					uint num10 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x2);
					char c10 = (char)num10;
					uint num11 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x4);
					char c11 = (char)num11;
					uint num12 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x6);
					char c12 = (char)num12;
					uint num13 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x8);
					char c13 = (char)num13;
					uint num14 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0xA);
					char c14 = (char)num14;
					uint num15 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0xC);
					char c15 = (char)num15;
					uint num16 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0xE);
					char c16 = (char)num16;
					uint num17 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x10);
					char c17 = (char)num17;
					uint num18 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x12);
					char c18 = (char)num18;
					uint num19 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x14);
					char c19 = (char)num19;
					uint num20 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x16);
					char c20 = (char)num20;
					uint num21 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x18);
					char c21 = (char)num21;
					uint num22 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x1A);
					char c22 = (char)num22;
					uint num23 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x1C);
					char c23 = (char)num23;
					uint num24 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000014) + 0x1E);
					char c24 = (char)num24;
					this.player1Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}", new object[]
					{
						c8,
						c9,
						c10,
						c11,
						c12,
						c13,
						c14,
						c15,
						c16,
						c17,
						c18,
						c19,
						c20,
						c21,
						c22,
						c23,
						c24
					});
				}
				this.player1Label.Visible = true;
				this.player2Label.Visible = false;
				this.player3Label.Visible = false;
				this.player4Label.Visible = false;
				this.player5Label.Visible = false;
				this.player6Label.Visible = false;
				this.player7Label.Visible = false;
				this.player8Label.Visible = false;
			}
			bool flag11 = this.numberPlayers >= 2;
			if (flag11)
			{
				bool flag12 = MainForm.GeckoU.PeekUInt(0x30000014) == MainForm.GeckoU.PeekUInt(0x30000034);
				if (flag12)
				{
					uint num25 = MainForm.GeckoU.PeekUInt(0x30000022);
					char c25 = (char)num25;
					uint num26 = MainForm.GeckoU.PeekUInt(0x30000024);
					char c26 = (char)num26;
					uint num27 = MainForm.GeckoU.PeekUInt(0x30000026);
					char c27 = (char)num27;
					uint num28 = MainForm.GeckoU.PeekUInt(0x30000028);
					char c28 = (char)num28;
					uint num29 = MainForm.GeckoU.PeekUInt(0x3000002A);
					char c29 = (char)num29;
					uint num30 = MainForm.GeckoU.PeekUInt(0x3000002C);
					char c30 = (char)num30;
					uint num31 = MainForm.GeckoU.PeekUInt(0x3000002E);
					char c31 = (char)num31;
					this.player2Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
					{
						c25,
						c26,
						c27,
						c28,
						c29,
						c30,
						c31
					});
				}
				else
				{
					uint num32 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) - 0x2);
					char c32 = (char)num32;
					uint num33 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034));
					char c33 = (char)num33;
					uint num34 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x2);
					char c34 = (char)num34;
					uint num35 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x4);
					char c35 = (char)num35;
					uint num36 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x6);
					char c36 = (char)num36;
					uint num37 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x8);
					char c37 = (char)num37;
					uint num38 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0xA);
					char c38 = (char)num38;
					uint num39 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0xC);
					char c39 = (char)num39;
					uint num40 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0xE);
					char c40 = (char)num40;
					uint num41 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x10);
					char c41 = (char)num41;
					uint num42 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x12);
					char c42 = (char)num42;
					uint num43 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x14);
					char c43 = (char)num43;
					uint num44 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x16);
					char c44 = (char)num44;
					uint num45 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x18);
					char c45 = (char)num45;
					uint num46 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x1A);
					char c46 = (char)num46;
					uint num47 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x1C);
					char c47 = (char)num47;
					uint num48 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000034) + 0x1E);
					char c48 = (char)num48;
					this.player2Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}", new object[]
					{
						c32,
						c33,
						c34,
						c35,
						c36,
						c37,
						c38,
						c39,
						c40,
						c41,
						c42,
						c43,
						c44,
						c45,
						c46,
						c47,
						c48
					});
				}
				this.player1Label.Visible = true;
				this.player2Label.Visible = true;
				this.player3Label.Visible = false;
				this.player4Label.Visible = false;
				this.player5Label.Visible = false;
				this.player6Label.Visible = false;
				this.player7Label.Visible = false;
				this.player8Label.Visible = false;
			}
			bool flag13 = this.numberPlayers >= 3;
			if (flag13)
			{
				bool flag14 = MainForm.GeckoU.PeekUInt(0x30000034) == MainForm.GeckoU.PeekUInt(0x30000054);
				if (flag14)
				{
					uint num49 = MainForm.GeckoU.PeekUInt(0x30000042);
					char c49 = (char)num49;
					uint num50 = MainForm.GeckoU.PeekUInt(0x30000044);
					char c50 = (char)num50;
					uint num51 = MainForm.GeckoU.PeekUInt(0x30000046);
					char c51 = (char)num51;
					uint num52 = MainForm.GeckoU.PeekUInt(0x30000048);
					char c52 = (char)num52;
					uint num53 = MainForm.GeckoU.PeekUInt(0x3000004A);
					char c53 = (char)num53;
					uint num54 = MainForm.GeckoU.PeekUInt(0x3000004C);
					char c54 = (char)num54;
					uint num55 = MainForm.GeckoU.PeekUInt(0x3000004E);
					char c55 = (char)num55;
					this.player3Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
					{
						c49,
						c50,
						c51,
						c52,
						c53,
						c54,
						c55
					});
				}
				else
				{
					uint num56 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) - 0x2);
					char c56 = (char)num56;
					uint num57 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054));
					char c57 = (char)num57;
					uint num58 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x2);
					char c58 = (char)num58;
					uint num59 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x4);
					char c59 = (char)num59;
					uint num60 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x6);
					char c60 = (char)num60;
					uint num61 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x8);
					char c61 = (char)num61;
					uint num62 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0xA);
					char c62 = (char)num62;
					uint num63 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0xC);
					char c63 = (char)num63;
					uint num64 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0xE);
					char c64 = (char)num64;
					uint num65 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x10);
					char c65 = (char)num65;
					uint num66 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x12);
					char c66 = (char)num66;
					uint num67 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x14);
					char c67 = (char)num67;
					uint num68 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x16);
					char c68 = (char)num68;
					uint num69 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x18);
					char c69 = (char)num69;
					uint num70 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x1A);
					char c70 = (char)num70;
					uint num71 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x1C);
					char c71 = (char)num71;
					uint num72 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000054) + 0x1E);
					char c72 = (char)num72;
					this.player3Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}", new object[]
					{
						c56,
						c57,
						c58,
						c59,
						c60,
						c61,
						c62,
						c63,
						c64,
						c65,
						c66,
						c67,
						c68,
						c69,
						c70,
						c71,
						c72
					});
				}
				this.player1Label.Visible = true;
				this.player2Label.Visible = true;
				this.player3Label.Visible = true;
				this.player4Label.Visible = false;
				this.player5Label.Visible = false;
				this.player6Label.Visible = false;
				this.player7Label.Visible = false;
				this.player8Label.Visible = false;
			}
			bool flag15 = this.numberPlayers >= 4;
			if (flag15)
			{
				bool flag16 = MainForm.GeckoU.PeekUInt(0x30000054) == MainForm.GeckoU.PeekUInt(0x30000074);
				if (flag16)
				{
					uint num73 = MainForm.GeckoU.PeekUInt(0x30000062);
					char c73 = (char)num73;
					uint num74 = MainForm.GeckoU.PeekUInt(0x30000064);
					char c74 = (char)num74;
					uint num75 = MainForm.GeckoU.PeekUInt(0x30000066);
					char c75 = (char)num75;
					uint num76 = MainForm.GeckoU.PeekUInt(0x30000068);
					char c76 = (char)num76;
					uint num77 = MainForm.GeckoU.PeekUInt(0x3000006A);
					char c77 = (char)num77;
					uint num78 = MainForm.GeckoU.PeekUInt(0x3000006C);
					char c78 = (char)num78;
					uint num79 = MainForm.GeckoU.PeekUInt(0x3000006E);
					char c79 = (char)num79;
					this.player4Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
					{
						c73,
						c74,
						c75,
						c76,
						c77,
						c78,
						c79
					});
				}
				else
				{
					uint num80 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) - 0x2);
					char c80 = (char)num80;
					uint num81 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074));
					char c81 = (char)num81;
					uint num82 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x2);
					char c82 = (char)num82;
					uint num83 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x4);
					char c83 = (char)num83;
					uint num84 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x6);
					char c84 = (char)num84;
					uint num85 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x8);
					char c85 = (char)num85;
					uint num86 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0xA);
					char c86 = (char)num86;
					uint num87 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0xC);
					char c87 = (char)num87;
					uint num88 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0xE);
					char c88 = (char)num88;
					uint num89 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x10);
					char c89 = (char)num89;
					uint num90 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x12);
					char c90 = (char)num90;
					uint num91 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x14);
					char c91 = (char)num91;
					uint num92 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x16);
					char c92 = (char)num92;
					uint num93 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x18);
					char c93 = (char)num93;
					uint num94 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x1A);
					char c94 = (char)num94;
					uint num95 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x1C);
					char c95 = (char)num95;
					uint num96 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000074) + 0x1E);
					char c96 = (char)num96;
					this.player4Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}", new object[]
					{
						c80,
						c81,
						c82,
						c83,
						c84,
						c85,
						c86,
						c87,
						c88,
						c89,
						c90,
						c91,
						c92,
						c93,
						c94,
						c95,
						c96
					});
				}
				this.player1Label.Visible = true;
				this.player2Label.Visible = true;
				this.player3Label.Visible = true;
				this.player4Label.Visible = true;
				this.player5Label.Visible = false;
				this.player6Label.Visible = false;
				this.player7Label.Visible = false;
				this.player8Label.Visible = false;
			}
			bool flag17 = this.numberPlayers >= 5;
			if (flag17)
			{
				bool flag18 = MainForm.GeckoU.PeekUInt(0x30000074) == MainForm.GeckoU.PeekUInt(0x30000094);
				if (flag18)
				{
					uint num97 = MainForm.GeckoU.PeekUInt(0x30000082);
					char c97 = (char)num97;
					uint num98 = MainForm.GeckoU.PeekUInt(0x30000084);
					char c98 = (char)num98;
					uint num99 = MainForm.GeckoU.PeekUInt(0x30000086);
					char c99 = (char)num99;
					uint num100 = MainForm.GeckoU.PeekUInt(0x30000088);
					char c100 = (char)num100;
					uint num101 = MainForm.GeckoU.PeekUInt(0x3000008A);
					char c101 = (char)num101;
					uint num102 = MainForm.GeckoU.PeekUInt(0x3000008C);
					char c102 = (char)num102;
					uint num103 = MainForm.GeckoU.PeekUInt(0x3000008E);
					char c103 = (char)num103;
					this.player5Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
					{
						c97,
						c98,
						c99,
						c100,
						c101,
						c102,
						c103
					});
				}
				else
				{
					uint num104 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) - 0x2);
					char c104 = (char)num104;
					uint num105 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094));
					char c105 = (char)num105;
					uint num106 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x2);
					char c106 = (char)num106;
					uint num107 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x4);
					char c107 = (char)num107;
					uint num108 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x6);
					char c108 = (char)num108;
					uint num109 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x8);
					char c109 = (char)num109;
					uint num110 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0xA);
					char c110 = (char)num110;
					uint num111 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0xC);
					char c111 = (char)num111;
					uint num112 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0xE);
					char c112 = (char)num112;
					uint num113 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x10);
					char c113 = (char)num113;
					uint num114 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x12);
					char c114 = (char)num114;
					uint num115 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x14);
					char c115 = (char)num115;
					uint num116 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x16);
					char c116 = (char)num116;
					uint num117 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x18);
					char c117 = (char)num117;
					uint num118 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x1A);
					char c118 = (char)num118;
					uint num119 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x1C);
					char c119 = (char)num119;
					uint num120 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x30000094) + 0x1E);
					char c120 = (char)num120;
					this.player5Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}", new object[]
					{
						c104,
						c105,
						c106,
						c107,
						c108,
						c109,
						c110,
						c111,
						c112,
						c113,
						c114,
						c115,
						c116,
						c117,
						c118,
						c119,
						c120
					});
				}
				this.player1Label.Visible = true;
				this.player2Label.Visible = true;
				this.player3Label.Visible = true;
				this.player4Label.Visible = true;
				this.player5Label.Visible = true;
				this.player6Label.Visible = false;
				this.player7Label.Visible = false;
				this.player8Label.Visible = false;
			}
			bool flag19 = this.numberPlayers >= 6;
			if (flag19)
			{
				bool flag20 = MainForm.GeckoU.PeekUInt(0x30000094) == MainForm.GeckoU.PeekUInt(0x300000B4);
				if (flag20)
				{
					uint num121 = MainForm.GeckoU.PeekUInt(0x300000A2);
					char c121 = (char)num121;
					uint num122 = MainForm.GeckoU.PeekUInt(0x300000A4);
					char c122 = (char)num122;
					uint num123 = MainForm.GeckoU.PeekUInt(0x300000A6);
					char c123 = (char)num123;
					uint num124 = MainForm.GeckoU.PeekUInt(0x300000A8);
					char c124 = (char)num124;
					uint num125 = MainForm.GeckoU.PeekUInt(0x300000AA);
					char c125 = (char)num125;
					uint num126 = MainForm.GeckoU.PeekUInt(0x300000AC);
					char c126 = (char)num126;
					uint num127 = MainForm.GeckoU.PeekUInt(0x300000AE);
					char c127 = (char)num127;
					this.player6Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
					{
						c121,
						c122,
						c123,
						c124,
						c125,
						c126,
						c127
					});
				}
				else
				{
					uint num128 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) - 0x2);
					char c128 = (char)num128;
					uint num129 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4));
					char c129 = (char)num129;
					uint num130 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x2);
					char c130 = (char)num130;
					uint num131 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x4);
					char c131 = (char)num131;
					uint num132 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x6);
					char c132 = (char)num132;
					uint num133 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x8);
					char c133 = (char)num133;
					uint num134 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0xA);
					char c134 = (char)num134;
					uint num135 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0xC);
					char c135 = (char)num135;
					uint num136 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0xE);
					char c136 = (char)num136;
					uint num137 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x10);
					char c137 = (char)num137;
					uint num138 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x12);
					char c138 = (char)num138;
					uint num139 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x14);
					char c139 = (char)num139;
					uint num140 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x16);
					char c140 = (char)num140;
					uint num141 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x18);
					char c141 = (char)num141;
					uint num142 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x1A);
					char c142 = (char)num142;
					uint num143 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x1C);
					char c143 = (char)num143;
					uint num144 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000B4) + 0x1E);
					char c144 = (char)num144;
					this.player6Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}", new object[]
					{
						c128,
						c129,
						c130,
						c131,
						c132,
						c133,
						c134,
						c135,
						c136,
						c137,
						c138,
						c139,
						c140,
						c141,
						c142,
						c143,
						c144
					});
				}
				this.player1Label.Visible = true;
				this.player2Label.Visible = true;
				this.player3Label.Visible = true;
				this.player4Label.Visible = true;
				this.player5Label.Visible = true;
				this.player6Label.Visible = true;
				this.player7Label.Visible = false;
				this.player8Label.Visible = false;
			}
			bool flag21 = this.numberPlayers >= 7;
			if (flag21)
			{
				bool flag22 = MainForm.GeckoU.PeekUInt(0x300000B4) == MainForm.GeckoU.PeekUInt(0x300000D4);
				if (flag22)
				{
					uint num145 = MainForm.GeckoU.PeekUInt(0x300000C2);
					char c145 = (char)num145;
					uint num146 = MainForm.GeckoU.PeekUInt(0x300000C4);
					char c146 = (char)num146;
					uint num147 = MainForm.GeckoU.PeekUInt(0x300000C6);
					char c147 = (char)num147;
					uint num148 = MainForm.GeckoU.PeekUInt(0x300000C8);
					char c148 = (char)num148;
					uint num149 = MainForm.GeckoU.PeekUInt(0x300000CA);
					char c149 = (char)num149;
					uint num150 = MainForm.GeckoU.PeekUInt(0x300000CC);
					char c150 = (char)num150;
					uint num151 = MainForm.GeckoU.PeekUInt(0x300000CE);
					char c151 = (char)num151;
					this.player7Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
					{
						c145,
						c146,
						c147,
						c148,
						c149,
						c150,
						c151
					});
				}
				else
				{
					uint num152 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) - 0x2);
					char c152 = (char)num152;
					uint num153 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4));
					char c153 = (char)num153;
					uint num154 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x2);
					char c154 = (char)num154;
					uint num155 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x4);
					char c155 = (char)num155;
					uint num156 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x6);
					char c156 = (char)num156;
					uint num157 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x8);
					char c157 = (char)num157;
					uint num158 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0xA);
					char c158 = (char)num158;
					uint num159 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0xC);
					char c159 = (char)num159;
					uint num160 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0xE);
					char c160 = (char)num160;
					uint num161 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x10);
					char c161 = (char)num161;
					uint num162 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x12);
					char c162 = (char)num162;
					uint num163 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x14);
					char c163 = (char)num163;
					uint num164 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x16);
					char c164 = (char)num164;
					uint num165 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x18);
					char c165 = (char)num165;
					uint num166 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x1A);
					char c166 = (char)num166;
					uint num167 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x1C);
					char c167 = (char)num167;
					uint num168 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000D4) + 0x1E);
					char c168 = (char)num168;
					this.player7Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}", new object[]
					{
						c152,
						c153,
						c154,
						c155,
						c156,
						c157,
						c158,
						c159,
						c160,
						c161,
						c162,
						c163,
						c164,
						c165,
						c166,
						c167,
						c168
					});
				}
				this.player1Label.Visible = true;
				this.player2Label.Visible = true;
				this.player3Label.Visible = true;
				this.player4Label.Visible = true;
				this.player5Label.Visible = true;
				this.player6Label.Visible = true;
				this.player7Label.Visible = true;
				this.player8Label.Visible = false;
			}
			bool flag23 = this.numberPlayers >= 8;
			if (flag23)
			{
				bool flag24 = MainForm.GeckoU.PeekUInt(805306580u) == MainForm.GeckoU.PeekUInt(805306612u);
				if (flag24)
				{
					uint num169 = MainForm.GeckoU.PeekUInt(805306594u);
					char c169 = (char)num169;
					uint num170 = MainForm.GeckoU.PeekUInt(805306596u);
					char c170 = (char)num170;
					uint num171 = MainForm.GeckoU.PeekUInt(805306598u);
					char c171 = (char)num171;
					uint num172 = MainForm.GeckoU.PeekUInt(805306600u);
					char c172 = (char)num172;
					uint num173 = MainForm.GeckoU.PeekUInt(805306602u);
					char c173 = (char)num173;
					uint num174 = MainForm.GeckoU.PeekUInt(805306604u);
					char c174 = (char)num174;
					uint num175 = MainForm.GeckoU.PeekUInt(805306606u);
					char c175 = (char)num175;
					this.player8Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
					{
						c169,
						c170,
						c171,
						c172,
						c173,
						c174,
						c175
					});
				}
				else
				{
					uint num176 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) - 0x2);
					char c176 = (char)num176;
					uint num177 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4));
					char c177 = (char)num177;
					uint num178 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x2);
					char c178 = (char)num178;
					uint num179 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x4);
					char c179 = (char)num179;
					uint num180 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x6);
					char c180 = (char)num180;
					uint num181 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x8);
					char c181 = (char)num181;
					uint num182 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0xA);
					char c182 = (char)num182;
					uint num183 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0xC);
					char c183 = (char)num183;
					uint num184 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0xE);
					char c184 = (char)num184;
					uint num185 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x10);
					char c185 = (char)num185;
					uint num186 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x12);
					char c186 = (char)num186;
					uint num187 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x14);
					char c187 = (char)num187;
					uint num188 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x16);
					char c188 = (char)num188;
					uint num189 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x18);
					char c189 = (char)num189;
					uint num190 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x1A);
					char c190 = (char)num190;
					uint num191 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x1C);
					char c191 = (char)num191;
					uint num192 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x300000F4) + 0x1E);
					char c192 = (char)num192;
					this.player8Label.Text = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}", new object[]
					{
						c176,
						c177,
						c178,
						c179,
						c180,
						c181,
						c182,
						c183,
						c184,
						c185,
						c186,
						c187,
						c188,
						c189,
						c190,
						c191,
						c192
					});
				}
				this.player1Label.Visible = true;
				this.player2Label.Visible = true;
				this.player3Label.Visible = true;
				this.player4Label.Visible = true;
				this.player5Label.Visible = true;
				this.player6Label.Visible = true;
				this.player7Label.Visible = true;
				this.player8Label.Visible = true;
			}
			bool flag25 = this.numberPlayers >= 1;
			if (flag25)
			{
				uint num193 = MainForm.GeckoU.PeekUInt(0x38000000);
				uint num194 = MainForm.GeckoU.PeekUInt(0x38000004);
				uint num195 = MainForm.GeckoU.PeekUInt(0x38000008);
				string text = num193.ToString();
				bool flag26 = num193 > 0xFFFF;
				if (flag26)
				{
					num193 = uint.MaxValue + num193;
					text = "-" + (uint.MaxValue - num193).ToString();
				}
				string text2 = num194.ToString();
				bool flag27 = num194 > 0xFFFF;
				if (flag27)
				{
					num194 = uint.MaxValue + num194;
					text2 = "-" + (uint.MaxValue - num194).ToString();
				}
				string text3 = num195.ToString();
				bool flag28 = num195 > 0xFFFF;
				if (flag28)
				{
					num195 = uint.MaxValue + num195;
					text3 = "-" + (uint.MaxValue - num195).ToString();
				}
				this.x1Label.Text = text;
				this.y1Label3.Text = text2;
				this.z1Label3.Text = text3;
				this.x1Label.Visible = true;
				this.y1Label3.Visible = true;
				this.z1Label3.Visible = true;
				this.x2Label.Visible = false;
				this.y2Label.Visible = false;
				this.z2Label.Visible = false;
				this.x3Label.Visible = false;
				this.y3Label.Visible = false;
				this.z3Label.Visible = false;
				this.x4Label.Visible = false;
				this.y4Label.Visible = false;
				this.z4Label.Visible = false;
				this.x5Label.Visible = false;
				this.y5Label.Visible = false;
				this.z5Label.Visible = false;
				this.x6Label.Visible = false;
				this.y6Label.Visible = false;
				this.z6Label.Visible = false;
				this.x7Label.Visible = false;
				this.y7Label.Visible = false;
				this.z7Label.Visible = false;
				this.x8Label.Visible = false;
				this.y8Label.Visible = false;
				this.z8Label.Visible = false;
			}
			bool flag29 = this.numberPlayers >= 2;
			if (flag29)
			{
				uint num196 = MainForm.GeckoU.PeekUInt(0x38000010);
				uint num197 = MainForm.GeckoU.PeekUInt(0x38000014);
				uint num198 = MainForm.GeckoU.PeekUInt(0x38000018);
				string text4 = num196.ToString();
				bool flag30 = num196 > 0xFFFF;
				if (flag30)
				{
					num196 = uint.MaxValue + num196;
					text4 = "-" + (uint.MaxValue - num196).ToString();
				}
				string text5 = num197.ToString();
				bool flag31 = num197 > 0xFFFF;
				if (flag31)
				{
					num197 = uint.MaxValue + num197;
					text5 = "-" + (uint.MaxValue - num197).ToString();
				}
				string text6 = num198.ToString();
				bool flag32 = num198 > 0xFFFF;
				if (flag32)
				{
					num198 = uint.MaxValue + num198;
					text6 = "-" + (uint.MaxValue - num198).ToString();
				}
				this.x2Label.Text = text4;
				this.y2Label.Text = text5;
				this.z2Label.Text = text6;
				this.x1Label.Visible = true;
				this.y1Label3.Visible = true;
				this.z1Label3.Visible = true;
				this.x2Label.Visible = true;
				this.y2Label.Visible = true;
				this.z2Label.Visible = true;
				this.x3Label.Visible = false;
				this.y3Label.Visible = false;
				this.z3Label.Visible = false;
				this.x4Label.Visible = false;
				this.y4Label.Visible = false;
				this.z4Label.Visible = false;
				this.x5Label.Visible = false;
				this.y5Label.Visible = false;
				this.z5Label.Visible = false;
				this.x6Label.Visible = false;
				this.y6Label.Visible = false;
				this.z6Label.Visible = false;
				this.x7Label.Visible = false;
				this.y7Label.Visible = false;
				this.z7Label.Visible = false;
				this.x8Label.Visible = false;
				this.y8Label.Visible = false;
				this.z8Label.Visible = false;
			}
			bool flag33 = this.numberPlayers >= 3;
			if (flag33)
			{
				uint num199 = MainForm.GeckoU.PeekUInt(0x38000020);
				uint num200 = MainForm.GeckoU.PeekUInt(0x38000024);
				uint num201 = MainForm.GeckoU.PeekUInt(0x38000028);
				string text7 = num199.ToString();
				bool flag34 = num199 > 0xFFFF;
				if (flag34)
				{
					num199 = uint.MaxValue + num199;
					text7 = "-" + (uint.MaxValue - num199).ToString();
				}
				string text8 = num200.ToString();
				bool flag35 = num200 > 0xFFFF;
				if (flag35)
				{
					num200 = uint.MaxValue + num200;
					text8 = "-" + (uint.MaxValue - num200).ToString();
				}
				string text9 = num201.ToString();
				bool flag36 = num201 > 0xFFFF;
				if (flag36)
				{
					num201 = uint.MaxValue + num201;
					text9 = "-" + (uint.MaxValue - num201).ToString();
				}
				this.x3Label.Text = text7;
				this.y3Label.Text = text8;
				this.z3Label.Text = text9;
				this.x1Label.Visible = true;
				this.y1Label3.Visible = true;
				this.z1Label3.Visible = true;
				this.x2Label.Visible = true;
				this.y2Label.Visible = true;
				this.z2Label.Visible = true;
				this.x3Label.Visible = true;
				this.y3Label.Visible = true;
				this.z3Label.Visible = true;
				this.x4Label.Visible = false;
				this.y4Label.Visible = false;
				this.z4Label.Visible = false;
				this.x5Label.Visible = false;
				this.y5Label.Visible = false;
				this.z5Label.Visible = false;
				this.x6Label.Visible = false;
				this.y6Label.Visible = false;
				this.z6Label.Visible = false;
				this.x7Label.Visible = false;
				this.y7Label.Visible = false;
				this.z7Label.Visible = false;
				this.x8Label.Visible = false;
				this.y8Label.Visible = false;
				this.z8Label.Visible = false;
			}
			bool flag37 = this.numberPlayers >= 4;
			if (flag37)
			{
				uint num202 = MainForm.GeckoU.PeekUInt(0x38000030);
				uint num203 = MainForm.GeckoU.PeekUInt(0x38000034);
				uint num204 = MainForm.GeckoU.PeekUInt(0x38000038);
				string text10 = num202.ToString();
				bool flag38 = num202 > 0xFFFF;
				if (flag38)
				{
					num202 = uint.MaxValue + num202;
					text10 = "-" + (uint.MaxValue - num202).ToString();
				}
				string text11 = num203.ToString();
				bool flag39 = num203 > 0xFFFF;
				if (flag39)
				{
					num203 = uint.MaxValue + num203;
					text11 = "-" + (uint.MaxValue - num203).ToString();
				}
				string text12 = num204.ToString();
				bool flag40 = num204 > 0xFFFF;
				if (flag40)
				{
					num204 = uint.MaxValue + num204;
					text12 = "-" + (uint.MaxValue - num204).ToString();
				}
				this.x4Label.Text = text10;
				this.y4Label.Text = text11;
				this.z4Label.Text = text12;
				this.x1Label.Visible = true;
				this.y1Label3.Visible = true;
				this.z1Label3.Visible = true;
				this.x2Label.Visible = true;
				this.y2Label.Visible = true;
				this.z2Label.Visible = true;
				this.x3Label.Visible = true;
				this.y3Label.Visible = true;
				this.z3Label.Visible = true;
				this.x4Label.Visible = true;
				this.y4Label.Visible = true;
				this.z4Label.Visible = true;
				this.x5Label.Visible = false;
				this.y5Label.Visible = false;
				this.z5Label.Visible = false;
				this.x6Label.Visible = false;
				this.y6Label.Visible = false;
				this.z6Label.Visible = false;
				this.x7Label.Visible = false;
				this.y7Label.Visible = false;
				this.z7Label.Visible = false;
				this.x8Label.Visible = false;
				this.y8Label.Visible = false;
				this.z8Label.Visible = false;
			}
			bool flag41 = this.numberPlayers >= 5;
			if (flag41)
			{
				uint num205 = MainForm.GeckoU.PeekUInt(0x38000040);
				uint num206 = MainForm.GeckoU.PeekUInt(0x38000044);
				uint num207 = MainForm.GeckoU.PeekUInt(0x38000048);
				string text13 = num205.ToString();
				bool flag42 = num205 > 0xFFFF;
				if (flag42)
				{
					num205 = uint.MaxValue + num205;
					text13 = "-" + (uint.MaxValue - num205).ToString();
				}
				string text14 = num206.ToString();
				bool flag43 = num206 > 0xFFFF;
				if (flag43)
				{
					num206 = uint.MaxValue + num206;
					text14 = "-" + (uint.MaxValue - num206).ToString();
				}
				string text15 = num207.ToString();
				bool flag44 = num207 > 0xFFFF;
				if (flag44)
				{
					num207 = uint.MaxValue + num207;
					text15 = "-" + (uint.MaxValue - num207).ToString();
				}
				this.x5Label.Text = text13;
				this.y5Label.Text = text14;
				this.z5Label.Text = text15;
				this.x1Label.Visible = true;
				this.y1Label3.Visible = true;
				this.z1Label3.Visible = true;
				this.x2Label.Visible = true;
				this.y2Label.Visible = true;
				this.z2Label.Visible = true;
				this.x3Label.Visible = true;
				this.y3Label.Visible = true;
				this.z3Label.Visible = true;
				this.x4Label.Visible = true;
				this.y4Label.Visible = true;
				this.z4Label.Visible = true;
				this.x5Label.Visible = true;
				this.y5Label.Visible = true;
				this.z5Label.Visible = true;
				this.x6Label.Visible = false;
				this.y6Label.Visible = false;
				this.z6Label.Visible = false;
				this.x7Label.Visible = false;
				this.y7Label.Visible = false;
				this.z7Label.Visible = false;
				this.x8Label.Visible = false;
				this.y8Label.Visible = false;
				this.z8Label.Visible = false;
			}
			bool flag45 = this.numberPlayers >= 6;
			if (flag45)
			{
				uint num208 = MainForm.GeckoU.PeekUInt(0x38000050);
				uint num209 = MainForm.GeckoU.PeekUInt(0x38000054);
				uint num210 = MainForm.GeckoU.PeekUInt(0x38000058);
				string text16 = num208.ToString();
				bool flag46 = num208 > 0xFFFF;
				if (flag46)
				{
					num208 = uint.MaxValue + num208;
					text16 = "-" + (uint.MaxValue - num208).ToString();
				}
				string text17 = num209.ToString();
				bool flag47 = num209 > 0xFFFF;
				if (flag47)
				{
					num209 = uint.MaxValue + num209;
					text17 = "-" + (uint.MaxValue - num209).ToString();
				}
				string text18 = num210.ToString();
				bool flag48 = num210 > 0xFFFF;
				if (flag48)
				{
					num210 = uint.MaxValue + num210;
					text18 = "-" + (uint.MaxValue - num210).ToString();
				}
				this.x6Label.Text = text16;
				this.y6Label.Text = text17;
				this.z6Label.Text = text18;
				this.x1Label.Visible = true;
				this.y1Label3.Visible = true;
				this.z1Label3.Visible = true;
				this.x2Label.Visible = true;
				this.y2Label.Visible = true;
				this.z2Label.Visible = true;
				this.x3Label.Visible = true;
				this.y3Label.Visible = true;
				this.z3Label.Visible = true;
				this.x4Label.Visible = true;
				this.y4Label.Visible = true;
				this.z4Label.Visible = true;
				this.x5Label.Visible = true;
				this.y5Label.Visible = true;
				this.z5Label.Visible = true;
				this.x6Label.Visible = true;
				this.y6Label.Visible = true;
				this.z6Label.Visible = true;
				this.x7Label.Visible = false;
				this.y7Label.Visible = false;
				this.z7Label.Visible = false;
				this.x8Label.Visible = false;
				this.y8Label.Visible = false;
				this.z8Label.Visible = false;
			}
			bool flag49 = this.numberPlayers >= 7;
			if (flag49)
			{
				uint num211 = MainForm.GeckoU.PeekUInt(0x38000060);
				uint num212 = MainForm.GeckoU.PeekUInt(0x38000064);
				uint num213 = MainForm.GeckoU.PeekUInt(0x38000068);
				string text19 = num211.ToString();
				bool flag50 = num211 > 0xFFFF;
				if (flag50)
				{
					num211 = uint.MaxValue + num211;
					text19 = "-" + (uint.MaxValue - num211).ToString();
				}
				string text20 = num212.ToString();
				bool flag51 = num212 > 0xFFFF;
				if (flag51)
				{
					num212 = uint.MaxValue + num212;
					text20 = "-" + (uint.MaxValue - num212).ToString();
				}
				string text21 = num213.ToString();
				bool flag52 = num213 > 0xFFFF;
				if (flag52)
				{
					num213 = uint.MaxValue + num213;
					text21 = "-" + (uint.MaxValue - num213).ToString();
				}
				this.x7Label.Text = text19;
				this.y7Label.Text = text20;
				this.z7Label.Text = text21;
				this.x1Label.Visible = true;
				this.y1Label3.Visible = true;
				this.z1Label3.Visible = true;
				this.x2Label.Visible = true;
				this.y2Label.Visible = true;
				this.z2Label.Visible = true;
				this.x3Label.Visible = true;
				this.y3Label.Visible = true;
				this.z3Label.Visible = true;
				this.x4Label.Visible = true;
				this.y4Label.Visible = true;
				this.z4Label.Visible = true;
				this.x5Label.Visible = true;
				this.y5Label.Visible = true;
				this.z5Label.Visible = true;
				this.x6Label.Visible = true;
				this.y6Label.Visible = true;
				this.z6Label.Visible = true;
				this.x7Label.Visible = true;
				this.y7Label.Visible = true;
				this.z7Label.Visible = true;
				this.x8Label.Visible = false;
				this.y8Label.Visible = false;
				this.z8Label.Visible = false;
			}
			bool flag53 = this.numberPlayers >= 8;
			if (flag53)
			{
				uint num214 = MainForm.GeckoU.PeekUInt(0x38000070);
				uint num215 = MainForm.GeckoU.PeekUInt(0x38000074);
				uint num216 = MainForm.GeckoU.PeekUInt(0x38000078);
				string text22 = num214.ToString();
				bool flag54 = num214 > 0xFFFF;
				if (flag54)
				{
					num214 = uint.MaxValue + num214;
					text22 = "-" + (uint.MaxValue - num214).ToString();
				}
				string text23 = num215.ToString();
				bool flag55 = num215 > 0xFFFF;
				if (flag55)
				{
					num215 = uint.MaxValue + num215;
					text23 = "-" + (uint.MaxValue - num215).ToString();
				}
				string text24 = num216.ToString();
				bool flag56 = num216 > 0xFFFF;
				if (flag56)
				{
					num216 = uint.MaxValue + num216;
					text24 = "-" + (uint.MaxValue - num216).ToString();
				}
				this.x8Label.Text = text22;
				this.y8Label.Text = text23;
				this.z8Label.Text = text24;
				this.x1Label.Visible = true;
				this.y1Label3.Visible = true;
				this.z1Label3.Visible = true;
				this.x2Label.Visible = true;
				this.y2Label.Visible = true;
				this.z2Label.Visible = true;
				this.x3Label.Visible = true;
				this.y3Label.Visible = true;
				this.z3Label.Visible = true;
				this.x4Label.Visible = true;
				this.y4Label.Visible = true;
				this.z4Label.Visible = true;
				this.x5Label.Visible = true;
				this.y5Label.Visible = true;
				this.z5Label.Visible = true;
				this.x6Label.Visible = true;
				this.y6Label.Visible = true;
				this.z6Label.Visible = true;
				this.x7Label.Visible = true;
				this.y7Label.Visible = true;
				this.z7Label.Visible = true;
				this.x8Label.Visible = true;
				this.y8Label.Visible = true;
				this.z8Label.Visible = true;
			}
			bool flag57 = this.numberPlayers >= 1;
			if (flag57)
			{
				this.givePlayerBox.Items[0] = this.player1Label.Text;
				this.EnchantPlayer.Items[0] = this.player1Label.Text;
			}
			else
			{
				this.givePlayerBox.Items[0] = "";
				this.EnchantPlayer.Items[0] = "";
			}
			bool flag58 = this.numberPlayers >= 2;
			if (flag58)
			{
				this.givePlayerBox.Items[1] = this.player2Label.Text;
				this.EnchantPlayer.Items[1] = this.player2Label.Text;
			}
			else
			{
				this.givePlayerBox.Items[1] = "";
				this.EnchantPlayer.Items[1] = "";
			}
			bool flag59 = this.numberPlayers >= 3;
			if (flag59)
			{
				this.givePlayerBox.Items[2] = this.player3Label.Text;
				this.EnchantPlayer.Items[2] = this.player3Label.Text;
			}
			else
			{
				this.givePlayerBox.Items[2] = "";
				this.EnchantPlayer.Items[2] = "";
			}
			bool flag60 = this.numberPlayers >= 4;
			if (flag60)
			{
				this.givePlayerBox.Items[3] = this.player4Label.Text;
				this.EnchantPlayer.Items[3] = this.player4Label.Text;
			}
			else
			{
				this.givePlayerBox.Items[3] = "";
				this.EnchantPlayer.Items[3] = "";
			}
			bool flag61 = this.numberPlayers >= 5;
			if (flag61)
			{
				this.givePlayerBox.Items[4] = this.player5Label.Text;
				this.EnchantPlayer.Items[4] = this.player5Label.Text;
			}
			else
			{
				this.givePlayerBox.Items[4] = "";
				this.EnchantPlayer.Items[4] = "";
			}
			bool flag62 = this.numberPlayers >= 6;
			if (flag62)
			{
				this.givePlayerBox.Items[5] = this.player6Label.Text;
				this.EnchantPlayer.Items[5] = this.player6Label.Text;
			}
			else
			{
				this.givePlayerBox.Items[5] = "";
				this.EnchantPlayer.Items[5] = "";
			}
			bool flag63 = this.numberPlayers >= 7;
			if (flag63)
			{
				this.givePlayerBox.Items[6] = this.player7Label.Text;
				this.EnchantPlayer.Items[6] = this.player7Label.Text;
			}
			else
			{
				this.givePlayerBox.Items[6] = "";
				this.EnchantPlayer.Items[6] = "";
			}
			bool flag64 = this.numberPlayers >= 8;
			if (flag64)
			{
				this.givePlayerBox.Items[7] = this.player8Label.Text;
				this.EnchantPlayer.Items[7] = this.player8Label.Text;
			}
			else
			{
				this.givePlayerBox.Items[7] = "";
				this.EnchantPlayer.Items[7] = "";
			}
			ulong num217 = MainForm.GeckoU.PeekULong(271593520u);
			bool flag65 = num217 > 11529215046068469760UL;
			if (flag65)
			{
				num217 = ulong.MaxValue - num217 + 1UL;
				this.seedText.Text = "Seed : -" + num217.ToString();
			}
			else
			{
				this.seedText.Text = "Seed : " + num217.ToString();
			}
		}

		private void GiveItemBTN_Click(object sender, EventArgs e)
        {


			bool @checked = this.giveToEveryone.Checked;
			if (@checked)
			{
				this.executeUpdateWorldInfo();
				bool flag = this.player1Label.Text != "Invalid Player";
				if (flag)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x0);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to player 1"
					});
					MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
					MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
					MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
					MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
					MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
					this.executeGiveItem();
				}
				bool flag2 = this.player2Label.Text != "Player 2";
				if (flag2)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x8);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to player 2"
					});
					MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
					MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
					MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
					MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
					MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
					this.executeGiveItem();
				}
				bool flag3 = this.player3Label.Text != "Player 3";
				if (flag3)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x10);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to player 3"
					});
					MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
					MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
					MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
					MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
					MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
					this.executeGiveItem();
				}
				bool flag4 = this.player4Label.Text != "Player 4";
				if (flag4)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x18);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to player 4"
					});
					MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
					MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
					MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
					MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
					MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
					this.executeGiveItem();
				}
				bool flag5 = this.player5Label.Text != "Player 5";
				if (flag5)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x20);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to player 5"
					});
					MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
					MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
					MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
					MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
					MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
					this.executeGiveItem();
				}
				bool flag6 = this.player6Label.Text != "Player 6";
				if (flag6)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x28);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to player 6"
					});
					MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
					MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
					MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
					MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
					MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
					this.executeGiveItem();
				}
				bool flag7 = this.player7Label.Text != "Player 7";
				if (flag7)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x30);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to player 7"
					});
					MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
					MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
					MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
					MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
					MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
					this.executeGiveItem();
				}
				bool flag8 = this.player8Label.Text != "Player 8";
				if (flag8)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x38);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to player 8"
					});
					MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
					MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
					MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
					MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
					MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
					this.executeGiveItem();
				}
			}
			else
			{
				bool flag9 = this.givePlayerBox.Text == "Invalid Player";
				if (flag9)
				{
					MainForm.GeckoU.WriteUInt(822084112u, 0x0);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag10 = this.givePlayerBox.Text == "Premier joueur";
				if (flag10)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x0);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag11 = this.givePlayerBox.SelectedIndex == 0;
				if (flag11)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x0);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag12 = this.givePlayerBox.SelectedIndex == 1;
				if (flag12)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x8);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag13 = this.givePlayerBox.SelectedIndex == 2;
				if (flag13)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x10);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag14 = this.givePlayerBox.SelectedIndex == 3;
				if (flag14)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x18);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag15 = this.givePlayerBox.SelectedIndex == 4;
				if (flag15)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x20);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag16 = this.givePlayerBox.SelectedIndex == 5;
				if (flag16)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x28);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag17 = this.givePlayerBox.SelectedIndex == 6;
				if (flag17)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x30);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				bool flag18 = this.givePlayerBox.SelectedIndex == 7;
				if (flag18)
				{
					MainForm.GeckoU.WriteUInt(0x31000210, 0x38);
					this.giveText = string.Concat(new string[]
					{
						"EZ-Cheatz: Given Item (ID: ",
						this.giveItemID.Value.ToString(),
						") to ",
						this.givePlayerBox.Text,
						""
					});
				}
				MainForm.GeckoU.clearString2(0x1061F270, 0x1061F360);
				MainForm.GeckoU.WriteStringUTF16(0x1061F270, this.giveText);
				MainForm.GeckoU.WriteUInt(0x31000214, MainForm.GeckoU.Mix(0x0, this.giveItemID.Value));
				MainForm.GeckoU.WriteUInt(0x3100021C, MainForm.GeckoU.Mix(0x0, this.giveItemDamage.Value));
				MainForm.GeckoU.WriteUInt(0x31000218, MainForm.GeckoU.Mix(0x0, this.giveItemNumber.Value));
				this.executeGiveItem();
			}
		}

		private void EnchantBTN_Click(object sender, EventArgs e)
		{
			//MainForm.GeckoU.WriteUInt(0x10303008, enchantments[enchantId.SelectedIndex]);
			//MainForm.GeckoU.WriteUInt(0x1030300C, (uint)int.Parse(enchantlvl.Text));
			//MainForm.GeckoU.WriteUInt(0x10303010, 0x1);
			//
			//MainForm.GeckoU.WriteBytes(0x03B10000, new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10,
			//	0x30, 0x93, 0xE1, 0x00, 0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9,
			//	0x03, 0xA6, 0x93, 0xA1, 0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61,
			//	0x29, 0x30, 0x10, 0x83, 0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34,
			//	0x2C, 0x04, 0x00, 0x00, 0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x2F, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x15, 0x18, 0x39, 0x04, 0x07,
			//	0x40, 0x7D, 0x29, 0x03, 0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6,
			//	0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38,
			//	0x80, 0x00, 0x00, 0x7D, 0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8,
			//	0x3C, 0x80, 0x10, 0x30, 0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00,
			//	0x1C, 0x3D, 0x20, 0x01, 0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1,
			//	0x00, 0x10, 0x7C, 0x08, 0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 });

			bool flag = this.enchantId.SelectedIndex == 0;
			if (flag)
			{
				this.enchantString = "00000000";
			}
			bool flag2 = this.enchantId.SelectedIndex == 1;
			if (flag2)
			{
				this.enchantString = "00000001";
			}
			bool flag3 = this.enchantId.SelectedIndex == 2;
			if (flag3)
			{
				this.enchantString = "00000002";
			}
			bool flag4 = this.enchantId.SelectedIndex == 3;
			if (flag4)
			{
				this.enchantString = "00000003";
			}
			bool flag5 = this.enchantId.SelectedIndex == 4;
			if (flag5)
			{
				this.enchantString = "00000004";
			}
			bool flag6 = this.enchantId.SelectedIndex == 5;
			if (flag6)
			{
				this.enchantString = "00000005";
			}
			bool flag7 = this.enchantId.SelectedIndex == 6;
			if (flag7)
			{
				this.enchantString = "00000006";
			}
			bool flag8 = this.enchantId.SelectedIndex == 7;
			if (flag8)
			{
				this.enchantString = "00000007";
			}
			bool flag9 = this.enchantId.SelectedIndex == 8;
			if (flag9)
			{
				this.enchantString = "00000008";
			}
			bool flag10 = this.enchantId.SelectedIndex == 9;
			if (flag10)
			{
				this.enchantString = "00000009";
			}
			bool flag11 = this.enchantId.SelectedIndex == 10;
			if (flag11)
			{
				this.enchantString = "00000010";
			}
			bool flag12 = this.enchantId.SelectedIndex == 11;
			if (flag12)
			{
				this.enchantString = "00000011";
			}
			bool flag13 = this.enchantId.SelectedIndex == 12;
			if (flag13)
			{
				this.enchantString = "00000012";
			}
			bool flag14 = this.enchantId.SelectedIndex == 13;
			if (flag14)
			{
				this.enchantString = "00000013";
			}
			bool flag15 = this.enchantId.SelectedIndex == 14;
			if (flag15)
			{
				this.enchantString = "00000014";
			}
			bool flag16 = this.enchantId.SelectedIndex == 15;
			if (flag16)
			{
				this.enchantString = "00000015";
			}
			bool flag17 = this.enchantId.SelectedIndex == 16;
			if (flag17)
			{
				this.enchantString = "00000020";
			}
			bool flag18 = this.enchantId.SelectedIndex == 17;
			if (flag18)
			{
				this.enchantString = "00000021";
			}
			bool flag19 = this.enchantId.SelectedIndex == 18;
			if (flag19)
			{
				this.enchantString = "00000022";
			}
			bool flag20 = this.enchantId.SelectedIndex == 19;
			if (flag20)
			{
				this.enchantString = "00000023";
			}
			bool flag21 = this.enchantId.SelectedIndex == 20;
			if (flag21)
			{
				this.enchantString = "00000030";
			}
			bool flag22 = this.enchantId.SelectedIndex == 21;
			if (flag22)
			{
				this.enchantString = "00000031";
			}
			bool flag23 = this.enchantId.SelectedIndex == 22;
			if (flag23)
			{
				this.enchantString = "00000032";
			}
			bool flag24 = this.enchantId.SelectedIndex == 23;
			if (flag24)
			{
				this.enchantString = "00000033";
			}
			bool flag25 = this.enchantId.SelectedIndex == 24;
			if (flag25)
			{
				this.enchantString = "0000003D";
			}
			bool flag26 = this.enchantId.SelectedIndex == 25;
			if (flag26)
			{
				this.enchantString = "0000003E";
			}
			bool flag27 = this.enchantId.SelectedIndex == 26;
			if (flag27)
			{
				this.enchantString = "00000041";
			}
			bool flag28 = this.enchantId.SelectedIndex == 27;
			if (flag28)
			{
				this.enchantString = "00000042";
			}
			bool flag29 = this.enchantId.SelectedIndex == 28;
			if (flag29)
			{
				this.enchantString = "00000043";
			}
			bool flag30 = this.enchantId.SelectedIndex == 29;
			if (flag30)
			{
				this.enchantString = "00000044";
			}
			bool flag31 = this.enchantId.SelectedIndex == 30;
			if (flag31)
			{
				this.enchantString = "00000046";
			}
			bool flag32 = this.enchantId.SelectedIndex == 31;
			if (flag32)
			{
				this.enchantString = "00000047";
			}
			MainForm.GeckoU.makeAssembly(0x10303008, enchantString);
			MainForm.GeckoU.WriteUInt(0x2081C9C, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2081D78, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2081E54, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2081FFC, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x20A8BA0, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2278618, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x22DDAC4, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x22E0680, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x22DB580, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2377B0C, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2426D84, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x244A47C, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2510714, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x25E6710, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x261B3C0, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x277EDEC, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x27F2CCC, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x29DE20C, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x29F2474, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x29F2F00, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x29F3080, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x29F31F8, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x29F2D48, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2A61FD8, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2A62C94, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x2AA824C, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x22DB580, 0x38607FFF);
			MainForm.GeckoU.WriteUInt(0x1030300C, MainForm.GeckoU.Mix(0x0, this.enchantLevel.Value));
			MainForm.GeckoU.WriteUInt(0x10303010, 0x0);
			this.enchantText = string.Concat(new string[]
			{
				"EZ-Cheatz: Enchanted Item with ",
				this.enchantId.Text,
				" ",
				this.enchantLevel.Value.ToString(),
				" "
			});
			MainForm.GeckoU.clearString2(274445988u, 274446216u);
			MainForm.GeckoU.WriteStringUTF16(274445988u, this.enchantText);
			MainForm.GeckoU.makeAssembly(59867608u, "9421FFE87C0802A63D0010303D40103093E100143FE0031663FF68189001001C938100087FE903A693A1000C3D20103093C1001061083008614A300C6129301083C8000083AA0000838900004E800421808300342C0400004182006C3D20022F3C60103061291518390407407D2903A67F87E3787FA6EB787FC5F378606330004CC631824E8004217FE903A64E8004213D20031B61292654388000007D2903A64CC631824E8004213D2003046129A5D83C8010307D2903A6608430004CC631824E8004218001001C3D20010F61296AE08381000883A1000C7D2903A683C100107C0803A683E10014382100184E80002060000000");
			MainForm.GeckoU.CallFunction(59867608u, new uint[1]);
		}

        private void TimeBTN_Click(object sender, EventArgs e)
        {
            byte[] Command = new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 
                0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 
                0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 
                0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 
                0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x9F, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x92, 0xE0, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 
                0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 
                0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 
                0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 
                0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 
                0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 
                0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 };

            MainForm.GeckoU.WriteUInt(0x10303008, 0x0);
            MainForm.GeckoU.WriteUInt(0x1030300C, (uint)int.Parse(settime.Text));
            MainForm.GeckoU.WriteUInt(0x10303010, 0x0);
            MainForm.GeckoU.WriteBytes(0x03B20000, Command);
            MainForm.GeckoU.CallFunction(0x03B20000, new uint[1]);
        }

        private void KillBTN_Click(object sender, EventArgs e)
        {
            byte[] Command = new byte[] { 0x94, 0x21, 0xFF, 0xE8, 0x7C, 0x08, 0x02, 0xA6, 0x3D, 0x00, 0x10, 0x30, 0x3D, 0x40, 0x10, 0x30, 0x93, 0xE1, 0x00, 
                0x14, 0x3F, 0xE0, 0x03, 0x16, 0x63, 0xFF, 0x68, 0x18, 0x90, 0x01, 0x00, 0x1C, 0x93, 0x81, 0x00, 0x08, 0x7F, 0xE9, 0x03, 0xA6, 0x93, 0xA1, 
                0x00, 0x0C, 0x3D, 0x20, 0x10, 0x30, 0x93, 0xC1, 0x00, 0x10, 0x61, 0x08, 0x30, 0x08, 0x61, 0x4A, 0x30, 0x0C, 0x61, 0x29, 0x30, 0x10, 0x83, 
                0xC8, 0x00, 0x00, 0x83, 0xAA, 0x00, 0x00, 0x83, 0x89, 0x00, 0x00, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x83, 0x00, 0x34, 0x2C, 0x04, 0x00, 0x00, 
                0x41, 0x82, 0x00, 0x6C, 0x3D, 0x20, 0x02, 0x52, 0x3C, 0x60, 0x10, 0x30, 0x61, 0x29, 0x0B, 0x58, 0x39, 0x04, 0x07, 0x40, 0x7D, 0x29, 0x03, 
                0xA6, 0x7F, 0x87, 0xE3, 0x78, 0x7F, 0xA6, 0xEB, 0x78, 0x7F, 0xC5, 0xF3, 0x78, 0x60, 0x63, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 
                0x04, 0x21, 0x7F, 0xE9, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x1B, 0x61, 0x29, 0x26, 0x54, 0x38, 0x80, 0x00, 0x00, 0x7D, 
                0x29, 0x03, 0xA6, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x3D, 0x20, 0x03, 0x04, 0x61, 0x29, 0xA5, 0xD8, 0x3C, 0x80, 0x10, 0x30, 
                0x7D, 0x29, 0x03, 0xA6, 0x60, 0x84, 0x30, 0x00, 0x4C, 0xC6, 0x31, 0x82, 0x4E, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x1C, 0x3D, 0x20, 0x01, 
                0x0F, 0x61, 0x29, 0x6A, 0xE0, 0x83, 0x81, 0x00, 0x08, 0x83, 0xA1, 0x00, 0x0C, 0x7D, 0x29, 0x03, 0xA6, 0x83, 0xC1, 0x00, 0x10, 0x7C, 0x08, 
                0x03, 0xA6, 0x83, 0xE1, 0x00, 0x14, 0x38, 0x21, 0x00, 0x18, 0x4E, 0x80, 0x00, 0x20, 0x60, 0x00, 0x00, 0x00 };

            MainForm.GeckoU.WriteUInt(0x10303008, 0x0);
            MainForm.GeckoU.WriteUInt(0x1030300C, 0x0);
            MainForm.GeckoU.WriteUInt(0x10303010, 0x0);
            MainForm.GeckoU.WriteBytes(0x03B30000, Command);
            MainForm.GeckoU.CallFunction(0x03B30000, new uint[1]);
        }

        private void enchantmentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void metroButton1_Click(object sender, EventArgs e)
        {
			executeUpdateWorldInfo();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
			
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enchantId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
			try
			{
				var player_ptr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34);
				var amount = Convert.ToInt32(xpAmountBox.Text);
				MainForm.GeckoU.CallFunction(0x02725330, player_ptr, unchecked((uint)amount));
			}
			catch (Exception)
			{
				MetroMessageBox.Show(this, "An error has occurred.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

        private void metroButton3_Click(object sender, EventArgs e)
        {
			try
			{
				var player_ptr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34);
				var amount = Convert.ToInt32(xpAmountBox.Text);
				MainForm.GeckoU.CallFunction(0x027250DC, player_ptr, unchecked((uint)amount));
			}
			catch (Exception)
			{
				MetroMessageBox.Show(this, "An error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void metroButton5_Click(object sender, EventArgs e)
        {
			try
			{
				var player_ptr = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34);
				var amount = Convert.ToInt32("-" + xpAmountBox.Text);
				MainForm.GeckoU.CallFunction(0x02725330, player_ptr, unchecked((uint)amount));
			}
			catch (Exception)
			{
				MetroMessageBox.Show(this, "An error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void CommandsMinigame_CheckedChanged(object sender, EventArgs e)
        {
			MainForm.GeckoU.WriteUIntToggle(0x022F0774, 0x38600000, 0x38600002, CommandsMinigame.Checked);
			MainForm.GeckoU.WriteUIntToggle(0x0245FC9C, 0x38600000, 0x38600002, CommandsMinigame.Checked);
			MainForm.GeckoU.WriteUIntToggle(0x02520964, 0x38600000, 0x38600002, CommandsMinigame.Checked);
			MainForm.GeckoU.WriteUIntToggle(0x029F8FE0, 0x38600000, 0x38600002, CommandsMinigame.Checked);
			MainForm.GeckoU.WriteUIntToggle(0x029FFE60, 0x38600000, 0x38600002, CommandsMinigame.Checked);
		}
    }
}
