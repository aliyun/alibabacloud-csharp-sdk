// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class InviteSubAccountRequest : TeaModel {
        /// <summary>
        /// List of invited account information,  less than 5 accounts at a time.</br>
        /// `Sub-levels <= 5`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public List<InviteSubAccountRequestAccountInfoList> AccountInfoList { get; set; }
        public class InviteSubAccountRequestAccountInfoList : TeaModel {
            /// <summary>
            /// The name of Sub Account:</br>
            /// 1. Use the official name of Company, if Sub Account is an enterprise.</br>
            /// 2. Use the official name of Partner, if Sub Account is a T2 reseller.</br>
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AccountNickname")]
            [Validation(Required=false)]
            public string AccountNickname { get; set; }

            /// <summary>
            /// The total budget Credit of Sub Account that distributed by Partner.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            [NameInMap("CustomerBd")]
            [Validation(Required=false)]
            public string CustomerBd { get; set; }

            /// <summary>
            /// Customer ID, Returning ID from CreateCustomer API.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// The email address of End User,  which will receive the invitation email.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }

            /// <summary>
            /// Initial Order Status</br>
            /// 1. ban：Ban the new purchase action--After End User finish registration and authorization, they can\\"t issue Cloud Resource order immediately. Partner should manually update the "Order Control" settings as "Normal" to enable new order.</br>
            /// 2. normal：Normal--After End User finished registration and authorization, they can issue Cloud Resource order immediately.</br>
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NewBuyStatus")]
            [Validation(Required=false)]
            public string NewBuyStatus { get; set; }

            /// <summary>
            /// Description of Sub Account.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The type of Sub Account</br>
            /// 
            /// 1 Agency\\"s End User</br>
            /// 2 Reseller\\"s End user</br>
            /// 5 Reseller\\"s T2 Partner</br>
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SubAccountType")]
            [Validation(Required=false)]
            public string SubAccountType { get; set; }

            /// <summary>
            /// Partner\\"s Shutdown Policy Management for Sub Account.</br>
            /// 1: delayStop. The account have Shutdown-delay Privilege,  After Shutdown-delay Credit is ran out, Alibaba Cloud will take over resources and keep the instance for 15 days. In addition, the instance will be released if Sub Account failed to pay the bill within these 15 days.</br>
            /// 2: noStop. Partner will manually manage Shutdown Status for Sub Account. Meanwhile, System would not manage the resource\\"s life-circle of Sub Account.</br>
            /// 3: immediatelyStop. Once valid quota of Sub Account falls below 0 and be identified as defaulting account, it will trigger the instance shutdown immediately.</br>
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ZeroCreditShutdownPolicy")]
            [Validation(Required=false)]
            public string ZeroCreditShutdownPolicy { get; set; }

        }

    }

}
