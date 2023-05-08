// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// The name of the baseline.
        /// </summary>
        [NameInMap("BaselineResultSummary")]
        [Validation(Required=false)]
        public List<DescribeImageBaselineCheckSummaryResponseBodyBaselineResultSummary> BaselineResultSummary { get; set; }
        public class DescribeImageBaselineCheckSummaryResponseBodyBaselineResultSummary : TeaModel {
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            [NameInMap("BaselineClassKey")]
            [Validation(Required=false)]
            public string BaselineClassKey { get; set; }

            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            [NameInMap("BaselineNameKey")]
            [Validation(Required=false)]
            public string BaselineNameKey { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("BaselineNameLevel")]
            [Validation(Required=false)]
            public string BaselineNameLevel { get; set; }

            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// DescribeImageBaselineCheckSummary
            /// </summary>
            [NameInMap("HighRiskImage")]
            [Validation(Required=false)]
            public int? HighRiskImage { get; set; }

            /// <summary>
            /// Queries the check results of image baselines that are included in an image scan task.
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            [NameInMap("LowRiskImage")]
            [Validation(Required=false)]
            public int? LowRiskImage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("MiddleRiskImage")]
            [Validation(Required=false)]
            public int? MiddleRiskImage { get; set; }

            /// <summary>
            /// The number of entries to return on each page. Default value: **20**.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The search condition for the image baseline.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageBaselineCheckSummaryResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageBaselineCheckSummaryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The type of the search condition. Valid values:
            /// 
            /// *   **BaselineNameAlias**: baseline name
            /// *   **BaselineClassAlias**: baseline category
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The ID of the container cluster.
            /// 
            /// >  You can call the [DescribeGroupedContainerInstances](~~182997~~) operation to query the IDs of container clusters.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The types of the assets that you want to scan.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
