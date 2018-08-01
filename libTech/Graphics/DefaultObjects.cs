﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FishGfx.Graphics;

namespace libTech.Graphics {
	public static class DefaultShaders {
		static DefaultShaders() {
			// 2D

			Engine.LogFatal(() => {
				DefaultTextureColor2D = new ShaderProgram(new ShaderStage(ShaderType.VertexShader, "content/shaders/default2d.vert"),
					new ShaderStage(ShaderType.FragmentShader, "content/shaders/default_fullbright_color.frag"));
			});

			Engine.LogFatal(() => {
				DefaultColor2D = new ShaderProgram(new ShaderStage(ShaderType.VertexShader, "content/shaders/default2d.vert"),
					new ShaderStage(ShaderType.FragmentShader, "content/shaders/default_fullbright.frag"));
			});

			Engine.LogFatal(() => {
				Line2D = new ShaderProgram(new ShaderStage(ShaderType.VertexShader, "content/shaders/line2d.vert"),
					new ShaderStage(ShaderType.GeometryShader, "content/shaders/line.geom"),
					new ShaderStage(ShaderType.FragmentShader, "content/shaders/line.frag"));
			});

			Engine.LogFatal(() => {
				Point2D = new ShaderProgram(new ShaderStage(ShaderType.VertexShader, "content/shaders/point2d.vert"),
					new ShaderStage(ShaderType.GeometryShader, "content/shaders/point.geom"),
					new ShaderStage(ShaderType.FragmentShader, "content/shaders/point.frag"));
			});

			// 3D

			Engine.LogFatal(() => {
				Line3D = new ShaderProgram(new ShaderStage(ShaderType.VertexShader, "content/shaders/line3d.vert"),
					new ShaderStage(ShaderType.GeometryShader, "content/shaders/line.geom"),
					new ShaderStage(ShaderType.FragmentShader, "content/shaders/line.frag"));
			});

			Engine.LogFatal(() => {
				Point3D = new ShaderProgram(new ShaderStage(ShaderType.VertexShader, "content/shaders/point3d.vert"),
					new ShaderStage(ShaderType.GeometryShader, "content/shaders/point.geom"),
					new ShaderStage(ShaderType.FragmentShader, "content/shaders/point.frag"));
			});

			Engine.LogFatal(() => {
				DefaultColor3D = new ShaderProgram(new ShaderStage(ShaderType.VertexShader, "content/shaders/default.vert"),
					new ShaderStage(ShaderType.FragmentShader, "content/shaders/default_fullbright.frag"));
			});
		}

		public static ShaderProgram DefaultTextureColor2D;
		public static ShaderProgram DefaultColor2D;
		public static ShaderProgram Line2D;
		public static ShaderProgram Point2D;

		public static ShaderProgram Line3D;
		public static ShaderProgram Point3D;
		public static ShaderProgram DefaultColor3D;
	}

	public static class DefaultFonts {
		static DefaultFonts() {
			ConsoleFont = new FreetypeFont("content/fonts/Hack.ttf", 16);

			MainMenuSmall = new FreetypeFont("content/fonts/Hack.ttf", 16);
			MainMenuMedium = new FreetypeFont("content/fonts/Hack.ttf", 22);
			MainMenuBig = new FreetypeFont("content/fonts/Hack.ttf", 32);
		}

		public static FreetypeFont ConsoleFont;
		public static FreetypeFont MainMenuSmall;
		public static FreetypeFont MainMenuMedium;
		public static FreetypeFont MainMenuBig;
	}

	public static class DefaultTextures {
		static DefaultTextures() {
			Engine.LogFatal(() => Panel = Texture.FromFile("content/textures/gui/panel.png"));
			Engine.LogFatal(() => PanelTransparent = Texture.FromFile("content/textures/gui/panel_transparent.png"));
			Engine.LogFatal(() => Button = Texture.FromFile("content/textures/gui/button.png"));
			Engine.LogFatal(() => ButtonHover = Texture.FromFile("content/textures/gui/button_hover.png"));
			Engine.LogFatal(() => ButtonClick = Texture.FromFile("content/textures/gui/button_click.png"));
		}

		public static Texture Panel;
		public static Texture PanelTransparent;
		public static Texture Button;
		public static Texture ButtonHover;
		public static Texture ButtonClick;
	}
}