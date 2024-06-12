using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapQuoteAPI;

namespace ConsoleApp1
{
    class CTapQuoteAPINotify : ITapQuoteAPINotify
    {   
        public enum QuoteQryType
        {
            Contract
        }
        public delegate void OnQryFinishHandler(QuoteQryType qryType);
        public event OnQryFinishHandler OnQryFinishEvent;


        public delegate void OnRspLoginEventHandler(int errorCode, TapAPIQuotLoginRspInfo loginRspInfo);
        public event OnRspLoginEventHandler OnRspLoginEvent;
        public override void OnRspLogin(int errorCode, TapAPIQuotLoginRspInfo info)
        {
            if (OnRspLoginEvent != null)
            {
                Console.WriteLine($"OnRspLogin:{errorCode}");
                OnRspLoginEvent(errorCode, info);
            }
        }

        public delegate void OnAPIReadyEventHandler();
        public event OnAPIReadyEventHandler OnAPIReadyEvent;
        public override void OnAPIReady()
        {
            Console.WriteLine($"OnAPIReady");
            if (OnAPIReadyEvent != null)
            {
                OnAPIReadyEvent();
            }
        }

        public delegate void OnDisconnectEventHandler(int reasonCode);
        public event OnDisconnectEventHandler OnDisconnectEvent;
        public override void OnDisconnect(int reasonCode)
        {
            Console.WriteLine($"OnDisconnect");
            if (OnDisconnectEvent != null)
            {
                OnDisconnectEvent(reasonCode);
            }
        }


        public override void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPIQuoteCommodityInfo info)
        {
            //throw new NotImplementedException();
        }

        //public override void OnRspQryTimeBucketOfCommodity(uint sessionID, int errorCode, char isLast, TapAPITimeBucketOfCommodityInfo info)
        //{
        //    //throw new NotImplementedException();
        //}

        //public override void OnRtnTimeBucketOfCommodity(TapAPITimeBucketOfCommodityInfo info)
        //{
        //    //throw new NotImplementedException();
        //}


        public override void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPIQuoteContractInfo info)
        {
            //DataManager.Quote.ContractMgr.AddContract(info);
            if (null != OnQryFinishEvent && isLast == TapQuote.APIYNFLAG_YES)
            {
                OnQryFinishEvent(QuoteQryType.Contract);
            }
        }


        public delegate void OnQuoteUpdateHandler();
        public event OnQuoteUpdateHandler OnQuoteUpdateEvent;
        public override void OnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIQuoteWhole info)
        {
            if (TapQuote.TAPIERROR_SUCCEED == errorCode)
            {
                //DataManager.Quote.QuoteWholeMgr.AddQuote(info);
            }
            if (TapQuote.APIYNFLAG_YES == isLast && null != OnQuoteUpdateEvent)
            {
                OnQuoteUpdateEvent();
            }
        }

        public override void OnRspUnSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIContract info)
        {
            if (TapQuote.TAPIERROR_SUCCEED == errorCode)
            {
                //DataManager.Quote.QuoteWholeMgr.RemoveQuote(info);
            }
            if (TapQuote.APIYNFLAG_YES == isLast && null != OnQuoteUpdateEvent)
            {
                OnQuoteUpdateEvent();
            }
        }

        public override void OnRtnQuote(TapAPIQuoteWhole info)
        {
            //DataManager.Quote.QuoteWholeMgr.UpdateQuote(info);
            if (null != OnQuoteUpdateEvent)
            {
                OnQuoteUpdateEvent();
            }
        }

        //public override void OnRspQryHisQuote(uint sessionID, int errorCode, char isLast, TapAPIHisQuoteQryRsp info)
        //{
        //    //throw new NotImplementedException();
        //}
    }
}
