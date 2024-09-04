// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCreditInfoResponseBody : TeaModel {
        /// <summary>
        /// Result Code:
        /// - 200 OK
        /// - 1109 System Error
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCreditInfoResponseBodyData Data { get; set; }
        public class GetCreditInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The Credit Control status, Value Range:</br>
            /// 1. normal - Sub Account status is running as usual.
            /// 2. arrearsNotShutdown - Sub Account status is running as usual, but have outstanding bill(s).
            /// 3. shutdown -  Sub Account status is down.
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// Percentage value, when the available credit limit is lower than this credit limit percentage, a notification E-mail will be sent to the main account.
            /// </summary>
            [NameInMap("AlarmThreshold")]
            [Validation(Required=false)]
            public string AlarmThreshold { get; set; }

            /// <summary>
            /// The Credit available to consume.
            /// </summary>
            [NameInMap("AvailableCredit")]
            [Validation(Required=false)]
            public string AvailableCredit { get; set; }

            /// <summary>
            /// Obtain total unpaid amount on demo bill before simulated deduction.
            /// </summary>
            [NameInMap("ConsumedUndeductedValue")]
            [Validation(Required=false)]
            public string ConsumedUndeductedValue { get; set; }

            /// <summary>
            /// The Credit Line of Sub Account
            /// </summary>
            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            /// <summary>
            /// The Credit have been consumed by Sub Account, and haven\\"t be paid.
            /// </summary>
            [NameInMap("OutstandingBalance")]
            [Validation(Required=false)]
            public string OutstandingBalance { get; set; }

            /// <summary>
            /// The systematic controlling policy for resource management, specifically when the available Credit of Sub Account falls to 0 or less.</br>
            /// 
            /// - 1: delayStop. The account have Shutdown-delay Privilege,  After Shutdown-delay Credit is ran out, Alibaba Cloud will take over resources and keep the instance for 15 days. In addition, the instance will be released if Sub Account failed to pay the bill within these 15 days.</br>
            /// - 2: noStop. Partner will manually manage Shutdown Status for Sub Account. Meanwhile, System would not manage the resource\\"s life-circle of Sub Account.</br>
            /// - 3: immediatelyStop. Once valid quota of Sub Account falls below 0 and be identified as defaulting account, it will trigger the instance shutdown immediately.</br>
            /// </summary>
            [NameInMap("ZeroCreditShutdownPolicy")]
            [Validation(Required=false)]
            public string ZeroCreditShutdownPolicy { get; set; }

            /// <summary>
            /// Manage order operation.
            /// - ban：Ban the new purchase action.
            /// - normal：The account could raise new purchase order as usual.
            /// </summary>
            [NameInMap("newBuyStatus")]
            [Validation(Required=false)]
            public string NewBuyStatus { get; set; }

        }

        /// <summary>
        /// Message Information
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Request ID, Alibaba Cloud will track errors with this.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
