// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The time when the network instance was attached to the CEN instance.
        /// 
        /// The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ChildInstanceAttachTime")]
        [Validation(Required=false)]
        public string ChildInstanceAttachTime { get; set; }

        /// <summary>
        /// The details about the network instance.
        /// </summary>
        [NameInMap("ChildInstanceAttributes")]
        [Validation(Required=false)]
        public DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributes ChildInstanceAttributes { get; set; }
        public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributes : TeaModel {
            /// <summary>
            /// The IPv4 CIDR block of the VPC.
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// The IPv6 CIDR block of the VPC.
            /// </summary>
            [NameInMap("Ipv6CidrBlock")]
            [Validation(Required=false)]
            public string Ipv6CidrBlock { get; set; }

            /// <summary>
            /// The IPv6 CIDR blocks of the VPC.
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
                    /// The IPv6 CIDR block of the VPC.
                    /// </summary>
                    [NameInMap("Ipv6CidrBlock")]
                    [Validation(Required=false)]
                    public string Ipv6CidrBlock { get; set; }

                    /// <summary>
                    /// The type of the IPv6 CIDR block of the VPC. Valid values:
                    /// 
                    /// *   BGP (default): Alibaba Cloud Border Gateway Protocol (BGP) IPv6
                    /// *   ChinaMobile: China Mobile (single line)
                    /// *   ChinaUnicom: China Unicom (single line)
                    /// *   ChinaTelecom: China Telecom (single line)
                    /// 
                    /// >  If you are on the whitelist of single-line bandwidth, you can set this parameter to ChinaTelecom, ChinaUnicom, or ChinaMobile.
                    /// </summary>
                    [NameInMap("Ipv6Isp")]
                    [Validation(Required=false)]
                    public string Ipv6Isp { get; set; }

                }

            }

            /// <summary>
            /// The information about the VPC secondary CIDR block.
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
        /// The ID of the network instance.
        /// </summary>
        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        /// <summary>
        /// The name of the network instance.
        /// </summary>
        [NameInMap("ChildInstanceName")]
        [Validation(Required=false)]
        public string ChildInstanceName { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the network instance belongs.
        /// </summary>
        [NameInMap("ChildInstanceOwnerId")]
        [Validation(Required=false)]
        public long? ChildInstanceOwnerId { get; set; }

        /// <summary>
        /// The region ID of the network instance.
        /// </summary>
        [NameInMap("ChildInstanceRegionId")]
        [Validation(Required=false)]
        public string ChildInstanceRegionId { get; set; }

        /// <summary>
        /// The type of the network instance. Valid values:
        /// 
        /// *   **VPC**: VPC
        /// *   **VBR**: VBR
        /// *   **CCN**: CCN instance
        /// </summary>
        [NameInMap("ChildInstanceType")]
        [Validation(Required=false)]
        public string ChildInstanceType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the network instance is attached to the CEN instance.
        /// 
        /// *   **Attaching**: The network instance is being attached to the CEN instance.
        /// *   **Attached**: The network instance is attached to the CEN instance.
        /// *   **Detaching**: The network instance is being detached from the CEN instance.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
