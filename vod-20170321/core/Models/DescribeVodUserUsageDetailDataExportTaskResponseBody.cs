// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserUsageDetailDataExportTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageDataPerPage")]
        [Validation(Required=false)]
        public DescribeVodUserUsageDetailDataExportTaskResponseBodyUsageDataPerPage UsageDataPerPage { get; set; }
        public class DescribeVodUserUsageDetailDataExportTaskResponseBodyUsageDataPerPage : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeVodUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageData Data { get; set; }
            public class DescribeVodUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageData : TeaModel {
                [NameInMap("DataItem")]
                [Validation(Required=false)]
                public List<DescribeVodUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageDataDataItem> DataItem { get; set; }
                public class DescribeVodUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageDataDataItem : TeaModel {
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
                    public DescribeVodUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageDataDataItemTaskConfig TaskConfig { get; set; }
                    public class DescribeVodUserUsageDetailDataExportTaskResponseBodyUsageDataPerPageDataDataItemTaskConfig : TeaModel {
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

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
