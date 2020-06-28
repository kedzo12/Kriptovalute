using BitcoinLib.Services.Coins.Bitcoin;
using Microsoft.AspNetCore.Mvc;

namespace kripto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CryptoController : ControllerBase
    {
        BitcoinService bcs;
        public string txId = "c3f11d1708ac20eff9137d4eadd62dd99d71ce22dc51bc51d4e5b83958d9596d";
        //public string txId = "883e8793c63bd947c31b14d61034647132d5324bb4a64ffc049e1abb8fcc2dd4";
        //public string txId = "74a6902a64471b65e2e536cc58663eae8d26ce1a5262c39dd2528c703ade05c0";

        public CryptoController()
        {
            bcs = new BitcoinService("http://blockchain.oss.unist.hr:8332", "student", "2B4DB3SmsM2B4DB3SmsM89QjgYFp89QjgYFp", "mywallet", 20);

        }

        [HttpGet]
        public ActionResult<Crypto> Get()
        {
            var transaction = bcs.GetRawTransaction(txId, 1);
            var blockInfo = bcs.GetBlockchainInfo();
            var acc = bcs.GetWalletInfo();
            return new Crypto
            {
                TransactionId = transaction.TxId,
                TransactionBlockHash = transaction.BlockHash,
                TransactionBlockTime = transaction.BlockTime,
                TransactionTime = transaction.Time,
                TransactionConfirmations = transaction.Confirmations,
                TransactionHex = transaction.Hex,
                TransactionLockTime = transaction.LockTime,
                TransactionVersion = transaction.Version,
                Chain = blockInfo.Chain,
                BlockHash = blockInfo.BestBlockHash,
                Blocks = blockInfo.Blocks,
                Balance = acc.Balance
            };
        }
    }
}
