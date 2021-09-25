using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridExample_03_3_DataGridTemplateColumn_CellIsComb
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class HocSinh
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Room Room { get; set; }
    }

    public class Datas
    {
        public List<HocSinh> Items { get; set; }
        public List<Room> Rooms { get; set; }
        public Datas()
        {
            Rooms = new List<Room>()
            {
                new Room(){ID=1,Name="Room1"},
                new Room(){ID=2,Name="Room2"},
                new Room(){ID=3,Name="Room3"},

            };
            Items = new List<HocSinh>()
            {
                new HocSinh(){ Name="Huy1", Age=18, Room= Rooms[1]},
                new HocSinh(){ Name="Huy2",Age=18,Room= Rooms[0]},
                new HocSinh(){Name="Huy3",Age=18,Room= Rooms[1]},
                new HocSinh(){Name="Huy4",Age=18, Room= Rooms[2]},
            };
        }

    }
}
