// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTaskInstanceOperationLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListTaskInstanceOperationLogsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListTaskInstanceOperationLogsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of operation logs.</para>
            /// </summary>
            [NameInMap("OperationLogs")]
            [Validation(Required=false)]
            public List<ListTaskInstanceOperationLogsResponseBodyPagingInfoOperationLogs> OperationLogs { get; set; }
            public class ListTaskInstanceOperationLogsResponseBodyPagingInfoOperationLogs : TeaModel {
                /// <summary>
                /// <para>The time when the operation log was generated.</para>
                /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The content of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Freeze tasks</para>
                /// </summary>
                [NameInMap("OperationContent")]
                [Validation(Required=false)]
                public string OperationContent { get; set; }

                /// <summary>
                /// <para>The sequence number of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("OperationSeq")]
                [Validation(Required=false)]
                public long? OperationSeq { get; set; }

                /// <summary>
                /// <para>The ID of the task instance on which the operation was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TaskInstanceId")]
                [Validation(Required=false)]
                public long? TaskInstanceId { get; set; }

                /// <summary>
                /// <para>The account ID of the user who performed the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
