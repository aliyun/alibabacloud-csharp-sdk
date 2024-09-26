// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateInstanceOpsTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-bp1dvysdafbh00t7****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The type of the O&amp;M task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>coredump</description></item>
        /// <item><description>tcpdump</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>coredump</para>
        /// </summary>
        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        /// <summary>
        /// <para>The value of the O\&amp;M task. You can set this parameter based on the value of OpsType.</para>
        /// <list type="bullet">
        /// <item><description><para>If OpsType is set to coredump, the valid values of OpsValue are:</para>
        /// <list type="bullet">
        /// <item><description>enable: enables coredump.</description></item>
        /// <item><description>disable: disables coredump.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If OpsType is set to tcpdump, the value of OpsValue is a JSON-formatted parameter string. Example: <c>{&quot;Enable&quot;:true, &quot;IfDeviceName&quot;:&quot;eth0&quot;}</c>. The value may contain the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>Enable: specifies whether to enable tcpdump. You must specify this parameter. Valid values: true and false.</description></item>
        /// <item><description>Protocol: the network protocol. Valid values: tcp, udp, and icmpv4.</description></item>
        /// <item><description>SourceIp: the source IP address.</description></item>
        /// <item><description>SourceCidr: the source CIDR block. If you specify both an IP address and a CIDR block, the IP address is ignored if the CIDR block is valid.</description></item>
        /// <item><description>SourcePort: the source port. Valid values: 1 to 65535.</description></item>
        /// <item><description>DestIp: the destination IP address.</description></item>
        /// <item><description>DestCidr: the destination CIDR block. If you specify both an IP address and a CIDR block, the IP address is ignored if the CIDR block is valid.</description></item>
        /// <item><description>DestPort: the destination port. Valid values: 1 to 65535.</description></item>
        /// <item><description>IfDeviceName: the destination network interface controller. Default value: eth0.</description></item>
        /// <item><description>Snaplen: the length to be captured. Default value: 65535. Unit: bytes.</description></item>
        /// <item><description>Duration: the captured period. Unit: seconds.</description></item>
        /// <item><description>PacketNum: the number of packets to be captured.</description></item>
        /// <item><description>FileSize: the size of the destination files on packets. Unit: bytes. Maximum value: 1073741824. 1073741824 bytes is equal to 1 GB.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("OpsValue")]
        [Validation(Required=false)]
        public string OpsValue { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the O&amp;M task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
