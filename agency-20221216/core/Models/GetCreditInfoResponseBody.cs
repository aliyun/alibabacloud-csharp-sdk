// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCreditInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>200: OK.</description></item>
        /// <item><description>1109: System error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCreditInfoResponseBodyData Data { get; set; }
        public class GetCreditInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The credit control status of the sub-account. Valid values:</para>
            /// <ol>
            /// <item><description>normal: Normal.</description></item>
            /// <item><description>arrearsNotShutdown: The account has an overdue payment but is not shut down.</description></item>
            /// <item><description>shutdown: Shut down.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// <para>The percentage value. When the available credit drops below this percentage of the credit limit, an email notification is sent to the main account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AlarmThreshold")]
            [Validation(Required=false)]
            public string AlarmThreshold { get; set; }

            /// <summary>
            /// <para>The available credit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("AvailableCredit")]
            [Validation(Required=false)]
            public string AvailableCredit { get; set; }

            /// <summary>
            /// <para>The total outstanding amount of virtual bills before simulated deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.000000</para>
            /// </summary>
            [NameInMap("ConsumedUndeductedValue")]
            [Validation(Required=false)]
            public string ConsumedUndeductedValue { get; set; }

            /// <summary>
            /// <para>The credit limit of the sub-account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            /// <summary>
            /// <para>The credit amount consumed by the sub-account that has not yet been paid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("OutstandingBalance")]
            [Validation(Required=false)]
            public string OutstandingBalance { get; set; }

            /// <summary>
            /// <para>The freeze status of pay-as-you-go. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>freeze: Frozen.</description></item>
            /// <item><description>normal: Normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("PAYGFreezeStatus")]
            [Validation(Required=false)]
            public string PAYGFreezeStatus { get; set; }

            /// <summary>
            /// <para>The policy that the system uses to manage resources when the active credit is 0 or less. Valid values:</para>
            /// <para>1: delayStop. Alibaba Cloud takes over the resources. Instances are shut down after the credit is exhausted with a delay epoch. If payment is not made within 15 days, storage resources are released.</para>
            /// <para>2: noStop. The system does not manage the resource lifecycle of the non-trusteeship linked account. The partner must manage it manually.</para>
            /// <para>3: immediatelyStop. Instances are shut down immediately when the account enters the overdue payment state, which triggers instance shutdown.</para>
            /// 
            /// <b>Example:</b>
            /// <para>delayStop</para>
            /// </summary>
            [NameInMap("ZeroCreditShutdownPolicy")]
            [Validation(Required=false)]
            public string ZeroCreditShutdownPolicy { get; set; }

            /// <summary>
            /// <para>The status that manages the purchase actions of the customer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ban: New purchases are prohibited.</description></item>
            /// <item><description>cancelBan: Normal status.</description></item>
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
        /// <para>The message information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud uses this ID for error tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: Successful.</description></item>
        /// <item><description>False: Failed.</description></item>
        /// </list>
        /// <para>This does not indicate whether the subsequent business operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
