// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetCustomerAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerAccountInfoResponseBodyData Data { get; set; }
        public class GetCustomerAccountInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the account. A value of 1 indicates an enterprise account. A value of 0 indicates an individual account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The business status of the customer. Valid values:</para>
            /// <para>Freeze: The business is frozen.</para>
            /// <para>Thaw: The business is unfrozen.</para>
            /// <para>Trusteeship: The business is hosted.</para>
            /// <para>TrusteeshipCancel: The business is not hosted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Freeze</para>
            /// </summary>
            [NameInMap("CreditLimitStatus")]
            [Validation(Required=false)]
            public string CreditLimitStatus { get; set; }

            /// <summary>
            /// <para>The hosting status of the credit information and instances of the customer. If the credit information and instances of the customer are managed on Alibaba Cloud, Alibaba Cloud suspends a customer service upon overdue payment. Valid values:</para>
            /// <para>FREEZE: The business of the customer is frozen.</para>
            /// <para>TRUSTEESHIP: The business of the customer is hosted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FREEZE</para>
            /// </summary>
            [NameInMap("HostingStatus")]
            [Validation(Required=false)]
            public string HostingStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the account passes the real-name verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsCertified")]
            [Validation(Required=false)]
            public bool? IsCertified { get; set; }

            /// <summary>
            /// <para>The email address of the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@aliyun.com">xxxx@aliyun.com</a></para>
            /// </summary>
            [NameInMap("LoginEmail")]
            [Validation(Required=false)]
            public string LoginEmail { get; set; }

            /// <summary>
            /// <para>The ID of the management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1051360339779133</para>
            /// </summary>
            [NameInMap("Mpk")]
            [Validation(Required=false)]
            public long? Mpk { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94017C56-1725-5DD9-AB41-B3BAE791D600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
