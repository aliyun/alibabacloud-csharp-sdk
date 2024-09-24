// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterImageSecuritySummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the image-related security events.</para>
        /// </summary>
        [NameInMap("ClusterImageEvent")]
        [Validation(Required=false)]
        public DescribeClusterImageSecuritySummaryResponseBodyClusterImageEvent ClusterImageEvent { get; set; }
        public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEvent : TeaModel {
            /// <summary>
            /// <para>The information about image baseline risks.</para>
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
                /// <item><description><b>high</b></description></item>
                /// <item><description><b>medium</b></description></item>
                /// <item><description><b>low</b></description></item>
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
            /// <para>The information about image system vulnerabilities.</para>
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
                /// <para>The alert level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>asap</b>: high. You must fix the vulnerability at the earliest opportunity.</description></item>
                /// <item><description><b>nntf</b>: medium. You can fix the vulnerability based on your business requirements.</description></item>
                /// <item><description><b>later</b>: low. You can ignore the vulnerability.</description></item>
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
            /// <para>The information about malicious image samples.</para>
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
                /// <item><description><b>high</b></description></item>
                /// <item><description><b>medium</b></description></item>
                /// <item><description><b>low</b></description></item>
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
            /// <para>The information about image application vulnerabilities.</para>
            /// </summary>
            [NameInMap("ImageScaVul")]
            [Validation(Required=false)]
            public List<DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageScaVul> ImageScaVul { get; set; }
            public class DescribeClusterImageSecuritySummaryResponseBodyClusterImageEventImageScaVul : TeaModel {
                /// <summary>
                /// <para>The number of image application vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The alert level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>asap</b>: high. You must fix the vulnerability at the earliest opportunity.</description></item>
                /// <item><description><b>nntf</b>: medium. You can fix the vulnerability based on your business requirements.</description></item>
                /// <item><description><b>later</b>: low. You can ignore the vulnerability.</description></item>
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
