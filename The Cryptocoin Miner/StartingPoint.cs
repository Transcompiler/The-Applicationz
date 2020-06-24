using System;

namespace The_Cryptocoin_Miner
{
    class StartingPoint
    {
        int coin;
        Graphic_Cards radeonCards = new Graphic_Cards("Radeon");
        Graphic_Cards nvidiaCards = new Graphic_Cards("NVIDIA");
        string currentGraphicCard;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //
        }
    }

    class Graphic_Cards : object
    {
        string[] graphicCards;
        public string[] GraphicCards { get => graphicCards; set => graphicCards = value; }

        public Graphic_Cards(string a)
        {
            if(a == "Radeon")
            {
                //GraphicCards[] = {"",""};
            }
            else
            {

            }
        }
    }
}
