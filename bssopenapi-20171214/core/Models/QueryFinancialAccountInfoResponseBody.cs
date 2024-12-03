// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryFinancialAccountInfoResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFinancialAccountInfoResponseBodyData Data { get; set; }
        public class QueryFinancialAccountInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the financial account. A value of MASTER indicates that the account is a management account. A value of MEMBER indicates that the account is a member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MEMBER</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is a financial account. A value of true indicates that the account is a financial account. A value of false indicates that the account is not a financial account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinancialAccount")]
            [Validation(Required=false)]
            public bool? IsFinancialAccount { get; set; }

            /// <summary>
            /// <para>The ID of the group to which the member belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>124</para>
            /// </summary>
            [NameInMap("MemberGroupId")]
            [Validation(Required=false)]
            public long? MemberGroupId { get; set; }

            /// <summary>
            /// <para>The name of the group to which the member belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test group</para>
            /// </summary>
            [NameInMap("MemberGroupName")]
            [Validation(Required=false)]
            public string MemberGroupName { get; set; }

            /// <summary>
            /// <para>The display name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("MemberNickName")]
            [Validation(Required=false)]
            public string MemberNickName { get; set; }

            /// <summary>
            /// <para>The username of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>killortop3</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
        /// <para>97426BC2-792E-41F5-92B8-73C710DA7779</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
