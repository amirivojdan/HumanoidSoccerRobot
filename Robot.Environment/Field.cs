﻿using System.Drawing;
using Robot.Environment.Color;

namespace Robot.Environment
{
    public class Field
    {

        public Point Location;
        public int FoundTime { set; get; }
        public int LostTime
        {
            set;
            get;
        }

        public ColorSpace Color
        {
            set;
            get;
        }

        public bool IsDetected
        {
            set;
            get;
        }

        public int Size
        {
            set;
            get;
        }

        public int Distance
        {
            set;
            get;
        }

        public Field()
        {
            Color = new ColorSpace();
        }

        public Field(string path)
        {
            Color = new ColorSpace(path);
        }

    }
}
