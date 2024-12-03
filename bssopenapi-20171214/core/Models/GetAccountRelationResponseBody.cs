// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetAccountRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAccountRelationResponseBodyData Data { get; set; }
        public class GetAccountRelationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used as a member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID of the Alibaba Cloud account that is used as a member</para>
            /// </summary>
            [NameInMap("ChildUserId")]
            [Validation(Required=false)]
            public long? ChildUserId { get; set; }

            /// <summary>
            /// <para>The time when the financial relationship between the management account and the member was terminated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-01</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The time when the financial relationship between the management account and the member was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-01</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the financial relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID of the financial relationship</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used as the management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID of the Alibaba Cloud account that is used as the management account</para>
            /// </summary>
            [NameInMap("ParentUserId")]
            [Validation(Required=false)]
            public long? ParentUserId { get; set; }

            /// <summary>
            /// <para>The time when the financial relationship between the management account and the member was established.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the financial relationship between the management account and the member.</para>
            /// <list type="bullet">
            /// <item><description>RELATED 【Association established】</description></item>
            /// <item><description>CONFIRMING 【To be confirmed by the other party】</description></item>
            /// <item><description>REJECTED 【Refused by the other party】</description></item>
            /// <item><description>CONNECTION_CANCELED 【Financial sub-account cancel request】</description></item>
            /// <item><description>CONNECTION_MASTER_CANCEL 【Financial master account cancel invitation】</description></item>
            /// <item><description>CHANGE_CONFIRMING 【Relationship change to be confirmed】</description></item>
            /// <item><description>INITIAL 【Initial new relationship status】</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RELATED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the financial relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise_group</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Message returned</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RequestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
