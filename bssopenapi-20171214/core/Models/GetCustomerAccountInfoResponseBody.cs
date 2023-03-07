// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetCustomerAccountInfoResponseBody : TeaModel {
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
        public GetCustomerAccountInfoResponseBodyData Data { get; set; }
        public class GetCustomerAccountInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the account. A value of 1 indicates an enterprise account. A value of 0 indicates an individual account.
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// The business status of the customer. Valid values:
            /// 
            /// Freeze: The business is frozen.
            /// 
            /// Thaw: The business is unfrozen.
            /// 
            /// Trusteeship: The business is hosted.
            /// 
            /// TrusteeshipCancel: The business is not hosted.
            /// </summary>
            [NameInMap("CreditLimitStatus")]
            [Validation(Required=false)]
            public string CreditLimitStatus { get; set; }

            /// <summary>
            /// The hosting status of the credit information and instances of the customer. If the credit information and instances of the customer are managed on Alibaba Cloud, Alibaba Cloud suspends a customer service upon overdue payment. Valid values:
            /// 
            /// FREEZE: The business of the customer is frozen.
            /// 
            /// TRUSTEESHIP: The business of the customer is hosted.
            /// </summary>
            [NameInMap("HostingStatus")]
            [Validation(Required=false)]
            public string HostingStatus { get; set; }

            /// <summary>
            /// Indicates whether the account passes the real-name verification.
            /// </summary>
            [NameInMap("IsCertified")]
            [Validation(Required=false)]
            public bool? IsCertified { get; set; }

            /// <summary>
            /// The email address of the customer.
            /// </summary>
            [NameInMap("LoginEmail")]
            [Validation(Required=false)]
            public string LoginEmail { get; set; }

            /// <summary>
            /// The ID of the management account.
            /// </summary>
            [NameInMap("Mpk")]
            [Validation(Required=false)]
            public long? Mpk { get; set; }

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
        /// Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
