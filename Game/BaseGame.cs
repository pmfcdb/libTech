﻿using FishGfx;
using FishGfx.Graphics;
using FishMarkupLanguage;
using libTech;
using libTech.Entities;
using libTech.Graphics;
using libTech.GUI;
using libTech.Importer;
using libTech.libNative;
using libTech.Scripting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Color = FishGfx.Color;

namespace Game {
	public unsafe class Game : LibTechGame {
		static string[] QuitPrompts = new string[] {
			"     Really?",
			"Whyyyyyyyyy?",
			"Are you sure you really want to quit?",
			"Do you really want to quit?",
			"Are you not sure you do not want to not quit the game?",
			"(\"&#(!% (\"!/$!)\\ =!)\")",
			"Environment.Exit(0);",
			"The \"yes\" and \"no\" buttons on this prompt are reversed.",
			"Delete all your save files?",
			"Delete system32?",
			"      Yes. No.",
			"      No. Yes.",
			"         What?",
		};

		FMLDocument Doc;
		FileSystemWatcher FSW;

		object Locke = new object();

		public override void Load() {
			Doc = new FMLDocument();
			Doc.TagSet.AddTags("root", "window", "button", "label", "panel", "input", "layout", "row");

			FSW = new FileSystemWatcher("content/gui", "main_menu.fml");
			FSW.Changed += (S, E) => {
				lock (Locke) {
					FML.Parse("content/gui/main_menu.fml", Doc);
				}
			};
			FSW.EnableRaisingEvents = true;

			FML.Parse("content/gui/main_menu.fml", Doc);

			Lua.Set(Lua.GUIEnvironment, "OnNewGame", new Action(() => { }));
			Lua.Set(Lua.GUIEnvironment, "OnQuit", new Action(() => Environment.Exit(0)));
		}

		public override void DrawGUI(float Dt) {
			base.DrawGUI(Dt);

			lock (Locke) {
				Engine.GUI.DrawDocument(Doc);
			}
		}
	}
}