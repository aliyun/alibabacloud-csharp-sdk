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
            /// <para>&lt;props=&quot;china&quot;&gt;Default value: For more information, see <a href="https://help.aliyun.com/document_detail/145895.html">Customize CPU options</a>.</para>
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
            /// <para>The number of threads per CPU core. The number of vCPUs of the ECS instance = <c>CpuOptions.Core</c> value × <c>CpuOptions.ThreadsPerCore</c> value.</para>
            /// <list type="bullet">
            /// <item><description><para><c>CpuOptions.ThreadsPerCore=1</c> indicates that CPU hyper-threading is disabled.</para>
            /// </description></item>
            /// <item><description><para>Only specific instance types support setting the number of threads per CPU core.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;For information about valid values and default values, see <a href="https://help.aliyun.com/document_detail/145895.html">Customize CPU options</a>.</para>
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
            /// <item><description>ContinuousCoreToHTMapping: The hyper-threads (HTs) within the same core of the instance are continuous in the CPU topology.</description></item>
            /// <item><description>DiscreteCoreToHTMapping: The HTs within the same core of the instance are discrete in the CPU topology.</description></item>
            /// </list>
            /// <para>Default value: null.</para>
            /// <remarks>
            /// <para>Only specific instance families support this parameter. For information about supported instance families, see <a href="https://help.aliyun.com/document_detail/2636059.html">View and modify the CPU topology structure</a>.</para>
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
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
            /// <para>The ID of the private pool. The ID of an elasticity assurance or capacity reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The private pool option for launching the instance. After an elasticity assurance or capacity reservation takes effect, a private pool is generated. You can select a private pool when you launch an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open mode. The system automatically matches available open private pool capacity. If no matching private pool capacity is available, public pool resources are used to launch the instance. In this mode, you do not need to specify the <c>PrivatePoolOptions.Id</c> parameter.</description></item>
            /// <item><description>Target: targeted mode. The instance is launched by using the specified private pool capacity. If the specified private pool capacity is unavailable, the instance fails to launch. In this mode, you must specify the private pool ID, which means the <c>PrivatePoolOptions.Id</c> parameter is required.</description></item>
            /// <item><description>None: none mode. No private pool capacity is used to launch the instance.</description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// <para>In any of the following scenarios, the private pool option can only be set to <c>None</c> or left empty:</para>
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
            /// <para>The ID of the dedicated host cluster to which the ECS instance belongs. The system automatically selects a dedicated host in the cluster to deploy the ECS instance.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <c>Tenancy</c> is set to <c>host</c>.</para>
            /// </remarks>
            /// <para>If you specify both a dedicated host (<c>DedicatedHostId</c>) and a dedicated host cluster (<c>SchedulerOptions.DedicatedHostClusterId</c>):</para>
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
            /// <para>The confidential computing mode. Set the value to Enclave.</para>
            /// <para>When this parameter is set to Enclave, the ECS instance uses Enclave to build a confidential computing environment. Currently, only the c7, g7, and r7 instance families support specifying this parameter when you invoke <c>RunInstances</c> to use Enclave-based confidential computing. Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>The confidential computing feature is in invitational preview.</para>
            /// </description></item>
            /// <item><description><para>When you create an Enclave-based confidential computing ECS instance by invoking an OpenAPI operation, you can only invoke <c>RunInstances</c>. <c>CreateInstance</c> does not support the <c>SecurityOptions.ConfidentialComputingMode</c> parameter.</para>
            /// </description></item>
            /// <item><description><para>Enclave-based confidential computing relies on the trusted system (vTPM). When you specify that an ECS instance uses Enclave to build a confidential computing environment, the trusted system is also enabled for the instance. Therefore, when you invoke this operation, if you set <c>SecurityOptions.ConfidentialComputingMode=Enclave</c>, the created ECS instance has both Enclave-based confidential computing mode and the trusted system enabled, regardless of whether you set <c>SecurityOptions.TrustedSystemMode=vTPM</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about confidential computing, see <a href="https://help.aliyun.com/document_detail/203433.html">Build a confidential computing environment by using Enclave</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enclave</para>
            /// </summary>
            [NameInMap("ConfidentialComputingMode")]
            [Validation(Required=false)]
            public string ConfidentialComputingMode { get; set; }

            /// <summary>
            /// <para>The trusted system mode. Set the value to vTPM.</para>
            /// <para>The following instance families support the trusted system mode:</para>
            /// <list type="bullet">
            /// <item><description>g7, c7, and r7.</description></item>
            /// <item><description>Security-enhanced instance families (g7t, c7t, and r7t).</description></item>
            /// </list>
            /// <para>When you create ECS instances of the preceding instance families, you must set this parameter. Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>To use Alibaba Cloud Trusted System, set this parameter to vTPM. The instance is verified by Alibaba Cloud Trusted System when it starts.</description></item>
            /// <item><description>If you do not use Alibaba Cloud Trusted System, you can leave this parameter empty. However, if the ECS instance uses Enclave-based confidential computing (<c>SecurityOptions.ConfidentialComputingMode=Enclave</c>), the trusted system is also enabled for the instance.</description></item>
            /// <item><description>When you create a trusted ECS instance by invoking an OpenAPI operation, you can only invoke <c>RunInstances</c>. <c>CreateInstance</c> does not support the <c>SecurityOptions.TrustedSystemMode</c> parameter.<remarks>
            /// <para>If you specify the instance as a trusted instance during creation, you can only use images that support the trusted system when you replace the system disk.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>For more information about the trusted system, see <a href="https://help.aliyun.com/document_detail/201394.html">Overview of trusted features for security-enhanced instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vTPM</para>
            /// </summary>
            [NameInMap("TrustedSystemMode")]
            [Validation(Required=false)]
            public string TrustedSystemMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable UEFI Secure Boot.</para>
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
            /// <para>The category of the system disk. Valid values:</para>
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
            /// <item><description>If InstanceType is a retired instance type that is not I/O optimized, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt; After January 30, 2026, for instance types that support only cloud_essd, the default value changes from cloud_efficiency to cloud_essd PL0. For more information, refer to <a href="https://www.aliyun.com/notice/117844">Change notice</a>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter supports the <c>cloud_essd_entry</c> value only when <c>InstanceType</c> is set to the <a href="https://help.aliyun.com/document_detail/457079.html">u1, universal instance family</a> (<c>ecs.u1</c>) or the <a href="https://help.aliyun.com/document_detail/108489.html">e, economy instance family</a> (<c>ecs.e</c>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDisk_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length and can contain characters from the Unicode letter category (including English letters, Chinese characters, and digits). It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The performance level of the enterprise SSD used as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1 (default): A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For information about how to select an ESSD performance level, refer to <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk, in GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Basic disk: 20 to 500.</description></item>
            /// <item><description>Enterprise SSD:<list type="bullet">
            /// <item><description>PL0: 1 to 2048.</description></item>
            /// <item><description>PL1: 20 to 2048.</description></item>
            /// <item><description>PL2: 461 to 2048.</description></item>
            /// <item><description>PL3: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>ESSD AutoPL disk: 1 to 2048.</description></item>
            /// <item><description>Other disk types: 20 to 2048.</description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to max{1, ImageSize}.</para>
            /// <para>Default value: max{40, size of the image specified by the ImageId parameter}.</para>
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
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <item><description><para>true: Encrypted.</para>
            /// </description></item>
            /// <item><description><para>false: Not encrypted.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Hong Kong (China) Zone D and Singapore Zone A do not support system disk encryption during instance creation.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a disk based on an encrypted snapshot, you must set the request parameter Encrypted to true for the disk to ensure that the disk uses the key of the image recipient.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key for the system disk.</para>
            /// <remarks>
            /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption. The KMSKeyId value is returned after the instance is created.</para>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>If the disk is created from a non-shared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>If the disk is created from a shared encrypted snapshot: The service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>If the disk is created in a region where account-level default encryption for block storage is enabled: The specified account-level key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>In other cases: The service key is used by default.</description></item>
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
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline Performance}.</para>
            /// <para>Baseline Performance = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <remarks>
            /// <para>This parameter is supported only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. To use a disk in a dedicated block storage cluster as the system disk when you create an ECS instance, set this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
            /// </summary>
            [NameInMap("StorageClusterId")]
            [Validation(Required=false)]
            public string StorageClusterId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the instance on a dedicated host is associated with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The instance is not associated with the dedicated host. When an instance that has economical mode enabled is restarted after being stopped, if the original dedicated host has insufficient resources, the instance is deployed on another dedicated host in the automatic deployment resource pool.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with the dedicated host. When an instance that has economical mode enabled is restarted after being stopped, the instance remains on the original dedicated host. If the original dedicated host has insufficient resources, the instance fails to restart.</para>
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
        /// <para>The number of successfully created ECS instances depends on the specified Amount and minAmount values:</para>
        /// <list type="bullet">
        /// <item><description><para>If minAmount is not specified: Instances are created based on the Amount value. If the inventory is insufficient, the API returns a failure and no instances are created.</para>
        /// </description></item>
        /// <item><description><para>If minAmount is specified:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS inventory &lt; minAmount: No instances are created and the API returns a failure.</description></item>
        /// <item><description>If minAmount ≤ ECS inventory &lt; Amount: Instances are created based on the available inventory and the API returns a success.</description></item>
        /// <item><description>If the ECS inventory ≥ Amount: Instances are created based on the specified Amount and the API returns a success.</description></item>
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
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<RunInstancesRequestArn> Arn { get; set; }
        public class RunInstancesRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
        /// <para>Specifies whether to automatically make automatic payment when you create the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Automatically makes automatic payment.</para>
        /// <remarks>
        /// <para>Make sure that your payment method has a sufficient balance. Otherwise, an abnormal order is generated and can only be canceled. If your payment method has an insufficient balance, set <c>AutoPay</c> to <c>false</c> to generate an unpaid order. Then, log on to the ECS console to pay for the order.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: Generates the order without making automatic payment.</para>
        /// <remarks>
        /// <para>If <c>InstanceChargeType</c> is set to <c>PostPaid</c>, <c>AutoPay</c> cannot be set to <c>false</c>.</para>
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
        /// <para>The automatic release time of the pay-as-you-go instance. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the UTC+0 time zone. The format is <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If the seconds (<c>ss</c>) value is not <c>00</c>, the time is automatically rounded down to the start of the current minute (<c>mm</c>).</para>
        /// </description></item>
        /// <item><description><para>The earliest release time is 30 minutes after the current time.</para>
        /// </description></item>
        /// <item><description><para>The latest release time cannot be more than three years from the current time.</para>
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
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enable auto-renewal.</description></item>
        /// <item><description>false: Disable auto-renewal.</description></item>
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
        /// <para>The auto-renewal period for each renewal. Valid values: </para>
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
        /// <para>A client token used to ensure the idempotence of the request. Generate a unique value from your client. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters in length. For more information, refer to <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The clock-related property parameters of the instance.</para>
        /// </summary>
        [NameInMap("ClockOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestClockOptions ClockOptions { get; set; }
        public class RunInstancesRequestClockOptions : TeaModel {
            /// <summary>
            /// <para>The PTP status. Valid values:</para>
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
        /// <para>The running mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard mode. For more information, see the performance constrained mode section in <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances?</a>.</description></item>
        /// <item><description>Unlimited: unlimited mode. For more information, see the unlimited mode section in <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances?</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The list of data disk information.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<RunInstancesRequestDataDisk> DataDisk { get; set; }
        public class RunInstancesRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy to apply to data disk N.</para>
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
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
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
            /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
            /// <item><description>cloud: basic disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.<remarks>
            /// <para>The <c>cloud_essd_entry</c> value is supported only when <c>InstanceType</c> is set to an instance type in the <c>ecs.u1</c> or <c>ecs.e</c> instance family.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>elastic_ephemeral_disk_standard: elastic ephemeral disk - Standard.</description></item>
            /// <item><description>elastic_ephemeral_disk_premium: elastic ephemeral disk - Premium.</description></item>
            /// </list>
            /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.
            /// Default value description:</para>
            /// <list type="bullet">
            /// <item><description>If InstanceType is a retired and non-I/O optimized instance type, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, if the I/O optimized instance type does not support cloud_auto, the default value is cloud_efficiency. Otherwise, the default value is cloud_auto, and performance burst is enabled by default (which incurs additional fees. For more information, see <a href="~~368372#p_75k_2hp_7gp~~">Billing examples</a>). For more information, see <a href="https://www.aliyun.com/notice/117844">Change notice</a>.</description></item>
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
            /// <item><description>true: The data disk is released when the instance is released.</description></item>
            /// <item><description>false: The data disk is not released when the instance is released.</description></item>
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
            /// <para>The description of the data disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataDisk_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the data disk. The naming convention varies based on the number of data disks attached:</para>
            /// <list type="bullet">
            /// <item><description><para>1 to 25 data disks: /dev/xvd<c>[b-z]</c></para>
            /// </description></item>
            /// <item><description><para>More than 25 data disks: /dev/xvd<c>[aa-zz]</c>. For example, the 26th data disk is named /dev/xvdaa, the 27th data disk is named /dev/xvdab, and so on.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is applicable only to full image (system image) scenarios. You can set this parameter to the mount point of a data disk in the full image and modify the corresponding <c>DataDisk.N.Size</c> and <c>DataDisk.N.Category</c> parameters to change the disk type and size of the data disk in the full image.</description></item>
            /// <item><description>When you create an instance from a full image, the data disks in the full image are created as the first 1 to N data disks of the ECS instance.</description></item>
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
            /// <para>The name of the data disk. The name must be 2 to 128 characters in length and can contain letters, digits, and other characters classified as letters in Unicode (including Chinese characters). The name can contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdData</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
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
            /// <item><description>true: Encrypted.</description></item>
            /// <item><description>false: Not encrypted.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a disk based on an encrypted snapshot, you must set the request parameter Encrypted to true for the disk to ensure that the disk uses the key of the image recipient.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key for the data disk.</para>
            /// <remarks>
            /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption. The KMSKeyId value is returned after the instance is created.</para>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>If the disk is created from a non-shared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>If the disk is created from a shared encrypted snapshot: The service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>If the disk is created in a region where account-level default encryption for block storage is enabled: The specified account-level key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>In other cases: The service key is used by default.</description></item>
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
            /// <para>Settings the performance level of the enterprise SSD (ESSD) used as a data disk. The value of N in this parameter must be the same as the value of N in <c>DataDisk.N.Category=cloud_essd</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1 (default): A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline Performance}.</para>
            /// <para>Baseline Performance = min{1,800 + 50 × Capacity, 50,000}.</para>
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
            /// <item><description>cloud_essd: The valid value range depends on the value of <c>DataDisk.N.PerformanceLevel</c>. <list type="bullet">
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
            /// <para>The value of this parameter must be greater than or equal to the size of the snapshot specified by <c>SnapshotId</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot used to create data disk N. Valid values of N: 1 to 16.</para>
            /// <para>After you specify <c>DataDisk.N.SnapshotId</c>, <c>DataDisk.N.Size</c> is ignored. The actual size of the created disk is the size of the specified snapshot. Snapshots created on or before July 15, 2013 cannot be used. Requests that use such snapshots are rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. To use a disk in a dedicated block storage cluster as the data disk when you create an ECS instance, set this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
            /// </summary>
            [NameInMap("StorageClusterId")]
            [Validation(Required=false)]
            public string StorageClusterId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the dedicated host.
        /// &lt;props=&quot;china&quot;&gt;You can call <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> to query the list of dedicated host IDs.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;You can call <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> to query the list of dedicated host IDs.</para>
        /// <remarks>
        /// <para>Notice: Dedicated hosts do not support the creation of spot instances. If you specify <c>DedicatedHostId</c>, the <c>SpotStrategy</c> and <c>SpotPriceLimit</c> settings in the request are automatically ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable release protection for the instance. This parameter determines whether the instance can be released from the console or by calling the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: Enables release protection.</description></item>
        /// <item><description>false: Disables release protection.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to pay-as-you-go instances. It can only restrict manual release operations and does not take effect on system-initiated releases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The group number of the instance in the deployment set. If the deployment set uses the high availability group strategy (AvailabilityGroup), you can use this parameter to specify the group number. Valid values: 1 to 7.</para>
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
        /// <para>The description of the instance. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance_Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a dry run request without creating instances. The system checks whether the required parameters are specified, whether the request format is valid, whether business restrictions are met, and whether the ECS inventory is sufficient. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description>false (default): Sends a normal request. After the check succeeds, instances are created directly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The hostname of the instance. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The hostname cannot start or end with a period (.) or hyphen (-), and cannot contain consecutive periods or hyphens.</description></item>
        /// <item><description>Windows instances: The hostname must be 2 to 15 characters in length and cannot contain periods (.) or consist entirely of digits. It can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>Other instances (such as Linux):<list type="bullet">
        /// <item><description>The hostname must be 2 to 64 characters in length and can contain multiple periods (.). Each segment between periods can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>You can use the placeholder <c>${instance_id}</c> to include the instance ID in the <c>HostName</c> parameter. For example, if <c>HostName=k8s-${instance_id}</c> and the created ECS instance ID is <c>i-123abc****</c>, the hostname is <c>k8s-i-123abc****</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>When creating multiple ECS instances, you can:</para>
        /// <list type="bullet">
        /// <item><description>Batch configure sequential hostnames. For more information, refer to <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for instances</a>.</description></item>
        /// <item><description>Use the <c>HostNames.N</c> parameter to set hostnames for multiple instances individually. Note that <c>HostName</c> and <c>HostNames.N</c> cannot be set at the same time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-ecshost</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>Specifies a different hostname for each instance when you create multiple instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-host-01</para>
        /// </summary>
        [NameInMap("HostNames")]
        [Validation(Required=false)]
        public List<string> HostNames { get; set; }

        /// <summary>
        /// <para>The ID of the HPC cluster to which the instance belongs. </para>
        /// <para>This parameter is required when you create Super Computing Cluster (SCC) instances. You can create an HPC cluster by referring to <a href="https://help.aliyun.com/document_detail/109138.html">CreateHpcCluster</a>.</para>
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
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para>For information about instance metadata, see <a href="https://help.aliyun.com/document_detail/49122.html">Overview of instance metadata</a>.</para>
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
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully use the security-hardened mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: Does not forcefully use the security-hardened mode.</description></item>
        /// <item><description>required: Forcefully uses the security-hardened mode. After this value is set, instance metadata cannot be accessed in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For information about modes for accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/150575.html">Access mode of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. When you set this parameter, the latest available image from the specified image family is used to create the instance.</para>
        /// <para>The name must be 2 to 128 characters in length. It cannot start with a special character, digit, <c>http://</c>, or <c>https://</c>. It can contain only the following special characters: periods (.), underscores (_), hyphens (-), and colons (:).</para>
        /// <para>Note the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>ImageId</c>, you cannot set this parameter.</description></item>
        /// <item><description>If you do not set <c>ImageId</c>, but the launch template specified by <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> has <c>ImageId</c> configured, you cannot set this parameter.</description></item>
        /// <item><description>If you do not set <c>ImageId</c>, and the launch template specified by <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> does not have <c>ImageId</c> configured, you can set this parameter.</description></item>
        /// <item><description>If you do not set <c>ImageId</c> and do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c>, you can set this parameter.<remarks>
        /// <para>For information about image families associated with Alibaba Cloud public images, refer to <a href="https://help.aliyun.com/document_detail/108393.html">Public image overview</a>.</para>
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
        /// <para>The image ID. Specifies the image resource used to start the instance. You can call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available image resources. If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to use a launch template, and do not specify <c>ImageFamily</c> to use the latest available image from an image family, <c>ImageId</c> is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_2_1903_x64_20G_alibase_20200324.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image-related property information.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestImageOptions ImageOptions { get; set; }
        public class RunInstancesRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether the instance that uses this image supports logon with the ecs-user user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Supported.</para>
            /// </description></item>
            /// <item><description><para>false: Not supported.</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;If you select subscription, make sure that your account supports balance payment or credit payment. Otherwise, the error <c>InvalidPayMethod</c> is returned.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;If you select subscription, make sure that your account supports credit payment. Otherwise, the error <c>InvalidPayMethod</c> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 128 characters in length and can contain characters from the Unicode letter category (including English letters, Chinese characters, and digits). It can also contain colons (:), underscores (_), periods (.), and hyphens (-). The default value is the <c>InstanceId</c> of the instance.</para>
        /// <para>When creating multiple ECS instances, you can batch configure sequential instance names. The names can contain brackets ([]) and commas (,). For more information, refer to <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to use a launch template, <c>InstanceType</c> is required.  </para>
        /// <list type="bullet">
        /// <item><description>Product selection: Refer to <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query performance data for the target instance type. You can also refer to <a href="https://help.aliyun.com/document_detail/58291.html">Best practices for instance type selection</a>.</description></item>
        /// <item><description>Inventory check: Invoke <a href="https://help.aliyun.com/document_detail/66186.html">DescribeAvailableResource</a> to query resource availability in a specific region or zone.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic.</description></item>
        /// </list>
        /// <para>Default value: PayByTraffic.</para>
        /// <remarks>
        /// <para>In <b>pay-by-traffic</b> mode, the peak inbound and outbound bandwidths are upper limits and are not guaranteed. When resource contention occurs, the peak bandwidth may be throttled. If your workloads require guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth, in Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
        /// <item><description>If the purchased outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>InternetMaxBandwidthOut</c>. Default value: the value of <c>InternetMaxBandwidthOut</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth, in Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is an I/O optimized instance. The default value is none for <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a> and optimized for other instance types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: non-I/O optimization.</description></item>
        /// <item><description>optimized: I/O optimization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>Specifies one or more IPv6 addresses for the primary ENI. You can specify up to 10 IPv6 addresses. Valid values of N: 1 to 10.</para>
        /// <para>Example: <c>Ipv6Address.1=2001:db8:1234:1a00::***</c>.</para>
        /// <para>Note the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>Ipv6Address.N</c> is specified, the <c>Amount</c> parameter can only be set to 1, and you cannot set <c>Ipv6AddressCount</c> at the same time.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>Ipv6Addresses.N</c> or <c>Ipv6AddressCount</c>. Instead, set <c>NetworkInterface.N.Ipv6Addresses.N</c> or <c>NetworkInterface.N.Ipv6AddressCount</c>.</para>
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
        /// <para>The number of randomly generated IPv6 addresses to assign to the primary ENI. Valid values: 1 to 10.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>You cannot specify both <c>Ipv6Address.N</c> and <c>Ipv6AddressCount</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot specify <c>Ipv6Address.N</c> or <c>Ipv6AddressCount</c>. Instead, specify <c>NetworkInterface.N.Ipv6Address.N</c> or <c>NetworkInterface.N.Ipv6AddressCount</c>.</para>
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
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The name of the SSH key pair.</para>
        /// <remarks>
        /// <para>For Windows instances, this parameter is ignored. The default value is empty. Even if you specify this parameter, only the <c>Password</c> value is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPair_Name</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The ID of the launch template. For more information, call <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a>.</para>
        /// <para>To create instances by using a launch template, you must specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1apo0bbbkuy0rj****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the launch template.</para>
        /// <para>To create instances by using a launch template, you must specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LaunchTemplate_Name</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The version of the launch template. If you specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> without specifying a version, the default version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public long? LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The minimum number of ECS instances to purchase. Valid values: 1 to 100.</para>
        /// <para>The number of successfully created ECS instances depends on the specified Amount and minAmount values:</para>
        /// <list type="bullet">
        /// <item><description><para>If minAmount is not specified: Instances are created based on the Amount value. If the inventory is insufficient, the API returns a failed response and no instances are created.</para>
        /// </description></item>
        /// <item><description><para>If minAmount is specified:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS inventory &lt; minAmount: No instances are created and the API returns a failed response.</description></item>
        /// <item><description>If minAmount ≤ ECS inventory &lt; Amount: Instances are created based on the available inventory and the API returns a success.</description></item>
        /// <item><description>If the ECS inventory ≥ Amount: Instances are created based on the specified Amount and the API returns a success.</description></item>
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
        /// <para>The Elastic Network Interface (ENI) information.</para>
        /// </summary>
        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<RunInstancesRequestNetworkInterface> NetworkInterface { get; set; }
        public class RunInstancesRequestNetworkInterface : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retain the ENI when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Do not retain.</para>
            /// </description></item>
            /// <item><description><para>false: Retain.</para>
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
            /// <para>The description of the Elastic Network Interface (ENI).</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N do not exceed the maximum number of network interface controllers (NICs) supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of network interface controllers (NICs) supported by the target instance type.</description></item>
            /// <item><description>The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you do not need to set this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Network_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the Elastic Network Interface (ENI). Valid values of N do not exceed the maximum number of network interface controllers (NICs) supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of network interface controllers (NICs) supported by the target instance type.</para>
            /// <para>Valid values:</para>
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
            /// <para>Specifies one or more IPv6 addresses for the primary ENI. You can specify up to 10 IPv6 addresses. Valid values of the second N: 1 to 10.</para>
            /// <para>Example: <c>Ipv6Address.1=2001:db8:1234:1a00::***</c></para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>. If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, you cannot set this parameter.</para>
            /// </description></item>
            /// <item><description><para>After you set this parameter, the <c>Amount</c> value can only be 1, and you cannot set <c>Ipv6AddressCount</c>, <c>Ipv6Address.N</c>, or <c>NetworkInterface.N.Ipv6AddressCount</c>.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<string> Ipv6Address { get; set; }

            /// <summary>
            /// <para>The number of randomly generated IPv6 addresses for the primary ENI. Valid values: 1 to 10.</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>. If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, you cannot set this parameter.</para>
            /// </description></item>
            /// <item><description><para>After you set this parameter, you cannot set <c>Ipv6AddressCount</c>, <c>Ipv6Address.N</c>, or <c>NetworkInterface.N.Ipv6Address.N</c>.</para>
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
            /// <para>The index of the physical network card specified for the network interface controller (NIC).</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description>Only specific instance types support specifying a physical network card index.</description></item>
            /// <item><description>If NetworkInterface.N.InstanceType is set to Primary, for instance types that support physical network cards, this parameter can only be set to 0.</description></item>
            /// <item><description>If NetworkInterface.N.InstanceType is set to Secondary or left empty, for instance types that support physical network cards, this parameter can be set based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetworkCardIndex")]
            [Validation(Required=false)]
            public int? NetworkCardIndex { get; set; }

            /// <summary>
            /// <para>The ID of an existing Elastic Network Interface (ENI) to attach to the instance.</para>
            /// <para>After you set this parameter, the <c>Amount</c> value can only be 1.</para>
            /// <remarks>
            /// <para>This parameter takes effect only for secondary Elastic Network Interfaces (ENIs). After you specify an existing secondary ENI, you cannot configure other network interface controller (NIC) creation parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1gn106np8jhxhj****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The name of the Elastic Network Interface (ENI). The name must be 2 to 128 characters in length and can contain letters, digits, and other characters classified under the letter categorization in Unicode (including Chinese characters). The name can contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N do not exceed the maximum number of network interface controllers (NICs) supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of network interface controllers (NICs) supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you do not need to set this parameter.</para>
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
            /// <para>The communication mode of the Elastic Network Interface (ENI). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: Uses the TCP communication mode.</description></item>
            /// <item><description>HighPerformance: Enables the Elastic RDMA Interface (ERI) and uses the RDMA communication mode.</description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para>The number of RDMA-mode Elastic Network Interfaces (ENIs) cannot exceed the limit imposed by the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>Adds an Elastic Network Interface (ENI) and sets the primary IP address.</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N do not exceed the maximum number of network interface controllers (NICs) supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of network interface controllers (NICs) supported by the target instance type.</para>
            /// <list type="bullet">
            /// <item><description>When you set one ENI, you can set one primary ENI or one secondary ENI. If the <c>Amount</c> parameter is set to a value greater than 1 and the primary ENI is specified with this parameter, consecutive primary IP addresses starting from the specified IP address are allocated to multiple ECS instances during batch creation. In this case, you cannot attach secondary ENIs to the instances.</description></item>
            /// <item><description>If the <c>Amount</c> parameter is set to a value greater than 1 and this parameter is set for the primary ENI, you cannot set a secondary ENI (that is, you cannot set <c>NetworkInterface.2.InstanceType=Secondary</c>).</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, this parameter has the same effect as <c>PrivateIpAddress</c>, but you cannot set the <c>PrivateIpAddress</c> parameter at the same time.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter specifies the primary IP address of the secondary ENI. By default, an IP address is randomly selected from the CIDR block of the vSwitch to which the ENI belongs.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The first and last three IP addresses of each vSwitch CIDR block are system reserved IP addresses and cannot be specified.
            /// For example, if the CIDR block of the vSwitch is 192.168.1.0/24, the IP addresses 192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255 are system reserved IP addresses.</description></item>
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
            /// <para>The number of queues for the Elastic Network Interface (ENI).</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N do not exceed the maximum number of network interface controllers (NICs) supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of network interface controllers (NICs) supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>The value cannot exceed the maximum number of queues per network interface controller (NIC) allowed by the instance type.</para>
            /// </description></item>
            /// <item><description><para>The total number of queues for all network interface controllers (NICs) on the instance cannot exceed the queue quota allowed by the instance type. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the <c>MaximumQueueNumberPerEni</c> and <c>TotalEniQueueQuantity</c> fields for the maximum number of queues per ENI and the total queue quota.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c> and this parameter is set, you cannot set the <c>NetworkInterfaceQueueNumber</c> parameter.</para>
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
            /// <para>If you want to attach multiple RDMA ENIs to the instance, we recommend that you manually specify QueuePairNumber for each ENI based on the upper limit of QueuePairNumber supported by the instance type and the number of ENIs you plan to use. Make sure that the total QueuePairNumber of all ENIs does not exceed the maximum value allowed by the instance type. Call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the upper limit for the instance type.</para>
            /// <remarks>
            /// <para>Notice: If QueuePairNumber is not specified for an RDMA ENI, the upper limit of QueuePairNumber supported by all RDMA ENIs of the instance type is used by default. Therefore, after an RDMA ENI without a specified QueuePairNumber is attached, no more RDMA ENIs can be added (regular ENIs are not affected by this limit).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public long? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The inbound queue depth of the Elastic Network Interface (ENI).</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. To use this feature, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a> to request access.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. To use this feature, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a> to request access.</para>
            /// </remarks>
            /// <para>Note the following items when you use this parameter:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter is applicable only to seventh-generation and later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is currently applicable only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger inbound queue depth can improve inbound throughput and reduce packet loss, but consumes more memory.</para>
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
            /// <para>The number of secondary private IPv4 addresses to allocate to the network interface controller (NIC). Valid values: 1 to 49.</para>
            /// <list type="bullet">
            /// <item><description>The value cannot exceed the IP address limit for the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
            /// <item><description><c>NetworkInterface.N.SecondaryPrivateIpAddressCount</c> specifies the number of secondary private IPv4 addresses to allocate to the network interface controller (NIC) (excluding the primary private IP address of the NIC). The system randomly allocates IP addresses from the available CIDR block of the vSwitch specified by <c>NetworkInterface.N.VSwitchId</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SecondaryPrivateIpAddressCount")]
            [Validation(Required=false)]
            public int? SecondaryPrivateIpAddressCount { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the Elastic Network Interface (ENI) belongs.</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N do not exceed the maximum number of network interface controllers (NICs) supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of network interface controllers (NICs) supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, this parameter is required. In this case, this parameter has the same effect as <c>SecurityGroupId</c>, but you cannot set <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupIds.N</c>.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter is optional. Default value: the security group of the ECS instance.</para>
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
            /// <para>The IDs of one or more security groups to which the Elastic Network Interface (ENI) belongs.</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N do not exceed the maximum number of network interface controllers (NICs) supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of network interface controllers (NICs) supported by the target instance type.</description></item>
            /// <item><description>The second N indicates that you can specify one or more security group IDs. Valid values of N depend on the maximum number of security groups to which an instance can belong. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
            /// </list>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you must set this parameter or <c>NetworkInterface.N.SecurityGroupId</c>. In this case, this parameter has the same effect as <c>SecurityGroupIds.N</c>, but you cannot set <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupId</c>.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter is optional. Default value: the security group of the ECS instance.</para>
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
            /// <para>Specifies whether to enable source/destination checking. We recommend that you enable this feature to improve network security. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>This feature is supported only in specific regions. Before using it, read <a href="https://help.aliyun.com/document_detail/2863210.html">Source/destination checking</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SourceDestCheck")]
            [Validation(Required=false)]
            public bool? SourceDestCheck { get; set; }

            /// <summary>
            /// <para>The outbound queue depth of the Elastic Network Interface (ENI).</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. To use this feature, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a> to request access.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. To use this feature, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a> to request access.</para>
            /// </remarks>
            /// <para>Note the following items when you use this parameter:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter is applicable only to seventh-generation and later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is currently applicable only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger outbound queue depth can improve outbound throughput and reduce packet loss, but consumes more memory.</para>
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
            /// <para>The ID of the vSwitch to which the Elastic Network Interface (ENI) belongs.</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N do not exceed the maximum number of network interface controllers (NICs) supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of network interface controllers (NICs) supported by the target instance type.  </para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, this parameter is required. In this case, this parameter has the same effect as <c>VSwitchId</c>, but you cannot set the <c>VSwitchId</c> parameter at the same time.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter is optional. Default value: the vSwitch to which the ECS instance belongs.</para>
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
        /// <para>The number of queues supported by the primary ENI. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot exceed the maximum number of queues per ENI allowed by the instance type.</para>
        /// </description></item>
        /// <item><description><para>The total number of queues across all ENIs on the instance cannot exceed the queue quota allowed by the instance type. To query the maximum number of queues per ENI and the total queue quota for an instance type, call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation and check the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot specify <c>NetworkInterfaceQueueNumber</c>. Instead, specify <c>NetworkInterface.N.QueueNumber</c>.</para>
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
        /// <para>The network-related property parameters.</para>
        /// </summary>
        [NameInMap("NetworkOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestNetworkOptions NetworkOptions { get; set; }
        public class RunInstancesRequestNetworkOptions : TeaModel {
            /// <summary>
            /// <para>The bandwidth weight value of the instance. Different instance types support different value ranges. You can call DescribeInstanceTypes to query the supported bandwidth weight tiers for a specific instance type. The returned BandwidthWeighting field indicates the supported bandwidth weight tiers. Use the name field in the returned values as the dictionary value, such as Vpc-L1 or Ebs-L1.</para>
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
            /// <item><description><para>false: Disabled. The MTU of all ENIs (including the primary ENI and secondary ENIs) on the instance is set to 1500.</para>
            /// </description></item>
            /// <item><description><para>true: Enabled. The MTU of all ENIs (including the primary ENI and secondary ENIs) on the instance is set to 8500.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para>Only some instance types of the eighth generation and later support the Jumbo Frame feature. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">ECS instance MTU</a>.</para>
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
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
        /// <para>The password of the instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify <c>Password</c>, use HTTPS to send the request to avoid password leaks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EcsV587!</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the password preset in the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Use the preset password.</description></item>
        /// <item><description>false: Do not use the preset password.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>When you use this parameter, the Password parameter must be empty. Make sure that the image you use has a password configured.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription duration of the resource. The unit is specified by <c>PeriodUnit</c>. This parameter takes effect and is required only when <c>InstanceChargeType</c> is set to <c>PrePaid</c>. If <c>DedicatedHostId</c> is specified, the value cannot exceed the subscription duration of the dedicated host. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>When PeriodUnit is set to Week: 1, 2, 3, and 4.</description></item>
        /// <item><description>When PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;When PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values: </para>
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
        /// <para>The private domain name configuration of the instance.</para>
        /// <para>For more information about private private domain resolution, see <a href="https://help.aliyun.com/document_detail/2844797.html">ECS private private domain resolution</a>.</para>
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class RunInstancesRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable DNS resolution from the instance ID-based domain name to the IPv6 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
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
            /// <para>Specifies whether to enable DNS resolution from the instance ID-based domain name to the IPv4 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
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
            /// <para>Specifies whether to enable DNS resolution from the IP-based domain name to the IPv4 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
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
            /// <para>Specifies whether to enable reverse DNS resolution from the IPv4 address to the IP-based domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
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
            /// <item><description>Custom: custom.</description></item>
            /// <item><description>IpBased: IP-based hostname.</description></item>
            /// <item><description>InstanceIdBased: instance ID-based hostname.</description></item>
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
        /// <para>The private IP address of the instance. When you set a private IP address for a VPC-type ECS instance, the IP address must be from an idle CIDR block of the vSwitch (<c>VSwitchId</c>).</para>
        /// <para>Note the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>After you set <c>PrivateIpAddress</c>:</para>
        /// <list type="bullet">
        /// <item><description>If <c>Amount</c> is set to 1, a private IP address is assigned to the created ECS instance.</description></item>
        /// <item><description>If <c>Amount</c> is set to a value greater than 1, the specified private IP address is used as the starting address and consecutive private IP addresses are assigned to the ECS instances created in the batch. In this case, you cannot attach secondary ENIs to the instances (that is, you cannot set <c>NetworkInterface.N.*</c> parameters).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>PrivateIpAddress</c>. Set <c>NetworkInterface.N.PrimaryIpAddress</c> instead.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The first and last three IP addresses of each vSwitch CIDR block are reserved by the system and cannot be specified.
        /// For example, if the CIDR block of a vSwitch is 192.168.1.0/24, the IP addresses 192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255 are reserved by the system.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role. You can call the RAM API <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query the instance RAM roles that you have created.</para>
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
        /// <item><description>Active: Enable security hardening. This value is applicable only to public images.</description></item>
        /// <item><description>Deactive: Disable security hardening. This value is applicable to all image types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the new instance belongs. Instances in the same security group can communicate with each other. The maximum number of instances that a security group can contain varies based on the security group type. For more information, refer to the security group section in <a href="~~25412#SecurityGroupQuota~~">Limits</a>.</para>
        /// <remarks>
        /// <para><c>SecurityGroupId</c> determines the network type of the instance. For example, if the specified security group is of the VPC type, the instance is a VPC-type instance, and you must also specify <c>VSwitchId</c>.</para>
        /// </remarks>
        /// <para>If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to use a launch template, the security group ID is required. Note the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>You can set a single security group by using <c>SecurityGroupId</c>, or set one or more security groups by using <c>SecurityGroupIds.N</c>. You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c> at the same time.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, do not set <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c>. Instead, set <c>NetworkInterface.N.SecurityGroupId</c> or <c>NetworkInterface.N.SecurityGroupIds.N</c>.</para>
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
        /// <para>Adds the instance to multiple security groups at the same time. Valid values of N depend on the maximum number of security groups to which an instance can belong. For more information, see <a href="https://help.aliyun.com/document_detail/101348.html">Security group limits</a>.</para>
        /// <para>Note the following items:</para>
        /// <list type="bullet">
        /// <item><description>You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c>.</description></item>
        /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c>. Instead, set <c>NetworkInterface.N.SecurityGroupId</c> or <c>NetworkInterface.N.SecurityGroupIds.N</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The retention period of the spot instance, in hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After the instance is created, Alibaba Cloud guarantees that the instance runs for 1 hour without automatic release. After 1 hour, the system compares the bid price with the market price and checks the resource inventory in real time to determine whether to retain or reclaim the instance.</description></item>
        /// <item><description>0: After the instance is created, Alibaba Cloud does not guarantee a running duration. The system compares the bid price with the market price and checks the resource inventory in real time to determine whether to retain or reclaim the instance.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter currently supports only the values 0 and 1.</description></item>
        /// <item><description>Spot instances are billed by second. Select an appropriate retention period based on the expected task execution duration.</description></item>
        /// <item><description>Alibaba Cloud sends a notification through an ECS system event 5 minutes before the instance is reclaimed.</description></item>
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
        /// <para>The break mode of the spot instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Terminate: The instance is released directly.</para>
        /// </description></item>
        /// <item><description><para>Stop: The instance enters economical mode.</para>
        /// <para>For more information about economical mode, refer to <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode for pay-as-you-go instances</a>.</para>
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
        /// <para>The maximum hourly price of the instance. This value supports up to three decimal places and takes effect only when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.97</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding strategy for the pay-as-you-go instance. This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: spot instance with a maximum price limit.</description></item>
        /// <item><description>SpotAsPriceGo: spot instance priced at the market price automatically.</description></item>
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
        /// <para>The maximum number of partitions in the storage set. Valid values: greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The tags of the instance, disks, and primary ENI.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesRequestTag> Tag { get; set; }
        public class RunInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance, disks, and primary ENI. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance, disks, and primary ENI. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
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
        /// <item><description><para>default: Creates a non-dedicated-host instance.</para>
        /// </description></item>
        /// <item><description><para>host: Creates an instance on a dedicated host. If you do not specify <c>DedicatedHostId</c>, Alibaba Cloud automatically selects a dedicated host for the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically append sequential suffixes to <c>HostName</c> and <c>InstanceName</c> when creating multiple instances. Sequential suffixes start from 001 and cannot exceed 999. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Append sequential suffixes.</description></item>
        /// <item><description>false: Do not append sequential suffixes.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>When <c>HostName</c> or <c>InstanceName</c> is set in a specified sequential format without the <c>name_suffix</c> naming suffix (that is, the format is <c>name_prefix[begin_number,bits]</c>), <c>UniqueSuffix</c> does not take effect. Names are ordered only based on the specified sequence.</para>
        /// <para>For more information, refer to <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>The instance user data. The data must be Base64-encoded. The size of the raw data before Base64 encoding cannot exceed 32 KB.</para>
        /// <para>For more information about usage limits, formats, and execution frequency of instance user data, refer to <a href="https://help.aliyun.com/document_detail/49121.html">Instance user data</a>.</para>
        /// <remarks>
        /// <para>To ensure the security of UserData during transmission, avoid passing sensitive data such as passwords and private keys in plaintext. If you need to pass such information, encrypt it first, encode it in Base64, and then decrypt it inside the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. If you are creating a VPC-type ECS instance, you must specify a vSwitch ID. The security group and the vSwitch must belong to the same VPC. You can call <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> to query existing vSwitches.</para>
        /// <para>Note the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>VSwitchId</c>, the <c>ZoneId</c> value must match the zone of the vSwitch. You can also leave <c>ZoneId</c> unspecified, and the system automatically selects the zone of the specified vSwitch.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, do not set <c>VSwitchId</c>. Instead, set <c>NetworkInterface.N.VSwitchId</c>.</para>
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
        /// <para>The zone ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> to query available zones.</para>
        /// <remarks>
        /// <para>If you specify <c>VSwitchId</c>, the <c>ZoneId</c> value must match the zone of the vSwitch. You can also leave <c>ZoneId</c> unspecified, and the system automatically selects the zone of the specified vSwitch.</para>
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
