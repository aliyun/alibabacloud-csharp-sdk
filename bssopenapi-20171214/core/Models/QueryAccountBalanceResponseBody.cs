// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountBalanceResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAccountBalanceResponseBodyData Data { get; set; }
        public class QueryAccountBalanceResponseBodyData : TeaModel {
            /// <summary>
            /// The available balance of the account.
            /// </summary>
            [NameInMap("AvailableAmount")]
            [Validation(Required=false)]
            public string AvailableAmount { get; set; }

            /// <summary>
            /// The available balance in cash.
            /// </summary>
            [NameInMap("AvailableCashAmount")]
            [Validation(Required=false)]
            public string AvailableCashAmount { get; set; }

            /// <summary>
            /// The credit balance of the account.
            /// </summary>
            [NameInMap("CreditAmount")]
            [Validation(Required=false)]
            public string CreditAmount { get; set; }

            /// <summary>
            /// The type of the currency. Valid values:
            /// 
            /// *   CNY: Chinese Yuan
            /// *   USD: US dollar
            /// *   JPY: Japanese Yen
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The credit line controlled by MYbank.
            /// </summary>
            [NameInMap("MybankCreditAmount")]
            [Validation(Required=false)]
            public string MybankCreditAmount { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
