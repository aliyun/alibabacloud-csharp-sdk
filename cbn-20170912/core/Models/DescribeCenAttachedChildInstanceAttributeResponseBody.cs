// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The CEN instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-5mv960yjhja0dh****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The time when the network instance was attached.</para>
        /// <para>The time is displayed in UTC in the YYYY-MM-DDThh:mmZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-07-30T07:53Z</para>
        /// </summary>
        [NameInMap("ChildInstanceAttachTime")]
        [Validation(Required=false)]
        public string ChildInstanceAttachTime { get; set; }

        /// <summary>
        /// <para>The details of the network instance.</para>
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

            [NameInMap("Ipv6CidrBlocks")]
            [Validation(Required=false)]
            public DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocks Ipv6CidrBlocks { get; set; }
            public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocks : TeaModel {
                [NameInMap("ipv6CidrBlock")]
                [Validation(Required=false)]
                public List<DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocksIpv6CidrBlock> Ipv6CidrBlock { get; set; }
                public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocksIpv6CidrBlock : TeaModel {
                    [NameInMap("Ipv6CidrBlock")]
                    [Validation(Required=false)]
                    public string Ipv6CidrBlock { get; set; }

                    [NameInMap("Ipv6Isp")]
                    [Validation(Required=false)]
                    public string Ipv6Isp { get; set; }

                }

            }

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
        /// <para>The network instance ID.</para>
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
        /// <para>The type of the network instance.</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: virtual private cloud.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: virtual border router.</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: Cloud Connect Network.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ChildInstanceType")]
        [Validation(Required=false)]
        public string ChildInstanceType { get; set; }

        /// <summary>
        /// <para>The cloud service to which the network instance belongs. This parameter is returned only when a VPC occupied by a cloud service is connected to a transit router. If the VPC is managed by you, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>swas</para>
        /// </summary>
        [NameInMap("ManagedService")]
        [Validation(Required=false)]
        public string ManagedService { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD98358-D265-4060-87CB-A2427F5A8944</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The attachment status of the network instance.</para>
        /// <list type="bullet">
        /// <item><description><b>Attaching</b>: being attached.</description></item>
        /// <item><description><b>Attached</b>: attached.</description></item>
        /// <item><description><b>Detaching</b>: being detached.</description></item>
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
