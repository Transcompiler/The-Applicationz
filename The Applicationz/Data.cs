using System;

namespace The_Statesman
{
    [Serializable]
    class Data : IData
    {
        //몰려드는 폭풍 확장팩 데이터
        string[] cataclysm = new string[] { "폭풍", "가뭄", "화산 폭발", "홍수", "산불" }; //재난
        int CO2; //이산화탄소

        //흥망성쇠 확장팩 데이터
        private static int eraScore = 100; //시대 점수
        public const int GOLDEN_AGE = 250; //황금기
        public const int NORMAL_AGE = 150; //정상기
        public const int DARK_AGE = 0; //암흑기
        public const bool HEROIC_AGE = false; //영웅기
        private static bool era; //현재 시대(황금기적 분류)

        //오리지널 데이터
        public static string civilName = "America";
        /* 시작 문명은 미국으로 고정되어 있으며 다음과 같은 보너스를 받는다:
         * 1. 헌법의 제정자들(외교 슬롯 = 와일드카드 슬롯)
         * 2. P-51 머스탱(폭격기 대체)
         * 3. 영화 스튜디오(관광 x2)
         * 4. ??
         */
        string[] cityName;
        string nationName;
        bool tech; //현재 시대(기술적 분류)
        int sciencePoint; //과학 점수
        int sciencePerTurn; //턴당 과학 점수
        int culturePoint; //문화 점수
        int culturePerTurn; //턴당 문화 점수
        int faithPoint; //종교 점수
        int faithPerTurn; //턴당 종교 점수
        int food; //도합 식량
        int foodPerTurn; //턴당 식량
        int gold; //보유 현금
        int goldPerTurn; //턴당 수입
        int production; //도합 생산력
        int productionPerTurn; //턴당 생산력
        int numberOfCity; //도시 갯수
        int pioneers; //개척자
        string[] difficult = new string[] { "개척자", "족장", "장군", "왕자", "왕", "황제", "불멸자", "신" }; //난이도
        string[] amenityList = new string[] { "황홀함", "행복함", "만족함", "불만족함", "불행함", "불안정함", "폭동" }; //전역 쾌적도
        string realDifficult = ""; //실제 난이도

        //외교 관련 데이터
        int warmongerPenalty; //전쟁광 페널티
        string diplomancyState; //외교 상태

        //프로퍼티 정의
        public int EraScore { get => eraScore; set => eraScore = value; }
        public bool Era { get => era; set => era = value; }
        public string NationName { get => nationName; set => nationName = value; }
        public bool Tech { get => tech; set => tech = value; }
        public int SciencePoint { get => sciencePoint; set => sciencePoint = value; }
        public int SciencePerTurn { get => sciencePerTurn; set => sciencePerTurn = value; }
        public string[] Cataclysm { get => cataclysm; set => cataclysm = value; }
        public int CulturePerTurn { get => culturePerTurn; set => culturePerTurn = value; }
        public int CulturePoint { get => culturePoint; set => culturePoint = value; }
        public int FaithPoint { get => faithPoint; set => faithPoint = value; }
        public int FaithPerTurn { get => faithPerTurn; set => faithPerTurn = value; }
        public int Food { get => food; set => food = value; }
        public int FoodPerTurn { get => foodPerTurn; set => foodPerTurn = value; }
        public int Production { get => production; set => production = value; }
        public int ProductionPerTurn { get => productionPerTurn; set => productionPerTurn = value; }
        public int CO21 { get => CO2; set => CO2 = value; }
        public string[] CityName { get => cityName; set => cityName = value; }
        public int NumberOfCity { get => numberOfCity; set => numberOfCity = value; }
        public string DiplomancyState { get => diplomancyState; set => diplomancyState = value; }
        public int WarmongerPenalty { get => warmongerPenalty; set => warmongerPenalty = value; }
        public int Pioneers { get => pioneers; set => pioneers = value; }
        public string[] Difficult { get => difficult; set => difficult = value; }
        public string[] AmenityList { get => amenityList; set => amenityList = value; }
        public int Gold { get => gold; set => gold = value; }
        public int GoldPerTurn { get => goldPerTurn; set => goldPerTurn = value; }
        public string RealDifficult { get => realDifficult; set => realDifficult = value; }
    }

    class Resource : IResource
    {
        public void makeResource()
        {

        }

        public void useResource()
        {

        }
    }

    class MilitaryResource : Resource
    {

    }

    class BonusResource : Resource
    {

    }

    class LuxuryResource : Resource
    {

    }

    class Tech : IResearchable
    {
        string[] bigtech = { "", "", "" };
    }

    class Civic : IResearchable
    {
        string[] bigcivic = { };
    }

    class Maps : IMaps
    {
        Maps()
        {
            makeMap();
        }

        public void makeMap()
        {
            //Console.WriteLine(Resource.ToString());
        }

        //public void
    }

    class Wonder : IWonder
    {
        int BonusScience;
        int BonusCulture;
        int BonusFaith;
        int BonusGold;
        int BonusFood;
        int BonusAmenity;
        int BonusProd;

        public Wonder()
        {
            PlayerData data = new PlayerData();
            data.GoldPerTurn = data.GoldPerTurn + BonusGold;
            data.SciencePerTurn = data.SciencePerTurn + BonusScience;
            data.FaithPerTurn = data.FaithPerTurn + BonusFaith;
            data.FoodPerTurn = data.FoodPerTurn + BonusFood;
            data.CulturePerTurn = data.CulturePerTurn + BonusCulture;
            data.GoldPerTurn = data.GoldPerTurn + BonusAmenity;
        }
    }

    class MilitaryUnit : IMilitaryUnit
    {

    }

    class Building : IBuildable
    {

    }

    [Serializable]
    class PlayerData : Data
    {
        public bool NewPlayer;

        public PlayerData()
        {
            NewPlayer = true;
        }
    }

    [Serializable]
    class PlayerTech : Tech
    {

    }

    class PlayerCivic : Civic
    {

    }

    class AIData : Data
    {

    }
}
