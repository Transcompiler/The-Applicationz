using System;

namespace The_Statesman
{
    class Starter : IRoot
    {
        static void Main(string[] args)
        {
            try
            {
                SubMain();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("종료");
            }
            
        }

        static void SubMain()
        {
            //본격적인 시작부입니다. 스파게티 코드를 주의하세요.

            //초기화
            string Reader;
            int turn = 0;
            Data data = new Data();
            Function fn = new Function();

            //기능 시작
            Console.WriteLine("Hello World!");
            Console.WriteLine("The Statesman에 오신 것을 환영합니다. \n본격 정치 게임으로써 문명 6 하다가 문명해 버리면서 구상한 게임입니다. \n설명을 보시려면 ?을 입력하세요.");
            for (; ; )
            {
                turn++;
                Console.WriteLine("\n\n{0}턴째", turn);
                Console.WriteLine("명령을 입력하세요.");
            Main:
                Reader = Console.ReadLine();
                switch (Reader.ToUpper())
                {
                    case "?":
                        Console.WriteLine("군사창 열기: MIL\n통계창 열기: STAT\n생산창 열기: PROD\n외교창 열기: DP\n건설창 열기: CON\n기술 계층도 열기: SCN\n게임 종료: OFF\n지금 이 창 띄우기: ?");
                        goto Main; //'GOTO Statement Considered Harmful' Considered Harmful.
                    case "PROD":
                        Console.WriteLine();
                        break;
                    case "MIL":

                        Console.WriteLine("");
                        break;
                    case "DP":
                        string WP = "";
                        if (data.WarmongerPenalty > 100) WP = "철혈의 전쟁광";
                        if (data.WarmongerPenalty > 70) WP = "전쟁 애호가";
                        if (data.WarmongerPenalty > 40) WP = "전쟁 중립가";
                        if (data.WarmongerPenalty > 10) WP = "전쟁 반대자";
                        if (data.WarmongerPenalty < 11) WP = "평화주의자";
                        Console.WriteLine("현재 외교 관계: {0}", data.DiplomancyState);
                        Console.WriteLine("현재 전쟁광 페널티: {0}", WP);
                        break;
                    case "CON":
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
                        break;
                    case "STAT":
                        Console.WriteLine("도시 숫자: {0}", data.NumberOfCity);
                        break;
                    case "SCN":
                        Console.WriteLine();
                        break;
                    case "OFF":
                        Wonder wonder = new Wonder();
                        fn.completeWonder(wonder);
                        break;
                    default:
                        Console.WriteLine("올바른 명령이 아닙니다.");
                        goto Main;
                }
            }          
        }
    }
}