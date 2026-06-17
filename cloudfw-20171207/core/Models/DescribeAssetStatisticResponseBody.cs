// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>Whether automatic traffic diversion is enabled. Valid values:- <b>true</b>: enabled- <b>false</b>: disabled</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoResourceEnable")]
        [Validation(Required=false)]
        public bool? AutoResourceEnable { get; set; }

        /// <summary>
        /// <para>Specifications for general instances in version 2.0.</para>
        /// </summary>
        [NameInMap("GeneralInstanceSpecStatistic")]
        [Validation(Required=false)]
        public DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatistic GeneralInstanceSpecStatistic { get; set; }
        public class DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatistic : TeaModel {
            /// <summary>
            /// <para>Internet-facing firewall instance usage by region.</para>
            /// </summary>
            [NameInMap("CfwGeneralInstanceRegionStatistic")]
            [Validation(Required=false)]
            public List<DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatisticCfwGeneralInstanceRegionStatistic> CfwGeneralInstanceRegionStatistic { get; set; }
            public class DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatisticCfwGeneralInstanceRegionStatistic : TeaModel {
                /// <summary>
                /// <para>List of member accounts in the region.</para>
                /// </summary>
                [NameInMap("MemberList")]
                [Validation(Required=false)]
                public List<string> MemberList { get; set; }

                /// <summary>
                /// <para>Region information</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>Total Internet-facing firewall instances by region.</para>
            /// </summary>
            [NameInMap("CfwTotalGeneralInstanceRegionStatistic")]
            [Validation(Required=false)]
            public List<DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatisticCfwTotalGeneralInstanceRegionStatistic> CfwTotalGeneralInstanceRegionStatistic { get; set; }
            public class DescribeAssetStatisticResponseBodyGeneralInstanceSpecStatisticCfwTotalGeneralInstanceRegionStatistic : TeaModel {
                /// <summary>
                /// <para>List of member accounts in the region.</para>
                /// </summary>
                [NameInMap("MemberList")]
                [Validation(Required=false)]
                public List<string> MemberList { get; set; }

                /// <summary>
                /// <para>Region information</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>Total number of Internet-facing firewall instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCfwGeneralInstanceCnt")]
            [Validation(Required=false)]
            public int? TotalCfwGeneralInstanceCnt { get; set; }

            /// <summary>
            /// <para>Number of Internet-facing firewall instances with protection enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCfwGeneralInstanceUsedCnt")]
            [Validation(Required=false)]
            public int? TotalCfwGeneralInstanceUsedCnt { get; set; }

            /// <summary>
            /// <para>Total number of general instances used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalGeneralInstanceUsedCnt")]
            [Validation(Required=false)]
            public int? TotalGeneralInstanceUsedCnt { get; set; }

            /// <summary>
            /// <para>Total number of NAT firewall instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNatGeneralInstanceCnt")]
            [Validation(Required=false)]
            public int? TotalNatGeneralInstanceCnt { get; set; }

            /// <summary>
            /// <para>Number of NAT firewall instances with protection enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNatGeneralInstanceUsedCnt")]
            [Validation(Required=false)]
            public int? TotalNatGeneralInstanceUsedCnt { get; set; }

            /// <summary>
            /// <para>Number of VPC firewall instances with protection enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalVfwGeneralInstanceUsedCnt")]
            [Validation(Required=false)]
            public int? TotalVfwGeneralInstanceUsedCnt { get; set; }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84******25g4d2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Resource specification usage statistics.</para>
        /// </summary>
        [NameInMap("ResourceSpecStatistic")]
        [Validation(Required=false)]
        public DescribeAssetStatisticResponseBodyResourceSpecStatistic ResourceSpecStatistic { get; set; }
        public class DescribeAssetStatisticResponseBodyResourceSpecStatistic : TeaModel {
            /// <summary>
            /// <para>Maximum number of public IP addresses that can be protected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IpNumSpec")]
            [Validation(Required=false)]
            public int? IpNumSpec { get; set; }

            /// <summary>
            /// <para>Number of public IP addresses with protection enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("IpNumUsed")]
            [Validation(Required=false)]
            public int? IpNumUsed { get; set; }

            /// <summary>
            /// <para>The number of IP specifications for sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SensitiveDataIpNumSpec")]
            [Validation(Required=false)]
            public long? SensitiveDataIpNumSpec { get; set; }

            /// <summary>
            /// <para>Number of public IP addresses currently scanned for sensitive data.</para>
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
