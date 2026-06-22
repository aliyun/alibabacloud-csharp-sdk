// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterHostSecuritySummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The host alert details.</para>
        /// </summary>
        [NameInMap("ClusterHostEvent")]
        [Validation(Required=false)]
        public DescribeClusterHostSecuritySummaryResponseBodyClusterHostEvent ClusterHostEvent { get; set; }
        public class DescribeClusterHostSecuritySummaryResponseBodyClusterHostEvent : TeaModel {
            /// <summary>
            /// <para>The host alert details.</para>
            /// </summary>
            [NameInMap("AlarmEvent")]
            [Validation(Required=false)]
            public List<DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventAlarmEvent> AlarmEvent { get; set; }
            public class DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventAlarmEvent : TeaModel {
                /// <summary>
                /// <para>The number of alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The warning level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>serious</b>: urgent.</description></item>
                /// <item><description><b>suspicious</b>: suspicious.</description></item>
                /// <item><description><b>remind</b>: reminder.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>remind</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>The host baseline details.</para>
            /// </summary>
            [NameInMap("BaselineEvent")]
            [Validation(Required=false)]
            public List<DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventBaselineEvent> BaselineEvent { get; set; }
            public class DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventBaselineEvent : TeaModel {
                /// <summary>
                /// <para>The number of baselines.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The baseline risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>high</b>: high risk.</description></item>
                /// <item><description><b>medium</b>: medium risk.</description></item>
                /// <item><description><b>low</b>: low risk.</description></item>
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
            /// <para>The host vulnerability details.</para>
            /// </summary>
            [NameInMap("VulEvent")]
            [Validation(Required=false)]
            public List<DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventVulEvent> VulEvent { get; set; }
            public class DescribeClusterHostSecuritySummaryResponseBodyClusterHostEventVulEvent : TeaModel {
                /// <summary>
                /// <para>The number of vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The warning level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>asap</b>: high. Fix the vulnerability at the earliest opportunity.</description></item>
                /// <item><description><b>nntf</b>: medium. The vulnerability can be temporarily left unfixed.</description></item>
                /// <item><description><b>later</b>: low. The vulnerability can be left unfixed.</description></item>
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
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
