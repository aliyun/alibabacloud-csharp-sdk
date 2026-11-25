// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateWuyingServerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of workstations to create. Default value: 1. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>true: attempts to automatically pay when the order is placed.</description></item>
        /// <item><description>false: manually pays after the order is created.</description></item>
        /// </list>
        /// <para>A returned workstation ID does not indicate that the resource has been created. You must still confirm that the order payment is completed and query the workstation status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Whether this parameter can be configured depends on the sales rules of the selected billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The bandwidth. Unit: Mbit/s. If this parameter is specified, the value must be greater than 0 and cannot exceed 1000.</para>
        /// <para>This parameter is required when NetworkStrategyType is set to DirectIp. The value must also meet the actual available configurations of the target region and office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method. <b>This parameter is required.</b> If this parameter is not specified or an unrecognized value is passed, InvalidParameter.chargeType is returned.</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. You must specify both Period and PeriodUnit, and use the matching SubPayType=prePaid.</description></item>
        /// <item><description>PostPaid: pay-as-you-go. The sub-billing method and specification must support the corresponding sales method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The list of data cloud disks. This parameter is optional. You can specify up to 16 data cloud disks, and the number cannot exceed the maximum number supported by the selected workstation specification. The data cloud disk types and performance levels in the same request must be the same. The capacity of each data cloud disk is verified separately.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateWuyingServerShrinkRequestDataDisk> DataDisk { get; set; }
        public class CreateWuyingServerShrinkRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The type of the data cloud disk.</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk.</description></item>
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD cloud disk.</description></item>
            /// <item><description>cloud_essd: ESSD cloud disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL cloud disk.</description></item>
            /// </list>
            /// <para>If this parameter is not specified, cloud is used. The final availability is subject to the specification, region, and cloud disk capacity limits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD data cloud disk. This parameter takes effect when cloud_essd is used. Default value: PL1.</para>
            /// <list type="bullet">
            /// <item><description>PL0: ESSD performance level 0.</description></item>
            /// <item><description>PL1: ESSD performance level 1.</description></item>
            /// <item><description>PL2: ESSD performance level 2.</description></item>
            /// <item><description>PL3: ESSD performance level 3.</description></item>
            /// </list>
            /// <para>Based on the 10 GiB step size for data cloud disks, the minimum capacity is 10 GiB for PL0, 20 GiB for PL1, 470 GiB for PL2, and 1270 GiB for PL3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("DataDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string DataDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the data cloud disk. Unit: GiB. This parameter is required when you configure a data cloud disk. The value must be a positive integer and a multiple of 10, and cannot exceed 65536.</para>
            /// <para>The value must also fall within the capacity range of the selected cloud disk type: up to 2000 GiB for a basic cloud disk, 20 to 32768 GiB for a standard SSD cloud disk or ultra cloud disk. An ESSD cloud disk must also meet the minimum capacity requirement of the performance level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the dedicated eRDMA NIC.</para>
        /// <list type="bullet">
        /// <item><description>true: enables the dedicated eRDMA NIC.</description></item>
        /// <item><description>false: disables the dedicated eRDMA NIC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ErdmaEnabled")]
        [Validation(Required=false)]
        public bool? ErdmaEnabled { get; set; }

        /// <summary>
        /// <para>The configuration version of the GPU driver, such as grid19.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grid19</para>
        /// </summary>
        [NameInMap("GpuDriverVersion")]
        [Validation(Required=false)]
        public string GpuDriverVersion { get; set; }

        /// <summary>
        /// <para>The hostname. The limits are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>The hostname cannot start or end with a period (.) or a hyphen (-). Consecutive periods or hyphens are not allowed.</para>
        /// </description></item>
        /// <item><description><para>Windows workstation: The hostname must be 2 to 15 characters in length. Periods (.) are not supported. Consecutive hyphens are not allowed. The hostname cannot contain only digits. It can contain uppercase and lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Linux workstation:</para>
        /// <list type="bullet">
        /// <item><description><para>The hostname must be 2 to 64 characters in length. Multiple periods (.) are supported. The string between two periods is a segment. Each segment can contain uppercase and lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>You can use the ${instance_id} placeholder to write the instance ID into the HostName parameter. For example, if HostName=k8s-${instance_id} and the created ECS instance ID is i-123abc****, the hostname of the instance is k8s-i-123abc****.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When you create multiple workstation instances at a time, you can use the name_prefix[begin_number,bits]name_suffix naming format to name the workstations uniformly. For example, if HostName is set to ecd-[1,4]-test, the hostname of the first workstation is ecd-0001-test, the hostname of the second workstation is ecd-0002-test, and so on.</para>
        /// <list type="bullet">
        /// <item><description><para>name_prefix: the prefix of the hostname.</para>
        /// </description></item>
        /// <item><description><para>[begin_number,bits]: the sequential number in the hostname.</para>
        /// <list type="bullet">
        /// <item><description><para>begin_number: the start number. Valid values: 0 to 999999. Default value: 0. If the specified value is invalid, 0 is used.</para>
        /// </description></item>
        /// <item><description><para>bits: the number of digits. Valid values: 1 to 6. Default value: 6. If the specified value is invalid, 6 is used.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>name_suffix: the suffix of the hostname.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testhost</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The idempotence token that ensures the uniqueness of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a1b8c3d</para>
        /// </summary>
        [NameInMap("IdempotenceToken")]
        [Validation(Required=false)]
        public string IdempotenceToken { get; set; }

        /// <summary>
        /// <para>The ID of the workstation image. <b>This parameter is required when you create a workstation by calling this operation.</b> If this parameter is not specified, InvalidParameter.imageId is returned.</para>
        /// <para>You can call ListImage to obtain the image ID applicable to the target workstation.
        /// <a href="~~ListImage~~">ListImage</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The maximum bid for a preemptible workstation. This parameter is required when ChargeType is set to PostPaid and SubPayType is set to spot. If this parameter is not specified, InvalidParameter.maxPrice is returned. The final availability for purchase depends on the preemptible sales rules of the target specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.05</para>
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <para>模型和运行配置。创建 WuyingModelServer 产品时必填。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ModelId&quot;:&quot;demo-model&quot;,&quot;ModelAccessMethod&quot;:&quot;Lan&quot;,&quot;ServerRunConfig&quot;:{&quot;SettingMode&quot;:&quot;Basic&quot;,&quot;MaxModelLen&quot;:16384,&quot;MaxNumSeqs&quot;:4}}</para>
        /// </summary>
        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public string ModelConfigShrink { get; set; }

        /// <summary>
        /// <para>The type of the network policy (invitational preview).</para>
        /// 
        /// <b>Example:</b>
        /// <para>DirectIp</para>
        /// </summary>
        [NameInMap("NetworkStrategyType")]
        [Validation(Required=false)]
        public string NetworkStrategyType { get; set; }

        /// <summary>
        /// <para>The ID of the office network. To specify an office network, specify the ID of an office network available for the current account in the target region.</para>
        /// <para>If this parameter is not specified, the service attempts to reuse a valid office network configured for the current account in the region. If no reusable network is available, a default office network is created. If this process fails, the workstation creation fails.</para>
        /// <para>The office network ID is different from the region ID and zone ID. You cannot use the zone ID returned by ListZones as a substitute.
        /// <a href="~~ListZones~~">ListZones</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-643067****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The logon password of the workstation. <b>This parameter is required when you create a workstation by calling this operation.</b> If this parameter is not specified, InvalidParameter.password is returned.</para>
        /// <para>The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Spaces, Chinese characters, backslashes, and double quotation marks are not supported. The supported special characters are:</para>
        /// <pre><code class="language-text">()`~!@#$%^&amp;*-_+=|{}[]:;\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>The password of a Windows workstation cannot start with a forward slash /.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YourPassword123</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The numeric part of the subscription duration. This parameter is used together with PeriodUnit.</para>
        /// <para><b>This parameter is required when ChargeType is set to PrePaid, and you must also specify PeriodUnit. This parameter has no default value.</b> If this parameter is not specified, InvalidParameter.period is returned (HTTP status code: 400). For example, Period=1 and PeriodUnit=Month indicate a subscription duration of one month.</para>
        /// <para>The numeric value and unit are verified based on the requested combination and are not automatically converted to other periods. The subscription duration must comply with the sales rules of the target workstation commodity. If the order verification determines that the combination exceeds the allowed range, OrderPeriod.Invalid is returned (HTTP status code: 400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is used together with Period.</para>
        /// <para><b>This parameter is required when ChargeType is set to PrePaid, and you must also specify Period.</b> If this parameter is not specified or an unrecognized unit is passed, InvalidParameter.periodUnit is returned (HTTP status code: 400). The value is case-sensitive.</para>
        /// <para>The units recognized by this operation are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Hour: hour.</description></item>
        /// <item><description>Day: day.</description></item>
        /// <item><description>Week: week.</description></item>
        /// <item><description>Month: month.</description></item>
        /// <item><description>Year: year.</description></item>
        /// </list>
        /// <para>The actual combinations of units and numeric values available for purchase must comply with the sales rules of the target workstation commodity. A recognizable unit does not mean that the combination is definitely available for purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>工作站产品类型。创建无影 AI 模型工作站时传 WuyingModelServer。省略时默认使用 WuyingServer。</para>
        /// 
        /// <b>Example:</b>
        /// <para>WuyingModelServer</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the discount.</para>
        /// <remarks>
        /// <para>If PromotionId is specified, the system attempts to apply the corresponding discount.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The ID of the savings plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spn-ce3f5b4fk**46CY</para>
        /// </summary>
        [NameInMap("SavingPlanId")]
        [Validation(Required=false)]
        public string SavingPlanId { get; set; }

        /// <summary>
        /// <para>The workstation specification. <b>This parameter is required.</b> If this parameter is not specified, InvalidParameter.serverInstanceType is returned.</para>
        /// <para>You can call ListNodeInstanceType to query the specifications available for purchase in the target region and confirm that they support the selected billing method.
        /// <a href="~~ListNodeInstanceType~~">ListNodeInstanceType</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.proworkstation_flagship_elite_ne.96c384g.192g4x</para>
        /// </summary>
        [NameInMap("ServerInstanceType")]
        [Validation(Required=false)]
        public string ServerInstanceType { get; set; }

        /// <summary>
        /// <para>The service port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("ServerPortRange")]
        [Validation(Required=false)]
        public string ServerPortRange { get; set; }

        /// <summary>
        /// <para>The sub-billing method. This parameter must match ChargeType and the sales method of the target specification.</para>
        /// <para>Billing combinations for Enterprise Edition workstations:</para>
        /// <list type="bullet">
        /// <item><description>ChargeType=PrePaid: use prePaid, which indicates subscription. It cannot be used with postPaid.</description></item>
        /// <item><description>ChargeType=PostPaid: usually use postPaid, which indicates pay-as-you-go. If you use spot for preemptible billing, you must also specify MaxPrice, and the target specification must support this method.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the default value for PrePaid is prePaid, and the default value for PostPaid is postPaid. Incompatible combinations may return InvalidOrder.CommodityCodeNotMatch.</para>
        /// <para>The meanings of the enumerated values are as follows. The actual availability depends on the sales method of the target resource. You cannot arbitrarily combine different billing methods.</para>
        /// <list type="bullet">
        /// <item><description>prePaid: subscription.</description></item>
        /// <item><description>postPaid: pay-as-you-go.</description></item>
        /// <item><description>spot: preemptible billing.</description></item>
        /// <item><description>duration: duration package.</description></item>
        /// <item><description>mau: pay-as-you-go based on the number of monthly active users.</description></item>
        /// <item><description>monthPackage: monthly package.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prePaid</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The type of the system cloud disk. Default value: cloud_auto.</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic cloud disk.</description></item>
        /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD cloud disk.</description></item>
        /// <item><description>cloud_essd: ESSD cloud disk.</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL cloud disk.</description></item>
        /// </list>
        /// <para>If you use cloud_essd, you must specify SystemDiskPerformanceLevel. The final availability is subject to the specification, region, and cloud disk capacity limits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSD system cloud disk. This parameter is required when SystemDiskCategory is set to cloud_essd.</para>
        /// <list type="bullet">
        /// <item><description>PL0: ESSD performance level 0.</description></item>
        /// <item><description>PL1: ESSD performance level 1.</description></item>
        /// <item><description>PL2: ESSD performance level 2.</description></item>
        /// <item><description>PL3: ESSD performance level 3.</description></item>
        /// </list>
        /// <para>The capacity must also meet the 10 GiB step size for the system cloud disk: at least 20 GiB for PL0 and PL1, at least 470 GiB for PL2, and at least 1270 GiB for PL3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("SystemDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk. Unit: GiB. Default value: 200. The value must be a multiple of 10. The general valid range is 20 to 65536. The value must also meet the capacity limits of the selected cloud disk type and performance level.</para>
        /// <para>The maximum size of a basic cloud disk is 2000 GiB. The maximum size of a standard SSD cloud disk or ultra cloud disk is 32768 GiB. If the system cloud disk capacity required by the selected image is greater than the requested value, the capacity required by the image is used during creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The list of office network vSwitches.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the existing virtual node pool. This parameter is optional. If this parameter is specified, the node pool must exist and belong to the current account.</para>
        /// <para>This operation associates the workstation with an existing node pool and does not create a node pool. If this parameter is not specified, this association is not established.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vnp-0b************gyw</para>
        /// </summary>
        [NameInMap("VirtualNodePoolId")]
        [Validation(Required=false)]
        public string VirtualNodePoolId { get; set; }

        /// <summary>
        /// <para>The name of the workstation. When multiple workstations are created, a numeric suffix is automatically added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleServerName</para>
        /// </summary>
        [NameInMap("WuyingServerName")]
        [Validation(Required=false)]
        public string WuyingServerName { get; set; }

    }

}
