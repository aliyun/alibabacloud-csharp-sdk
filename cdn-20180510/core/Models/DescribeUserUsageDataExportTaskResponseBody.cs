// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserUsageDataExportTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageDataPerPage")]
        [Validation(Required=false)]
        public DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPage UsageDataPerPage { get; set; }
        public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPage : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageData Data { get; set; }
            public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageData : TeaModel {
                [NameInMap("DataItem")]
                [Validation(Required=false)]
                public List<DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItem> DataItem { get; set; }
                public class DescribeUserUsageDataExportTaskResponseBodyUsageDataPerPageDataDataItem : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public string UpdateTime { get; set; }

                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("TaskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

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
                    };

                }

            }
        };

    }

}
