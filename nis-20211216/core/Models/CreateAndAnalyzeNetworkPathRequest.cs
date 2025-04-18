// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateAndAnalyzeNetworkPathRequest : TeaModel {
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
        /// <para>The ID of the region for which you want to initiate a task for analyzing network reachability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the source resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf62y8khhbkbdrp6****</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// <para>The source port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>The ID of the destination resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-m5eactvw7wtpktv5****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The destination IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.50.XX.XX</para>
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
