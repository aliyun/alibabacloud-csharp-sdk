// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateHighReliablePhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b> (default): Chinese.</description></item>
        /// <item><description><b>en-US</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The list of access points.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApList")]
        [Validation(Required=false)]
        public List<CreateHighReliablePhysicalConnectionRequestApList> ApList { get; set; }
        public class CreateHighReliablePhysicalConnectionRequestApList : TeaModel {
            /// <summary>
            /// <para>The ID of the access point for the Express Connect circuit.</para>
            /// <remarks>
            /// <para>When <b>HighReliableType</b> is set to <b>MultiApMultiDevice</b> or <b>MultiApSingleDevice</b>, you must specify two different access points. When <b>HighReliableType</b> is set to <b>SingleApMultiDevice</b> or <b>SingleApMultiConnection</b>, you must specify one access point.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-cn-beijing-ft-A</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The bandwidth of the shared Express Connect circuits. Unit: Mbit/s.</para>
            /// <para>Valid values: 50, 100, 200, 300, 400, 500, 1000, 2000, 4000, 5000, 8000, and 10000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The circuit code provided by the connectivity provider for the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longtel001</para>
            /// </summary>
            [NameInMap("CircuitCode")]
            [Validation(Required=false)]
            public string CircuitCode { get; set; }

            /// <summary>
            /// <para>The description of the Express Connect circuit.</para>
            /// <para>The description must be 2 to 256 characters in length and must start with a letter or Chinese character, but cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The connectivity provider of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CT</b>: China Telecom.</para>
            /// </description></item>
            /// <item><description><para><b>CU</b>: China Unicom.</para>
            /// </description></item>
            /// <item><description><para><b>CM</b>: China Mobile.</para>
            /// </description></item>
            /// <item><description><para><b>CO</b>: other Chinese carriers. </para>
            /// </description></item>
            /// <item><description><para><b>Equinix</b>: Equinix.</para>
            /// </description></item>
            /// <item><description><para><b>Other</b>: other carriers outside the Chinese mainland.</para>
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
            /// <para>The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It can contain digits, underscores (_), and hyphens (-), but cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The optical module model supported by the access point of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1000Base-LX: <list type="bullet">
            /// <item><description><c>SFP-GE-LR-SM1310,10KM</c></description></item>
            /// <item><description><c>SFP-GE-ER-SM1310,40KM</c></description></item>
            /// <item><description><c>SFP-GE-ZR-SM1550,80KM</c></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>10GBase-LR: <list type="bullet">
            /// <item><description><c>SFP-10G-LR-SM1310,10KM</c></description></item>
            /// <item><description><c>SFP-10G-ER-SM1550,40KM</c> </description></item>
            /// <item><description><c>SFP-10G-ZR-SM1550,80KM</c></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>40GBase-LR: <list type="bullet">
            /// <item><description><c>QSFP-40G-LR4-WDM1300,10KM</c></description></item>
            /// <item><description><c>QSFP-40G-ER4-WDM1300,40KM</c></description></item>
            /// <item><description><c>QSFP-40G-ZR4-WDM1300,80KM</c></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>100GBase-LR: <list type="bullet">
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

            /// <summary>
            /// <para>The geographic location of the on-premises data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XX街道</para>
            /// </summary>
            [NameInMap("PeerLocation")]
            [Validation(Required=false)]
            public string PeerLocation { get; set; }

            /// <summary>
            /// <para>The number of ports. This parameter is required only when <b>HighReliableType</b> is set to <b>SingleApMultiConnection</b>. Valid values: 2 to 16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PortNum")]
            [Validation(Required=false)]
            public int? PortNum { get; set; }

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
            /// <para>The type of the Express Connect circuit. Default value: <b>VPC</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of advanced device capabilities.</para>
        /// </summary>
        [NameInMap("DeviceAdvancedCapacity")]
        [Validation(Required=false)]
        public List<string> DeviceAdvancedCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without creating the instance. The system checks the required parameters, request format, and instance status. If the check fails, the error code <c>DRYRUN.FAIL</c> is returned along with the corresponding error list. If the check succeeds, the code <c>DRYRUN.SUCCESS</c> is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. After the request passes the check, the instance is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The zone-redundancy mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MultiApMultiDevice</b>: maximum disaster recovery. This mode supports two different access points and two different devices, providing maximum disaster recovery.</description></item>
        /// <item><description><b>MultiApSingleDevice</b>: enhanced disaster recovery. This mode supports two different access points and one device, providing enhanced disaster recovery.</description></item>
        /// <item><description><b>SingleApMultiDevice</b>: development and testing. This mode supports one access point and two devices. This mode is recommended only for development and testing of non-critical workloads.</description></item>
        /// <item><description><b>SingleApMultiConnection</b>: high-bandwidth load balancing. This mode is available only to users in the whitelist. It supports one access point, one device, and multiple physical ports. To use this mode, contact your account manager.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MultiApMultiDevice</para>
        /// </summary>
        [NameInMap("HighReliableType")]
        [Validation(Required=false)]
        public string HighReliableType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The port type of the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1000Base-LX</b>: GE single-mode optical port (10 km).</para>
        /// </description></item>
        /// <item><description><para><b>10GBase-LR</b>: 10 GE single-mode optical port (10 km).</para>
        /// </description></item>
        /// <item><description><para><b>40GBase-LR</b>: 40 GE single-mode optical port.</para>
        /// </description></item>
        /// <item><description><para><b>100GBase-LR</b>: 100 GE single-mode optical port.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>40GBase-LR and 100GBase-LR are subject to the actual port availability. For information about port availability, contact your account manager.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000Base-LX</para>
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>rg-acfmxazb4p****</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateHighReliablePhysicalConnectionRequestTag> Tag { get; set; }
        public class CreateHighReliablePhysicalConnectionRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and must start with a letter or Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and must start with a letter or Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
