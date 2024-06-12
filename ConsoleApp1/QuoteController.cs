using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapQuoteAPI;
namespace ConsoleApp1
{
    class QuoteController
    {
        

        public CTapQuoteAPINotify QuoteNotify = null;
        private ITapQuoteAPI m_api = null;
        private uint m_sessionID = 0;

        public delegate void OnQuoteUpdateHandler();
        public event OnQuoteUpdateHandler OnQuoteUpdateEvent;

        public delegate void OnRspLoginHandler(int errorCode, TapAPIQuotLoginRspInfo loginRspInfo);
        public event OnRspLoginHandler OnRspLoginEvent;

        public delegate void OnDisconnectHandler(int reasonCode);
        public event OnDisconnectHandler OnDisconnectEvent;

        public delegate void OnQryContractFinishHandler();
        public event OnQryContractFinishHandler OnQryContractFinishEvent;

        public QuoteController()
        {
            QuoteNotify = new CTapQuoteAPINotify();
            InitEventHandler();
        }
        public int InitQuoteAPI()
        {
            TapAPIApplicationInfo appInfo = new TapAPIApplicationInfo();
            appInfo.AuthCode = "67EA896065459BECDFDB924B29CB7DF1946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE41BCBAB68D525B0D111A0884D847D57163FF7F329FA574E7946CED32E26C1EAC946CED32E26C1EAC733827B0CE853869ABD9B8F170E14F8847D3EA0BF4E191F5D97B3DFE4CCB1F01842DD2B3EA2F4B20CAD19B8347719B7E20EA1FA7A3D1BFEFF22290F4B5C43E6C520ED5A40EC1D50ACDF342F46A92CCF87AEE6D73542C42EC17818349C7DEDAB0E4DB16977714F873D505029E27B3D57EB92D5BEDA0A710197EB67F94BB1892B30F58A3F211D9C3B3839BE2D73FD08DD776B9188654853DDA57675EBB7D6FBBFC";
            int iResult = 0;
            m_api = TapQuote.CreateTapQuoteAPI(appInfo, out iResult);
            if (m_api != null)
            {
                m_api.SetAPINotify(QuoteNotify);
            }
            return iResult;
        }
        public void FreeApi()
        {
            ClearEventHandler();
            if (m_api != null)
            {
                TapQuote.FreeTapQuoteAPI(m_api);
            }
        }

        private void InitEventHandler()
        {
            QuoteNotify.OnRspLoginEvent += QuoteNotify_OnRspLoginEvent;
            QuoteNotify.OnAPIReadyEvent += QuoteNotify_OnAPIReadyEvent;
            QuoteNotify.OnQryFinishEvent += QuoteNotify_OnQryFinishEvent;
            QuoteNotify.OnQuoteUpdateEvent += QuoteNotify_OnQuoteUpdateEvent;
            QuoteNotify.OnDisconnectEvent += QuoteNotify_OnDisconnectEvent;
        }

        private void ClearEventHandler()
        {
            OnQuoteUpdateEvent = null;
            OnRspLoginEvent = null;
            OnDisconnectEvent = null;
            OnQryContractFinishEvent = null;
        }

        void QuoteNotify_OnDisconnectEvent(int reasonCode)
        {
            if (null != OnDisconnectEvent)
            {
                OnDisconnectEvent(reasonCode);
            }
        }

        void QuoteNotify_OnRspLoginEvent(int errorCode, TapAPIQuotLoginRspInfo loginRspInfo)
        {
            if (null != OnRspLoginEvent)
            {
                OnRspLoginEvent(errorCode, loginRspInfo);
            }
        }

        void QuoteNotify_OnQuoteUpdateEvent()
        {
            if (null != OnQuoteUpdateEvent)
            {
                OnQuoteUpdateEvent();
            }
        }
        void QuoteNotify_OnQryFinishEvent(CTapQuoteAPINotify.QuoteQryType qryType)
        {
            switch (qryType)
            {
                case CTapQuoteAPINotify.QuoteQryType.Contract:
                    {
                        if (OnQryContractFinishEvent != null)
                        {
                            OnQryContractFinishEvent();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        void QuoteNotify_OnAPIReadyEvent()
        {
            m_api.QryContract(out m_sessionID, null);
        }


        public bool Login(string ip, ushort port, string username, string password)
        {
            m_api.SetHostAddress(ip, port);
            TapAPIQuoteLoginAuth loginInfo = new TapAPIQuoteLoginAuth();
            loginInfo.UserNo = username;
            loginInfo.Password = password;
            loginInfo.ISDDA = 'N';
            loginInfo.ISModifyPassword = 'N';
            return (0 == m_api.Login(loginInfo));
        }

        public void Disconnect()
        {
            m_api.Disconnect();
        }

        public bool SubQuote(TapQuoteAPI.TapAPIContract contract)
        {
            int iRet = m_api.SubscribeQuote(out m_sessionID, contract);
            return (0 == iRet);
        }

        public bool UnSubQuote(TapQuoteAPI.TapAPIContract contract)
        {
            int iRet = m_api.UnSubscribeQuote(out m_sessionID, contract);
            return (0 == iRet);
        }

    }
}
