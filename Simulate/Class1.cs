using System;
using System.Collections.Generic;
using System.Text;

namespace Simulate
{
    class Codes
    {
        public static void StartPoint()
        {
            InitArm();
            //플레이어 군사력
            int P1Antitank = 0; //대기병
            int P1Tank = 0; //전차; 중기병
            int P1HuntingTank = 0; //구축전차; 기갑대기병
            int P1Mechanized = 0; //기계화보병; 경기병
            int P1Infantry = 0; //보병
            int P1SelfPropelled = 0; //자주포; 기갑 원거리
            int P1TowedGun = 0; //견인포; 원거리
            int P1MRL = 0; //다연장 로켓포; 공성
            int P1MachineGun = 0; //기관총; 화력지원
            int P1AssaultGun = 0; //돌격포; 기갑 화력지원
            int P1Ranger = 0; //정찰
            int P1LightTank = 0; //기갑정찰

            //적 군사력
            int P2Antitank = 0; //대기병
            int P2Tank = 0; //전차
            int P2HuntingTank = 0; //구축전차
            int P2Mechanized = 0; //기계화보병
            int P2Infantry = 0; //보병
            int P2SelfPropelled = 0; //자주포
            int P2TowedGun = 0; //견인포
            int P2MRL = 0; //다연장 로켓포
            int P2MachineGun = 0; //기관총; 화력지원
            int P2AssaultGun = 0; //돌격포; 기갑 화력지원
            int P2Ranger = 0; //정찰
            int P2LightTank = 0; //기갑정찰

            //코드 시작부

            int v;
            string[] ArmList = { "대기병", "전차", "구축전차", "기계화보병", "보병", "자주포", " 견인포", "로켓포", "기관총", "돌격포", "정찰", "기갑정찰" };
            Console.WriteLine("전투 시뮬레이터를 시작합니다.");
            foreach (string var in ArmList)
            {
                Console.WriteLine("플레이어의 {0} 갯수를 입력하세요.", var);
                v = Int32.Parse(Console.ReadLine());
                switch (var)
                {
                    case "대기병":
                        P1Antitank = v;
                        break;
                    case "전차":
                        P1Tank = v;
                        break;
                    case "구축전차":
                        P1HuntingTank = v;
                        break;
                    case "기계화보병":
                        P1Mechanized = v;
                        break;
                    case "보병":
                        P1Infantry = v;
                        break;
                    case "자주포":
                        P1SelfPropelled = v;
                        break;
                    case "견인포":
                        P1TowedGun = v;
                        break;
                    case "로켓포":
                        P1MRL = v;
                        break;
                    case "기관총":
                        P1MachineGun = v;
                        break;
                    case "돌격포":
                        P1AssaultGun = v;
                        break;
                    case "정찰":
                        P1Ranger = v;
                        break;
                    case "기갑정찰":
                        P1LightTank = v;
                        break;
                    default:
                        break;
                }
            }

            foreach (string var in ArmList)
            {
                Console.WriteLine("적군의 {0} 갯수를 입력하세요.", var);
                v = Int32.Parse(Console.ReadLine());
                switch (var)
                {
                    case "대기병":
                        P2Antitank = v;
                        break;
                    case "전차":
                        P2Tank = v;
                        break;
                    case "구축전차":
                        P2HuntingTank = v;
                        break;
                    case "기계화보병":
                        P2Mechanized = v;
                        break;
                    case "보병":
                        P2Infantry = v;
                        break;
                    case "자주포":
                        P2SelfPropelled = v;
                        break;
                    case "견인포":
                        P2TowedGun = v;
                        break;
                    case "로켓포":
                        P2MRL = v;
                        break;
                    case "기관총":
                        P2MachineGun = v;
                        break;
                    case "돌격포":
                        P2AssaultGun = v;
                        break;
                    case "정찰":
                        P2Ranger = v;
                        break;
                    case "기갑정찰":
                        P2LightTank = v;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("정상적으로 입력되었습니다.");
            Console.WriteLine("이제 전투를 시작하겠습니다.");
            Console.WriteLine("계속하려면 Y를 입력하세요.");
            if (Console.ReadLine() == "Y")
            {
                Random rd = new Random();
                int rand = rd.Next(6);
                Console.WriteLine(rand);
                Console.WriteLine("");
            }
            else
                return;
        }
        static void InitArm()
        {

        }
    }
}

