// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserUsageDataExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A91BE91F-0B34-4CBF-8E0F-A2977E15AA52</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The usage details returned per page.</para>
        /// </summary>
        [NameInMap("UsageDataPerPage")]
        [Validation(Required=false)]
        public DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPage UsageDataPerPage { get; set; }
        public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPage : TeaModel {
            /// <summary>
            /// <para>The information about the tasks.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageData Data { get; set; }
            public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageData : TeaModel {
                [NameInMap("DataItem")]
                [Validation(Required=false)]
                public List<DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItem> DataItem { get; set; }
                public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItem : TeaModel {
                    /// <summary>
                    /// <para>The time when the task was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-12-31T08:43:21Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The download URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://cdn-polaris.xxxx">https://cdn-polaris.xxxx</a></para>
                    /// </summary>
                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    /// <summary>
                    /// <para>The state of the task.</para>
                    /// <list type="bullet">
                    /// <item><description>created: The task is being created.</description></item>
                    /// <item><description>success: The task is successful.</description></item>
                    /// <item><description>failed: The task failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The configurations of the task.</para>
                    /// </summary>
                    [NameInMap("TaskConfig")]
                    [Validation(Required=false)]
                    public DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItemTaskConfig TaskConfig { get; set; }
                    public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItemTaskConfig : TeaModel {
                        /// <summary>
                        /// <para>The end of the time range that was queried.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-30T15:59:59Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The start of the time range during which data was queried.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-29T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A91BE91F-0B34-4CBF-8E0F-A2977</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    /// <summary>
                    /// <para>The name of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Refresh</para>
                    /// </summary>
                    [NameInMap("TaskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

                    /// <summary>
                    /// <para>The time when the task was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-12-31T08:45:02Z</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public string UpdateTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
