// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-5mv960yjhja0dh****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The time when the network instance was attached to the CEN instance.</para>
        /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-07-30T07:53Z</para>
        /// </summary>
        [NameInMap("ChildInstanceAttachTime")]
        [Validation(Required=false)]
        public string ChildInstanceAttachTime { get; set; }

        /// <summary>
        /// <para>The details about the network instance.</para>
        /// </summary>
        [NameInMap("ChildInstanceAttributes")]
        [Validation(Required=false)]
        public DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributes ChildInstanceAttributes { get; set; }
        public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributes : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The IPv6 CIDR block of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2408:XXXX:0:a600::/56</para>
            /// </summary>
            [NameInMap("Ipv6CidrBlock")]
            [Validation(Required=false)]
            public string Ipv6CidrBlock { get; set; }

            /// <summary>
            /// <para>The IPv6 CIDR blocks of the VPC.</para>
            /// </summary>
            [NameInMap("Ipv6CidrBlocks")]
            [Validation(Required=false)]
            public DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocks Ipv6CidrBlocks { get; set; }
            public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocks : TeaModel {
                [NameInMap("ipv6CidrBlock")]
                [Validation(Required=false)]
                public List<DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocksIpv6CidrBlock> Ipv6CidrBlock { get; set; }
                public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocksIpv6CidrBlock : TeaModel {
                    /// <summary>
                    /// <para>The IPv6 CIDR block of the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2408:XXXX:0:6a::/56</para>
                    /// </summary>
                    [NameInMap("Ipv6CidrBlock")]
                    [Validation(Required=false)]
                    public string Ipv6CidrBlock { get; set; }

                    /// <summary>
                    /// <para>The type of the IPv6 CIDR block of the VPC. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BGP (default): Alibaba Cloud Border Gateway Protocol (BGP) IPv6</description></item>
                    /// <item><description>ChinaMobile: China Mobile (single line)</description></item>
                    /// <item><description>ChinaUnicom: China Unicom (single line)</description></item>
                    /// <item><description>ChinaTelecom: China Telecom (single line)</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> If you are on the whitelist of single-line bandwidth, you can set this parameter to ChinaTelecom, ChinaUnicom, or ChinaMobile.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BGP</para>
                    /// </summary>
                    [NameInMap("Ipv6Isp")]
                    [Validation(Required=false)]
                    public string Ipv6Isp { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the VPC secondary CIDR block.</para>
            /// </summary>
            [NameInMap("SecondaryCidrBlocks")]
            [Validation(Required=false)]
            public DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesSecondaryCidrBlocks SecondaryCidrBlocks { get; set; }
            public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesSecondaryCidrBlocks : TeaModel {
                [NameInMap("secondaryCidrBlock")]
                [Validation(Required=false)]
                public List<string> SecondaryCidrBlock { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the network instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zebdboka7d7t37vo****</para>
        /// </summary>
        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the network instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultvpc</para>
        /// </summary>
        [NameInMap("ChildInstanceName")]
        [Validation(Required=false)]
        public string ChildInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the network instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688000000000000</para>
        /// </summary>
        [NameInMap("ChildInstanceOwnerId")]
        [Validation(Required=false)]
        public long? ChildInstanceOwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the network instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("ChildInstanceRegionId")]
        [Validation(Required=false)]
        public string ChildInstanceRegionId { get; set; }

        /// <summary>
        /// <para>The type of the network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC</description></item>
        /// <item><description><b>VBR</b>: VBR</description></item>
        /// <item><description><b>CCN</b>: CCN instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ChildInstanceType")]
        [Validation(Required=false)]
        public string ChildInstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD98358-D265-4060-87CB-A2427F5A8944</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the network instance is attached to the CEN instance.</para>
        /// <list type="bullet">
        /// <item><description><b>Attaching</b>: The network instance is being attached to the CEN instance.</description></item>
        /// <item><description><b>Attached</b>: The network instance is attached to the CEN instance.</description></item>
        /// <item><description><b>Detaching</b>: The network instance is being detached from the CEN instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Attached</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
