// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAppliedAdvicesResponseBody : TeaModel {
        /// <summary>
        /// The queried suggestions.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAppliedAdvicesResponseBodyItems> Items { get; set; }
        public class DescribeAppliedAdvicesResponseBodyItems : TeaModel {
            /// <summary>
            /// The suggestion ID.
            /// </summary>
            [NameInMap("AdviceId")]
            [Validation(Required=false)]
            public string AdviceId { get; set; }

            /// <summary>
            /// The benefit of the suggestion.
            /// </summary>
            [NameInMap("Benefit")]
            [Validation(Required=false)]
            public string Benefit { get; set; }

            /// <summary>
            /// The SQL statement that is used to execute the BUILD job.
            /// </summary>
            [NameInMap("BuildSQL")]
            [Validation(Required=false)]
            public string BuildSQL { get; set; }

            /// <summary>
            /// The state of the suggestion execution job. Valid values:
            /// 
            /// *   **SUCCEED**
            /// *   **FAILED**
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// The page number. Pages start from 1. Default value: 1.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Valid values:
            /// 
            /// *   **30** (default)
            /// *   **50**
            /// *   **100**
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The SQL statement that is used to roll back the suggestion.
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// The SQL statement that is used to apply the suggestion.
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// The submission state of the suggestion. Valid values:
            /// 
            /// *   **SUCCEED**
            /// *   **FAILED**
            /// </summary>
            [NameInMap("SubmitStatus")]
            [Validation(Required=false)]
            public string SubmitStatus { get; set; }

            /// <summary>
            /// The time when the suggestion was submitted. The time follows the ISO 8601 standard in the yyMMddHHmm format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// The total number of entries returned. Minimum value: 0. Default value: 0.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned. The value is an integer that is greater than or equal to 0. Default value: 0.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
