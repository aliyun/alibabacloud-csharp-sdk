// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckResultResponseBody : TeaModel {
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
        /// The check items.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeRiskCheckResultResponseBodyList> List { get; set; }
        public class DescribeRiskCheckResultResponseBodyList : TeaModel {
            /// <summary>
            /// The number of affected assets.
            /// </summary>
            [NameInMap("AffectedCount")]
            [Validation(Required=false)]
            public int? AffectedCount { get; set; }

            /// <summary>
            /// The timestamp when the last check was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public long? CheckTime { get; set; }

            /// <summary>
            /// The ID of the check item. For more information about the check item, see the check item table in the "Response parameters" section of this topic.
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            /// <summary>
            /// The time when the next check will be performed.
            /// </summary>
            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public int? RemainingTime { get; set; }

            /// <summary>
            /// Indicates whether the risks that are detected based on the check item can be fixed. Valid values:
            /// 
            /// *   **enabled**: yes
            /// *   **disabled**: no
            /// </summary>
            [NameInMap("RepairStatus")]
            [Validation(Required=false)]
            public string RepairStatus { get; set; }

            /// <summary>
            /// The type of the affected assets.
            /// </summary>
            [NameInMap("RiskAssertType")]
            [Validation(Required=false)]
            public string RiskAssertType { get; set; }

            /// <summary>
            /// An array that consists of the details about the check item.
            /// </summary>
            [NameInMap("RiskItemResources")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckResultResponseBodyListRiskItemResources> RiskItemResources { get; set; }
            public class DescribeRiskCheckResultResponseBodyListRiskItemResources : TeaModel {
                /// <summary>
                /// The details about the check results.
                /// </summary>
                [NameInMap("ContentResource")]
                [Validation(Required=false)]
                public Dictionary<string, object> ContentResource { get; set; }

                /// <summary>
                /// The title in the details. Valid values:
                /// 
                /// *   **bestPractice**: description
                /// *   **influence**: risk
                /// *   **suggestion**: solution
                /// *   **helpResource**: reference
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

            }

            /// <summary>
            /// The risk level of the check item. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The sequence number in the check results. The check items are sorted based on the sequence number.
            /// </summary>
            [NameInMap("Sort")]
            [Validation(Required=false)]
            public int? Sort { get; set; }

            /// <summary>
            /// Indicates whether the check item is supported by the edition of Security Center that you purchase. Valid values:
            /// 
            /// *   **enabled**: yes
            /// *   **disable**: no
            /// </summary>
            [NameInMap("StartStatus")]
            [Validation(Required=false)]
            public string StartStatus { get; set; }

            /// <summary>
            /// The status of the check results. Valid values:
            /// 
            /// *   **pass**
            /// *   **failed**
            /// *   **running**
            /// *   **waiting**
            /// *   **ignored**
            /// *   **falsePositive**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the check task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// The name of the check item.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The type of the check item. Valid values:
            /// 
            /// *   Identity authentication and permissions
            /// *   Network access control
            /// *   Log audit
            /// *   Data security
            /// *   Monitoring and alerting
            /// *   Basic security protection
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// The number of entries returned per page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
