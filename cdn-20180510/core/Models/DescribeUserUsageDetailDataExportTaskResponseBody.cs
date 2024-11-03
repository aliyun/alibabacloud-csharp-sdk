// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserUsageDetailDataExportTaskResponseBody : TeaModel {
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
        public DescribeUserUsageDetailDataExportTaskResponseBodyUsageDataPerPage UsageDataPerPage { get; set; }
        public class DescribeUserUsageDetailDataExportTaskResponseBodyUsageDataPerPage : TeaModel {
            /// <summary>
            /// <para>The information about the task.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageData Data { get; set; }
            public class DescribeUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageData : TeaModel {
                [NameInMap("DataItem")]
                [Validation(Required=false)]
                public List<DescribeUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageDataDataItem> DataItem { get; set; }
                public class DescribeUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageDataDataItem : TeaModel {
                    /// <summary>
                    /// <para>The time when the task was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-10-09T06:33:38Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The download URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://test.oss-cn-beijing.aliyuncs.com/billing_data/xxx">https://test.oss-cn-beijing.aliyuncs.com/billing_data/xxx</a></para>
                    /// </summary>
                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    /// <summary>
                    /// <para>The status of the task.</para>
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
                    public DescribeUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageDataDataItemTaskConfig TaskConfig { get; set; }
                    public class DescribeUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageDataDataItemTaskConfig : TeaModel {
                        /// <summary>
                        /// <para>The end of the time range during which data was queried.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2018-08-31T15:59:59Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The start of the time range during which data was queried.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2018-07-31T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
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
                    /// <para>2018-10-09T06:35:46Z</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
