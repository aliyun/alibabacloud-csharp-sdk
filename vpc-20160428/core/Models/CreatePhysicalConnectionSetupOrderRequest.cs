// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionSetupOrderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access point.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-cn-beijing-ft-A</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payments. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): disables automatic payment.</description></item>
        /// <item><description><b>true</b></description></item>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>318BB676-0A2B-43A0-9AD8-F1D34E93750F</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The connectivity provider of the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CT</b>: China Telecom</description></item>
        /// <item><description><b>CU</b>: China Unicom</description></item>
        /// <item><description><b>CM</b>: China Mobile</description></item>
        /// <item><description><b>CO</b>: other connectivity providers in the Chinese mainland</description></item>
        /// <item><description><b>Equinix</b>: Equinix</description></item>
        /// <item><description><b>Other</b>: other connectivity providers outside the Chinese mainland</description></item>
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
        /// <item><description><b>100Base-T</b>: 100 Mbit/s copper Ethernet port</description></item>
        /// <item><description><b>1000Base-T</b> (default): 1,000 Mbit/s copper Ethernet port</description></item>
        /// <item><description><b>1000Base-LX</b>: 1,000 Mbit/s single-mode optical port (10 km)</description></item>
        /// <item><description><b>10GBase-T</b>: 10,000 Mbit/s copper Ethernet port</description></item>
        /// <item><description><b>10GBase-LR</b>: 10,000 Mbit/s single-mode optical port (10 km)</description></item>
        /// <item><description><b>40GBase-LR</b>: 40,000 Mbit/s single-mode optical port</description></item>
        /// <item><description><b>100GBase-LR</b>: 100,000 Mbit/s single-mode optical port</description></item>
        /// </list>
        /// <remarks>
        /// <para> Whether 40GBase-LR and 100GBase-LR ports can be created depends on resource supplies. For more information, contact your account manager.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100Base-T</para>
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// <para>The ID of the redundant physical connection. The redundant physical connection must be in the <b>Allocated</b>, <b>Confirmed</b>, or <b>Enabled</b> state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp10zsv5ntp****</para>
        /// </summary>
        [NameInMap("RedundantPhysicalConnectionId")]
        [Validation(Required=false)]
        public string RedundantPhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
