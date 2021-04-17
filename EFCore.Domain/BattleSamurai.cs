using System;
namespace EFCore.Domain
{
    public class BattleSamurai
    {
        public int BattleId { get; set; }

        public int SamuraiId { get; set; }

        public DateTime JoinedDate { get; set; }
    }
}
