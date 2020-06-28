using System;

namespace kripto
{
    public class Crypto
    {
        public string TransactionId { get; set; }
        public string TransactionBlockHash { get; set; }
        public uint TransactionBlockTime { get; set; }
        public uint TransactionTime { get; set; }
        public int TransactionConfirmations { get; set; }
        public string TransactionHex { get; set; }
        public uint TransactionLockTime { get; set; }
        public long TransactionVersion { get; set; }
        public string Chain { get; set; }
        public string BlockHash { get; set; }
        public ulong Blocks { get; set; }
        public decimal Balance { get; set; }
    }
}
