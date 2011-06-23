﻿
namespace BitMaker.Miner.Plugin.Cpu
{

    /// <summary>
    /// Implements a CPU-bound algorithm to search the nonce space for a value to create a block. 
    /// </summary>
    public abstract class Hasher
    {

        public abstract unsafe uint? Solve(CpuPlugin cpu, Work work, uint* round1State, byte* round1Blocks, uint* round2State, byte* round2Blocks);

    }

}
