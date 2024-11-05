// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class InviteSubAccountRequest : TeaModel {
        /// <summary>
        /// <para>List of invited account information,  less than 5 accounts at a time.</br>
        /// <c>Sub-levels &lt;= 5</c></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public List<InviteSubAccountRequestAccountInfoList> AccountInfoList { get; set; }
        public class InviteSubAccountRequestAccountInfoList : TeaModel {
            /// <summary>
            /// <para>The name of Sub Account:</br></para>
            /// <ol>
            /// <item><description>Use the official name of Company, if Sub Account is an enterprise.</br></description></item>
            /// <item><description>Use the official name of Partner, if Sub Account is a T2 reseller.</br></description></item>
            /// </ol>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX Technology LTD.</para>
            /// </summary>
            [NameInMap("AccountNickname")]
            [Validation(Required=false)]
            public string AccountNickname { get; set; }

            /// <summary>
            /// <para>The total budget Credit of Sub Account that distributed by Partner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            [NameInMap("CustomerBd")]
            [Validation(Required=false)]
            public string CustomerBd { get; set; }

            /// <summary>
            /// <para>Customer ID, Returning ID from CreateCustomer API.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>The email address of End User,  which will receive the invitation email.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:12345@163.com">12345@163.com</a></para>
            /// </summary>
            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }

            /// <summary>
            /// <para>Initial Order Status</br></para>
            /// <ol>
            /// <item><description>ban：Ban the new purchase action--After End User finish registration and authorization, they can\&quot;t issue Cloud Resource order immediately. Partner should manually update the &quot;Order Control&quot; settings as &quot;Normal&quot; to enable new order.</br></description></item>
            /// <item><description>normal：Normal--After End User finished registration and authorization, they can issue Cloud Resource order immediately.</br></description></item>
            /// </ol>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ban</para>
            /// </summary>
            [NameInMap("NewBuyStatus")]
            [Validation(Required=false)]
            public string NewBuyStatus { get; set; }

            /// <summary>
            /// <para>Description of Sub Account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The invitation to develop XX as a Sub Account</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The type of Sub Account</br></para>
            /// <para>1 Agency\&quot;s End User</br>
            /// 2 Reseller\&quot;s End user</br>
            /// 5 Reseller\&quot;s T2 Partner</br></para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubAccountType")]
            [Validation(Required=false)]
            public string SubAccountType { get; set; }

            /// <summary>
            /// <para>Partner\&quot;s Shutdown Policy Management for Sub Account.</br>
            /// 1: delayStop. The account have Shutdown-delay Privilege,  After Shutdown-delay Credit is ran out, Alibaba Cloud will take over resources and keep the instance for 15 days. In addition, the instance will be released if Sub Account failed to pay the bill within these 15 days.</br>
            /// 2: noStop. Partner will manually manage Shutdown Status for Sub Account. Meanwhile, System would not manage the resource\&quot;s life-circle of Sub Account.</br>
            /// 3: immediatelyStop. Once valid quota of Sub Account falls below 0 and be identified as defaulting account, it will trigger the instance shutdown immediately.</br></para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ZeroCreditShutdownPolicy")]
            [Validation(Required=false)]
            public string ZeroCreditShutdownPolicy { get; set; }

        }

    }

}
