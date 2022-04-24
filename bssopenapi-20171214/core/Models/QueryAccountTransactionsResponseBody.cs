// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAccountTransactionsResponseBodyData Data { get; set; }
        public class QueryAccountTransactionsResponseBodyData : TeaModel {
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }
            [NameInMap("AccountTransactionsList")]
            [Validation(Required=false)]
            public QueryAccountTransactionsResponseBodyDataAccountTransactionsList AccountTransactionsList { get; set; }
            public class QueryAccountTransactionsResponseBodyDataAccountTransactionsList : TeaModel {
                [NameInMap("AccountTransactionsList")]
                [Validation(Required=false)]
                public List<QueryAccountTransactionsResponseBodyDataAccountTransactionsListAccountTransactionsList> AccountTransactionsList { get; set; }
                public class QueryAccountTransactionsResponseBodyDataAccountTransactionsListAccountTransactionsList : TeaModel {
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    [NameInMap("Balance")]
                    [Validation(Required=false)]
                    public string Balance { get; set; }

                    [NameInMap("BillingCycle")]
                    [Validation(Required=false)]
                    public string BillingCycle { get; set; }

                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }

                    [NameInMap("RecordID")]
                    [Validation(Required=false)]
                    public string RecordID { get; set; }

                    [NameInMap("Remarks")]
                    [Validation(Required=false)]
                    public string Remarks { get; set; }

                    [NameInMap("TransactionAccount")]
                    [Validation(Required=false)]
                    public string TransactionAccount { get; set; }

                    [NameInMap("TransactionChannel")]
                    [Validation(Required=false)]
                    public string TransactionChannel { get; set; }

                    [NameInMap("TransactionChannelSN")]
                    [Validation(Required=false)]
                    public string TransactionChannelSN { get; set; }

                    [NameInMap("TransactionFlow")]
                    [Validation(Required=false)]
                    public string TransactionFlow { get; set; }

                    [NameInMap("TransactionNumber")]
                    [Validation(Required=false)]
                    public string TransactionNumber { get; set; }

                    [NameInMap("TransactionTime")]
                    [Validation(Required=false)]
                    public string TransactionTime { get; set; }

                    [NameInMap("TransactionType")]
                    [Validation(Required=false)]
                    public string TransactionType { get; set; }

                }

            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
