using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Blocks
{
    public class LockedChestBlock : BlockProvider
    {
        public static readonly byte BlockID = 0x5F;
        
        public override byte ID { get { return 0x5F; } }

        public override double Hardness { get { return 0; } }

        public override string DisplayName { get { return "Locked Chest"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(10, 1);
        }
    }
}