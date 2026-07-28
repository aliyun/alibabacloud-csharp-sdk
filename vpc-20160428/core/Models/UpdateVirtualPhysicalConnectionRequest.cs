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
        /// <item><description><b>true</b>: performs a dry run without modifying the VLAN ID of the shared Express Connect circuit. The system checks whether required parameters are specified, whether the request format is valid, and whether the instance status is valid. If the check fails, the corresponding error is returned. If the check succeeds, the corresponding request ID is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. After the request passes the check, the VLAN ID of the shared Express Connect circuit is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The expected bandwidth value of the shared Express Connect circuit. The bandwidth value takes effect only after payment is completed.</para>
        /// <para>Valid values: <b>50M</b>, <b>100M</b>, <b>200M</b>, <b>300M</b>, <b>400M</b>, <b>500M</b>, <b>1G</b>, <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>The bandwidth values <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b> are not available by default. To use these values, contact your account manager.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>The bandwidth values <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b> are not available by default. To use these values, contact your account manager.</para>
        /// </remarks>
        /// <para>Unit: <b>M</b> indicates Mbit/s and <b>G</b> indicates Gbit/s.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
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
        /// <item><description>If the VLAN ID is <b>0</b>, the physical vSwitch port of the Virtual Border Router (VBR) does not use VLAN mode but uses Layer 3 vRouter interface mode. In Layer 3 vRouter interface mode, each Express Connect circuit corresponds to one VBR.</description></item>
        /// <item><description>If the VLAN ID is <b>1</b> to <b>2999</b>, the physical vSwitch port of the VBR uses VLAN-based Layer 3 subinterfaces. In Layer 3 subinterface mode, each VLAN ID corresponds to one VBR. In this case, the Express Connect circuit of the VBR can connect to VPCs under multiple accounts. VBRs in different VLANs have network isolation at Layer 2 and cannot communicate with each other.</description></item>
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
