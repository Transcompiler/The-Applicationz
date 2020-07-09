using System;
using System.Runtime.CompilerServices;

namespace The_Statesman
{
    class Function
    {
        public void setting()
        {
            MainClass.pd.NewPlayer = true;
            Console.WriteLine("The Stateman의 시작에 앞서 설정이 필요합니다.\n먼저 난이도를 선택하세요.\n개척자, 족장, 장군, 왕자, 왕, 황제, 불멸자, 신");
            //if Console.ReadLine(); 
        }

        public static string oneMoreTurn()
        {
            //초기화
            Function fn = new Function();
            string Reader;

            //본격적인 시작부입니다. 스파게티 코드를 주의하세요.
            Console.WriteLine("명령을 입력하세요.");
            if (MainClass.pd.NewPlayer == true) Console.WriteLine("도움말을 보시려면 ?을 입력하세요.\n또한 도움말을 제외한 모든 명령은 턴을 소모합니다.\n이 설명은 단 한 번만 표시됩니다.");
            Main:
            Reader = Console.ReadLine();
            switch (Reader.ToUpper())
            {
                case "?":
                    Line();
                    Console.WriteLine("군사창 열기: MIL\n통계창 열기: STAT\n생산창 열기: PROD\n외교창 열기: DP\n건설창 열기: CON\n기술 계층도 열기: SCN\n게임 종료: OFF\n지금 이 창 띄우기: ?");
                    Line();
                    goto Main; //'GOTO Statement Considered Harmful' Considered Harmful.
                case "PROD":
                    Line();
                    Console.WriteLine();
                    Line();
                    break;
                case "MIL":
                    Line();
                    Console.WriteLine("");
                    Line();
                    break;
                case "DP":
                    int WPV = MainClass.pd.WarmongerPenalty;
                    string WP = "";
                    string[] nationInWar = { "", "" };
                    if (WPV > 100) WP = "철혈의 전쟁광";
                    if (WPV > 70) WP = "전쟁 애호가";
                    if (WPV > 40) WP = "전쟁 반대자";
                    if (WPV > 10) WP = "평화주의자";
                    if (WPV < 11) WP = "전쟁 혐오자";
                    Line();
                    Console.WriteLine("현재 외교 관계: {0}", MainClass.pd.DiplomancyState);
                    Console.WriteLine("현재 전쟁광 인식도: {0} 페널티 수치: {1} ", WP, WPV);
                    Console.WriteLine("전쟁 중인 문명: {0}", nationInWar);
                    Line();
                    break;
                case "CON":
                    Line();
                    Console.WriteLine();
                    var v = Console.ReadLine();
                    if (v.ToUpper() == "Y")
                    {
                        fn.completeCity();
                        Console.WriteLine("정상적으로 건설되었습니다.");
                    }
                    else if (v.ToUpper() == "N")
                    {
                        Console.WriteLine("건설을 미룹니다.");
                    }
                    else Console.WriteLine("Y/N으로만 답해주세요.");
                    Line();
                    break;
                case "STAT":
                    Console.WriteLine("도시 숫자: {0}", MainClass.pd.NumberOfCity);
                    break;
                case "SCN":
                    Console.WriteLine();
                    break;
                case "OFF":
                    return "OFF";
                    Wonder wonder = new Wonder();
                    fn.completeWonder(wonder);
                    break;
                default:
                    Console.WriteLine("올바른 명령이 아닙니다.");
                    goto Main;
            }
            MainClass.pd.NewPlayer = false;
            return "NORMAL"
; }

        public void completeWonder(Wonder wdr)
        {
            string a = wdr.ToString();
        }

        public void completeCity()
        {

        }
        public static void Line()
        {
            Console.WriteLine("-------------------");
        }

        public static void Era()
        {
        }
    }

}
