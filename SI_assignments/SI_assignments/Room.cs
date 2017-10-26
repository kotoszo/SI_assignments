using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_assignments
{
    class Room
    {
        private int roomNumber;

        public Room()
        {
            this.roomNumber = 123;
        }

        public int RoomNumber
        {
            get { return this.roomNumber; }
            set { this.roomNumber = value; }
        }
    }
}
