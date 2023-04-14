using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Yoga
    {
        //Fields
        private string yogaMatColor;
        private int numberOfBlocks;
        private int numberofYogaStraps;
        private string videoToWatch;

        //Constructors
        public Yoga(string yogaMatColor, int numberOfBlocks, int numberofYogaStraps, string videoToWatch)
        {
            YogaMatColor = yogaMatColor;
            NumberOfBlocks = numberOfBlocks;
            NumberofYogaStraps = numberofYogaStraps;
            VideoToWatch = videoToWatch;
        }

        //Properties
        public string YogaMatColor { get => yogaMatColor; set => yogaMatColor = value; }
        public int NumberOfBlocks { get => numberOfBlocks; set => numberOfBlocks = value; }
        public int NumberofYogaStraps { get => numberofYogaStraps; set => numberofYogaStraps = value; }
        public string VideoToWatch { get => videoToWatch; set => videoToWatch = value; }

        public override string ToString()
        {
            return $"When I do yoga: I use my {yogaMatColor} mat, my {numberOfBlocks} blocks and my {numberofYogaStraps} yoga straps while watching {videoToWatch}.";
        }
    }
}
