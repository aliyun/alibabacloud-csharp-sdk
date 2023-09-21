// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineCheckResultResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the check results of image baselines.
        /// </summary>
        [NameInMap("BaselineResult")]
        [Validation(Required=false)]
        public List<DescribeImageBaselineCheckResultResponseBodyBaselineResult> BaselineResult { get; set; }
        public class DescribeImageBaselineCheckResultResponseBodyBaselineResult : TeaModel {
            /// <summary>
            /// The key of the image baseline type.
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// The number of baseline check items.
            /// </summary>
            [NameInMap("BaselineItemCount")]
            [Validation(Required=false)]
            public int? BaselineItemCount { get; set; }

            /// <summary>
            /// The alias of the image baseline.
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// The key of the image baseline.
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
            /// The number of high-risk images that are affected.
            /// </summary>
            [NameInMap("HighRiskItemCount")]
            [Validation(Required=false)]
            public int? HighRiskItemCount { get; set; }

            /// <summary>
            /// The timestamp generated when the last scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// The number of low-risk images that are affected.
            /// </summary>
            [NameInMap("LowRiskItemCount")]
            [Validation(Required=false)]
            public int? LowRiskItemCount { get; set; }

            /// <summary>
            /// The number of medium-risk images that are affected.
            /// </summary>
            [NameInMap("MiddleRiskItemCount")]
            [Validation(Required=false)]
            public int? MiddleRiskItemCount { get; set; }

            /// <summary>
            /// The status of the baseline risks. Valid values:
            /// 
            /// *   **0**: unfixed
            /// *   **1**: fixed
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
        public DescribeImageBaselineCheckResultResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageBaselineCheckResultResponseBodyPageInfo : TeaModel {
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
            /// The number of entries returned per page.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
