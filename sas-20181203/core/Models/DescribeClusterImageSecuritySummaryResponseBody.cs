// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterImageSecuritySummaryResponseBody : TeaModel {
        /// <summary>
        /// The information about the image-related security events.
        /// </summary>
        [NameInMap("ClusterImageEvent")]
        [Validation(Required=false)]
        public DescribeClusterImageSecuritySummaryResponseBodyClusterImageEvent ClusterImageEvent { get; set; }
        public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEvent : TeaModel {
            /// <summary>
            /// The information about image baseline risks.
            /// </summary>
            [NameInMap("ImageBaseline")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageBaseline> ImageBaseline { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageBaseline : TeaModel {
                /// <summary>
                /// The number of baselines.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

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

            }

            /// <summary>
            /// The information about image system vulnerabilities.
            /// </summary>
            [NameInMap("ImageCveVul")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageCveVul> ImageCveVul { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageCveVul : TeaModel {
                /// <summary>
                /// The number of vulnerabilities.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The alert level. Valid values:
                /// 
                /// *   **asap**: high. You must fix the vulnerability at the earliest opportunity.
                /// *   **nntf**: medium. You can fix the vulnerability based on your business requirements.
                /// *   **later**: low. You can ignore the vulnerability.
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// The information about malicious image samples.
            /// </summary>
            [NameInMap("ImageMaliciousFile")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageMaliciousFile> ImageMaliciousFile { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageMaliciousFile : TeaModel {
                /// <summary>
                /// The number of malicious samples.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

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

            }

            /// <summary>
            /// The information about image application vulnerabilities.
            /// </summary>
            [NameInMap("ImageScaVul")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageScaVul> ImageScaVul { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageScaVul : TeaModel {
                /// <summary>
                /// The number of image application vulnerabilities.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The alert level. Valid values:
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
