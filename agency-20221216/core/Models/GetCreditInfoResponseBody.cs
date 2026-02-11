// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCreditInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Result Code:</para>
        /// <list type="bullet">
        /// <item><description>200 OK</description></item>
        /// <item><description>1109 System Error</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCreditInfoResponseBodyData Data { get; set; }
        public class GetCreditInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Credit Control status, Value Range:</br></para>
            /// <ol>
            /// <item><description>normal - Sub Account status is running as usual.</description></item>
            /// <item><description>arrearsNotShutdown - Sub Account status is running as usual, but have outstanding bill(s).</description></item>
            /// <item><description>shutdown -  Sub Account status is down.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// <para>Percentage value, when the available credit limit is lower than this credit limit percentage, a notification E-mail will be sent to the main account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AlarmThreshold")]
            [Validation(Required=false)]
            public string AlarmThreshold { get; set; }

            /// <summary>
            /// <para>The Credit available to consume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("AvailableCredit")]
            [Validation(Required=false)]
            public string AvailableCredit { get; set; }

            /// <summary>
            /// <para>Obtain total unpaid amount on demo bill before simulated deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.000000</para>
            /// </summary>
            [NameInMap("ConsumedUndeductedValue")]
            [Validation(Required=false)]
            public string ConsumedUndeductedValue { get; set; }

            /// <summary>
            /// <para>The Credit Line of Sub Account</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            /// <summary>
            /// <para>The Credit have been consumed by Sub Account, and haven\&quot;t be paid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("OutstandingBalance")]
            [Validation(Required=false)]
            public string OutstandingBalance { get; set; }

            [NameInMap("PAYGFreezeStatus")]
            [Validation(Required=false)]
            public string PAYGFreezeStatus { get; set; }

            /// <summary>
            /// <para>The systematic controlling policy for resource management, specifically when the available Credit of Sub Account falls to 0 or less.</br></para>
            /// <list type="bullet">
            /// <item><description>1: delayStop. The account have Shutdown-delay Privilege,  After Shutdown-delay Credit is ran out, Alibaba Cloud will take over resources and keep the instance for 15 days. In addition, the instance will be released if Sub Account failed to pay the bill within these 15 days.</br></description></item>
            /// <item><description>2: noStop. Partner will manually manage Shutdown Status for Sub Account. Meanwhile, System would not manage the resource\&quot;s life-circle of Sub Account.</br></description></item>
            /// <item><description>3: immediatelyStop. Once valid quota of Sub Account falls below 0 and be identified as defaulting account, it will trigger the instance shutdown immediately.</br></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delayStop</para>
            /// </summary>
            [NameInMap("ZeroCreditShutdownPolicy")]
            [Validation(Required=false)]
            public string ZeroCreditShutdownPolicy { get; set; }

            /// <summary>
            /// <para>Manage order operation.</para>
            /// <list type="bullet">
            /// <item><description>ban：Ban the new purchase action.</description></item>
            /// <item><description>normal：The account could raise new purchase order as usual.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ban</para>
            /// </summary>
            [NameInMap("newBuyStatus")]
            [Validation(Required=false)]
            public string NewBuyStatus { get; set; }

        }

        /// <summary>
        /// <para>Message Information</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, Alibaba Cloud will track errors with this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
