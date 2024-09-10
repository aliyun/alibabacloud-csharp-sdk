// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBuildRiskListResponseBody : TeaModel {
        /// <summary>
        /// The response code. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageBuildRiskListResponseBodyData Data { get; set; }
        public class DescribeImageBuildRiskListResponseBodyData : TeaModel {
            /// <summary>
            /// The risks.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageBuildRiskListResponseBodyDataList> List { get; set; }
            public class DescribeImageBuildRiskListResponseBodyDataList : TeaModel {
                /// <summary>
                /// The number of affected images.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The timestamp generated when the first scan was performed. Unit: milliseconds.
                /// </summary>
                [NameInMap("FirstScanTime")]
                [Validation(Required=false)]
                public long? FirstScanTime { get; set; }

                /// <summary>
                /// The timestamp generated when the last scan was performed. Unit: milliseconds.
                /// </summary>
                [NameInMap("LastScanTime")]
                [Validation(Required=false)]
                public long? LastScanTime { get; set; }

                /// <summary>
                /// The type key of the risk.
                /// </summary>
                [NameInMap("RiskClass")]
                [Validation(Required=false)]
                public string RiskClass { get; set; }

                /// <summary>
                /// The type name of the risk.
                /// </summary>
                [NameInMap("RiskClassName")]
                [Validation(Required=false)]
                public string RiskClassName { get; set; }

                /// <summary>
                /// The key of the risk. You can call the [DescribeImageBuildRiskList](~~~~) operation to obtain the value of **RiskKey**.
                /// </summary>
                [NameInMap("RiskKey")]
                [Validation(Required=false)]
                public string RiskKey { get; set; }

                /// <summary>
                /// The rule name of the risk.
                /// </summary>
                [NameInMap("RiskKeyName")]
                [Validation(Required=false)]
                public string RiskKeyName { get; set; }

                /// <summary>
                /// The risk level. Valid values:
                /// 
                /// *   **high**
                /// *   **medium**
                /// *   **low**
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// The number of unprocessed images.
                /// </summary>
                [NameInMap("UnprocessedNum")]
                [Validation(Required=false)]
                public int? UnprocessedNum { get; set; }

            }

            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageBuildRiskListResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageBuildRiskListResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The page number. Default value: **1**.
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
                /// 
                /// >  We recommend that you do not leave this parameter empty.
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

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
