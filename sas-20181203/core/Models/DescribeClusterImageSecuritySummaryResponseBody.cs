// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterImageSecuritySummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The image security event information.</para>
        /// </summary>
        [NameInMap("ClusterImageEvent")]
        [Validation(Required=false)]
        public DescribeClusterImageSecuritySummaryResponseBodyClusterImageEvent ClusterImageEvent { get; set; }
        public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEvent : TeaModel {
            /// <summary>
            /// <para>The image baseline check information.</para>
            /// </summary>
            [NameInMap("ImageBaseline")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageBaseline> ImageBaseline { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageBaseline : TeaModel {
                /// <summary>
                /// <para>The number of baselines.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>high</b>: High.</description></item>
                /// <item><description><b>medium</b>: Medium.</description></item>
                /// <item><description><b>low</b>: Low.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>The image system vulnerability information.</para>
            /// </summary>
            [NameInMap("ImageCveVul")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageCveVul> ImageCveVul { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageCveVul : TeaModel {
                /// <summary>
                /// <para>The number of vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The warning level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>asap</b>: High. Fix the vulnerability at the earliest opportunity.</description></item>
                /// <item><description><b>nntf</b>: Medium. The vulnerability can be temporarily left unfixed.</description></item>
                /// <item><description><b>later</b>: Low. The vulnerability can be left unfixed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>later</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>The image malicious sample information.</para>
            /// </summary>
            [NameInMap("ImageMaliciousFile")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageMaliciousFile> ImageMaliciousFile { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageMaliciousFile : TeaModel {
                /// <summary>
                /// <para>The number of malicious samples.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>high</b>: High.</description></item>
                /// <item><description><b>medium</b>: Medium.</description></item>
                /// <item><description><b>low</b>: Low.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>The image application vulnerability information.</para>
            /// </summary>
            [NameInMap("ImageScaVul")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageScaVul> ImageScaVul { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageScaVul : TeaModel {
                /// <summary>
                /// <para>The number of application vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The warning level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>asap</b>: High. Fix the vulnerability at the earliest opportunity.</description></item>
                /// <item><description><b>nntf</b>: Medium. The vulnerability can be temporarily left unfixed.</description></item>
                /// <item><description><b>later</b>: Low. The vulnerability can be left unfixed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>later</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
