// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListRecallManagementJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of synchronization tasks.</para>
        /// </summary>
        [NameInMap("RecallManagementJobs")]
        [Validation(Required=false)]
        public List<ListRecallManagementJobsResponseBodyRecallManagementJobs> RecallManagementJobs { get; set; }
        public class ListRecallManagementJobsResponseBodyRecallManagementJobs : TeaModel {
            /// <summary>
            /// <para>The end time of the task. The time follows the ISO 8601 standard and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-28T10:24Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RecallManagementJobId")]
            [Validation(Required=false)]
            public string RecallManagementJobId { get; set; }

            /// <summary>
            /// <para>The task information of the recall management table.</para>
            /// </summary>
            [NameInMap("RecallManagementTableInfo")]
            [Validation(Required=false)]
            public ListRecallManagementJobsResponseBodyRecallManagementJobsRecallManagementTableInfo RecallManagementTableInfo { get; set; }
            public class ListRecallManagementJobsResponseBodyRecallManagementJobsRecallManagementTableInfo : TeaModel {
                /// <summary>
                /// <para>The data version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20250701</para>
                /// </summary>
                [NameInMap("DataVersion")]
                [Validation(Required=false)]
                public string DataVersion { get; set; }

                /// <summary>
                /// <para>The ID of the table version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RecallManagementTableVersionId")]
                [Validation(Required=false)]
                public string RecallManagementTableVersionId { get; set; }

                /// <summary>
                /// <para>The data size of the source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SourceTableDataSize")]
                [Validation(Required=false)]
                public string SourceTableDataSize { get; set; }

                /// <summary>
                /// <para>The number of data rows in the source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SourceTableRowCount")]
                [Validation(Required=false)]
                public string SourceTableRowCount { get; set; }

            }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("RecallManagerTableInfo")]
            [Validation(Required=false)]
            public ListRecallManagementJobsResponseBodyRecallManagementJobsRecallManagerTableInfo RecallManagerTableInfo { get; set; }
            public class ListRecallManagementJobsResponseBodyRecallManagementJobsRecallManagerTableInfo : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20250701</para>
                /// </summary>
                [NameInMap("DataVersion")]
                [Validation(Required=false)]
                public string DataVersion { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RecallManagementTableVersionId")]
                [Validation(Required=false)]
                public string RecallManagementTableVersionId { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SourceTableDataSize")]
                [Validation(Required=false)]
                public string SourceTableDataSize { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SourceTableRowCount")]
                [Validation(Required=false)]
                public string SourceTableRowCount { get; set; }

            }

            /// <summary>
            /// <para>The start time of the task. The time follows the ISO 8601 standard and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-28T10:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status. Valid values: <c>Init</c> (initializing), <c>Running</c> (running), <c>Success</c> (successful), and <c>Failed</c> (failed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
