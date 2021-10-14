// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingTasksResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingTasksResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingTasksResponseBodyItems : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            [NameInMap("HasUnfinishProcess")]
            [Validation(Required=false)]
            public bool? HasUnfinishProcess { get; set; }

            [NameInMap("OriginalTable")]
            [Validation(Required=false)]
            public bool? OriginalTable { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public int? TriggerType { get; set; }

            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            [NameInMap("RunCount")]
            [Validation(Required=false)]
            public int? RunCount { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("DstPath")]
            [Validation(Required=false)]
            public string DstPath { get; set; }

            [NameInMap("SrcTypeCode")]
            [Validation(Required=false)]
            public string SrcTypeCode { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("SrcPath")]
            [Validation(Required=false)]
            public string SrcPath { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
