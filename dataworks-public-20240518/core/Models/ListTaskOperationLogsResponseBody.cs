// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTaskOperationLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListTaskOperationLogsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListTaskOperationLogsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The operation logs.</para>
            /// </summary>
            [NameInMap("OperationLogs")]
            [Validation(Required=false)]
            public List<ListTaskOperationLogsResponseBodyPagingInfoOperationLogs> OperationLogs { get; set; }
            public class ListTaskOperationLogsResponseBodyPagingInfoOperationLogs : TeaModel {
                /// <summary>
                /// <para>The time when the operation log was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The operation content.</para>
                /// </summary>
                [NameInMap("OperationContent")]
                [Validation(Required=false)]
                public string OperationContent { get; set; }

                /// <summary>
                /// <para>The serial number of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("OperationSeq")]
                [Validation(Required=false)]
                public long? OperationSeq { get; set; }

                /// <summary>
                /// <para>The ID of the task on which the operation was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The account ID of the operator.</para>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
