// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetCustomerAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerAccountInfoResponseBodyData Data { get; set; }
        public class GetCustomerAccountInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: enterprise account.</description></item>
            /// <item><description>0: individual account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The business type of the end user.</para>
            /// <para>Valid values:</para>
            /// <ol>
            /// <item><description><para>Freeze: The user is in a frozen state.</para>
            /// </description></item>
            /// <item><description><para>Thaw: The user is in a thawed state.</para>
            /// </description></item>
            /// <item><description><para>Trusteeship: The user is in a trusteeship state.</para>
            /// </description></item>
            /// <item><description><para>TrusteeshipCancel: The user is in a non-trusteeship state.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Freeze</para>
            /// </summary>
            [NameInMap("CreditLimitStatus")]
            [Validation(Required=false)]
            public string CreditLimitStatus { get; set; }

            /// <summary>
            /// <para>The hosting status. This parameter is provided by the credit control system and indicates whether the instance is managed by Alibaba Cloud. If the instance is managed, Alibaba Cloud handles resource suspension/resumption due to overdue payments.</para>
            /// <para>Valid values:</para>
            /// <ol>
            /// <item><description><para>FREEZE: The user\&quot;s business is frozen.</para>
            /// </description></item>
            /// <item><description><para>TRUSTEESHIP: The user\&quot;s business is under trusteeship.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>FREEZE</para>
            /// </summary>
            [NameInMap("HostingStatus")]
            [Validation(Required=false)]
            public string HostingStatus { get; set; }

            /// <summary>
            /// <para>The real-name verification status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsCertified")]
            [Validation(Required=false)]
            public bool? IsCertified { get; set; }

            /// <summary>
            /// <para>The email address of the end customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@aliyun.com">xxxx@aliyun.com</a></para>
            /// </summary>
            [NameInMap("LoginEmail")]
            [Validation(Required=false)]
            public string LoginEmail { get; set; }

            /// <summary>
            /// <para>The MPK of the parent account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1051360339779133</para>
            /// </summary>
            [NameInMap("Mpk")]
            [Validation(Required=false)]
            public long? Mpk { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94017C56-1725-5DD9-AB41-B3BAE791D600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates that the call was completed. A value of false indicates that an error occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
