// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetAccountRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
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
            /// <para>The UID of the child account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud account UID of the child account</para>
            /// </summary>
            [NameInMap("ChildUserId")]
            [Validation(Required=false)]
            public long? ChildUserId { get; set; }

            /// <summary>
            /// <para>The end time of the account linking, in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-01</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The update time of the account linking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-01</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The account linking ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Account linking ID</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The UID of the parent account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud UID of the main account</para>
            /// </summary>
            [NameInMap("ParentUserId")]
            [Validation(Required=false)]
            public long? ParentUserId { get; set; }

            /// <summary>
            /// <para>The start time of the account linking, in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The account linking status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RELATED: linked.</description></item>
            /// <item><description>CONFIRMING: pending confirmation from the other party.</description></item>
            /// <item><description>REJECTED: rejected by the other party.</description></item>
            /// <item><description>CONNECTION_CANCELED: application canceled by the child account.</description></item>
            /// <item><description>CONNECTION_MASTER_CANCEL: invitation canceled by the main account.</description></item>
            /// <item><description>CHANGE_CONFIRMING: pending confirmation for relationship change.</description></item>
            /// <item><description>INITIAL: initial status of a newly created linking.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RELATED: linked</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The account linking type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise_group</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RequestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
