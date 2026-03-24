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
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageData Data { get; set; }
            public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageData : TeaModel {
                [NameInMap("DataItem")]
                [Validation(Required=false)]
                public List<DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItem> DataItem { get; set; }
                public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItem : TeaModel {
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TaskConfig")]
                    [Validation(Required=false)]
                    public DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItemTaskConfig TaskConfig { get; set; }
                    public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItemTaskConfig : TeaModel {
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    [NameInMap("TaskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

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
