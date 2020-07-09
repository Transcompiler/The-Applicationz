/* 대망의 코드 첫 부분이지만,
 * 그렇게 중요치는 않습니다.
 * 온갖 것들을 전부 캡슐화 시켜 놨으니까요.
 * 꼴에 객체지향적으로 설계됐습니다.
 * ㅋㅋㅋㅋ 
 * 문명 6 본편과의 차이점:
 * 첫째. 정책카드의 부재
 * 둘째, 위인 시스템의 간소화
 * 셋째, 전투 시스템의 대폭 축소
 * 넷째, 생산력 일시불화(!)
 * 다섯째, 도국 시스템의 부재
 * 여섯째, 유레카 시스템 삭제
 * 일곱째. 과학/문화 시스템 완전히 변경
 */

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace The_Statesman
{
    class MainClass : IRoot
    {
        public static PlayerData pd = new PlayerData();
        public static PlayerTech pt = new PlayerTech();
        public static PlayerCivic pc = new PlayerCivic();

        static void Main(string[] args)
        {
            try
            {
                SubMain();
            }
            catch(Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine(e);
            }
            finally
            {
                //종료 처리. 그렇게 중요하진 않음.
                DataContractJsonSerializer s = new DataContractJsonSerializer(typeof(PlayerData));
                using(Stream stream = new FileStream("PlayerData.json", FileMode.OpenOrCreate))
                {
                    s.WriteObject(stream, pd);
                }
                using(Stream stream1 = new FileStream("PlayerData.json", FileMode.Open))
                {
                    PlayerData read = (PlayerData)s.ReadObject(stream1);
                    Console.WriteLine(read.RealDifficult);
                }
                Console.WriteLine("종료");
                Console.ReadLine();             
            }
            
        }

        static void SubMain()
        {                           
            int turn = 0;      
            //턴 넘기는 부분.
            Console.WriteLine("Hello World!");
            Console.WriteLine("The Statesman에 오신 것을 환영합니다. \n본격 정치 게임으로써 문명 6 하다가 문명해 버리면서 구상한 게임입니다. ");
            for (; ; )
            {
                turn++;
                Console.WriteLine("\n\n{0}턴째", turn);
                if (Function.oneMoreTurn() == "OFF")
                   break;
            }          
        }
    }
}