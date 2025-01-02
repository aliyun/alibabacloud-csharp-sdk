// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0525EADE-C112-5702-A5BC-0E2F6F94DB23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The statistics on traffic.</para>
        /// </summary>
        [NameInMap("TrafficList")]
        [Validation(Required=false)]
        public List<DescribePostpayTrafficDetailResponseBodyTrafficList> TrafficList { get; set; }
        public class DescribePostpayTrafficDetailResponseBodyTrafficList : TeaModel {
            /// <summary>
            /// <para>The inbound network throughput, which indicates the total number of bytes that are received Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1115096939</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vb2d7c9mtn0bo9qcraq</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The asset type. This value takes effect only for the Internet firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EcsPublicIP</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The outbound network throughput, which indicates the total number of bytes that are sent. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000000</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>Protection duration. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ProtectionDuration")]
            [Validation(Required=false)]
            public long? ProtectionDuration { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The resource ID. The resource ID for the Internet firewall is the public IP address that is protected the Internet firewall, and the resource ID for a NAT firewall is the instance ID of the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39.106.146.214</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The total inbound and outbound network throughput, which indicates the total number of bytes that are received and sent. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1215096939</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

            /// <summary>
            /// <para>The date on which the statistics are collected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20231001</para>
            /// </summary>
            [NameInMap("TrafficDay")]
            [Validation(Required=false)]
            public string TrafficDay { get; set; }

            /// <summary>
            /// <para>The traffic type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EIP_TRAFFIC</b>: traffic for the Internet firewall</description></item>
            /// <item><description><b>NatGateway_TRAFFIC</b>: traffic for NAT firewalls</description></item>
            /// <item><description><b>VPC_TRAFFIC</b>: traffic for VPC firewalls</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EIP_TRAFFIC</para>
            /// </summary>
            [NameInMap("TrafficType")]
            [Validation(Required=false)]
            public string TrafficType { get; set; }

        }

    }

}
