// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether automatic traffic redirection is enabled. Valid values:- <b>true</b>: Enabled.- <b>false</b>: Disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoResourceEnable")]
        [Validation(Required=false)]
        public bool? AutoResourceEnable { get; set; }

        /// <summary>
        /// <para>The general instance specifications for version 2.0.</para>
        /// </summary>
        [NameInMap("GeneralInstanceSpecStatistic")]
        [Validation(Required=false)]
        public DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatistic GeneralInstanceSpecStatistic { get; set; }
        public class DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatistic : TeaModel {
            /// <summary>
            /// <para>The region-specific statistics for the Internet firewall.</para>
            /// </summary>
            [NameInMap("CfwGeneralInstanceRegionStatistic")]
            [Validation(Required=false)]
            public List<DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatisticCfwGeneralInstanceRegionStatistic> CfwGeneralInstanceRegionStatistic { get; set; }
            public class DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatisticCfwGeneralInstanceRegionStatistic : TeaModel {
                /// <summary>
                /// <para>The list of members in the region.</para>
                /// </summary>
                [NameInMap("MemberList")]
                [Validation(Required=false)]
                public List<string> MemberList { get; set; }

                /// <summary>
                /// <para>The region information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The region-specific statistics for all Internet firewall instances.</para>
            /// </summary>
            [NameInMap("CfwTotalGeneralInstanceRegionStatistic")]
            [Validation(Required=false)]
            public List<DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatisticCfwTotalGeneralInstanceRegionStatistic> CfwTotalGeneralInstanceRegionStatistic { get; set; }
            public class DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatisticCfwTotalGeneralInstanceRegionStatistic : TeaModel {
                /// <summary>
                /// <para>The list of members in the region.</para>
                /// </summary>
                [NameInMap("MemberList")]
                [Validation(Required=false)]
                public List<string> MemberList { get; set; }

                /// <summary>
                /// <para>The region information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The total number of instances for the Internet firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCfwGeneralInstanceCnt")]
            [Validation(Required=false)]
            public int? TotalCfwGeneralInstanceCnt { get; set; }

            /// <summary>
            /// <para>The number of instances with the Internet firewall enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCfwGeneralInstanceUsedCnt")]
            [Validation(Required=false)]
            public int? TotalCfwGeneralInstanceUsedCnt { get; set; }

            /// <summary>
            /// <para>The total quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalGeneralInstanceUsedCnt")]
            [Validation(Required=false)]
            public int? TotalGeneralInstanceUsedCnt { get; set; }

            /// <summary>
            /// <para>The total number of instances for the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNatGeneralInstanceCnt")]
            [Validation(Required=false)]
            public int? TotalNatGeneralInstanceCnt { get; set; }

            /// <summary>
            /// <para>The number of instances with the NAT firewall enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNatGeneralInstanceUsedCnt")]
            [Validation(Required=false)]
            public int? TotalNatGeneralInstanceUsedCnt { get; set; }

            /// <summary>
            /// <para>The number of instances with the VPC firewall enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalVfwGeneralInstanceUsedCnt")]
            [Validation(Required=false)]
            public int? TotalVfwGeneralInstanceUsedCnt { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84******25g4d2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The consumed quota statistics information.</para>
        /// </summary>
        [NameInMap("ResourceSpecStatistic")]
        [Validation(Required=false)]
        public DescribeAssetStatisticResponseBodyResourceSpecStatistic ResourceSpecStatistic { get; set; }
        public class DescribeAssetStatisticResponseBodyResourceSpecStatistic : TeaModel {
            /// <summary>
            /// <para>The quota for protected public IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IpNumSpec")]
            [Validation(Required=false)]
            public int? IpNumSpec { get; set; }

            /// <summary>
            /// <para>The number of public IP addresses with protection enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("IpNumUsed")]
            [Validation(Required=false)]
            public int? IpNumUsed { get; set; }

            /// <summary>
            /// <para>The quota for sensitive data IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SensitiveDataIpNumSpec")]
            [Validation(Required=false)]
            public long? SensitiveDataIpNumSpec { get; set; }

            /// <summary>
            /// <para>The number of sensitive data IP addresses with protection enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SensitiveDataIpNumUsed")]
            [Validation(Required=false)]
            public long? SensitiveDataIpNumUsed { get; set; }

        }

    }

}
