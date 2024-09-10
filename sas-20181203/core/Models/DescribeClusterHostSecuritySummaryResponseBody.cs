// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterHostSecuritySummaryResponseBody : TeaModel {
        /// <summary>
        /// The alert details of the hosts.
        /// </summary>
        [NameInMap("ClusterHostEvent")]
        [Validation(Required=false)]
        public DescribeClusterHostSecuritySummaryResponseBodyClusterHostEvent ClusterHostEvent { get; set; }
        public class DescribeClusterHostSecuritySummaryResponseBodyClusterHostEvent : TeaModel {
            /// <summary>
            /// The alert details of the host.
            /// </summary>
            [NameInMap("AlarmEvent")]
            [Validation(Required=false)]
            public List<DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventAlarmEvent> AlarmEvent { get; set; }
            public class DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventAlarmEvent : TeaModel {
                /// <summary>
                /// The number of alerts.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The alert level. Valid values:
                /// 
                /// *   **serious**
                /// *   **suspicious**
                /// *   **remind**
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// The baseline details of the host.
            /// </summary>
            [NameInMap("BaselineEvent")]
            [Validation(Required=false)]
            public List<DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventBaselineEvent> BaselineEvent { get; set; }
            public class DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventBaselineEvent : TeaModel {
                /// <summary>
                /// The number of baselines.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The risk level of the baseline. Valid values:
                /// 
                /// *   **high**
                /// *   **medium**
                /// *   **low**
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// The vulnerability details of the host.
            /// </summary>
            [NameInMap("VulEvent")]
            [Validation(Required=false)]
            public List<DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventVulEvent> VulEvent { get; set; }
            public class DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventVulEvent : TeaModel {
                /// <summary>
                /// The number of vulnerabilities.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The risk level of the vulnerability. Valid values:
                /// 
                /// *   **asap**: high. You must fix the vulnerability at the earliest opportunity.
                /// *   **nntf**: medium. You can fix the vulnerability based on your business requirements.
                /// *   **later**: low. You can ignore the vulnerability.
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
