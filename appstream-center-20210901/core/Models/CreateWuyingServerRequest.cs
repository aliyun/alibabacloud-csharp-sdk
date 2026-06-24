// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateWuyingServerRequest : TeaModel {
        /// <summary>
        /// <para>The number of workstations to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The bandwidth value. This parameter takes effect only when NetworkStrategyType is set to DirectIp. Unit: Mbit/s. Valid values: 2 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The list of data cloud disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateWuyingServerRequestDataDisk> DataDisk { get; set; }
        public class CreateWuyingServerRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The type of the data cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the data cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("DataDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string DataDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the data cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

        }

        /// <summary>
        /// <para>The hostname. The following limits apply:</para>
        /// <list type="bullet">
        /// <item><description><para>A period (.) or hyphen (-) cannot be used as the first or last character, and consecutive periods or hyphens are not allowed.</para>
        /// </description></item>
        /// <item><description><para>Windows workstations: The hostname must be 2 to 15 characters in length. It cannot contain periods (.), consecutive hyphens, or consist entirely of digits. It can contain uppercase and lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Linux workstations:</para>
        /// <list type="bullet">
        /// <item><description><para>The hostname must be 2 to 64 characters in length and can contain multiple periods (.). Each segment separated by a period can contain uppercase and lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>You can use the placeholder <c>${instance_id}</c> to include the instance ID in the HostName parameter. For example, if you set <c>HostName=k8s-${instance_id}</c> and the ECS instance ID is <c>i-123abc****</c>, the hostname is <c>k8s-i-123abc****</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When you create multiple workstation instances at a time, you can use the <c>name_prefix[begin_number,bits]name_suffix</c> format to assign sequential hostnames. For example, if you set HostName to <c>ecd-[1,4]-test</c>, the hostname of the first workstation is <c>ecd-0001-test</c>, the hostname of the second workstation is <c>ecd-0002-test</c>, and so on.</para>
        /// <list type="bullet">
        /// <item><description><para><c>name_prefix</c>: the prefix of the hostname.</para>
        /// </description></item>
        /// <item><description><para><c>[begin_number,bits]</c>: the sequential number in the hostname.</para>
        /// <list type="bullet">
        /// <item><description><para><c>begin_number</c>: the starting number. Valid values: 0 to 999999. Default value: 0. If the value is invalid, 0 is used.</para>
        /// </description></item>
        /// <item><description><para><c>bits</c>: the number of digits. Valid values: 1 to 6. Default value: 6. If the value is invalid, 6 is used.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>name_suffix</c>: the suffix of the hostname.</para>
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
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <para>The network policy type (in invitational preview).</para>
        /// 
        /// <b>Example:</b>
        /// <para>DirectIp</para>
        /// </summary>
        [NameInMap("NetworkStrategyType")]
        [Validation(Required=false)]
        public string NetworkStrategyType { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-643067****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The logon password of the workstation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YourPassword123</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// <remarks>
        /// <para>If PromotionId is specified, the corresponding discount is applied.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        [NameInMap("SavingPlanId")]
        [Validation(Required=false)]
        public string SavingPlanId { get; set; }

        /// <summary>
        /// <para>The workstation instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.proworkstation_flagship_elite_ne.96c384g.192g4x</para>
        /// </summary>
        [NameInMap("ServerInstanceType")]
        [Validation(Required=false)]
        public string ServerInstanceType { get; set; }

        [NameInMap("ServerPortRange")]
        [Validation(Required=false)]
        public string ServerPortRange { get; set; }

        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The type of the system cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level of the system cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("SystemDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The list of vSwitches in the office network.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vnp-0b************gyw</para>
        /// </summary>
        [NameInMap("VirtualNodePoolId")]
        [Validation(Required=false)]
        public string VirtualNodePoolId { get; set; }

        /// <summary>
        /// <para>The workstation name. When you create multiple workstations, a numeric suffix is automatically appended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleServerName</para>
        /// </summary>
        [NameInMap("WuyingServerName")]
        [Validation(Required=false)]
        public string WuyingServerName { get; set; }

    }

}
