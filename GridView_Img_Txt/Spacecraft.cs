using System;

namespace GridView_Img_Txt
{
    class Spacecraft
    {
        private String name;
        private int image;

        public Spacecraft(string name, int image)
        {
            this.name = name;
            this.image = image;
        }

        public string Name
        {
            get { return name; }
        }

        public int Image
        {
            get { return image; }
        }
    }
}