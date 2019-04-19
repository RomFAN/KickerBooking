using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KickerBooking.Entities
{
    public class UserInfo
    {
    public PlayerInfo Guest { get; set; }
    public TableInfo Table { get; set; }
    public GameInfo Game { get; set; }
    }
}
