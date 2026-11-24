// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunInstancesRequest : TeaModel {
        [NameInMap("CpuOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestCpuOptions CpuOptions { get; set; }
        public class RunInstancesRequestCpuOptions : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;Default value: see <a href="https://help.aliyun.com/document_detail/145895.html">Custom CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Numa")]
            [Validation(Required=false)]
            public string Numa { get; set; }

            /// <summary>
            /// <para>The number of threads per core. The number of vCPUs of the ECS instance = the value of CpuOptions.Core × the value of CpuOptions.ThreadsPerCore.</para>
            /// <list type="bullet">
            /// <item><description><para>CpuOptions.ThreadsPerCore=1 indicates that CPU hyper-threading is disabled.</para>
            /// </description></item>
            /// <item><description><para>Only specific instance types support configuring the number of CPU threads.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;Valid values and default value: see <a href="https://help.aliyun.com/document_detail/145895.html">Custom CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ThreadsPerCore")]
            [Validation(Required=false)]
            public int? ThreadsPerCore { get; set; }

            /// <summary>
            /// <para>The CPU topology type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ContinuousCoreToHTMapping: When this value is selected, the hyper-threads of the same core in the CPU topology of the instance are continuous.</description></item>
            /// <item><description>DiscreteCoreToHTMapping: When this value is selected, the hyper-threads of the same core in the instance are discrete.</description></item>
            /// </list>
            /// <para>Default value: none.</para>
            /// <remarks>
            /// <para>Only specific instance families support this parameter. For more information about the supported instance families, see <a href="https://help.aliyun.com/document_detail/2636059.html">View and modify the CPU topology</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DiscreteCoreToHTMapping</para>
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("NestedVirtualization")]
            [Validation(Required=false)]
            public string NestedVirtualization { get; set; }

        }

        [NameInMap("HibernationOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestHibernationOptions HibernationOptions { get; set; }
        public class RunInstancesRequestHibernationOptions : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Configured")]
            [Validation(Required=false)]
            public bool? Configured { get; set; }

        }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class RunInstancesRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool, which is the ID of the elasticity assurance or capacity reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The private pool matching criteria for instance startup. After an elasticity assurance or capacity reservation takes effect, a private pool is generated for you to select when you start an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open mode. The system automatically matches an open private pool. If no eligible private pool is available, the instance uses public pool resources to start. In this mode, you do not need to specify the PrivatePoolOptions.Id parameter.</description></item>
            /// <item><description>Target: specified mode. The instance uses the specified private pool to start. If the specified private pool is unavailable, the instance fails to start. In this mode, you must specify the private pool ID, which means the PrivatePoolOptions.Id parameter is required.</description></item>
            /// <item><description>None: no private pool mode. The instance does not use a private pool to start.</description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// <para>In any of the following scenarios, the private pool matching criteria for instance startup can only be set to None or left unspecified:</para>
            /// <list type="bullet">
            /// <item><description>Creating a spot instance.</description></item>
            /// <item><description>Creating an ECS instance on a dedicated host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestSchedulerOptions SchedulerOptions { get; set; }
        public class RunInstancesRequestSchedulerOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the dedicated host cluster to which the ECS instance belongs. The system automatically selects a dedicated host from the specified dedicated host cluster to deploy the ECS instance.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when Tenancy is set to host.</para>
            /// </remarks>
            /// <para>When you specify both a dedicated host (DedicatedHostId) and a dedicated host cluster (SchedulerOptions.DedicatedHostClusterId):</para>
            /// <list type="bullet">
            /// <item><description>If the dedicated host belongs to the dedicated host cluster, the ECS instance is preferentially deployed on the specified dedicated host.</description></item>
            /// <item><description>If the dedicated host does not belong to the dedicated host cluster, the ECS instance fails to be created.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;You can call the <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a> operation to query the list of dedicated host cluster IDs.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;You can call the <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a> operation to query the list of dedicated host cluster IDs.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;You can call the <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a> operation to query the list of dedicated host cluster IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-bp12wlf6am0vz9v2****</para>
            /// </summary>
            [NameInMap("DedicatedHostClusterId")]
            [Validation(Required=false)]
            public string DedicatedHostClusterId { get; set; }

        }

        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestSecurityOptions SecurityOptions { get; set; }
        public class RunInstancesRequestSecurityOptions : TeaModel {
            /// <summary>
            /// <para>The confidential computing mode. Valid value: Enclave.</para>
            /// <para>When this parameter is set to Enclave, the ECS instance uses Enclave to build a confidential computing environment. Currently, only the c7, g7, and r7 instance families support specifying this parameter when you call RunInstances to use Enclave confidential computing. Note the following:</para>
            /// <list type="bullet">
            /// <item><description><para>The confidential computing feature is in invitational preview.</para>
            /// </description></item>
            /// <item><description><para>To create an ECS instance with Enclave confidential computing by calling API operations, you can only call RunInstances. CreateInstance does not support the SecurityOptions.ConfidentialComputingMode parameter.</para>
            /// </description></item>
            /// <item><description><para>Enclave confidential computing relies on the trusted system (vTPM). When you specify that an ECS instance uses Enclave to build a confidential computing environment, the trusted system is also enabled for the instance. Therefore, when you call this operation, if you set SecurityOptions.ConfidentialComputingMode=Enclave, the created ECS instance will have both the Enclave confidential computing mode and the trusted system enabled, regardless of whether you set SecurityOptions.TrustedSystemMode=vTPM.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about confidential computing, see <a href="https://help.aliyun.com/document_detail/203433.html">Use Enclave to build a confidential computing environment</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enclave</para>
            /// </summary>
            [NameInMap("ConfidentialComputingMode")]
            [Validation(Required=false)]
            public string ConfidentialComputingMode { get; set; }

            /// <summary>
            /// <para>The trusted system mode. Valid value: vTPM.</para>
            /// <para>Currently, the trusted system mode supports the following instance families:</para>
            /// <list type="bullet">
            /// <item><description>g7, c7, and r7.</description></item>
            /// <item><description>Security-enhanced instance families (g7t, c7t, and r7t).</description></item>
            /// </list>
            /// <para>When you create an ECS instance of the preceding instance families, you must configure this parameter. Details:</para>
            /// <list type="bullet">
            /// <item><description>If you use the Alibaba Cloud trusted system, set this parameter to vTPM. This allows the instance to complete trusted verification through the Alibaba Cloud trusted system during startup.</description></item>
            /// <item><description>If you do not use the Alibaba Cloud trusted system, you can leave this parameter unspecified. However, note that if the ECS instance you create uses the Enclave confidential computing mode (SecurityOptions.ConfidentialComputingMode=Enclave), the trusted system is also enabled for the instance.</description></item>
            /// <item><description>To create a trusted ECS instance by calling API operations, you can only call RunInstances. CreateInstance does not support the SecurityOptions.TrustedSystemMode parameter.<remarks>
            /// <para>If you specify an instance as a trusted instance when you create it, you can only use images that support the trusted system when you replace the system disk.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>For more information about the trusted system, see <a href="https://help.aliyun.com/document_detail/201394.html">Overview of the trusted feature for security-enhanced instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vTPM</para>
            /// </summary>
            [NameInMap("TrustedSystemMode")]
            [Validation(Required=false)]
            public string TrustedSystemMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable UEFI Secure Boot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableSecureBoot")]
            [Validation(Required=false)]
            public bool? EnableSecureBoot { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public RunInstancesRequestSystemDisk SystemDisk { get; set; }
        public class RunInstancesRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The system disk category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: enterprise SSD.</description></item>
            /// <item><description>cloud: basic disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
            /// </list>
            /// <para>Default value description:</para>
            /// <list type="bullet">
            /// <item><description>If InstanceType is a retired and non-I/O optimization instance type, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, for instance types that only support <c>cloud_essd</c>, the default value will be changed from <c>cloud_efficiency</c> to <c>cloud_essd</c> PL0. For more details, see <a href="https://www.aliyun.com/notice/117844">Announcement</a>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The value of this parameter can be <c>cloud_essd_entry</c> only when the value of <c>InstanceType</c> is <a href="https://help.aliyun.com/document_detail/457079.html">u1, universal instance family</a> (<c>ecs.u1</c>) or <a href="https://help.aliyun.com/document_detail/108489.html">e, economy instance family</a> (<c>ecs.e</c>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The system disk description. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDisk_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The system disk name. The name must be 2 to 128 characters in length. It can contain letters and digits in Unicode, and can include colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>When creating an enterprise SSD as the system disk, Settings the performance level of the disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1 (default): A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more information about how to select an enterprise SSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">enterprise SSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The system disk size. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Basic disk: 20 to 500.</description></item>
            /// <item><description>enterprise SSD:<list type="bullet">
            /// <item><description>PL0: 1 to 2048.</description></item>
            /// <item><description>PL1: 20 to 2048.</description></item>
            /// <item><description>PL2: 461 to 2048.</description></item>
            /// <item><description>PL3: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>ESSD AutoPL disk: 1 to 2048.</description></item>
            /// <item><description>Other disk categories: 20 to 2048.</description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to max{1, ImageSize}.</para>
            /// <para>Default value: max{40, the size of the image specified by the ImageId parameter}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables the feature.</description></item>
            /// <item><description>false: Disables the feature.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only when SystemDisk.Category is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("EncryptAlgorithm")]
            [Validation(Required=false)]
            public string EncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Encrypts the system disk.</para>
            /// </description></item>
            /// <item><description><para>false: Does not encrypt the system disk.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>You cannot encrypt the system disk when you create an instance in Hong Kong (China) Zone D or Singapore Zone A.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must specify the request parameter Encrypted=true for the cloud disk. This ensures that the created cloud disk uses the key of the user to whom the image is shared.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key that is used to encrypt the system disk.</para>
            /// <remarks>
            /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>If the cloud disk is created from an unshared encrypted snapshot, the encryption key used by the snapshot is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>If the cloud disk is created in a region where account-level default encryption for block storage is enabled, the specified account-level key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>In other cases, the service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <remarks>
            /// <para>This parameter is supported only when SystemDisk.Category is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. If you want to use cloud disk resources in a dedicated block storage cluster as the system disk when you create an ECS instance, specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
            /// </summary>
            [NameInMap("StorageClusterId")]
            [Validation(Required=false)]
            public string StorageClusterId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the instance is associated with a dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The instance is not associated with a dedicated host. If an instance with economical mode enabled is stopped and then started, and the original dedicated host has insufficient available resources, the instance is placed on another dedicated host in the automatic deployment resource pool.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with a dedicated host. If an instance with economical mode enabled is stopped and then started, it remains on the original dedicated host. If the original dedicated host has insufficient available resources, the instance fails to start.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public string Affinity { get; set; }

        /// <summary>
        /// <para>The number of ECS instances to create. Valid values: 1 to 100.</para>
        /// <para>The number of successfully created ECS instances depends on the specified Amount and minAmount:</para>
        /// <list type="bullet">
        /// <item><description><para>When minAmount is not specified: Instances are created based on the Amount value. If the inventory is insufficient, the API returns a creation failure, and no instances are created.</para>
        /// </description></item>
        /// <item><description><para>When minAmount is specified:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS inventory &lt; minAmount: No ECS instances are created, and the API returns a creation failure.</description></item>
        /// <item><description>If minAmount ≤ ECS inventory &lt; Amount: Instances are created based on the inventory, and the API returns a creation success.</description></item>
        /// <item><description>If the ECS inventory ≥ Amount: Instances are created based on the specified Amount, and the API returns a creation success.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<RunInstancesRequestArn> Arn { get; set; }
        public class RunInstancesRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to automatically pay for the instance when you create the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Automatically pays for the instance.</para>
        /// <remarks>
        /// <para>If you set this parameter to true, make sure that automatic payment method has sufficient balance. Otherwise, an abnormal order is generated and can only be canceled. If automatic payment method has insufficient balance, you can set AutoPay to false. In this case, an unpaid order is generated, and you can log on to the ECS console to pay for the order.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: Generates an order without deducting fees.</para>
        /// <remarks>
        /// <para>If InstanceChargeType is set to PostPaid, you cannot set AutoPay to false.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The automatic release time of the pay-as-you-go instance. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description><para>If the seconds (ss) value is not 00, it is automatically set to the start of the current minute (mm).</para>
        /// </description></item>
        /// <item><description><para>The minimum release time is half an hour after the current time.</para>
        /// </description></item>
        /// <item><description><para>The maximum release time cannot exceed three years from the current time.
        /// <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-01T12:05:00Z</para>
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when InstanceChargeType is set to PrePaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. Valid values: </para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>When PeriodUnit is set to Week: 1, 2, and 3.</description></item>
        /// <item><description>When PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;When PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The clock configurations of the instance.</para>
        /// </summary>
        [NameInMap("ClockOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestClockOptions ClockOptions { get; set; }
        public class RunInstancesRequestClockOptions : TeaModel {
            /// <summary>
            /// <para>The Precision Time Protocol (PTP) status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: Enables PTP.</para>
            /// </description></item>
            /// <item><description><para>disabled: Disables PTP.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PtpStatus")]
            [Validation(Required=false)]
            public string PtpStatus { get; set; }

        }

        /// <summary>
        /// <para>The performance mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard mode. For more information about instance performance, see the &quot;Standard mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// <item><description>Unlimited: unlimited mode. For more information about instance performance, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The data disk configurations.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<RunInstancesRequestDataDisk> DataDisk { get; set; }
        public class RunInstancesRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy that is applied to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables the feature.</description></item>
            /// <item><description>false: Disables the feature.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The category of data disk N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>cloud: basic disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.<remarks>
            /// <para>This parameter supports cloud_essd_entry only when InstanceType is specified as an instance type in the ecs.u1 or ecs.e instance family.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>elastic_ephemeral_disk_standard: elastic ephemeral disk - Standard Edition.</description></item>
            /// <item><description>elastic_ephemeral_disk_premium: elastic ephemeral disk - Premium Edition.</description></item>
            /// </list>
            /// <para>For I/O optimized instances, the default Settings are cloud_efficiency. For non-I/O optimized instances, the default Settings are cloud.
            /// Default value description:</para>
            /// <list type="bullet">
            /// <item><description>If InstanceType is configured as a retired and non-I/O optimized instance type, the default Settings are cloud.</description></item>
            /// <item><description>In other cases, the default Settings are cloud_efficiency. &lt;props=&quot;china&quot;&gt;After January 30, 2026, if the I/O optimized instance type does not support cloud_auto, the default Settings are cloud_efficiency. Otherwise, the default Settings are cloud_auto, and the performance burst feature is enabled by default. This feature incurs additional fees. For details, see <a href="~~368372#p_75k_2hp_7gp~~">Billing examples</a>. For more information, see <a href="https://www.aliyun.com/notice/117844">Announcement</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to release the data disk when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Releases the data disk when the instance is released.</description></item>
            /// <item><description>false: Retains the data disk when the instance is released.</description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The description of the data disk. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataDisk_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the data disk. The naming convention for mount points varies based on the number of attached data disks:</para>
            /// <list type="bullet">
            /// <item><description><para>1 to 25 data disks: /dev/xvd[b-z]</para>
            /// </description></item>
            /// <item><description><para>More than 25 data disks: /dev/xvd[aa-zz]. For example, the 26th data disk is named /dev/xvdaa, the 27th data disk is named /dev/xvdab, and so on.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is applicable only to full images. You can set this parameter to the mount point of the data disk in the full image and modify the DataDisk.N.Size and DataDisk.N.Category parameters to change the category and size of the data disk in the full image.</description></item>
            /// <item><description>When you use a full image to create an instance, the data disks in the full image are created as the first n data disks of the ECS instance.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the data disk. The name must be 2 to 128 characters in length. It can contain characters that fall under the letter category in Unicode, such as letters, Chinese characters, and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdData</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("EncryptAlgorithm")]
            [Validation(Required=false)]
            public string EncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt data disk N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Encrypts the data disk.</description></item>
            /// <item><description>false: Does not encrypt the data disk.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must specify the request parameter Encrypted=true for the cloud disk. This ensures that the created cloud disk uses the key of the user to whom the image is shared.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key that is used to encrypt the data disk.</para>
            /// <remarks>
            /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>If the cloud disk is created from an unshared encrypted snapshot, the encryption key used by the snapshot is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>If the cloud disk is created in a region where account-level default encryption for block storage is enabled, the specified account-level key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>In other cases, the service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>When you create an ESSD as a data disk, configure the Settings for the performance level of the disk. The value of N must be the same as the value of N in DataDisk.N.Category=cloud_essd. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1 (default): A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more information about how to select the performance level of an ESSD, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <remarks>
            /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of data disk N. Valid values of N: 1 to 16. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: 20 to 32768.</description></item>
            /// <item><description>cloud_ssd: 20 to 32768.</description></item>
            /// <item><description>cloud_essd: The valid values depend on the value of DataDisk.N.PerformanceLevel. <list type="bullet">
            /// <item><description>PL0: 1 to 65,536.</description></item>
            /// <item><description>PL1: 20 to 65,536.</description></item>
            /// <item><description>PL2: 461 to 65,536.</description></item>
            /// <item><description>PL3: 1261 to 65,536.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>cloud: 5 to 2000.</description></item>
            /// <item><description>cloud_auto: 1 to 65,536.</description></item>
            /// <item><description>cloud_essd_entry: 10 to 32768.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The value of this parameter must be greater than or equal to the size of the snapshot specified by the SnapshotId parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot that is used to create data disk N. Valid values of N: 1 to 16.</para>
            /// <para>If you specify the DataDisk.N.SnapshotId parameter, the DataDisk.N.Size parameter is ignored. The size of the created cloud disk is the same as the size of the specified snapshot. You cannot use snapshots that were created on or before July 15, 2013. Otherwise, the request is rejected and an error is reported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. If you want to use cloud disk resources in a dedicated block storage cluster as data disks when you create an ECS instance, specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
            /// </summary>
            [NameInMap("StorageClusterId")]
            [Validation(Required=false)]
            public string StorageClusterId { get; set; }

        }

        /// <summary>
        /// <para>The dedicated host ID.
        /// &lt;props=&quot;china&quot;&gt;You can invoke <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> to query the dedicated host ID list.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;You can invoke <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> to query the dedicated host ID list.</para>
        /// <remarks>
        /// <para>Notice: Dedicated hosts do not support the creation of spot instance. After you specify the <c>DedicatedHostId</c> parameter, the <c>SpotStrategy</c> and <c>SpotPriceLimit</c> Settings in the request are automatically ignored.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The release protection property of the instance. It specifies whether the instance can be released through the console or API (<a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a>). Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: enables release protection.</description></item>
        /// <item><description>false: disables release protection.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This property applies only to pay-as-you-go instances and can only restrict manual release operations. It does not take effect on system release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The group number of the instance in the deployment set. If the deployment set policy is set to AvailabilityGroup, you can use this parameter to specify the group number. Valid values: 1 to 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DeploymentSetGroupNo")]
        [Validation(Required=false)]
        public int? DeploymentSetGroupNo { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp1brhwhoqinyjd6****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The instance description. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance_Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run and does not create the instance. Check items include whether required parameters are specified, the request format, service limits, and ECS inventory. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false (default): performs a normal request and creates the instance directly after the check succeeds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The hostname of the instance. Limits:</para>
        /// <list type="bullet">
        /// <item><description>Periods (.) and hyphens (-) cannot be used as the first or last character, and cannot be used consecutively.</description></item>
        /// <item><description>Windows instances: The name must be 2 to 15 characters in length. It cannot contain periods (.) or contain only digits. It can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>Other instances (such as Linux instances):<list type="bullet">
        /// <item><description>The name must be 2 to 64 characters in length. It can contain multiple periods (.). The string between two periods is a segment, which can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>You can use the ${instance_id} placeholder to write the instance ID into the HostName parameter. For example, if HostName=k8s-${instance_id} and the created ECS instance ID is i-123abc****, the hostname of the instance is k8s-i-123abc****.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>When you create multiple ECS instances, you can:</para>
        /// <list type="bullet">
        /// <item><description>Specify sequential hostnames in batches. For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Specify sequential instance names or hostnames</a>.</description></item>
        /// <item><description>Specify hostnames for multiple instances separately by using the HostNames.N parameter. Note that you cannot specify both HostName and HostNames.N.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-ecshost</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>Specifies different hostnames for each instance when you create multiple instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-host-01</para>
        /// </summary>
        [NameInMap("HostNames")]
        [Validation(Required=false)]
        public List<string> HostNames { get; set; }

        /// <summary>
        /// <para>The ID of the HPC cluster to which the instance belongs. </para>
        /// <para>This parameter is required when you create an SCC instance. You can call <a href="https://help.aliyun.com/document_detail/109138.html">CreateHpcCluster</a> to create an HPC cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hpc-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the access channel for instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: enables the access channel.</description></item>
        /// <item><description>disabled: disables the access channel.</description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para>For more information about instance metadata, see <a href="https://help.aliyun.com/document_detail/49122.html">Overview of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly use the security hardening mode (IMDSv2) when you access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcibly use the security hardening mode.</description></item>
        /// <item><description>required: forcibly uses the security hardening mode. After this value is set, instance metadata cannot be accessed in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about the modes for accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/150575.html">Access modes of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The image family name. Set this parameter to use the latest available image in the specified image family to create the instance.</para>
        /// <para>The name must be 2 to 128 characters in length. It cannot start with a special character, digit, http://, or https://. It can contain only the following special characters: periods (.), underscores (_), hyphens (-), and colons (:).</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If ImageId is specified, you cannot specify this parameter.</description></item>
        /// <item><description>If ImageId is not specified but the launch template specified by LaunchTemplateId or LaunchTemplateName has ImageId configured, you cannot specify this parameter.</description></item>
        /// <item><description>If ImageId is not specified and the launch template specified by LaunchTemplateId or LaunchTemplateName does not have ImageId configured, you can specify this parameter.</description></item>
        /// <item><description>If neither ImageId nor LaunchTemplateId and LaunchTemplateName are specified, you can specify this parameter.<remarks>
        /// <para>For information about the image families associated with Alibaba Cloud official images, see <a href="https://help.aliyun.com/document_detail/108393.html">Public images</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The image ID. The image resource selected when the instance is started. You can call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available image resources. If you do not specify LaunchTemplateId or LaunchTemplateName to determine a launch template, and do not specify ImageFamily to use the latest available image in an image family, ImageId is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_2_1903_x64_20G_alibase_20200324.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image configurations.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestImageOptions ImageOptions { get; set; }
        public class RunInstancesRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether the instance that uses the image supports logons by using the ecs-user username. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Supports logons by using the ecs-user username.</para>
            /// </description></item>
            /// <item><description><para>false: Does not support logons by using the ecs-user username.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LoginAsNonRoot")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

        }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;When you select subscription, you must ensure that your account supports balance payment or credit payment. Otherwise, an InvalidPayMethod error is returned.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;When you select subscription, you must ensure that your account supports credit payment. Otherwise, an InvalidPayMethod error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 128 characters in length. It can contain letters and digits in Unicode, and can include colons (:), underscores (_), periods (.), and hyphens (-). The default value is the InstanceId of the instance.</para>
        /// <para>When you create multiple ECS instances, you can specify sequential instance names in batches, which can include square brackets ([]) and commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Specify sequential instance names or hostnames</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to determine a launch template, <c>InstanceType</c> is a required parameter.  </para>
        /// <list type="bullet">
        /// <item><description>Instance type selection: See <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to view the performance data of the target instance type, or see <a href="https://help.aliyun.com/document_detail/58291.html">Best practices for instance type selection</a> to learn how to select an instance type.</description></item>
        /// <item><description>Inventory query: invoke <a href="https://help.aliyun.com/document_detail/66186.html">DescribeAvailableResource</a> to view the active resource supply in a specific region or zone.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The network billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic.</description></item>
        /// </list>
        /// <para>Default value: PayByTraffic.</para>
        /// <remarks>
        /// <para>In <b>pay-by-traffic</b> mode, the peak inbound and outbound bandwidths are bandwidth upper limits and are not guaranteed service level indicators. When resource contention occurs, the peak bandwidth may be limited. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
        /// </remarks>
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
        /// <item><description>When the purchased outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
        /// <item><description>When the purchased outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of InternetMaxBandwidthOut. Default value: the value of InternetMaxBandwidthOut.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is an I/O optimized instance. For <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a>, the default value is none. For other instance types, the default value is optimization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: The instance is not I/O optimization.</description></item>
        /// <item><description>optimized: The instance is I/O optimization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The IPv6 addresses that are assigned to the primary ENI. You can specify up to 10 IPv6 addresses. Valid values of N: 1 to 10.</para>
        /// <para>Example: Ipv6Address.1=2001:db8:1234:1a00::***.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify Ipv6Address.N, the value of Amount can only be 1, and you cannot specify Ipv6AddressCount at the same time.</para>
        /// </description></item>
        /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you cannot specify Ipv6Addresses.N or Ipv6AddressCount. Instead, you must specify NetworkInterface.N.Ipv6Addresses.N or NetworkInterface.N.Ipv6AddressCount.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ipv6Address.1=2001:db8:1234:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses to be randomly generated for the primary ENI. Valid values: 1 to 10.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>You cannot specify both Ipv6Address.N and Ipv6AddressCount.</para>
        /// </description></item>
        /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you cannot specify Ipv6Address.N or Ipv6AddressCount. You can only specify NetworkInterface.N.Ipv6Address.N or NetworkInterface.N.Ipv6AddressCount.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The key pair name.</para>
        /// <remarks>
        /// <para>For Windows instances, this parameter is ignored. The default value is empty. Even if this parameter is specified, only the Password parameter takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPair_Name</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The launch template ID. For more information, call <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a>.</para>
        /// <para>When you use a launch template to create an instance, you must specify LaunchTemplateId or LaunchTemplateName to determine the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1apo0bbbkuy0rj****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The launch template name.</para>
        /// <para>When you use a launch template to create an instance, you must specify LaunchTemplateId or LaunchTemplateName to determine the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LaunchTemplate_Name</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The launch template version. If you specify LaunchTemplateId or LaunchTemplateName but do not specify the launch template version, the default version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public long? LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The unique identifier of the managed host, such as mh-f2d3647ca21****.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mh-f2d3647ca21****</para>
        /// </summary>
        [NameInMap("ManagedHostId")]
        [Validation(Required=false)]
        public string ManagedHostId { get; set; }

        /// <summary>
        /// <para>The minimum Quantity of ECS instances to purchase. Valid values: 1 to 100.</para>
        /// <para>The number of successfully created ECS instances depends on the specified Amount and minAmount:</para>
        /// <list type="bullet">
        /// <item><description><para>When minAmount is not specified: Instances are created based on the Amount value. If the inventory is insufficient, the API returns a creation failed, and no instances are created.</para>
        /// </description></item>
        /// <item><description><para>When minAmount is specified:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS inventory &lt; minAmount: No ECS instances are created, and the API returns a creation failed.</description></item>
        /// <item><description>If minAmount ≤ ECS inventory &lt; Amount: Instances are created based on the inventory, and the API returns a creation success.</description></item>
        /// <item><description>If the ECS inventory ≥ Amount: Instances are created based on the specified Amount, and the API returns a creation success.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinAmount")]
        [Validation(Required=false)]
        public int? MinAmount { get; set; }

        /// <summary>
        /// <para>The ENI information.</para>
        /// </summary>
        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<RunInstancesRequestNetworkInterface> NetworkInterface { get; set; }
        public class RunInstancesRequestNetworkInterface : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retain the ENI when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Does not retain the ENI.</para>
            /// </description></item>
            /// <item><description><para>false: Retains the ENI.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para>This parameter takes effect only for secondary ENIs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteOnRelease")]
            [Validation(Required=false)]
            public bool? DeleteOnRelease { get; set; }

            /// <summary>
            /// <para>The description of the ENI.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>The valid values of N cannot exceed the maximum number of network interface controller (NIC) supported by the target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum number of network interface controller (NIC) supported by the target instance type.</description></item>
            /// <item><description>The description must be 2 to 256 characters in length and cannot start with http:// or https://.</description></item>
            /// <item><description>If NetworkInterface.N.InstanceType is specified as Primary, you do not need to configure the Settings for this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Network_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the ENI. The valid values of N cannot exceed the maximum number of network interface controller (NIC) supported by the target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum number of network interface controller (NIC) supported by the target instance type.</para>
            /// <para>Valid values of the parameter:</para>
            /// <list type="bullet">
            /// <item><description>Primary: primary ENI.</description></item>
            /// <item><description>Secondary: secondary ENI.</description></item>
            /// </list>
            /// <para>Default value: Secondary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Secondary</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The IPv6 addresses that are assigned to the primary ENI. You can specify up to 10 IPv6 addresses. Valid values of the second N: 1 to 10.</para>
            /// <para>Example: Ipv6Address.1=2001:db8:1234:1a00::***.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when NetworkInterface.N.InstanceType is set to Primary. If NetworkInterface.N.InstanceType is set to Secondary or left empty, you cannot specify this parameter.</para>
            /// </description></item>
            /// <item><description><para>After you specify this parameter, the value of Amount can only be 1, and you cannot specify Ipv6AddressCount, Ipv6Address.N, or NetworkInterface.N.Ipv6AddressCount.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<string> Ipv6Address { get; set; }

            /// <summary>
            /// <para>The number of IPv6 addresses that are randomly generated for the primary ENI. Valid values: 1 to 10.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when NetworkInterface.N.InstanceType is set to Primary. If NetworkInterface.N.InstanceType is set to Secondary or left empty, you cannot specify this parameter.</para>
            /// </description></item>
            /// <item><description><para>After you specify this parameter, you cannot specify Ipv6AddressCount, Ipv6Address.N, or NetworkInterface.N.Ipv6Address.N.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public long? Ipv6AddressCount { get; set; }

            /// <summary>
            /// <para>The index of the network card specified for the network interface controller (NIC).</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>Only specific instance types support specifying the network card index.</description></item>
            /// <item><description>If NetworkInterface.N.InstanceType is specified as Primary and the instance type supports network card, you can only configure the Settings for this parameter to 0.</description></item>
            /// <item><description>If NetworkInterface.N.InstanceType is specified as Secondary or left empty and the instance type supports network card, you can configure the Settings for this parameter based on the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetworkCardIndex")]
            [Validation(Required=false)]
            public int? NetworkCardIndex { get; set; }

            /// <summary>
            /// <para>The ID of the ENI that is attached to the instance.</para>
            /// <para>After you configure the Settings for this parameter, the value of Amount can only be 1.</para>
            /// <remarks>
            /// <para>This parameter takes effect only for secondary ENIs. After you specify an existing secondary ENI, you cannot configure other network interface controller (NIC) creation parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1gn106np8jhxhj****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The name of the ENI. The name must be 2 to 128 characters in length. It can contain characters that fall under the letter categorization in Unicode, such as letters, Chinese characters, and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N cannot exceed the maximum number of network interface controller (NIC) supported by the target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum number of network interface controller (NIC) supported by the target instance family.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Primary, you do not need to configure the Settings for this parameter.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Network_Name</para>
            /// </summary>
            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            /// <summary>
            /// <para>The communication pattern of the network interface controller (NIC). Valid values of the parameter:</para>
            /// <list type="bullet">
            /// <item><description>Standard: Uses the TCP communication pattern.</description></item>
            /// <item><description>HighPerformance: Enables the Elastic RDMA Interface (ERI) and uses the RDMA communication pattern.</description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para>The number of Elastic Network Interface (ENI) in RDMA mode cannot exceed the limit of the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>Adds an ENI and configures the primary IP address.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N cannot exceed the maximum number of network interface controller (NIC) supported by the target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum number of network interface controller (NIC) supported by the target instance type.</para>
            /// <list type="bullet">
            /// <item><description>When you configure the Settings for one ENI, you can configure one primary ENI or one secondary ENI. If the value of the Amount parameter is greater than 1, and you configure a primary ENI and specify this parameter, consecutive primary IP addresses are allocated to multiple ECS instances starting from the specified primary IP address when you create target instances in batches. Note that you cannot attach secondary ENIs to target instances in this case.</description></item>
            /// <item><description>Note that if the value of the Amount parameter is greater than 1 and you have configured the Settings for this parameter for the primary ENI, you cannot configure secondary ENIs. This means you cannot specify NetworkInterface.2.InstanceType as Secondary.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Primary, this parameter serves the same purpose as PrivateIpAddress. Note that you cannot specify both this parameter and PrivateIpAddress at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Secondary or left empty, this parameter specifies the primary IP address of the secondary ENI. By default, an IP address is randomly selected from the vSwitch CIDR block of the vSwitch to which the ENI belongs.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The first and last three IP addresses of each vSwitch are system reserved IP addresses and cannot be specified.
            /// For example, if the vSwitch CIDR block of the vSwitch is 192.168.1.0/24, the four IP addresses 192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255 are system reserved IP addresses.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><c>172.16.**.**</c></para>
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// <para>The number of queues for the ENI.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N cannot exceed the maximum number of network interface controller (NIC) supported by the target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum number of network interface controller (NIC) supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>The value cannot exceed the maximum number of queues per ENI allowed by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>The total number of queues for all ENIs of the target instance cannot exceed the total queue quota allowed by the target instance type. You can invoke the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields for the maximum number of queues per ENI and the total queue quota of the target instance type.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Primary and you specify this parameter, you cannot configure the Settings for the NetworkInterfaceQueueNumber parameter.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queues for the RDMA ENI.</para>
            /// <para>If you want to attach multiple RDMA ENIs to the instance, we recommend that you manually specify QueuePairNumber for each ENI based on the maximum QueuePairNumber supported by the instance type and the number of ENIs you plan to use. Make sure that the total QueuePairNumber of all ENIs does not exceed the maximum value allowed by the instance type. You can call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum value for the instance type.</para>
            /// <remarks>
            /// <para>Notice: If QueuePairNumber is not specified for an RDMA ENI, the maximum QueuePairNumber supported by all RDMA ENIs of the instance type is used by default. Therefore, after you attach an RDMA ENI for which QueuePairNumber is not specified, you cannot attach more RDMA ENIs. Regular ENIs are not subject to this limit.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public long? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The inbound queue depth of the ENI.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available. If you want to use this parameter, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a> to apply for the whitelist.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available. If you want to use this parameter, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a> to apply for the whitelist.</para>
            /// </remarks>
            /// <para>When you use this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter is applicable only to seventh-generation and later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger inbound queue depth can improve inbound throughput and reduce the packet loss rate, but it consumes more memory.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("RxQueueSize")]
            [Validation(Required=false)]
            public int? RxQueueSize { get; set; }

            /// <summary>
            /// <para>The number of secondary private IPv4 addresses that are allocated to the network interface controller (NIC). Valid values: 1 to 49.</para>
            /// <list type="bullet">
            /// <item><description>The value cannot exceed the limit on the number of IP addresses for the instance type. For more information, see <a href="~~~25378~~">instance family</a>.</description></item>
            /// <item><description>NetworkInterface.N.SecondaryPrivateIpAddressCount specifies the number of secondary private IPv4 addresses that are allocated to the network interface controller (NIC), excluding the primary private IP address of the network interface controller (NIC). The system randomly allocates these addresses from the active CIDR block of the vSwitch (NetworkInterface.N.VSwitchId) to which the network interface controller (NIC) belongs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SecondaryPrivateIpAddressCount")]
            [Validation(Required=false)]
            public int? SecondaryPrivateIpAddressCount { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the ENI belongs.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N cannot exceed the maximum number of network interface controller (NIC) supported by the target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum number of network interface controller (NIC) supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Primary, you must configure the Settings for this parameter. In this case, this parameter serves the same purpose as SecurityGroupId. Note that you cannot configure the Settings for SecurityGroupId, SecurityGroupIds.N, or NetworkInterface.N.SecurityGroupIds.N at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Secondary or left empty, this parameter is optional. The default value is the security group to which the ECS instance belongs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of one or more security groups to which the ENI belongs.</para>
            /// <list type="bullet">
            /// <item><description>The valid values of N cannot exceed the maximum number of network interface controller (NIC) supported by the target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum number of network interface controller (NIC) supported by the target instance type.</description></item>
            /// <item><description>The second N specifies the IDs of one or more security groups. The valid values of N depend on the quota of security groups that the target instance can join. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
            /// </list>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Primary, you must configure the Settings for this parameter or NetworkInterface.N.SecurityGroupId. In this case, this parameter serves the same purpose as SecurityGroupIds.N. Note that you cannot configure the Settings for SecurityGroupId, SecurityGroupIds.N, or NetworkInterface.N.SecurityGroupId at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Secondary or left empty, this parameter is optional. The default value is the security group to which the ECS instance belongs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp15ed6xe1yxeycg7****</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the source/destination checking feature. We recommend that you enable this feature to improve network security. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables the feature.</para>
            /// </description></item>
            /// <item><description><para>false: Disables the feature.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>This feature is supported only in specific regions. Before you use this feature, read <a href="https://help.aliyun.com/document_detail/2863210.html">Source/destination checking</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SourceDestCheck")]
            [Validation(Required=false)]
            public bool? SourceDestCheck { get; set; }

            /// <summary>
            /// <para>The outbound queue depth of the ENI.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available. If you want to use this parameter, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a> to apply for the whitelist.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available. If you want to use this parameter, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a> to apply for the whitelist.</para>
            /// </remarks>
            /// <para>When you use this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter is applicable only to seventh-generation and later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger outbound queue depth can improve outbound throughput and reduce the packet loss rate, but it consumes more memory.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("TxQueueSize")]
            [Validation(Required=false)]
            public int? TxQueueSize { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the ENI belongs.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N cannot exceed the maximum number of network interface controller (NIC) supported by the target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a> or invoke the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum number of network interface controller (NIC) supported by the target instance type.  </para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Primary, you must configure the Settings for this parameter. In this case, this parameter serves the same purpose as VSwitchId. Note that you cannot configure the Settings for both this parameter and VSwitchId at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is specified as Secondary or left empty, this parameter is optional. The default value is the vSwitch to which the ECS instance belongs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The number of queues for the primary ENI. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot exceed the maximum number of queues per ENI allowed by the instance type.</para>
        /// </description></item>
        /// <item><description><para>The total number of queues for all ENIs of the instance cannot exceed the total queue quota allowed by the instance type. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields for the maximum number of queues per ENI and the total quota of the instance type.</para>
        /// </description></item>
        /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you cannot specify NetworkInterfaceQueueNumber. You can only specify NetworkInterface.N.QueueNumber.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("NetworkInterfaceQueueNumber")]
        [Validation(Required=false)]
        public int? NetworkInterfaceQueueNumber { get; set; }

        /// <summary>
        /// <para>The network configurations.</para>
        /// </summary>
        [NameInMap("NetworkOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestNetworkOptions NetworkOptions { get; set; }
        public class RunInstancesRequestNetworkOptions : TeaModel {
            /// <summary>
            /// <para>The bandwidth weight of the instance. The valid values vary based on the instance type. You can call the DescribeInstanceTypes operation to query the valid values for a specific instance type. The BandwidthWeighting field in the response indicates the bandwidth weight levels supported by the instance type. You can use the name field in the response as the dictionary value, such as Vpc-L1 and Ebs-L1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("BandwidthWeighting")]
            [Validation(Required=false)]
            public string BandwidthWeighting { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Jumbo Frame feature for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false: Disables the Jumbo Frame feature. The maximum transmission unit (MTU) of all ENIs, including the primary ENI and secondary ENIs, is set to 1500.</para>
            /// </description></item>
            /// <item><description><para>true: Enables the Jumbo Frame feature. The MTU of all ENIs, including the primary ENI and secondary ENIs, is set to 8500.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para>Only specific eighth-generation and later instance types support the Jumbo Frame feature. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">MTU of ECS instances</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableJumboFrame")]
            [Validation(Required=false)]
            public bool? EnableJumboFrame { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("EnableNetworkEncryption")]
            [Validation(Required=false)]
            public bool? EnableNetworkEncryption { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The instance password. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The special characters can be:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify the Password parameter, we recommend that you send the request over HTTPS to prevent password leaks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EcsV587!</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the preset password of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Uses the preset password.</description></item>
        /// <item><description>false: Does not use the preset password.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>When you use this parameter, the Password parameter must be empty, and you must ensure that the image you use has a password configured.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription period of the resource. The unit is specified by PeriodUnit. This parameter takes effect and is required only when InstanceChargeType is set to PrePaid. If DedicatedHostId is specified, the value cannot exceed the subscription period of the dedicated host. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>When PeriodUnit is set to Week, valid values of Period are 1, 2, 3, and 4.</description></item>
        /// <item><description>When PeriodUnit is set to Month, valid values of Period are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;When PeriodUnit is set to Month, valid values of Period are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The billing unit of the subscription billing method. Valid values: </para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Week.</description></item>
        /// <item><description>Month (default).</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;Month (default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The private DNS name configurations of the instance.</para>
        /// <para>For more information about private Private domain resolution, see <a href="https://help.aliyun.com/document_detail/2844797.html">Private Private domain resolution for ECS</a>.</para>
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class RunInstancesRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable or disable the resolution of instance ID-based domain names to IPv6 addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables the resolution.</para>
            /// </description></item>
            /// <item><description><para>false: Disables the resolution.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableInstanceIdDnsAAAARecord")]
            [Validation(Required=false)]
            public bool? EnableInstanceIdDnsAAAARecord { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable or disable the resolution of instance ID-based domain names to IPv4 addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables the resolution.</para>
            /// </description></item>
            /// <item><description><para>false: Disables the resolution.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInstanceIdDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableInstanceIdDnsARecord { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable or disable the resolution of IP-based domain names to IPv4 addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables the resolution.</description></item>
            /// <item><description>false: Disables the resolution.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIpDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsARecord { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable or disable the reverse resolution of IPv4 addresses to IP-based domain names. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables the resolution.</description></item>
            /// <item><description>false: Disables the resolution.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableIpDnsPtrRecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsPtrRecord { get; set; }

            /// <summary>
            /// <para>The hostname type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Custom: Custom hostname.</description></item>
            /// <item><description>IpBased: IP-based hostname.</description></item>
            /// <item><description>InstanceIdBased: Instance ID-based hostname.</description></item>
            /// </list>
            /// <para>Default value: Custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("HostnameType")]
            [Validation(Required=false)]
            public string HostnameType { get; set; }

        }

        /// <summary>
        /// <para>The private IP address of the instance. When you specify system reserved IP address for a VPC-type ECS instance, the IP address must be selected from the idle CIDR block of the vSwitch (VSwitchId).</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>After PrivateIpAddress is specified:</para>
        /// <list type="bullet">
        /// <item><description>If the Amount parameter is set to 1, it indicates that system reserved IP address is assigned to the single ECS instance being created.</description></item>
        /// <item><description>If the Amount parameter is set to a value greater than 1, it indicates that when multiple ECS instances are created in batches, consecutive private IP addresses starting from the specified private IP address are assigned to the instances. Note that in this case, you cannot bind secondary ENIs to the instances (that is, you cannot specify parameters like NetworkInterface.N.*).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you cannot specify PrivateIpAddress. You can only specify NetworkInterface.N.PrimaryIpAddress.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The first and the last three IP addresses of each vSwitch are reserved by the system and cannot be specified.
        /// For example, if the vSwitch CIDR block is 192.168.1.0/24, the four IP addresses 192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255 are reserved by the system.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The instance RAM role name. You can use the RAM API <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query the instance RAM roles you have created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM_Name</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
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
        /// <para>Specifies whether to enable security hardening. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: enables security hardening. This value takes effect only for public images.</description></item>
        /// <item><description>Deactive: disables security hardening. This value takes effect for all image types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the new instance belongs. Instances in the same security group can access each other. The maximum number of instances that a security group can contain depends on the security group type. For more information, see the &quot;Security group limits&quot; section in <a href="~~25412#SecurityGroupQuota~~">Limits</a>.</para>
        /// <remarks>
        /// <para>SecurityGroupId determines the network type of the instance. For example, if the network type of the specified security group is VPC, the instance is a VPC-type instance and the VSwitchId parameter must be specified.</para>
        /// </remarks>
        /// <para>If you do not specify LaunchTemplateId or LaunchTemplateName to determine a launch template, the security group ID is required. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>You can specify one security group by using SecurityGroupId, or specify one or more security groups by using SecurityGroupIds.N. However, you cannot specify both SecurityGroupId and SecurityGroupIds.N.</para>
        /// </description></item>
        /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you cannot specify SecurityGroupId or SecurityGroupIds.N. You can only specify NetworkInterface.N.SecurityGroupId or NetworkInterface.N.SecurityGroupIds.N.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Adds the instance to multiple security groups at the same time. The valid values of N depend on the quota of security groups that the instance can join. For more information, see <a href="https://help.aliyun.com/document_detail/101348.html">Security group limits</a>.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description>You cannot specify both SecurityGroupId and SecurityGroupIds.N at the same time.</description></item>
        /// <item><description>If NetworkInterface.N.InstanceType is set to Primary, you cannot specify SecurityGroupId or SecurityGroupIds.N. You can only specify NetworkInterface.N.SecurityGroupId or NetworkInterface.N.SecurityGroupIds.N.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The protection period of the spot instance. Unit: hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After the spot instance is created, Alibaba Cloud guarantees that the spot instance will not be automatic release within 1 hour. After 1 hour, the system compares the bid price with the marketplace price and checks the resource inventory in real-time to determine whether to retain or revoke the spot instance.</description></item>
        /// <item><description>0: After the spot instance is created, Alibaba Cloud does not guarantee the runtime of the spot instance. The system compares the bid price with the marketplace price and checks the resource inventory in real-time to determine whether to retain or revoke the spot instance.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter currently only supports 0 or 1.</description></item>
        /// <item><description>Preemptible instances are billing by the second. We recommend that you select an appropriate protection period based on the execution duration of your specific node.</description></item>
        /// <item><description>Alibaba Cloud sends a notification through an ECS system event 5 minutes before the spot instance is reclaimed.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The break mode of the preemptible instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Terminate: releases the instance.</para>
        /// </description></item>
        /// <item><description><para>Stop: puts the instance into economical mode.</para>
        /// <para>For more information about economical mode, see <a href="https://help.aliyun.com/document_detail/63353.html">economical mode for pay-as-you-go instances</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Terminate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>The maximum hourly price for the instance. It supports up to three decimal places. This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.97</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding policy for the pay-as-you-go instance. This parameter takes effect only when InstanceChargeType is set to PostPaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: spot instance with a maximum price.</description></item>
        /// <item><description>SpotAsPriceGo: spot instance for which the system automatically places bids based on the market price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the storage set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// <para>The maximum number of partitions in the storage set. Valid values: integers greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The tag configurations of the instance, cloud disks, and primary ENI.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesRequestTag> Tag { get; set; }
        public class RunInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance, cloud disks, and primary ENI. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance, cloud disks, and primary ENI. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to create the instance on a dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: creates the instance on a non-dedicated host.</description></item>
        /// <item><description>host: creates the instance on a dedicated host. If you do not specify DedicatedHostId, Alibaba Cloud automatically selects a dedicated host to place the instance.
        /// Default value: default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically append sequential suffixes to HostName and InstanceName when you create multiple instances. The sequential suffix starts from 001 and increments up to 999. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Appends sequential suffixes.</description></item>
        /// <item><description>false: Does not append sequential suffixes.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>If HostName or InstanceName is set in a specified sorting format without the name_suffix naming suffix, meaning the naming format is name_prefix[begin_number,bits], UniqueSuffix does not take effect, and the names are sorted only in the specified order.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Specify sequential instance names or hostnames</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>The instance user data. The data must be Base64-encoded, and the size of the custom data before Base64 encoding cannot exceed 32 KB.</para>
        /// <para>For more information about the limits, format, and execution frequency of instance user data, see <a href="https://help.aliyun.com/document_detail/49121.html">Instance user data</a>.</para>
        /// <remarks>
        /// <para>To ensure the security of UserData during transmission, avoid transmitting sensitive data such as passwords and private keys in plaintext. If you need to transmit such information, we recommend that you encrypt the data first, encode it in Base64, and then decrypt it inside the instance to ensure information security.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. If you create a VPC-type ECS instance, you must specify a vSwitch ID, and the security group and the vSwitch must belong to the same VPC. You can call <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> to query information about created vSwitches.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify the VSwitchId parameter, the ZoneId parameter must be set to the zone where the vSwitch resides. You can also leave ZoneId unspecified, and the system automatically selects the zone where the specified vSwitch resides.</para>
        /// </description></item>
        /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you cannot specify VSwitchId. You can only specify NetworkInterface.N.VSwitchId.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> to obtain the zone list.</para>
        /// <remarks>
        /// <para>If you specify the VSwitchId parameter, the ZoneId parameter must be set to the zone where the vSwitch resides. You can also leave the ZoneId parameter unspecified, and the system automatically selects the zone where the specified vSwitch resides.</para>
        /// </remarks>
        /// <para>Default value: automatically selected by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
