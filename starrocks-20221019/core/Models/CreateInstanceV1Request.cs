// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class CreateInstanceV1Request : TeaModel {
        /// <summary>
        /// <para>The administrator password of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password_example</para>
        /// </summary>
        [NameInMap("AdminPassword")]
        [Validation(Required=false)]
        public string AdminPassword { get; set; }

        [NameInMap("AgentNodeGroup")]
        [Validation(Required=false)]
        public CreateInstanceV1RequestAgentNodeGroup AgentNodeGroup { get; set; }
        public class CreateInstanceV1RequestAgentNodeGroup : TeaModel {
            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

        }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when payType is set to PrePaid. Auto-renewal is disabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The BE or CN node group information.</para>
        /// </summary>
        [NameInMap("BackendNodeGroups")]
        [Validation(Required=false)]
        public List<CreateInstanceV1RequestBackendNodeGroups> BackendNodeGroups { get; set; }
        public class CreateInstanceV1RequestBackendNodeGroups : TeaModel {
            /// <summary>
            /// <para>The number of CUs. A CU (Compute Unit) is the basic metering unit of the service. 1 CU = 1 CPU core + 4 GiB memory. When SpecType is set to memory-enhanced instance family, 1 CU = 1 CPU core + 8 GiB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            /// <summary>
            /// <para>The number of disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("diskNumber")]
            [Validation(Required=false)]
            public int? DiskNumber { get; set; }

            /// <summary>
            /// <para>The local SSD instance type of the node group. This parameter takes effect only when the instance is ECS-based and SpecType is set to local SSD or large-scale storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>local_ssd_4_4xlarge</para>
            /// </summary>
            [NameInMap("localStorageInstanceType")]
            [Validation(Required=false)]
            public string LocalStorageInstanceType { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("residentNodeNumber")]
            [Validation(Required=false)]
            public int? ResidentNodeNumber { get; set; }

            /// <summary>
            /// <para>The specification type of the node group. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("specType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>The performance level of the cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pl0: A single disk delivers up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>pl1: A single disk delivers up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>pl2: A single disk delivers up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>pl3: A single disk delivers up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pl1</para>
            /// </summary>
            [NameInMap("storagePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>The storage size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a unique parameter value from your client. The ClientToken value supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the DLF Catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon_test</para>
        /// </summary>
        [NameInMap("DlfCatalogName")]
        [Validation(Required=false)]
        public string DlfCatalogName { get; set; }

        /// <summary>
        /// <para>The type of the DLF Catalog. Valid values: paimon and iceberg.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon</para>
        /// </summary>
        [NameInMap("DlfCatalogType")]
        [Validation(Required=false)]
        public string DlfCatalogType { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter takes effect only when payType is set to PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("EnableAiFunction")]
        [Validation(Required=false)]
        public bool? EnableAiFunction { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable disaster recovery.</para>
        /// </summary>
        [NameInMap("EnableMultiAz")]
        [Validation(Required=false)]
        public bool? EnableMultiAz { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The FE node group information.</para>
        /// </summary>
        [NameInMap("FrontendNodeGroups")]
        [Validation(Required=false)]
        public List<CreateInstanceV1RequestFrontendNodeGroups> FrontendNodeGroups { get; set; }
        public class CreateInstanceV1RequestFrontendNodeGroups : TeaModel {
            /// <summary>
            /// <para>The number of CUs. A CU (Compute Unit) is the basic metering unit of the service. 1 CU = 1 CPU core + 4 GiB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            /// <summary>
            /// <para>The number of disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("diskNumber")]
            [Validation(Required=false)]
            public int? DiskNumber { get; set; }

            /// <summary>
            /// <para>The local SSD instance type. This parameter does not need to be set for the FE node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("localStorageInstanceType")]
            [Validation(Required=false)]
            public string LocalStorageInstanceType { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("residentNodeNumber")]
            [Validation(Required=false)]
            public int? ResidentNodeNumber { get; set; }

            /// <summary>
            /// <para>The specification type of the node group. Only standard is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("specType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the cloud disk. Only pl1 is supported, which provides up to 50,000 random read/write IOPS per disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl1</para>
            /// </summary>
            [NameInMap("storagePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>The storage size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The KMS key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fdsdf****</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The username of the associated Resource Access Management (RAM) user or the name of the associated RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun.test1</para>
        /// </summary>
        [NameInMap("LinkedRamUserName")]
        [Validation(Required=false)]
        public string LinkedRamUserName { get; set; }

        /// <summary>
        /// <para>The Observer node group information. Specify this parameter only when you need to enable cross-zone disaster recovery. The Observer node group specifications must be the same as those of the FE node group.</para>
        /// </summary>
        [NameInMap("ObserverNodeGroups")]
        [Validation(Required=false)]
        public List<CreateInstanceV1RequestObserverNodeGroups> ObserverNodeGroups { get; set; }
        public class CreateInstanceV1RequestObserverNodeGroups : TeaModel {
            /// <summary>
            /// <para>The number of CUs. A CU (Compute Unit) is the basic metering unit of the service. 1 CU = 1 CPU core + 4 GiB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            /// <summary>
            /// <para>The number of disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("diskNumber")]
            [Validation(Required=false)]
            public int? DiskNumber { get; set; }

            /// <summary>
            /// <para>The local SSD instance type. This parameter does not need to be set for the Observer node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("localStorageInstanceType")]
            [Validation(Required=false)]
            public string LocalStorageInstanceType { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("residentNodeNumber")]
            [Validation(Required=false)]
            public int? ResidentNodeNumber { get; set; }

            /// <summary>
            /// <para>The specification type of the node group. Only standard is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("specType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the cloud disk. Only pl1 is supported, which provides up to 50,000 random read/write IOPS per disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl1</para>
            /// </summary>
            [NameInMap("storagePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>The storage size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The name of the role used for password-free access to Object Storage Service (OSS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunEMRStarRocksAccessingOSSRole</para>
        /// </summary>
        [NameInMap("OssAccessingRoleName")]
        [Validation(Required=false)]
        public string OssAccessingRoleName { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>trial: Trial Edition.</description></item>
        /// <item><description>official: Standard Edition.</description></item>
        /// </list>
        /// 
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>official</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <ol>
        /// <item><description>prePaid: subscription.</description></item>
        /// <item><description>postPaid: pay-as-you-go.</description></item>
        /// </ol>
        /// 
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// This parameter takes effect only when payType is set to PrePaid.
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The RAM authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RS: Resource Access Management (RAM) user.</description></item>
        /// <item><description>RR: RAM role.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RR</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165445235634</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>The ID of the Resource Access Management (RAM) user or RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("RamUserId")]
        [Validation(Required=false)]
        public string RamUserId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzllkih7jqxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The running mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>shared_nothing: compute-storage coupled.</description></item>
        /// <item><description>shared_data: storage-compute disaggregation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shared_data</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// <para>The instance tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateInstanceV1RequestTags> Tags { get; set; }
        public class CreateInstanceV1RequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch and zone information.</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<CreateInstanceV1RequestVSwitches> VSwitches { get; set; }
        public class CreateInstanceV1RequestVSwitches : TeaModel {
            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp19mlh98tm9teyyd****</para>
            /// </summary>
            [NameInMap("VswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <para>The zone ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The major version of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>VPC ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1fll2mci6d7pw8m****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The primary zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
