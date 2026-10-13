// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class GetTicketResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denied error. If the request is authorized, an empty string is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;AuthAction\&quot;:\&quot;ram:GetTicket\&quot;,\&quot;AuthPrincipalDisplayName\&quot;:\&quot;2146216584788xxxxx\&quot;,\&quot;AuthPrincipalOwnerId\&quot;:\&quot;1135850448xxxxx\&quot;,\&quot;AuthPrincipalType\&quot;:\&quot;SubUser\&quot;,\&quot;NoPermissionType\&quot;:\&quot;ImplicitDeny\&quot;,\&quot;PolicyType\&quot;:\&quot;AccountLevelIdentityBasedPolicy\&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code returned by the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The business data returned upon a successful API call.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTicketResponseBodyData Data { get; set; }
        public class GetTicketResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the ticket category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7161</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The timestamp when the ticket was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623396736000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The user ID of the ticket creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1168025</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The name of the ticket creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;creator_name_xxx&quot;</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The description of the ticket issue. Only plain text format is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why ECS renewal failed?</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The severity level of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Normal issue.</description></item>
            /// <item><description>2: Urgent issue.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public GetTicketResponseBodyDataSeverity Severity { get; set; }
            public class GetTicketResponseBodyDataSeverity : TeaModel {
                /// <summary>
                /// <para>The display text of the severity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>General issue</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The value of the severity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The status of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: assigned (Pending response). </description></item>
            /// <item><description>2: dealing (Processing).</description></item>
            /// <item><description>3: wait_feedback (Pending feedback).</description></item>
            /// <item><description>4: feedback (Feedback provided).</description></item>
            /// <item><description>5: wait_confirm (Pending confirmation).</description></item>
            /// <item><description>6: confirmed (Completed).</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public GetTicketResponseBodyDataStatus Status { get; set; }
            public class GetTicketResponseBodyDataStatus : TeaModel {
                /// <summary>
                /// <para>The display text of the status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The value of the status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0005PYGCW</para>
            /// </summary>
            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

            /// <summary>
            /// <para>The title of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why did ECS renewal fail?</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is returned when Success is set to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the paging query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the paging query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C499BB0F-630D-5BE6-B3EA-5FCD95B85503</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. A value of true indicates that the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of queried results, which is the total number of ticket records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>108</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
