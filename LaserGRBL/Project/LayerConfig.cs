﻿using LaserGRBLPlus.Libraries.GRBLLibrary;
using LaserGRBLPlus.RasterConverter;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LaserGRBLPlus
{
    public class LayerConfig
    {
        public GCodeConfig GCodeConfig { get; set; } = new GCodeConfig();
        public Color PreviewColor { get; set; }
        
        
       
        
        
        //public float OffsetX { get; internal set; } = 0;
        //public float OffsetY { get; internal set; } = 0;


        public float ImageWidth { get; internal set; } = 100;
        public float ImageHeight { get; internal set; } = 100;
       
        public bool IsRasterHiRes { get; internal set; } = false;
        
        public Enum Direction { get; internal set; } = ImageProcessor.Direction.Horizontal;
        public decimal Quality { get; internal set; } = 3.0m;
        public bool Preview { get; internal set; } = true;
        
        //public decimal SpotRemovalValue { get; internal set; } = 2.0m;
      //  public bool SmootingEnabled { get; internal set; } = false;
        //public decimal SmootingValue { get; internal set; } = 1.0m;
       // public bool OptimizeEnabled { get; internal set; } = false;
        public bool UseAdaptiveQualityEnabled { get; internal set; } = false;
        
        public bool DownSampleEnabled { get; internal set; } = false;
        public decimal DownSampleValue { get; internal set; } = 2.0m;
        
        public Enum FillingDirection { get; internal set; } = ImageProcessor.Direction.None;
        public decimal FillingQuality { get; internal set; } = 3.0m;
        public InterpolationMode Interpolation { get; internal set; } = InterpolationMode.HighQualityBicubic;
        public ImageTransform.Formula Mode { get; internal set; } = ImageTransform.Formula.SimpleAverage;
        public int R { get; internal set; } = 100;
        public int G { get; internal set; } = 100;
        public int B { get; internal set; } = 100;
        public int Brightness { get; internal set; } = 100;
        public int Contrast { get; internal set; } = 100;
        public bool ThresholdEnabled { get; set; } = false;
        public int ThresholdValue { get; internal set; } = 50;
        public int WhiteClip { get; internal set; } = 5;
        public ImageTransform.DitheringMode DitheringMode { get; internal set; } = ImageTransform.DitheringMode.None;
    //    public bool LineThresholdEnabled { get; internal set; } = true;
      //  public int LineThresholdValue { get; internal set; } = 10;
        //public bool CornerThresholdEnabled { get; internal set; } = true;
//        public int CornerThresholdValue { get; internal set; } = 110;

        public LayerConfig()
        {
        }
    }
}
