// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListTicketsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission error. If you have the required permissions, an empty string is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;AuthAction\&quot;:\&quot;ram:ListTickets\&quot;,\&quot;AuthPrincipalDisplayName\&quot;:\&quot;2146216584788xxxxx\&quot;,\&quot;AuthPrincipalOwnerId\&quot;:\&quot;1135850448xxxxx\&quot;,\&quot;AuthPrincipalType\&quot;:\&quot;SubUser\&quot;,\&quot;NoPermissionType\&quot;:\&quot;ImplicitDeny\&quot;,\&quot;PolicyType\&quot;:\&quot;AccountLevelIdentityBasedPolicy\&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The return code of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The list of your tickets.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTicketsResponseBodyData> Data { get; set; }
        public class ListTicketsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ticket status. Valid values: assigned (Pending response), dealing (In progress), wait_feedback (Waiting for feedback), feedback (Feedback received), wait_confirm (Pending confirmation), and confirmed (Completed).</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public ListTicketsResponseBodyDataStatus Status { get; set; }
            public class ListTicketsResponseBodyDataStatus : TeaModel {
                /// <summary>
                /// <para>The description of the status. Example: Completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The value of the status. For example, a value of 6 indicates that the ticket is completed.</para>
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
            /// <para>The ticket title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why did ECS renewal fail?</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is returned only when the value of success is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>入参解析失败</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. A unique ID is returned for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC0AB2EC-AFBC-44BA-AE77-132A5A1EC0AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates that the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of query results, which is the total number of your tickets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
