// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The processor architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("ArchitectureType")]
        [Validation(Required=false)]
        public string ArchitectureType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter does not take effect for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>POST: pay-as-you-go.</description></item>
        /// <item><description>PRE: subscription.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRE</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// <remarks>
        /// <para>This parameter is required when ChargeType is set to PRE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The extended field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>Specifies whether to use zone-disaster recovery resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The zone-disaster recovery resource specifications.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("HaResourceSpec")]
        [Validation(Required=false)]
        public CreateInstanceRequestHaResourceSpec HaResourceSpec { get; set; }
        public class CreateInstanceRequestHaResourceSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPUs for zone-disaster recovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The memory size for zone-disaster recovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

        /// <summary>
        /// <para>The list of vSwitch IDs in the secondary zone for zone-disaster recovery.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("HaVSwitchIds")]
        [Validation(Required=false)]
        public List<string> HaVSwitchIds { get; set; }

        /// <summary>
        /// <para>The workspace name. The name must start with a lowercase letter and can contain lowercase letters, digits, and hyphens (-). The name cannot end with a hyphen.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtc-e2e-test-pre</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The type of monitoring and alerting service. You can select ARMS or CloudMonitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TAIHAO</para>
        /// </summary>
        [NameInMap("MonitorType")]
        [Validation(Required=false)]
        public string MonitorType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>year</b>: year.</description></item>
        /// <item><description><b>month</b>: month.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when ChargeType is set to PRE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500043499350689</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxbavps3rpiy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource specifications.</para>
        /// <remarks>
        /// <para>This parameter is required when ChargeType is set to PRE.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public CreateInstanceRequestResourceSpec ResourceSpec { get; set; }
        public class CreateInstanceRequestResourceSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPUs.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required for subscription workspaces. For pay-as-you-go workspaces, you do not need to specify this parameter.- The number of CPUs for the target project must be less than the remaining CPUs in the workspace (total purchased CPUs minus CPUs already allocated to other projects). Otherwise, an error is returned.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GB.</para>
            /// <remarks>
            /// <para>The memory size must be 4 times the number of CPUs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

        /// <summary>
        /// <para>The storage parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public CreateInstanceRequestStorage Storage { get; set; }
        public class CreateInstanceRequestStorage : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use fully managed storage. You can select only one of fully managed storage or binding an OSS bucket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Use fully managed storage.</description></item>
            /// <item><description>false: Do not use fully managed storage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FullyManaged")]
            [Validation(Required=false)]
            public bool? FullyManaged { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) storage.</para>
            /// </summary>
            [NameInMap("Oss")]
            [Validation(Required=false)]
            public CreateInstanceRequestStorageOss Oss { get; set; }
            public class CreateInstanceRequestStorageOss : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket to bind.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-flink-cn-shanghai-260343971602724445</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of tags. A maximum of 20 tags can be specified.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTag> Tag { get; set; }
        public class CreateInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Use a coupon.</description></item>
        /// <item><description>false: Do not use a coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UsePromotionCode")]
        [Validation(Required=false)]
        public bool? UsePromotionCode { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze9xoh8qyt1rnxfmfcdi</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
