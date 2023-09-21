// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the check results of image baselines.
        /// </summary>
        [NameInMap("BaselineResultSummary")]
        [Validation(Required=false)]
        public List<DescribeImageBaselineCheckSummaryResponseBodyBaselineResultSummary> BaselineResultSummary { get; set; }
        public class DescribeImageBaselineCheckSummaryResponseBodyBaselineResultSummary : TeaModel {
            /// <summary>
            /// The category of the baseline.
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// The keyword of the baseline category.
            /// </summary>
            [NameInMap("BaselineClassKey")]
            [Validation(Required=false)]
            public string BaselineClassKey { get; set; }

            /// <summary>
            /// The name of the baseline.
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// The keyword of the baseline name.
            /// </summary>
            [NameInMap("BaselineNameKey")]
            [Validation(Required=false)]
            public string BaselineNameKey { get; set; }

            /// <summary>
            /// The severity of the image baseline. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("BaselineNameLevel")]
            [Validation(Required=false)]
            public string BaselineNameLevel { get; set; }

            /// <summary>
            /// The timestamp generated when the first scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// The number of images on which **high** baseline risks are detected.
            /// </summary>
            [NameInMap("HighRiskImage")]
            [Validation(Required=false)]
            public int? HighRiskImage { get; set; }

            /// <summary>
            /// The timestamp generated when the last scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// The number of images on which **low** baseline risks are detected.
            /// </summary>
            [NameInMap("LowRiskImage")]
            [Validation(Required=false)]
            public int? LowRiskImage { get; set; }

            /// <summary>
            /// The number of images on which **medium** baseline risks are detected.
            /// </summary>
            [NameInMap("MiddleRiskImage")]
            [Validation(Required=false)]
            public int? MiddleRiskImage { get; set; }

            /// <summary>
            /// The status of the baseline risks. Valid values:
            /// 
            /// *   **0**: unfixed
            /// *   **1**: fixed
            /// *   **2**: pending verification
            /// *   **3**: fixing failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageBaselineCheckSummaryResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageBaselineCheckSummaryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
