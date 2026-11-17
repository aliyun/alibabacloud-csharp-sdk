// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateVirtualPhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to only perform a dry run for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system performs a dry run without modifying the VLAN ID of the shared Express Connect circuit. The system checks whether the required parameters are specified, the request format, and the instance status. If the request fails the dry run, the corresponding error is returned. If the request passes the dry run, the corresponding request ID is returned.</description></item>
        /// <item><description><b>false</b> (default): The system sends a normal request. After the request passes the dry run, the VLAN ID of the shared Express Connect circuit is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The expected bandwidth of the shared Express Connect circuit. The bandwidth takes effect only after the payment is completed.</para>
        /// <para>Valid values: <b>50M</b>, <b>100M</b>, <b>200M</b>, <b>300M</b>, <b>400M</b>, <b>500M</b>, <b>1G</b>, <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>The bandwidth values of <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b> are not available by default. To use these values, contact your account manager.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>The bandwidth values of <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b> are not available by default. To use these values, contact your account manager.</para>
        /// </remarks>
        /// <para>Unit: <b>M</b> indicates Mbps, and <b>G</b> indicates Gbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50M</para>
        /// </summary>
        [NameInMap("ExpectSpec")]
        [Validation(Required=false)]
        public string ExpectSpec { get; set; }

        /// <summary>
        /// <para>The instance ID of the shared Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1mrgfbtmc9brre7****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the shared Express Connect circuit.</para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CBCE910E-D396-4944-8****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the shared Express Connect circuit. Valid values: <b>0</b> to <b>2999</b>.</para>
        /// <list type="bullet">
        /// <item><description>A value of <b>0</b> specifies that the physical vSwitch port of the Virtual Border Router (VBR), which acts as a vRouter, does not use the VLAN mode, but uses the Layer 3 routing interface mode. In the Layer 3 routing interface mode, each Express Connect circuit corresponds to one VBR.</description></item>
        /// <item><description>A value of <b>1</b> to <b>2999</b> specifies that the physical vSwitch port of the VBR uses a VLAN-based Layer 3 subinterface. In the Layer 3 subinterface mode, each VLAN ID corresponds to one VBR. In this case, the Express Connect circuit of the VBR can be used to connect VPCs that belong to different Alibaba Cloud accounts. Layer 2 network isolation is implemented for VBRs in different VLANs, and they cannot communicate with each other.</description></item>
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
