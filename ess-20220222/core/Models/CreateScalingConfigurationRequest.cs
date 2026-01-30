// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingConfigurationRequest : TeaModel {
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationRequestImageOptions ImageOptions { get; set; }
        public class CreateScalingConfigurationRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>For more information about whether an ECS instance uses the ecs-user user user to log on to an ECS instance, see <a href="https://help.aliyun.com/document_detail/388447.html">Manage the login name of an ECS instance</a>. Value range:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LoginAsNonRoot")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

        }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateScalingConfigurationRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool. The ID of a private pool is the same as the ID of the elasticity assurance or capacity reservation for which the private pool is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The type of the private pool that you want to use to start ECS instances. A private pool is generated when an elasticity assurance or a capacity reservation takes effect. You can select a private pool to create ECS instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open private pool. Auto Scaling selects a matching open private pool to start instances. If no matching open private pools are found, Auto Scaling uses the resources in the public pool to start instances. In this case, you do not need to specify PrivatePoolOptions.Id.</description></item>
            /// <item><description>Target: specified private pool. Auto Scaling uses the resources in the specified private pool to start ECS instances. If the specified private pool is unavailable, Auto Scaling cannot start ECS instances. If you set this parameter to Target, you must specify PrivatePoolOptions.Id.</description></item>
            /// <item><description>None: no private pool. Auto Scaling does not use the resources in private pools to start ECS instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateScalingConfigurationRequestSystemDisk SystemDisk { get; set; }
        public class CreateScalingConfigurationRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy that you want to apply to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp12m37ccmxvbmi5****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only if you set <c>SystemDisk.Category</c> to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The category of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk</description></item>
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>ephemeral_ssd: local SSD</description></item>
            /// <item><description>cloud_essd: enhanced SSD (ESSD)</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
            /// </list>
            /// <para>If you specify SystemDisk.Category, you cannot specify <c>SystemDiskCategories</c>. If you do not specify SystemDisk.Category or <c>SystemDiskCategories</c>, the default value of SystemDisk.Category is used.</para>
            /// <list type="bullet">
            /// <item><description>For I/O optimized instances, the default value is cloud_efficiency.</description></item>
            /// <item><description>For non-I/O optimized instances, the default value is cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length. The description can contain letters and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test system disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The encryption algorithm that you want to use to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AES-256</description></item>
            /// <item><description>SM4-128</description></item>
            /// </list>
            /// <para>Default value: AES-256</para>
            /// 
            /// <b>Example:</b>
            /// <para>AES-256</para>
            /// </summary>
            [NameInMap("EncryptAlgorithm")]
            [Validation(Required=false)]
            public string EncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>Default value: false</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key that you want to use to encrypt the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the system disk that is an enhanced SSD (ESSD). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: An ESSD can provide up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: An ESSD can provide up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: An ESSD can provide up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>Default value: PL1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The IOPS metric that is preconfigured for the system disk.</para>
            /// <remarks>
            /// <para>IOPS measures the number of read and write operations that an EBS device can process per second.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB.</para>
            /// <list type="bullet">
            /// <item><description><para>Basic disk: 20 to 500.</para>
            /// </description></item>
            /// <item><description><para>ESSD (cloud_essd): The valid values vary based on the performance level of the ESSD.</para>
            /// <list type="bullet">
            /// <item><description>PL0 ESSD: 1 to 2048.</description></item>
            /// <item><description>PL1 ESSD: 20 to 2048.</description></item>
            /// <item><description>PL2 ESSD: 461 to 2048.</description></item>
            /// <item><description>PL3 ESSD: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ESSD AutoPL disk (cloud_auto): 1 to 2048.</para>
            /// </description></item>
            /// <item><description><para>Other disk categories: 20 to 2048.</para>
            /// </description></item>
            /// </list>
            /// <para>The value of this parameter must be at least 1 and greater than or equal to the image size.</para>
            /// <para>Default value: 40 or the size of the image, whichever is larger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to associate an ECS instance on a dedicated host with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: does not associate the ECS instance with the dedicated host. If you start an ECS instance that was stopped in economical mode and the original dedicated host has insufficient resources, the ECS instance is automatically deployed to another dedicated host in the automatic deployment resource pool.</description></item>
        /// <item><description>host: associates the ECS instance with the dedicated host. If you start an ECS instance that was stopped in economical mode, the instance remains on the original dedicated host. If the original dedicated host has insufficient resources, the ECS instance fails to start.</description></item>
        /// </list>
        /// <para>Default value: default</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public string Affinity { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see the &quot;<a href="https://help.aliyun.com/document_detail/25693.html">How to ensure the idempotence of a request</a>&quot; topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of vCPUs.</para>
        /// <para>You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set CPU to 2 and Memory to 16 to specify instance types that have 2 vCPUs and 16 GiB of memory. If you specify Cpu and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances by using the lowest-priced instance type.</para>
        /// <remarks>
        /// <para>You can specify Cpu and Memory to determine the range of instance types only if you set Scaling Policy to Cost Optimization Policy and you do not specify instance types in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The performance mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard mode</description></item>
        /// <item><description>Unlimited: unlimited mode</description></item>
        /// </list>
        /// <para>For more information, see the &quot;Performance modes&quot; section in the &quot;<a href="https://help.aliyun.com/document_detail/59977.html">Overview</a>&quot; topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The priority of the custom ECS instance type + vSwitch combination.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when Scaling Policy of the scaling group is set to Priority Policy.</para>
        /// </remarks>
        /// <para>If Auto Scaling cannot create ECS instances by using the custom ECS instance type + vSwitch combination of the highest priority, Auto Scaling creates ECS instances by using the custom ECS instance type + vSwitch combination of the next highest priority.</para>
        /// <remarks>
        /// <para> If you specify the priorities of only partial custom ECS instance type + vSwitch combinations, Auto Scaling preferentially creates ECS instances by using the custom combinations that have specified priorities. If the custom combinations that have specified priorities do not provide sufficient resources, Auto Scaling creates ECS instances by using the custom combinations that do not have specified priorities based on the specified orders of vSwitches and instance types.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Example: the specified order of vSwitches for your scaling group is vsw1 and vsw2 and the specified order of instance types in your scaling configuration is type1 and type 2. In addition, you use CustomPriorities to specify [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;]. In this example, the vsw2+type2 combination has the highest priority and the vsw2+type1 combination has the lowest priority. The vsw1+type2 combination has a higher priority than the vsw1+type1 combination.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("CustomPriorities")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestCustomPriorities> CustomPriorities { get; set; }
        public class CreateScalingConfigurationRequestCustomPriorities : TeaModel {
            /// <summary>
            /// <para>The ECS instance type.</para>
            /// <remarks>
            /// <para> The ECS instance type must be included in the instance types specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// <remarks>
            /// <para> The vSwitch must be included in the vSwitch list of the scaling group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp14zolna43z266bq****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The data disks.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestDataDisks> DataDisks { get; set; }
        public class CreateScalingConfigurationRequestDataDisks : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy that you want to apply to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp19nq9enxqkomib****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only if you set <c>SystemDisk.Category</c> to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The categories of the data disks. If Auto Scaling cannot create instances by using the disk category that has the highest priority, Auto Scaling creates instances by using the disk category that has the next highest priority. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk. For a basic disk that is created together with the instance, DeleteWithInstance is set to true.</description></item>
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If you specify Categories, you cannot specify <c>DataDisks.Category</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The category of the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk</description></item>
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>cloud_essd: ESSD</description></item>
            /// <item><description>ephemeral_ssd: local SSD</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
            /// </list>
            /// <para>If you specify this parameter, you cannot specify Categories. If you do not specify Category or Categories, the default value of Category is used.</para>
            /// <list type="bullet">
            /// <item><description>For I/O optimized instances, the default value is cloud_efficiency.</description></item>
            /// <item><description>For non-I/O optimized instances, the default value is cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to release the data disk when the instance to which the data disk is attached is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>This parameter is available only for independent disks whose value of Category is set to cloud, cloud_efficiency, cloud_ssd, or cloud_essd. If you specify this parameter for other disks, an error is reported.</para>
            /// <para>Default value: true</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The description of the data disk. The description must be 2 to 256 characters in length. The description can contain letters and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test data disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount target of the data disk. If you do not specify Device, a mount target is automatically assigned when Auto Scaling creates ECS instances. The names of mount targets range from /dev/xvdb to /dev/xvdz.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdData</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>Default value: false</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key that you want to use to encrypt the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The PL of the data disk that is an ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: An ESSD can provide up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: An ESSD can provide up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: An ESSD can provide up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about how to select ESSD PLs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The IOPS metric that is preconfigured for the data disk.</para>
            /// <remarks>
            /// <para>IOPS measures the number of read and write operations that an EBS device can process per second.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the data disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If you set Categories to cloud: 5 to 2000.</description></item>
            /// <item><description>If you set Categories to cloud_efficiency: 20 to 32768.</description></item>
            /// <item><description>If you set Categories to cloud_essd: 20 to 32768.</description></item>
            /// <item><description>If you set Categories to ephemeral_ssd: 5 to 800.</description></item>
            /// </list>
            /// <para>The size of the data disk must be greater than or equal to the size of the snapshot that is specified by SnapshotId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot that you want to use to create data disks. If you specify this parameter, DataDisks.Size is ignored. The size of the data disk is the same as the size of the specified snapshot.</para>
            /// <para>If you specify a snapshot that is created on or before July 15, 2013, the operation fails and the system returns InvalidSnapshot.TooOld.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-280s7****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the dedicated host cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-2zedxc67zqzt7lb4****</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated host on which you want to create an ECS instance. You cannot create preemptible instances on dedicated hosts. If you specify DedicatedHostId, SpotStrategy and SpotPriceLimit are ignored.</para>
        /// <para>You can call the DescribeDedicatedHosts operation to query dedicated host IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set of the ECS instances that are created by using the scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp1frxuzdg87zh4pz****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The hostname of the ECS instance. The hostname cannot start or end with a period (.) or a hyphen (-). The hostname cannot contain consecutive periods (.) or hyphens (-). Naming conventions for different types of instances:</para>
        /// <list type="bullet">
        /// <item><description>Windows instances: The hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). The hostname cannot contain periods (.) or contain only digits.</description></item>
        /// <item><description>Other instances, such as Linux instances: The hostname must be 2 to 64 characters in length. You can use periods (.) to separate a hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>host****</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic High Performance Computing (E-HPC) cluster to which the ECS instances that are created by using the scaling configuration belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hpc-clusterid</para>
        /// </summary>
        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the access channel for instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled</description></item>
        /// <item><description>disabled</description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para> For information about instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Obtain instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly use the security hardening mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcibly use the security hardening mode (IMDSv2).</description></item>
        /// <item><description>required: forcibly uses the security hardening mode (IMDSv2). If you set this parameter to required, you cannot access instance metadata in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para> For more information about instance metadata access modes, see <a href="https://help.aliyun.com/document_detail/108460.html">Access modes of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. If you specify this parameter, the most recent custom images that are available in the specified image family are returned. You can use the images to create instances. If you specify ImageId, you cannot specify ImageFamily.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image that Auto Scaling uses to automatically create ECS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image. Each image name must be unique in a region. If you specify ImageId, ImageName is ignored.</para>
        /// <para>You cannot use ImageName to specify images that are purchased from Alibaba Cloud Marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image****</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The description of the ECS instance. The description must be 2 to 256 characters in length. The description can contain letters and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test instance.</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The name of the ECS instance that Auto Scaling creates based on the scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The intelligent configuration settings, which determine the available instance types.</para>
        /// </summary>
        [NameInMap("InstancePatternInfos")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestInstancePatternInfos> InstancePatternInfos { get; set; }
        public class CreateScalingConfigurationRequestInstancePatternInfos : TeaModel {
            /// <summary>
            /// <para>The architecture types of the instance types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>X86: x86 architecture.</description></item>
            /// <item><description>Heterogeneous: heterogeneous computing, such as GPU-accelerated or FPGA-accelerated.</description></item>
            /// <item><description>BareMetal: ECS Bare Metal Instance.</description></item>
            /// <item><description>Arm: Arm.</description></item>
            /// </list>
            /// <para>By default, all values are selected.</para>
            /// </summary>
            [NameInMap("Architectures")]
            [Validation(Required=false)]
            public List<string> Architectures { get; set; }

            /// <summary>
            /// <para>Specifies whether to include burstable instance types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exclude: excludes burstable instance types.</description></item>
            /// <item><description>Include: includes burstable instance types.</description></item>
            /// <item><description>Required: includes only burstable instance types.</description></item>
            /// </list>
            /// <para>Default value: Include.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Include</para>
            /// </summary>
            [NameInMap("BurstablePerformance")]
            [Validation(Required=false)]
            public string BurstablePerformance { get; set; }

            /// <summary>
            /// <para>The number of vCPUs per instance type in intelligent configuration mode. You can specify this parameter to filter the available instance types. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>InstancePatternInfos applies only to scaling groups that reside in virtual private clouds (VPCs).</description></item>
            /// <item><description>If you specify InstancePatternInfos, you must also specify InstancePatternInfos.Cores and InstancePatternInfos.Memory.</description></item>
            /// <item><description>If you specify InstanceType or InstanceTypes, Auto Scaling preferentially uses the instance type specified by InstanceType or InstanceTypes to create instances during scale-out events. If the specified instance type has insufficient inventory, Auto Scaling uses the lowest-priced instance type specified by InstancePatternInfos to create instances during scale-out events.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            /// <summary>
            /// <para>The CPU architectures of the instance types. Valid values:</para>
            /// <remarks>
            /// <para> You can specify up to two CPU architectures.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>x86</description></item>
            /// <item><description>Arm</description></item>
            /// </list>
            /// </summary>
            [NameInMap("CpuArchitectures")]
            [Validation(Required=false)]
            public List<string> CpuArchitectures { get; set; }

            /// <summary>
            /// <para>The instance types that you want to exclude. You can use an asterisk (\*) as a wildcard character to exclude an instance type or an instance family. Examples:</para>
            /// <list type="bullet">
            /// <item><description>ecs.c6.large: excludes the ecs.c6.large instance type.</description></item>
            /// <item><description>ecs.c6.\*: excludes the c6 instance family.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExcludedInstanceTypes")]
            [Validation(Required=false)]
            public List<string> ExcludedInstanceTypes { get; set; }

            /// <summary>
            /// <para>The GPU models.</para>
            /// </summary>
            [NameInMap("GpuSpecs")]
            [Validation(Required=false)]
            public List<string> GpuSpecs { get; set; }

            /// <summary>
            /// <para>The categories of the instance types. Valid values:</para>
            /// <remarks>
            /// <para> You can specify up to 10 categories.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>General-purpose: general-purpose instance type.</description></item>
            /// <item><description>Compute-optimized: compute-optimized instance type.</description></item>
            /// <item><description>Memory-optimized: memory-optimized instance type.</description></item>
            /// <item><description>Big data: big data instance type.</description></item>
            /// <item><description>Local SSDs: instance type that uses local SSDs.</description></item>
            /// <item><description>High Clock Speed: instance type that has high clock speeds.</description></item>
            /// <item><description>Enhanced: enhanced instance type.</description></item>
            /// <item><description>Shared: shared instance type.</description></item>
            /// <item><description>Compute-optimized with GPU: GPU-accelerated compute-optimized instance type.</description></item>
            /// <item><description>Visual Compute-optimized: visual compute-optimized instance type.</description></item>
            /// <item><description>Heterogeneous Service: heterogeneous service instance type.</description></item>
            /// <item><description>Compute-optimized with FPGA: FPGA-accelerated compute-optimized instance type.</description></item>
            /// <item><description>Compute-optimized with NPU: NPU-accelerated compute-optimized instance type.</description></item>
            /// <item><description>ECS Bare Metal: ECS Bare Metal Instance type.</description></item>
            /// <item><description>High Performance Compute: HPC-optimized instance type.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstanceCategories")]
            [Validation(Required=false)]
            public List<string> InstanceCategories { get; set; }

            /// <summary>
            /// <para>The level of the instance family. You can specify this parameter to match the available instance types. This parameter takes effect only if you set <c>CostOptimization</c> to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: entry-level (shared instance types). Instance types of this level are the most cost-effective but may not ensure stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise-level. Instance types of this level provide stable performance and dedicated resources and are suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: credit entry-level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview</a> of burstable instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EnterpriseLevel</para>
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// <para>The instance families that you want to specify. You can specify up to 10 instance families in each call.</para>
            /// </summary>
            [NameInMap("InstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> InstanceTypeFamilies { get; set; }

            /// <summary>
            /// <para>The maximum hourly price of pay-as-you-go or preemptible instances in intelligent configuration mode. You can specify this parameter to filter the available instance types.</para>
            /// <remarks>
            /// <para> If you set SpotStrategy to SpotWithPriceLimit, you must specify this parameter. In other cases, this parameter is optional.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public float? MaxPrice { get; set; }

            /// <summary>
            /// <para>The maximum number of vCPUs per instance type.</para>
            /// <remarks>
            /// <para> The value of MaximumCpuCoreCount cannot exceed four times the value of MinimumCpuCoreCount.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaximumCpuCoreCount")]
            [Validation(Required=false)]
            public int? MaximumCpuCoreCount { get; set; }

            /// <summary>
            /// <para>The maximum number of GPUs per instance. The value must be a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaximumGpuAmount")]
            [Validation(Required=false)]
            public int? MaximumGpuAmount { get; set; }

            /// <summary>
            /// <para>The maximum memory size per instance. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaximumMemorySize")]
            [Validation(Required=false)]
            public float? MaximumMemorySize { get; set; }

            /// <summary>
            /// <para>The memory size per instance type in intelligent configuration mode. Unit: GiB. You can specify this parameter to filter the available instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The baseline vCPU computing performance (overall baseline performance of all vCPUs) per t5 or t6 burstable instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("MinimumBaselineCredit")]
            [Validation(Required=false)]
            public int? MinimumBaselineCredit { get; set; }

            /// <summary>
            /// <para>The minimum number of vCPUs per instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumCpuCoreCount")]
            [Validation(Required=false)]
            public int? MinimumCpuCoreCount { get; set; }

            /// <summary>
            /// <para>The minimum number of IPv6 addresses per ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinimumEniIpv6AddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniIpv6AddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of IPv4 addresses per ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumEniPrivateIpAddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniPrivateIpAddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of elastic network interfaces (ENIs) per instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumEniQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of GPUs per instance. The value must be a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumGpuAmount")]
            [Validation(Required=false)]
            public int? MinimumGpuAmount { get; set; }

            /// <summary>
            /// <para>The initial vCPU credits per t5 or t6 burstable instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("MinimumInitialCredit")]
            [Validation(Required=false)]
            public int? MinimumInitialCredit { get; set; }

            /// <summary>
            /// <para>The minimum memory size per instance. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MinimumMemorySize")]
            [Validation(Required=false)]
            public float? MinimumMemorySize { get; set; }

            /// <summary>
            /// <para>The processor models of the instance types. You can specify up to 10 processor models.</para>
            /// </summary>
            [NameInMap("PhysicalProcessorModels")]
            [Validation(Required=false)]
            public List<string> PhysicalProcessorModels { get; set; }

        }

        /// <summary>
        /// <para>The instance type of the ECS instance. For more information, see the <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The information about instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypeOverrides")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestInstanceTypeOverrides> InstanceTypeOverrides { get; set; }
        public class CreateScalingConfigurationRequestInstanceTypeOverrides : TeaModel {
            /// <summary>
            /// <para>If you want to scale instances in the scaling group based on the weight of an instance type, you must specify this property and WeightedCapacity.</para>
            /// <para>The instance type specified by using this parameter overwrites the instance type of the launch template. You can specify N instance types by using the Extend Launch Template feature. You can specify 1 to 10 memory sizes, indicated by N.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you specify LaunchTemplateId.</para>
            /// </remarks>
            /// <para>You can use this parameter to specify any instance types that are available for purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>If you need to specify the capacity of the instance type in the scaling configuration, you must specify this parameter after you specify InstanceTypeOverrides.InstanceType.</para>
            /// <para>The weight specifies the capacity of an instance of the specified instance type in the scaling group. A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.</para>
            /// <para>Performance metrics such as the number of vCPUs and memory size vary with each instance type. You can specify different weights for different instance types based on your business requirements.</para>
            /// <para>For example:</para>
            /// <list type="bullet">
            /// <item><description>Current capacity: 0.</description></item>
            /// <item><description>Expected capacity: 6</description></item>
            /// <item><description>Capacity of ecs.c5.xlarge: 4.</description></item>
            /// </list>
            /// <para>To reach the expected capacity, Auto Scaling must scale out two instances of ecs.c5.xlarge.</para>
            /// <remarks>
            /// <para> The total capacity of the scaling group is constrained and cannot surpass the combined total of the maximum group size defined by MaxSize and the highest weight assigned to any instance type.</para>
            /// </remarks>
            /// <para>Valid values of WeightedCapacity: 1 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The instance types. If you specify InstanceTypes, InstanceType is ignored.</para>
        /// <para>Auto Scaling creates instances based on a priority list of instance types. If it fails to create instances using the highest-priority type, it automatically moves to the next type in the priority order.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The metering method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: You are charged for the maximum available bandwidth that is specified by InternetMaxBandwidthOut.</description></item>
        /// <item><description>PayByTraffic: You are charged based on the amount of transferred data. InternetMaxBandwidthOut specifies only the maximum available bandwidth.</description></item>
        /// </list>
        /// <para>For the classic network, the default value is PayByBandwidth. For VPCs, the default value is PayByTraffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of this parameter are 1 to 10, and the default value is 10.</description></item>
        /// <item><description>If the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the value of <c>InternetMaxBandwidthOut</c>, and the default value is the value of <c>InternetMaxBandwidthOut</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Specifies whether to create an I/O optimized instance. Valid values:</para>
        /// <para>none: does not create an I/O optimized instance. optimized: creates an I/O optimized instance.</para>
        /// <para>For instances of retired instance types, the default value is none. For instances of other instance types, the default value is optimized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The number of randomly generated IPv6 addresses that you want to allocate to the elastic network interface (ENI).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The name of the key pair that you want to use to log on to an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>Windows instances do not support this parameter.</description></item>
        /// <item><description>By default, the username and password authentication method is disabled for Linux instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPairTest</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The weight of an ECS instance as a backend server. Valid values: 1 to 100.</para>
        /// <para>Default value: 50</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: GiB.</para>
        /// <para>You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set Cpu to 2 and Memory to 16 to specify instance types that have 2 vCPUs and 16 GiB of memory. If you specify Cpu and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances by using the lowest-priced instance type.</para>
        /// <remarks>
        /// <para>You can specify Cpu and Memory to determine the range of instance types only if you set Scaling Policy to Cost Optimization Policy and you do not specify instance types in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("NetworkInterfaces")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestNetworkInterfaces> NetworkInterfaces { get; set; }
        public class CreateScalingConfigurationRequestNetworkInterfaces : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            [NameInMap("SecondaryPrivateIpAddressCount")]
            [Validation(Required=false)]
            public int? SecondaryPrivateIpAddressCount { get; set; }

            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password that you want to use to log on to an ECS instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <para><c>`() ~!@#$%^&amp;*-_+=\\|{}[]:;\\&quot;&lt;&gt;,.?/</c></para>
        /// <para>The password of a Windows instance cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>For security reasons, we recommend that you use HTTPS to send requests if you specify Password.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123abc****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the password that is preconfigured in the image. Before you use this parameter, make sure that a password is configured in the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that you attach to the ECS instance. The name is provided and maintained by Resource Access Management (RAM). You can call the ListRoles operation to query the available RAM roles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ramrole****</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the ECS instances that are created by using the scaling configuration belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-resource****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The resource pools used for instance creation, which can be the public pool or a private pool associated with any active elasticity assurance or capacity reservation. When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when you create pay-as-you-go instances.</description></item>
        /// <item><description>If you specify this parameter, you cannot specify PrivatePoolOptions.MatchCriteria or PrivatePoolOptions.Id.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationRequestResourcePoolOptions ResourcePoolOptions { get; set; }
        public class CreateScalingConfigurationRequestResourcePoolOptions : TeaModel {
            /// <summary>
            /// <para>The IDs of private pools. The ID of a private pool is the same as the ID of the elasticity assurance or capacity reservation that is associated with the private pool. You can specify the IDs of only targeted private pools for this parameter.</para>
            /// </summary>
            [NameInMap("PrivatePoolIds")]
            [Validation(Required=false)]
            public List<string> PrivatePoolIds { get; set; }

            /// <summary>
            /// <para>The resource pool used for instance creation, which can be the public pool or a private pool associated with any active elasticity assurance or capacity reservation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrivatePoolFirst: prioritizes private pools. When this option is set along with ResourcePoolOptions.PrivatePoolIds, the specified private pools are used first. If you leave ResourcePoolOptions.PrivatePoolIds empty or if the specified private pools lack sufficient capacity, the system will automatically use available open private pools instead. If no matching private pools are available, the system defaults to the public pool.</description></item>
            /// <item><description>PrivatePoolOnly: uses only private pools. If you set this value, you must specify ResourcePoolOptions.PrivatePoolIds. If the specified private pools lack sufficient capacity, instance creation will fail.</description></item>
            /// <item><description>None: uses no resource pools.</description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrivatePoolFirst</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

        }

        /// <summary>
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.</para>
        /// <para>The name of the scaling configuration must be unique in a region. If you do not specify this parameter, the scaling configuration ID is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalingconfig****</para>
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group in which you want to create a scaling configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp14wlu85wrpchm0****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The scheduler options.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;testManagedPrivateSpaceId****&quot;]</para>
        /// </summary>
        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public Dictionary<string, object> SchedulerOptions { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable security hardening. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: enables security hardening. This value is applicable only to public images.</description></item>
        /// <item><description>Deactive: disables security hardening. This value is applicable to all image types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group with which ECS instances are associated. ECS instances that are associated with the same security group can access each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-280ih****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups with which you want to associate the ECS instances that are created by using the scaling configuration. For more information, see the &quot;Security group limits&quot; section of the &quot;<a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>&quot; topic.</para>
        /// <remarks>
        /// <para>If you specify SecurityGroupId, you cannot specify SecurityGroupIds.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationRequestSecurityOptions SecurityOptions { get; set; }
        public class CreateScalingConfigurationRequestSecurityOptions : TeaModel {
            /// <summary>
            /// <para>The confidential computing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enclave: An enclave-based confidential computing environment is built on the instance. For more information, see <a href="https://help.aliyun.com/document_detail/203433.html">Build a confidential computing environment by using Enclave</a>.</description></item>
            /// <item><description>TDX: A Trust Domain Extensions (TDX) confidential computing environment is built on the instance. For more information, see <a href="https://help.aliyun.com/document_detail/479090.html">Build a TDX confidential computing environment</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TDX</para>
            /// </summary>
            [NameInMap("ConfidentialComputingMode")]
            [Validation(Required=false)]
            public string ConfidentialComputingMode { get; set; }

        }

        /// <summary>
        /// <para>The retention period of the preemptible instance. Unit: hours. Valid values: 0, 1, 2, 3, 4, 5, and 6.</para>
        /// <list type="bullet">
        /// <item><description>The following retention periods are available in invitational preview: 2, 3, 4, 5, and 6 hours. If you want to set this parameter to one of these values, submit a ticket.</description></item>
        /// <item><description>If you set this parameter to 0, no protection period is specified for the preemptible instance.</description></item>
        /// </list>
        /// <para>Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The interruption mode of the preemptible instance. Set the value to Terminate. The value specifies that the preemptible instance is to be released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>The billing information of the spot instances.</para>
        /// </summary>
        [NameInMap("SpotPriceLimits")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestSpotPriceLimits> SpotPriceLimits { get; set; }
        public class CreateScalingConfigurationRequestSpotPriceLimits : TeaModel {
            /// <summary>
            /// <para>The instance type of the spot instances. This parameter takes effect only if you set SpotStrategy to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The price limit of the spot instances. This parameter takes effect only if you set SpotStrategy to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("PriceLimit")]
            [Validation(Required=false)]
            public float? PriceLimit { get; set; }

        }

        /// <summary>
        /// <para>The preemption policy that you want to apply to pay-as-you-go and preemptible instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is created as a pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ss-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The categories of the system disks. If Auto Scaling cannot create instances by using the disk category that has the highest priority, Auto Scaling creates instances by using the disk category that has the next highest priority. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic disk</description></item>
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: standard SSD</description></item>
        /// <item><description>cloud_essd: ESSD</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify SystemDiskCategories, you cannot specify <c>SystemDisk.Category</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>The tags of the ECS instance. Tags must be specified as key-value pairs. You can specify up to 20 tags. When you specify tag keys and tag values, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>A tag key can be up to 64 characters in length. The key cannot start with acs: or aliyun and cannot contain <c>http://</c> or <c>https://</c>. You cannot specify an empty string as a tag key.</description></item>
        /// <item><description>A tag value can be up to 128 characters in length. The value cannot start with acs: or aliyun and cannot contain <c>http://</c> or <c>https://</c>. You can specify an empty string as a tag value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;, ... &quot;key5&quot;:&quot;value5&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Specifies whether to create an ECS instance on a dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: does not create an ECS instance on a dedicated host.</description></item>
        /// <item><description>host: creates an ECS instance on a dedicated host. If you do not specify DedicatedHostId, Alibaba Cloud selects a dedicated host for the ECS instance.</description></item>
        /// </list>
        /// <para>Default value: default</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        /// <summary>
        /// <para>The user data of the Elastic Compute Service (ECS) instance. The user data must be encoded in Base64 format. The size of raw data before Base64 encoding cannot exceed 32 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo hello ecs!</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The zone ID of the ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
