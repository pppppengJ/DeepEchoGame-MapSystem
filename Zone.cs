using System;
using System.Collections.Generic;
using System.Text;

namespace DeepEchoGame
{
    class Zone
    {
        public string Name;
        public List<Zone> ConnectedZones;
        public bool HasMonster;

        public Zone(string name) //생성 시 zone 정의
        {
            Name = name;
            ConnectedZones = new List<Zone>();
            HasMonster = false;
        }

        public void Connect(Zone name) //생성 시 zone 연결
        {
            ConnectedZones.Add(name);
        }

        public void MonsterIn() //zone에 몬스터 생김
        {
            HasMonster = true;
        }

        public void MonsterOut() //zone에 몬스터 사라짐
        {
            HasMonster = false;
        }

        public void PrintZone() //zone 정보 출력
        {
            Console.Write($"[{Name}]");

            Console.Write(" - 연결 통로: ");

            for (int i = 0; i < ConnectedZones.Count; i++)
            {
                Console.Write(ConnectedZones[i].Name);

                if (i < ConnectedZones.Count - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
