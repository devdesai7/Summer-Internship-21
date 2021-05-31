using System;
using System.Collections.Generic;

namespace Insem2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Q3();
            // Q4();
        }

        //Q1

        enum PhotoType { Jpeg, Png };

        class Img
        {

        }
        class Jpeg :Img { }   /* represents a JPEG file */
        class JpegFilter
        {
            public Jpeg GrayScale(Jpeg jpeg) { /*convert to grayscale*/ return jpeg; }
        }
        class Png : Img { }  /* represents a PNG file */
        class PngFilter
        {
            public Png GrayScale(Png png) { /*convert to grayscale*/ return png; }

            internal Img GrayScale(Img photo)
            {
                throw new NotImplementedException();
            }
        }

        class PhotoStudio
        {
            private JpegFilter jpegFilter;
            private PngFilter pngFilter;
            private List<Jpeg> jpegs;
            private List<Png> pngs;
            private List<Img> img;

            public void PlaceOrder(List<Jpeg> jpegPhotos, List<Png> pngPhotos, PhotoType
           image)
            {
                switch (image)
                {
                    case PhotoType.Jpeg:
                        jpegFilter = new JpegFilter();
                                       jpegs = jpegPhotos;
                        break;
                    case PhotoType.Png:
                        pngFilter = new PngFilter();
                        pngs = pngPhotos;
                        break;
                }
            }
                        //Changed the Code acc to DRY
            public List<Img> GetGrayScaleAlbum()
            {
                List<Img> album = new List<Img>();
                foreach (var photo in album)
                    album.Add(pngFilter.GrayScale(photo));
                return album;
            }
        }


        public static void Q3()
            {
     
               int i = 123;
               object o = i; // Boxing
               i = 456; 
               int j = (int)o; //unBoxing
               System.Console.WriteLine(i);
               System.Console.WriteLine(j);
 
} 

       
        //Below this all material is for Q4
    public static void Q4()
    {
     //   I: Interface Segregation Principle(ISP) is been violted 
     //We can break the interface in more categories as there can be a possiblity that a anaimal can only walk
     //or a animal can only swim , but according to interface it will force to add the value in it ,regardless of null
     // and according to the principle the No object  should forced to implement interface which it does not use
  
        
        }
        interface IAnimal
        {
            void Breathe();
          
        }
          interface IMammal : IAnimal
        {
            void Walk();
        }
            interface IFish : IAnimal
        {
            void Swim();

        }
        class Fish : IFish
        {
            public void Breathe()
            {
                throw new NotImplementedException();
            }

            public void Swim()
            {
                throw new NotImplementedException();
            }
        }
        class Bull : IMammal
        {
            public void Breathe()
            {
                throw new NotImplementedException();
            }

            public void Walk()
            {
                throw new NotImplementedException();
            }
        }

    }



}
