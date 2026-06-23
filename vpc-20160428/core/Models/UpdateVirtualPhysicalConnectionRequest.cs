// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateVirtualPhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a dry run to check for required parameters, the request format, and the instance status. The VLAN ID of the virtual physical connection is not modified. If the check fails, an error message is returned. If it passes, the request ID is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends the request. If the check passes, the VLAN ID of the virtual physical connection is modified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The expected bandwidth of the virtual physical connection. The new bandwidth takes effect only after the payment is complete.</para>
        /// <para>Valid values: <b>50M</b>, <b>100M</b>, <b>200M</b>, <b>300M</b>, <b>400M</b>, <b>500M</b>, <b>1G</b>, <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>Bandwidth settings of <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b> are not enabled by default. To use these settings, contact your account manager.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>Bandwidth settings of <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b> are not enabled by default. To use these settings, contact your account manager.</para>
        /// </remarks>
        /// <para>Units: <b>M</b> indicates Mbps and <b>G</b> indicates Gbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50M</para>
        /// </summary>
        [NameInMap("ExpectSpec")]
        [Validation(Required=false)]
        public string ExpectSpec { get; set; }

        /// <summary>
        /// <para>The ID of the virtual physical connection instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1mrgfbtmc9brre7****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the virtual physical connection is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The client token that ensures the idempotence of the request.</para>
        /// <para>A client-generated value that must be unique across requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> is different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CBCE910E-D396-4944-8****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the virtual physical connection. Valid values: <b>0</b> to <b>2999</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the VLAN ID to <b>0</b>, the physical switch port of the Virtual Border Router (VBR) operates in Layer 3 routed interface mode. In this mode, one physical connection corresponds to one VBR.</para>
        /// </description></item>
        /// <item><description><para>If you set the VLAN ID to a value from <b>1</b> to <b>2999</b>, the physical switch port of the VBR uses a VLAN-based Layer 3 subinterface. In this mode, each VLAN ID corresponds to one VBR. The physical connection can be attached to VPCs that belong to different accounts. VBRs in different VLANs are isolated at Layer 2 and cannot communicate with each other.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public long? VlanId { get; set; }

    }

}
