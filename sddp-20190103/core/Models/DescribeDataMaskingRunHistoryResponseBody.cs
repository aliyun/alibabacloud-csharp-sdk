// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingRunHistoryResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingRunHistoryResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingRunHistoryResponseBodyItems : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            [NameInMap("SrcTableName")]
            [Validation(Required=false)]
            public string SrcTableName { get; set; }

            [NameInMap("MaskingCount")]
            [Validation(Required=false)]
            public long? MaskingCount { get; set; }

            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            [NameInMap("FailMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            [NameInMap("FailCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            [NameInMap("ConflictCount")]
            [Validation(Required=false)]
            public long? ConflictCount { get; set; }

            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("RunIndex")]
            [Validation(Required=false)]
            public int? RunIndex { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("HasSubProcess")]
            [Validation(Required=false)]
            public int? HasSubProcess { get; set; }

            [NameInMap("HasDownloadFile")]
            [Validation(Required=false)]
            public int? HasDownloadFile { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("SrcTypeCode")]
            [Validation(Required=false)]
            public string SrcTypeCode { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
