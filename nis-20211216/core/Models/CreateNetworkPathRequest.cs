// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateNetworkPathRequest : TeaModel {
        /// <summary>
        /// <para>The description of the network path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analyze the path from ECS to ECS</para>
        /// </summary>
        [NameInMap("NetworkPathDescription")]
        [Validation(Required=false)]
        public string NetworkPathDescription { get; set; }

        /// <summary>
        /// <para>The name of the network path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs2PublicIp</para>
        /// </summary>
        [NameInMap("NetworkPathName")]
        [Validation(Required=false)]
        public string NetworkPathName { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b>: Transmission Control Protocol (TCP)</description></item>
        /// <item><description><b>udp</b>: User Datagram Protocol (UDP)</description></item>
        /// <item><description><b>icmp</b>: Internet Control Message Protocol (ICMP)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID of the network path that you want to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm27qsxjj****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the source resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zef4ngqfarepyun****</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.17.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// <para>The source port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public int? SourcePort { get; set; }

        /// <summary>
        /// <para>The type of the source resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: the Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>internetIp</b>: the public IP address</description></item>
        /// <item><description><b>vsw</b>: the vSwitch</description></item>
        /// <item><description><b>vpn</b>: the VPN gateway</description></item>
        /// <item><description><b>vbr</b>: the virtual border router (VBR)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The tags to add to the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkPathRequestTag> Tag { get; set; }
        public class CreateNetworkPathRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the resource. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// <para>You can add up to 20 tags in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ops</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the destination resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp13d0e064gubm****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The destination IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.210</para>
        /// </summary>
        [NameInMap("TargetIpAddress")]
        [Validation(Required=false)]
        public string TargetIpAddress { get; set; }

        /// <summary>
        /// <para>The destination port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public int? TargetPort { get; set; }

        /// <summary>
        /// <para>The type of the destination resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: the ECS instance</description></item>
        /// <item><description><b>internetIp</b>: the public IP address</description></item>
        /// <item><description><b>vsw</b>: the vSwitch</description></item>
        /// <item><description><b>vpn</b>: the VPN gateway</description></item>
        /// <item><description><b>vbr</b>: the VBR</description></item>
        /// <item><description><b>clb</b>: the Classic Load Balancer (CLB) instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
