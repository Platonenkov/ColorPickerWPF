﻿using System;
using System.IO;

namespace WPF.ColorPicker
{
    public static class ColorPickerSettings
    {
        internal static bool UsingCustomPalette;
        public static string CustomColorsFilename = "CustomColorPalette.xml";
        public static string CustomColorsDirectory = Environment.CurrentDirectory;

        public static string CustomPaletteFilename {  get { return Path.Combine(CustomColorsDirectory, CustomColorsFilename); } }

    }
}
