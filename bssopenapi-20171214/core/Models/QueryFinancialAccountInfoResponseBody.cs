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
        /// <para>The data message body.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFinancialAccountInfoResponseBodyData Data { get; set; }
        public class QueryFinancialAccountInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The enterprise financial account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MASTER: primary account.</description></item>
            /// <item><description>MEMBER: member accounts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MEMBER</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is an enterprise financial account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The account is an enterprise financial account.</description></item>
            /// <item><description>false: The account is not an enterprise financial account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinancialAccount")]
            [Validation(Required=false)]
            public bool? IsFinancialAccount { get; set; }

            /// <summary>
            /// <para>The ID of the group to which the member accounts belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>124</para>
            /// </summary>
            [NameInMap("MemberGroupId")]
            [Validation(Required=false)]
            public long? MemberGroupId { get; set; }

            /// <summary>
            /// <para>The name of the group to which the member accounts belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestGroup</para>
            /// </summary>
            [NameInMap("MemberGroupName")]
            [Validation(Required=false)]
            public string MemberGroupName { get; set; }

            /// <summary>
            /// <para>The display name of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("MemberNickName")]
            [Validation(Required=false)]
            public string MemberNickName { get; set; }

            /// <summary>
            /// <para>The logon name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>killortop3</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The message description.</para>
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
