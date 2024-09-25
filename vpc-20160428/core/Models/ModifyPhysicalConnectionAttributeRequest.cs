// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyPhysicalConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>longtel001</para>
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>efefe566754h</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the Express Connect circuit.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the Express Connect circuit.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>CT</para>
        /// </summary>
        [NameInMap("LineOperator")]
        [Validation(Required=false)]
        public string LineOperator { get; set; }

        /// <summary>
        /// <para>The name of the Express Connect circuit.</para>
        /// <para>The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The geographical location of the data center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XX Number, XX Road, XX Town, XX District, Hangzhou City, Zhejiang Province.</para>
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-119mfjzm******</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The port type of the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>100Base-T</b>: 100 Mbit/s copper Ethernet port</description></item>
        /// <item><description><b>1000Base-T</b> (default): 1,000 Mbit/s copper Ethernet port</description></item>
        /// <item><description><b>1000Base-LX</b>: 1,000 Mbit/s single-mode optical port (10 kilometers)</description></item>
        /// <item><description><b>10GBase-T</b>: 10,000 Mbit/s copper Ethernet port</description></item>
        /// <item><description><b>10GBase-LR</b>: 10,000 Mbit/s single-mode optical port (10 kilometers)</description></item>
        /// <item><description><b>40GBase-LR</b>: 40,000 Mbit/s single-mode optical port</description></item>
        /// <item><description><b>100GBase-LR</b>: 100,000 Mbit/s single-mode optical port</description></item>
        /// </list>
        /// <remarks>
        /// <para> To use ports 40GBase-LR and 100GBase-LR, you must first contact your account manager.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000Base-LX</para>
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// <para>The ID of the redundant Express Connect circuit. The redundant Express Connect circuit must be in the <b>Allocated</b>, <b>Confirmed</b>, or <b>Enabled</b> state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-119mfjzm7</para>
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
        /// <para>cn-shanghai</para>
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

        /// <summary>
        /// <para>The bandwidth value for the connection over the Express Connect circuit. Unit: Mbit/s. Valid values: 2 to 10240.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

    }

}
