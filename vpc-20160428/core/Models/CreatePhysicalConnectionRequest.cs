// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access point where the Express Connect circuit is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-cn-beijing-ft-A</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>The circuit code provided by the carrier for the Express Connect circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>longtel001</para>
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the Express Connect circuit. </para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of device advanced capabilities.</para>
        /// </summary>
        [NameInMap("DeviceAdvancedCapacity")]
        [Validation(Required=false)]
        public List<string> DeviceAdvancedCapacity { get; set; }

        /// <summary>
        /// <para>The carrier that provides the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CT</b>: China Telecom.</para>
        /// </description></item>
        /// <item><description><para><b>CU</b>: China Unicom.</para>
        /// </description></item>
        /// <item><description><para><b>CM</b>: China Mobile.</para>
        /// </description></item>
        /// <item><description><para><b>CO</b>: Other carriers in China. </para>
        /// </description></item>
        /// <item><description><para><b>Equinix</b>: Equinix.</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: Other carriers outside China.</para>
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

        /// <summary>
        /// <para>The name of the Express Connect circuit.  </para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The optical module model supported by the Express Connect circuit access point. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1000Base-LX : <list type="bullet">
        /// <item><description><c>SFP-GE-LR-SM1310,10KM</c></description></item>
        /// <item><description><c>SFP-GE-ER-SM1310,40KM</c></description></item>
        /// <item><description><c>SFP-GE-ZR-SM1550,80KM</c></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>10GBase-LR : <list type="bullet">
        /// <item><description><c>SFP-10G-LR-SM1310,10KM</c></description></item>
        /// <item><description><c>SFP-10G-ER-SM1550,40KM</c> </description></item>
        /// <item><description><c>SFP-10G-ZR-SM1550,80KM</c></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>40GBase-LR : <list type="bullet">
        /// <item><description><c>QSFP-40G-LR4-WDM1300,10KM</c></description></item>
        /// <item><description><c>QSFP-40G-ER4-WDM1300,40KM</c></description></item>
        /// <item><description><c>QSFP-40G-ZR4-WDM1300,80KM</c></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>100GBase-LR : <list type="bullet">
        /// <item><description><c>QSFP28-100G-LR4-WDM1300,10KM</c></description></item>
        /// <item><description><c>QSFP28-100G-ER4-WDM1300,40KM</c></description></item>
        /// <item><description><c>QSFP28-100G-ZR4-WDM1300,80KM</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SFP-GE-LR-SM1310,10KM</para>
        /// </summary>
        [NameInMap("OpticalModuleModel")]
        [Validation(Required=false)]
        public string OpticalModuleModel { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The geographical location of the on-premises data center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XX街道</para>
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// <para>The port type of the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>100Base-T</b>: 100M Ethernet port.</para>
        /// </description></item>
        /// <item><description><para><b>1000Base-T</b>: 1 GE electrical port.</para>
        /// </description></item>
        /// <item><description><para><b>1000Base-LX</b>: GE single-mode optical port (10 km).</para>
        /// </description></item>
        /// <item><description><para><b>10GBase-T</b>: 10 GE electrical port.</para>
        /// </description></item>
        /// <item><description><para><b>10GBase-LR</b>: 10 GE single-mode optical port (10 km).</para>
        /// </description></item>
        /// <item><description><para><b>40GBase-LR</b>: 40 GE single-mode optical port.</para>
        /// </description></item>
        /// <item><description><para><b>100GBase-LR</b>: 100 GE single-mode optical port.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>40GBase-LR and 100GBase-LR are created based on the actual port availability in the backend. Contact your account manager for port availability details.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000Base-T</para>
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// <para>The instance ID of the redundant Express Connect circuit. The redundant circuit must be in the <b>Allocated</b>, <b>Confirmed</b>, or <b>Enabled</b> state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-119mfjzm****</para>
        /// </summary>
        [NameInMap("RedundantPhysicalConnectionId")]
        [Validation(Required=false)]
        public string RedundantPhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Express Connect circuit belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmoiyermp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePhysicalConnectionRequestTag> Tag { get; set; }
        public class CreatePhysicalConnectionRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the Express Connect circuit. Default value: <b>VPC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The bandwidth of the shared Express Connect circuits. Unit: Mbit/s.</para>
        /// <para>Valid values: <b>50</b>, <b>100</b>, <b>200</b>, <b>300</b>, <b>400</b>, <b>500</b>, <b>1000</b>, <b>2000</b>, <b>4000</b>, <b>5000</b>, <b>8000</b>, and <b>10000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

    }

}
