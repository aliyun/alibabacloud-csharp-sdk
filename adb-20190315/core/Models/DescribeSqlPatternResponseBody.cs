// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSqlPatternResponseBody : TeaModel {
        /// <summary>
        /// Details about the SQL pattern.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSqlPatternResponseBodyItems> Items { get; set; }
        public class DescribeSqlPatternResponseBodyItems : TeaModel {
            /// <summary>
            /// The IP address of the client.
            /// 
            /// >  This parameter is returned only when the `Type` parameter is set to `accessip`.
            /// </summary>
            [NameInMap("AccessIP")]
            [Validation(Required=false)]
            public string AccessIP { get; set; }

            /// <summary>
            /// The average CPU time. Unit: milliseconds.
            /// </summary>
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public string AvgCpuTime { get; set; }

            /// <summary>
            /// The average peak memory. Unit: KB.
            /// </summary>
            [NameInMap("AvgPeakMemory")]
            [Validation(Required=false)]
            public string AvgPeakMemory { get; set; }

            /// <summary>
            /// The average scan size. Unit: KB.
            /// </summary>
            [NameInMap("AvgScanSize")]
            [Validation(Required=false)]
            public string AvgScanSize { get; set; }

            /// <summary>
            /// The average number of stages.
            /// </summary>
            [NameInMap("AvgStageCount")]
            [Validation(Required=false)]
            public string AvgStageCount { get; set; }

            /// <summary>
            /// The average number of tasks.
            /// </summary>
            [NameInMap("AvgTaskCount")]
            [Validation(Required=false)]
            public string AvgTaskCount { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The maximum CPU time. Unit: milliseconds.
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public string MaxCpuTime { get; set; }

            /// <summary>
            /// The maximum peak memory. Unit: KB.
            /// </summary>
            [NameInMap("MaxPeakMemory")]
            [Validation(Required=false)]
            public string MaxPeakMemory { get; set; }

            /// <summary>
            /// The maximum scan size. Unit: KB.
            /// </summary>
            [NameInMap("MaxScanSize")]
            [Validation(Required=false)]
            public string MaxScanSize { get; set; }

            /// <summary>
            /// The maximum number of stages.
            /// </summary>
            [NameInMap("MaxStageCount")]
            [Validation(Required=false)]
            public string MaxStageCount { get; set; }

            /// <summary>
            /// The maximum number of tasks.
            /// </summary>
            [NameInMap("MaxTaskCount")]
            [Validation(Required=false)]
            public string MaxTaskCount { get; set; }

            /// <summary>
            /// The SQL pattern.
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// The total number of queries.
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public string QueryCount { get; set; }

            /// <summary>
            /// The query date.
            /// </summary>
            [NameInMap("ReportDate")]
            [Validation(Required=false)]
            public string ReportDate { get; set; }

            /// <summary>
            /// The username.
            /// 
            /// >  This parameter is returned only when the `Type` parameter is left empty or set to `user`.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
