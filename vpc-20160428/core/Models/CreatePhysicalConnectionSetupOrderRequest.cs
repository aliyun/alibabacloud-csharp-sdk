// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionSetupOrderRequest : TeaModel {
        /// <summary>
        /// <para>The access point ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-cn-beijing-ft-A</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): disables automatic payment.</description></item>
        /// <item><description><b>true</b>: enables automatic payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>318BB676-0A2B-43A0-9AD8-F1D34E93750F</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The carrier that provides the physical connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CT</b>: China Telecom</para>
        /// </description></item>
        /// <item><description><para><b>CU</b>: China Unicom</para>
        /// </description></item>
        /// <item><description><para><b>CM</b>: China Mobile</para>
        /// </description></item>
        /// <item><description><para><b>CO</b>: other carriers in the Chinese mainland</para>
        /// </description></item>
        /// <item><description><para><b>Equinix</b>: Equinix</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: other carriers outside the Chinese mainland</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CT</para>
        /// </summary>
        [NameInMap("LineOperator")]
        [Validation(Required=false)]
        public string LineOperator { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The port type of the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>100Base-T</b>: 100M Ethernet port.</para>
        /// </description></item>
        /// <item><description><para><b>1000Base-T</b> (default): 1 GE port.</para>
        /// </description></item>
        /// <item><description><para><b>1000Base-LX</b>: GE single-mode optical port (10 km).</para>
        /// </description></item>
        /// <item><description><para><b>10GBase-T</b>: 10 GE port.</para>
        /// </description></item>
        /// <item><description><para><b>10GBase-LR</b>: 10 GE single-mode optical port (10 km).</para>
        /// </description></item>
        /// <item><description><para><b>40GBase-LR</b>: 40 GE single-mode optical port.</para>
        /// </description></item>
        /// <item><description><para><b>100GBase-LR</b>: 100 GE single-mode optical port.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>40GBase-LR and 100GBase-LR ports are created based on the actual port availability. Contact your account manager for details.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100Base-T</para>
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// <para>The ID of the redundant Express Connect circuit. The circuit must be in the <b>Allocated</b>, <b>Confirmed</b>, or <b>Enabled</b> state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp10zsv5ntp****</para>
        /// </summary>
        [NameInMap("RedundantPhysicalConnectionId")]
        [Validation(Required=false)]
        public string RedundantPhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
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
