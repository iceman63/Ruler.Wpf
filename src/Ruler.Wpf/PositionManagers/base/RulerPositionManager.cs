﻿using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Ruler.Wpf.PositionManagers
{
    public enum RulerPosition
    {
        Top,
        Left
    }

    public abstract class RulerPositionManager
    {

        public RulerPositionManager(RulerBase control) => Control = control;

        public RulerBase Control { get; private set; }

        public abstract Line CreateMajorLine(double offset);
        public abstract Line CreateMinorLine(double offset);
        public abstract TextBlock CreateText(double text, double offset);
        public abstract double GetSize();
        public abstract double GetHeight();

        public abstract bool UpdateMakerPosition(Line marker, Point position);

        protected virtual Line GetBaseLine() 
        {
            return new Line
            {
                Stroke = Control.StepColor,
                StrokeThickness = 1,
                Stretch = Stretch.None,
            };
        }

        protected virtual TextBlock GetTextBlock(string text)
        {
            return new TextBlock { Text = text };
        }
    }
}
