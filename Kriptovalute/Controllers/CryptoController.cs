using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BitcoinLib.Services.Coins.Bitcoin;

namespace kripto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CryptoController : ControllerBase
    {

        BitcoinService bcs;
        public string txId = "c3f11d1708ac20eff9137d4eadd62dd99d71ce22dc51bc51d4e5b83958d9596d";

        public CryptoController()
        {
            bcs = new BitcoinService("http://blockchain.oss.unist.hr:8332", "student", "2B4DB3SmsM2B4DB3SmsM89QjgYFp89QjgYFp", "mywallet", 20);

        }

        [HttpGet]
        public ActionResult<Crypto> Get()
        {
            //var block = bcs.GetBlock(bcs.GetBestBlockHash(), true);
            var transaction = bcs.GetRawTransaction(txId, 1);
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
            };
        }
    }
}
