using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataGrid
{
    class StratData
    {
        public int CustomerID { get; set; }
        public string CustName { get; set; }
        public string ContractName { get; set; }
        public double CurrentPrice { get; set; }
        public string OrderType { get; set; }
        public string StrategyDate { get; set; }
        public string ExecutedTime { get; set; }
        public int LotSize { get; set; }
        public double ExectuedPrice { get; set; }
        public double StopLoss { get; set; }

        public StratData()
        {

        }
        public StratData(int customerID, string custName, string contractName, double currentPrice,
            string orderType, string strategyDate, string executedTime, int lotSize, double executedPrice, double stopLoss)
        {
            CustomerID = customerID;
            CustName = custName;
            ContractName = contractName;
            CurrentPrice = currentPrice;
            OrderType = orderType;
            StrategyDate = strategyDate;
            ExecutedTime = executedTime;
            LotSize = lotSize;
            ExectuedPrice = executedPrice;
            StopLoss = stopLoss;
        }

        public List<StratData> GetStrategyData()
        {
            List<StratData> tmp = new List<StratData>();

            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 186.55, "SELL", "04-03-2020", "09:30", 1, 186.55, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 209.4, "SELL", "04-03-2020", "09:30", 1, 209.4, 309.4));

            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11600 CE", 56.00, "BUY", "04-03-2020", "09:31", 1, 56, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11100 CE", 117.5, "BUY", "04-03-2020", "09:33", 1, 117.5, 307.3));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 186.55, "SELL", "04-03-2020", "09:30", 1, 186.55, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 209.4, "SELL", "04-03-2020", "09:30", 1, 209.4, 309.4));

            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11600 CE", 56.00, "BUY", "04-03-2020", "09:31", 1, 56, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11100 CE", 117.5, "BUY", "04-03-2020", "09:33", 1, 117.5, 307.3));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 186.55, "SELL", "04-03-2020", "09:30", 1, 186.55, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 209.4, "SELL", "04-03-2020", "09:30", 1, 209.4, 309.4));

            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11600 CE", 56.00, "BUY", "04-03-2020", "09:31", 1, 56, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11100 CE", 117.5, "BUY", "04-03-2020", "09:33", 1, 117.5, 307.3));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 186.55, "SELL", "04-03-2020", "09:30", 1, 186.55, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 209.4, "SELL", "04-03-2020", "09:30", 1, 209.4, 309.4));

            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11600 CE", 56.00, "BUY", "04-03-2020", "09:31", 1, 56, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11100 CE", 117.5, "BUY", "04-03-2020", "09:33", 1, 117.5, 307.3));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 186.55, "SELL", "04-03-2020", "09:30", 1, 186.55, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 209.4, "SELL", "04-03-2020", "09:30", 1, 209.4, 309.4));

            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11600 CE", 56.00, "BUY", "04-03-2020", "09:31", 1, 56, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11100 CE", 117.5, "BUY", "04-03-2020", "09:33", 1, 117.5, 307.3));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 186.55, "SELL", "04-03-2020", "09:30", 1, 186.55, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 209.4, "SELL", "04-03-2020", "09:30", 1, 209.4, 309.4));

            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11600 CE", 56.00, "BUY", "04-03-2020", "09:31", 1, 56, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11100 CE", 117.5, "BUY", "04-03-2020", "09:33", 1, 117.5, 307.3));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 186.55, "SELL", "04-03-2020", "09:30", 1, 186.55, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11300 CE", 209.4, "SELL", "04-03-2020", "09:30", 1, 209.4, 309.4));

            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11600 CE", 56.00, "BUY", "04-03-2020", "09:31", 1, 56, 286.55));
            tmp.Add(new StratData(80438, "Ashokraj", "NIFTY 12th MAR 11100 CE", 117.5, "BUY", "04-03-2020", "09:33", 1, 117.5, 307.3));

            return tmp;
        }

    }
}
