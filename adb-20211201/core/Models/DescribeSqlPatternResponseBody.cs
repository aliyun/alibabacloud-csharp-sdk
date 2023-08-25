// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSqlPatternResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSqlPatternResponseBodyItems> Items { get; set; }
        public class DescribeSqlPatternResponseBodyItems : TeaModel {
            [NameInMap("AccessIP")]
            [Validation(Required=false)]
            public string AccessIP { get; set; }

            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public string AvgCpuTime { get; set; }

            [NameInMap("AvgPeakMemory")]
            [Validation(Required=false)]
            public string AvgPeakMemory { get; set; }

            [NameInMap("AvgScanSize")]
            [Validation(Required=false)]
            public string AvgScanSize { get; set; }

            [NameInMap("AvgStageCount")]
            [Validation(Required=false)]
            public string AvgStageCount { get; set; }

            [NameInMap("AvgTaskCount")]
            [Validation(Required=false)]
            public string AvgTaskCount { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public string MaxCpuTime { get; set; }

            [NameInMap("MaxPeakMemory")]
            [Validation(Required=false)]
            public string MaxPeakMemory { get; set; }

            [NameInMap("MaxScanSize")]
            [Validation(Required=false)]
            public string MaxScanSize { get; set; }

            [NameInMap("MaxStageCount")]
            [Validation(Required=false)]
            public string MaxStageCount { get; set; }

            [NameInMap("MaxTaskCount")]
            [Validation(Required=false)]
            public string MaxTaskCount { get; set; }

            /// <summary>
            /// SQL Pattern。
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public string QueryCount { get; set; }

            [NameInMap("ReportDate")]
            [Validation(Required=false)]
            public string ReportDate { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
