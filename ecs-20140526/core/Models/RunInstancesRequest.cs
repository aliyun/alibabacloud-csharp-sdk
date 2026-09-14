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
            /// <para>&lt;props=&quot;china&quot;&gt;Default value: see <a href="https://help.aliyun.com/document_detail/145895.html">Customize CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Numa")]
            [Validation(Required=false)]
            public string Numa { get; set; }

            /// <summary>
            /// <para>The number of threads per CPU core. The number of vCPUs for an ECS instance equals <c>CpuOptions.Core</c> × <c>CpuOptions.ThreadsPerCore</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>Setting <c>CpuOptions.ThreadsPerCore=1</c> disables hyper-threading.</para>
            /// </description></item>
            /// <item><description><para>Only some instance types support configuring the number of threads per core.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;For valid values and default values, see <a href="https://help.aliyun.com/document_detail/145895.html">Customize CPU options</a>.</para>
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
            /// <item><description>ContinuousCoreToHTMapping: In the CPU topology structure, the hyper-threads (HTs) of the same core are contiguous.</description></item>
            /// <item><description>DiscreteCoreToHTMapping: In the CPU topology structure, the HTs of the same core are discrete.</description></item>
            /// </list>
            /// <para>Default value: none.</para>
            /// <remarks>
            /// <para>Only some instance families support this parameter. For the supported instance families, see <a href="https://help.aliyun.com/document_detail/2636059.html">View and modify the CPU topology structure</a>.</para>
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
            /// <para>This parameter is in invitational preview and is not available for general use.</para>
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
            /// <para>This parameter is currently in invitational preview and is not available for use.</para>
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
            /// <para>The private pool capacity option for starting the instance. After an elasticity assurance or capacity reservation takes effect, a private pool is generated for launching instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open mode. The system automatically matches an open private pool. If no matching private pool is available, the instance is launched from the public pool. In this mode, you do not need to set <c>PrivatePoolOptions.Id</c>.</description></item>
            /// <item><description>Target: targeted mode. The instance is launched from the specified private pool. If the specified private pool is unavailable, the instance fails to start. In this mode, you must specify a private pool ID by setting <c>PrivatePoolOptions.Id</c>.</description></item>
            /// <item><description>None: no private pool mode. The instance is launched without using a private pool.</description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// <para>In the following scenarios, the private pool capacity option can only be set to <c>None</c> or left unset:</para>
            /// <list type="bullet">
            /// <item><description>Creating a spot instance.</description></item>
            /// <item><description>Creating an ECS instance on a dedicated host (DDH).</description></item>
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
            /// <para>The ID of the dedicated host cluster to which the ECS instance belongs. The system automatically selects a dedicated host from the specified cluster to deploy the ECS instance.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <c>Tenancy</c> is set to <c>host</c>.</para>
            /// </remarks>
            /// <para>If you specify both a dedicated host (<c>DedicatedHostId</c>) and a dedicated host cluster (<c>SchedulerOptions.DedicatedHostClusterId</c>):</para>
            /// <list type="bullet">
            /// <item><description>If the dedicated host belongs to the specified cluster, the ECS instance is preferentially deployed on the specified dedicated host.</description></item>
            /// <item><description>If the dedicated host does not belong to the specified cluster, the ECS instance fails to be created.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;To query the list of dedicated host cluster IDs, call <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a>.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;To query the list of dedicated host cluster IDs, call <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a>.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;To query the list of dedicated host cluster IDs, call <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a>.</para>
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
            /// <para>Setting this parameter to Enclave means the ECS instance uses Enclave to build a confidential computing environment. Currently, only instance types in instance families c7, g7, and r7 support setting this parameter when invoking <c>RunInstances</c>. Note the following:</para>
            /// <list type="bullet">
            /// <item><description><para>The confidential computing feature is in invitational preview.</para>
            /// </description></item>
            /// <item><description><para>To create an Enclave-based confidential computing instance by invoking an API operation, use <c>RunInstances</c>. <c>CreateInstance</c> does not support the <c>SecurityOptions.ConfidentialComputingMode</c> parameter.</para>
            /// </description></item>
            /// <item><description><para>Enclave-based confidential computing relies on the trusted system (vTPM). If you configure an instance to use Enclave, the trusted system is also enabled. Therefore, if you set <c>SecurityOptions.ConfidentialComputingMode=Enclave</c>, the instance will have both Enclave confidential computing pattern and the trusted system enabled, regardless of whether you set <c>SecurityOptions.TrustedSystemMode=vTPM</c>.</para>
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
            /// <para>The trusted system mode. Set the value to vTPM.</para>
            /// <para>The trusted system mode supports the following instance families:</para>
            /// <list type="bullet">
            /// <item><description>g7, c7, r7.</description></item>
            /// <item><description>Security-enhanced instance families (g7t, c7t, r7t).</description></item>
            /// </list>
            /// <para>If you create an ECS instance that belongs to one of the above instance families, configure this parameter as follows:</para>
            /// <list type="bullet">
            /// <item><description>To use the Alibaba Cloud Trusted System, set this parameter to vTPM. The trusted system then performs a trusted verification when the instance starts.</description></item>
            /// <item><description>If you do not use the Alibaba Cloud Trusted System, you can leave this parameter unset. However, if the instance uses Enclave-based confidential computing (<c>SecurityOptions.ConfidentialComputingMode=Enclave</c>), the trusted system is also enabled.</description></item>
            /// <item><description>To create a trusted instance by invoking an API operation, use <c>RunInstances</c>. <c>CreateInstance</c> does not support the <c>SecurityOptions.TrustedSystemMode</c> parameter.<remarks>
            /// <para>If you configure an instance as a trusted instance at creation time, you can only use images that support the trusted system when replacing the system disk.</para>
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
            /// <para>The disk type of the system disk. Valid values:</para>
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
            /// <item><description>If the instance type is a retired non-I/O optimized instance type, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In all other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, for instance types that support only cloud_essd, the default value changes from cloud_efficiency to cloud_essd PL0. For more information, see <a href="https://www.aliyun.com/notice/117844">Change notice</a>.</description></item>
            /// </list>
            /// <remarks>
            /// <para><c>cloud_essd_entry</c> is supported only when <c>InstanceType</c> is set to <a href="https://help.aliyun.com/document_detail/457079.html">u1, universal instance family</a> (<c>ecs.u1</c>) or <a href="https://help.aliyun.com/document_detail/108489.html">e, economy instance family</a> (<c>ecs.e</c>).</para>
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
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length and can contain Unicode letters (including English, Chinese, and digits). It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The performance level of the enterprise SSD used as the system disk. This parameter takes effect when you create an enterprise SSD as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: maximum random read/write IOPS of 10,000 per disk.</description></item>
            /// <item><description>PL1 (default): maximum random read/write IOPS of 50,000 per disk.</description></item>
            /// <item><description>PL2: maximum random read/write IOPS of 100,000 per disk.</description></item>
            /// <item><description>PL3: maximum random read/write IOPS of 1,000,000 per disk.</description></item>
            /// </list>
            /// <para>For information about how to choose an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values:</para>
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
            /// <para>The value must be greater than or equal to max{1, ImageSize}.</para>
            /// <para>Default value: max{40, the size of the image specified by the ImageId parameter}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst feature (performance burst). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: yes.</description></item>
            /// <item><description>false: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is valid only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
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
            /// <para>This parameter is not available for use.</para>
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
            /// <item><description><para>true: encrypts the system disk.</para>
            /// </description></item>
            /// <item><description><para>false: does not encrypt the system disk.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Encrypting the system disk during instance creation is not supported in China (Hong Kong) Zone D or Singapore Zone A.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a disk based on an encrypted snapshot, you must set the request parameter Encrypted=true for the disk to ensure that the disk uses the key of the account with which the image is shared.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used for the system disk.</para>
            /// <remarks>
            /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption. The KMSKeyId value is returned after the instance is created successfully.</para>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>Disk created from a non-shared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>Disk created from a shared encrypted snapshot: The service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>Disk created in a region where account-level default encryption for block storage is enabled: The specified account-level key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>All other cases: The service key is used by default.</description></item>
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
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × capacity − baseline performance}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
            /// <remarks>
            /// <para>This parameter is valid only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. If you want to use a disk from a dedicated block storage cluster as the system disk when creating an ECS instance, set this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
            /// </summary>
            [NameInMap("StorageClusterId")]
            [Validation(Required=false)]
            public string StorageClusterId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to associate the instance with a dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The instance is not associated with a dedicated host. If the instance is stopped in economical mode and then restarted, and the original dedicated host has insufficient resources, the instance is placed on another dedicated host in the automatic deployment resource pool.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with a dedicated host. If the instance is stopped in economical mode and then restarted, it remains on the original dedicated host. If the original dedicated host has insufficient resources, the restart fails.</para>
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
        /// <para>The number of instances successfully created depends on the values of Amount and MinAmount:</para>
        /// <list type="bullet">
        /// <item><description><para>If MinAmount is not specified: instances are created according to the Amount value. If inventory is insufficient, the API returns a creation failure and no instances are created.</para>
        /// </description></item>
        /// <item><description><para>If MinAmount is specified:</para>
        /// <list type="bullet">
        /// <item><description>If the available ECS inventory &lt; MinAmount: no instances are created and the API returns a creation failure.</description></item>
        /// <item><description>If MinAmount ≤ available ECS inventory &lt; Amount: instances are created based on the available inventory and the API returns a creation success.</description></item>
        /// <item><description>If the available ECS inventory ≥ Amount: instances are created according to the specified Amount and the API returns a creation success.</description></item>
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
        /// <para>This parameter is not available for use.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<RunInstancesRequestArn> Arn { get; set; }
        public class RunInstancesRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available for use.</para>
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
            /// <para>This parameter is not available for use.</para>
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
            /// <para>This parameter is not available for use.</para>
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
        /// <para>Specifies whether to automatically complete the payment when creating an instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: automatically completes the payment.</para>
        /// <remarks>
        /// <para>If automatic payment is enabled, make sure that your payment method has sufficient balance. Otherwise, an abnormal order is generated and can only be voided. If your payment method has insufficient balance, set <c>AutoPay</c> to <c>false</c>. An unpaid order is then generated, which you can pay for in the ECS console.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: generates an order without charging.</para>
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
        /// <para>The automatic release time for pay-as-you-go instances. Specify the time in <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> format in UTC+0. The format is <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If the seconds (<c>ss</c>) value is not <c>00</c>, it is automatically set to the start of the current minute (<c>mm</c>).</para>
        /// </description></item>
        /// <item><description><para>The earliest release time is 30 minutes from the current time.</para>
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
        /// <para>The auto-renewal period for a single renewal. Valid values: </para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>When PeriodUnit=Week: 1, 2, 3.</description></item>
        /// <item><description>When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, 60.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token used to ensure the idempotency of the request. Generate a unique value for this parameter from your client to ensure that different requests use different values. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotency</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance clock parameters.</para>
        /// </summary>
        [NameInMap("ClockOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestClockOptions ClockOptions { get; set; }
        public class RunInstancesRequestClockOptions : TeaModel {
            /// <summary>
            /// <para>The PTP status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: enables PTP.</para>
            /// </description></item>
            /// <item><description><para>disabled: disables PTP.</para>
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
        /// <para>Sets the running mode of a burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard mode. For more information about the performance of instances in standard mode, see the performance constraint mode section in <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances</a>.</description></item>
        /// <item><description>Unlimited: unlimited mode. For more information about the performance of instances in unlimited mode, see the unlimited mode section in <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The list of data disk information collections.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<RunInstancesRequestDataDisk> DataDisk { get; set; }
        public class RunInstancesRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst feature (performance burst). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: yes.</description></item>
            /// <item><description>false: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is valid only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
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
            /// <item><description>cloud_essd: enterprise SSD.</description></item>
            /// <item><description>cloud: basic disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// <item><description>cloud_regional_disk_auto: regional Enterprise SSD (ESSD).</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.<remarks>
            /// <para>This value is supported only when <c>InstanceType</c> is set to an instance type in the <c>ecs.u1</c> or <c>ecs.e</c> instance family.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>elastic_ephemeral_disk_standard: elastic ephemeral disk - standard edition.</description></item>
            /// <item><description>elastic_ephemeral_disk_premium: elastic ephemeral disk - premium edition.</description></item>
            /// </list>
            /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.
            /// Default value description:</para>
            /// <list type="bullet">
            /// <item><description>If InstanceType is a retired non-I/O optimized instance type, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In all other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt; After January 30, 2026, if the I/O optimized instance type does not support cloud_auto, the default value is cloud_efficiency. Otherwise, the default value is cloud_auto, and performance burst is enabled by default (additional fees apply; for details, see <a href="~~368372#p_75k_2hp_7gp~~">Billing examples</a>). For more information, see the <a href="https://www.aliyun.com/notice/117844">change notice</a>.</description></item>
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
            /// <para>The mount point of the data disk. The naming convention for mount points varies based on the number of data disks attached:</para>
            /// <list type="bullet">
            /// <item><description><para>1 to 25 data disks: /dev/xvd<c>[b-z]</c></para>
            /// </description></item>
            /// <item><description><para>More than 25 data disks: /dev/xvd<c>[aa-zz]</c>. For example, the 26th data disk is named /dev/xvdaa, the 27th is /dev/xvdab, and so on.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is used only for full images (system images). You can set this parameter to the mount point of a data disk in the full image, and modify the corresponding <c>DataDisk.N.Size</c> and <c>DataDisk.N.Category</c> parameters to change the category and size of that data disk.</description></item>
            /// <item><description>When you create an instance from a full image, the data disks in the full image are created as the first 1 to n data disks of the ECS instance.</description></item>
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
            /// <para>The name of the data disk. The name must be 2 to 128 characters in length and can contain Unicode characters in the letter category, including letters in English, Chinese, and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdData</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available for use.</para>
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
            /// <item><description>true: encrypts the data disk.</description></item>
            /// <item><description>false: does not encrypt the data disk.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a disk based on an encrypted snapshot, you must set the request parameter Encrypted=true for the disk to ensure that the disk uses the key of the account with which the image is shared.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used for the data disk.</para>
            /// <remarks>
            /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption. The KMSKeyId value is returned after the instance is created successfully.</para>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>Disk created from a non-shared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>Disk created from a shared encrypted snapshot: The service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>Disk created in a region where account-level default encryption for block storage is enabled: The specified account-level key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>All other cases: The service key is used by default.</description></item>
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
            /// <para>Settings for the performance level of the enterprise SSD (ESSD) used as the data disk. The value of N must match the N in <c>DataDisk.N.Category=cloud_essd</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: maximum random read/write IOPS of 10,000 per disk.</description></item>
            /// <item><description>PL1 (default): maximum random read/write IOPS of 50,000 per disk.</description></item>
            /// <item><description>PL2: maximum random read/write IOPS of 100,000 per disk.</description></item>
            /// <item><description>PL3: maximum random read/write IOPS of 1,000,000 per disk.</description></item>
            /// </list>
            /// <para>For information about how to choose an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × capacity − baseline performance}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
            /// <remarks>
            /// <para>This parameter is valid only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of data disk N, in GiB. The valid values of N range from 1 to 16. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: 20 to 32768.</description></item>
            /// <item><description>cloud_ssd: 20 to 32768.</description></item>
            /// <item><description>cloud_essd: The valid range depends on the value of <c>DataDisk.N.PerformanceLevel</c>. <list type="bullet">
            /// <item><description>PL0: 1 to 65,536.</description></item>
            /// <item><description>PL1: 20 to 65,536.</description></item>
            /// <item><description>PL2: 461 to 65,536.</description></item>
            /// <item><description>PL3: 1,261 to 65,536.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>cloud: 5 to 2,000.</description></item>
            /// <item><description>cloud_auto: 1 to 65,536.</description></item>
            /// <item><description>cloud_essd_entry: 10 to 32,768.</description></item>
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
            /// <para>The snapshot used to create data disk N. The valid values of N range from 1 to 16.</para>
            /// <para>If <c>DataDisk.N.SnapshotId</c> is specified, <c>DataDisk.N.Size</c> is ignored. The size of the created disk equals the size of the specified snapshot. Snapshots created on or before July 15, 2013 are not supported. Requests that use such snapshots are rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. If you want to use a disk from a dedicated block storage cluster as a data disk when creating an ECS instance, set this parameter.</para>
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
        /// <para>Notice: Dedicated hosts do not support spot instances. If <c>DedicatedHostId</c> is specified, the <c>SpotStrategy</c> and <c>SpotPriceLimit</c> settings in the request are automatically ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the instance. This parameter controls whether the instance can be released through the console or by calling <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a>. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: enables deletion protection.</description></item>
        /// <item><description>false: disables deletion protection.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter applies only to pay-as-you-go instances. It prevents manual release only and does not apply to system-initiated release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The group number of the instance within the deployment set. This parameter applies when the deployment set uses the AvailabilityGroup strategy. Valid values: 1 to 7.</para>
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
        /// <para>Specifies whether to perform only a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a check request without creating the instance. The check includes whether required parameters are specified, the request format, business limits, and ECS inventory. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description>false (default): sends a normal request. After passing the check, the instance is created immediately.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The hostname of the instance. The following limits apply:</para>
        /// <list type="bullet">
        /// <item><description>Periods (.) and hyphens (-) cannot be used as the first or last character, and cannot be used consecutively.</description></item>
        /// <item><description>Windows instances: The hostname must be 2 to 15 characters in length. Periods (.) are not supported. The hostname cannot consist of digits only. It can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>Other instance types (such as Linux):<list type="bullet">
        /// <item><description>The hostname must be 2 to 64 characters in length. Multiple periods (.) are supported. Each segment between periods can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>You can use the placeholder <c>${instance_id}</c> to write the instance ID into the <c>HostName</c> parameter. For example, if <c>HostName=k8s-${instance_id}</c> and the ECS instance ID is <c>i-123abc****</c>, the hostname of the instance is <c>k8s-i-123abc****</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>When creating multiple ECS instances, you can:</para>
        /// <list type="bullet">
        /// <item><description>Set sequential hostnames in batch. For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Set sequential instance names or hostnames in batch</a>.</description></item>
        /// <item><description>Use the <c>HostNames.N</c> parameter to set a different hostname for each instance. Note that <c>HostName</c> and <c>HostNames.N</c> cannot be specified at the same time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-ecshost</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The hostnames of instances when you create multiple instances at a time. Each instance is assigned a unique hostname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-host-01</para>
        /// </summary>
        [NameInMap("HostNames")]
        [Validation(Required=false)]
        public List<string> HostNames { get; set; }

        /// <summary>
        /// <para>The ID of the HPC cluster to which the instance belongs. </para>
        /// <para>This parameter is required when creating an SCC instance. You can create an HPC cluster by referring to <a href="https://help.aliyun.com/document_detail/109138.html">CreateHpcCluster</a>.</para>
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
        /// <para>This parameter is not available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enforce the use of the hardened mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not enforce the use of the hardened mode.</description></item>
        /// <item><description>required: enforces the use of the hardened mode. After you set this value, the normal mode cannot be used to access instance metadata.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about the modes for accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/150575.html">Access modes for instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. Set this parameter to use the latest available image from the specified image family to create the instance.</para>
        /// <para>The name must be 2 to 128 characters in length. It cannot start with a special character, a digit, <c>http://</c>, or <c>https://</c>. It can contain only the following special characters: periods (.), underscores (_), hyphens (-), and colons (:).</para>
        /// <para>Note the following:</para>
        /// <list type="bullet">
        /// <item><description>If <c>ImageId</c> is specified, do not set this parameter.</description></item>
        /// <item><description>If <c>ImageId</c> is not specified but the launch template identified by <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> has <c>ImageId</c> configured, do not set this parameter.</description></item>
        /// <item><description>If <c>ImageId</c> is not specified and the launch template identified by <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> does not have <c>ImageId</c> configured, you can set this parameter.</description></item>
        /// <item><description>If <c>ImageId</c> is not specified and neither <c>LaunchTemplateId</c> nor <c>LaunchTemplateName</c> is specified, you can set this parameter.<remarks>
        /// <para>For image family information associated with Alibaba Cloud official images, see <a href="https://help.aliyun.com/document_detail/108393.html">Public image overview</a>.</para>
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
        /// <para>The ID of the image used to create the instance. You can call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available images. If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to identify a launch template, and do not use <c>ImageFamily</c> to select the latest available image from an image family, ImageId is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_2_1903_x64_20G_alibase_20200324.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image-related attributes.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestImageOptions ImageOptions { get; set; }
        public class RunInstancesRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether the instance that uses this image supports logon as the ecs-user user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: yes.</para>
            /// </description></item>
            /// <item><description><para>false: no.</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;If you select subscription, make sure your account supports balance payment or credit payment. Otherwise, the error <c>InvalidPayMethod</c> is returned.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;If you select subscription, make sure your account supports credit payment. Otherwise, the error <c>InvalidPayMethod</c> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 128 characters in length and can contain Unicode letters (including English and Chinese characters) and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-). The default value is the <c>InstanceId</c> of the instance.</para>
        /// <para>When creating multiple ECS instances, you can set sequential instance names in batch. The name can contain brackets ([]) and commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Set sequential instance names or hostnames in batch</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to identify a launch template, InstanceType is required.</para>
        /// <list type="bullet">
        /// <item><description>To select an instance type: see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the performance data of a target instance type. You can also see <a href="https://help.aliyun.com/document_detail/58291.html">Select instance types</a> for guidance on how to choose an instance type.</description></item>
        /// <item><description>To check inventory: invoke <a href="https://help.aliyun.com/document_detail/66186.html">DescribeAvailableResource</a> to query resource availability in a specified region or zone.</description></item>
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
        /// <para>In <b>pay-by-traffic</b> mode, the peak inbound and outbound bandwidth values are upper limits and are not guaranteed. When resource contention occurs, the peak bandwidth may be limited. If your workloads require guaranteed bandwidth, use <b>pay-by-bandwidth</b> mode.</para>
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
        /// <para>Specifies whether the instance is an I/O optimized instance. The default value for <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a> is none. The default value for all other instance types is optimized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: not I/O optimized.</description></item>
        /// <item><description>optimized: I/O optimized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>One or more IPv6 addresses assigned to the primary ENI. You can specify up to 10 IPv6 addresses. The valid values of N range from 1 to 10.</para>
        /// <para>Example: <c>Ipv6Address.1=2001:db8:1234:1a00::***</c>.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>Ipv6Address.N</c> is set, <c>Amount</c> can only be set to 1, and you cannot set <c>Ipv6AddressCount</c> at the same time.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>Ipv6Addresses.N</c> or <c>Ipv6AddressCount</c>. Set <c>NetworkInterface.N.Ipv6Addresses.N</c> or <c>NetworkInterface.N.Ipv6AddressCount</c> instead.</para>
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
        /// <para>Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>You cannot specify both <c>Ipv6Address.N</c> and <c>Ipv6AddressCount</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>Ipv6Address.N</c> or <c>Ipv6AddressCount</c>. Use <c>NetworkInterface.N.Ipv6Address.N</c> or <c>NetworkInterface.N.Ipv6AddressCount</c> instead.</para>
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
        /// <para>This parameter is currently in invitational preview and is not available for use.</para>
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
        /// <para>This parameter is ignored for Windows instances and is empty by default. Even if this parameter is specified, only the <c>Password</c> content is used.</para>
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
        /// <para>When creating an instance from a launch template, you must specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to identify the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1apo0bbbkuy0rj****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the launch template.</para>
        /// <para>When creating an instance from a launch template, you must specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to identify the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LaunchTemplate_Name</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The version of the launch template. If you specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> without specifying a version number, the default version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public long? LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The unique identifier of the platform-managed host, such as mh-f2d3647ca21****.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mh-f2d3647ca21****</para>
        /// </summary>
        [NameInMap("ManagedHostId")]
        [Validation(Required=false)]
        public string ManagedHostId { get; set; }

        /// <summary>
        /// <para>The minimum number of ECS instances to purchase. Valid values: 1 to 100.</para>
        /// <para>The number of instances successfully created depends on the values of Amount and MinAmount:</para>
        /// <list type="bullet">
        /// <item><description><para>If MinAmount is not specified: instances are created according to the Amount value. If inventory is insufficient, the API returns a creation failure and no instances are created.</para>
        /// </description></item>
        /// <item><description><para>If MinAmount is specified:</para>
        /// <list type="bullet">
        /// <item><description>If the available ECS inventory &lt; MinAmount: no instances are created and the API returns a creation failure.</description></item>
        /// <item><description>If MinAmount ≤ available ECS inventory &lt; Amount: instances are created based on the available inventory and the API returns a creation success.</description></item>
        /// <item><description>If the available ECS inventory ≥ Amount: instances are created according to the specified Amount and the API returns a creation success.</description></item>
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
        /// <para>The network interface controller (NIC) information.</para>
        /// </summary>
        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<RunInstancesRequestNetworkInterface> NetworkInterface { get; set; }
        public class RunInstancesRequestNetworkInterface : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retain the ENI when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The ENI is not retained.</para>
            /// </description></item>
            /// <item><description><para>false: The ENI is retained.</para>
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
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>The valid values of N must not exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</description></item>
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
            /// <para>The type of the Elastic Network Interface (ENI). The valid values of N must not exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</para>
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
            /// <para>One or more IPv6 addresses assigned to the primary ENI. You can specify up to 10 IPv6 addresses. The valid values of the second N range from 1 to 10.</para>
            /// <para>Example: <c>Ipv6Address.1=2001:db8:1234:1a00::***</c></para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>. If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, you cannot set this parameter.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is set, <c>Amount</c> can only be set to 1, and you cannot set <c>Ipv6AddressCount</c>, <c>Ipv6Address.N</c>, or <c>NetworkInterface.N.Ipv6AddressCount</c> at the same time.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<string> Ipv6Address { get; set; }

            /// <summary>
            /// <para>The number of randomly generated IPv6 addresses assigned to the primary ENI. Valid values: 1 to 10.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>. If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, you cannot set this parameter.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is set, you cannot set <c>Ipv6AddressCount</c>, <c>Ipv6Address.N</c>, or <c>NetworkInterface.N.Ipv6Address.N</c> at the same time.</para>
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
            /// <para>The index of the physical network card assigned to the ENI.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>Only specific instance types support specifying a physical network card index.</description></item>
            /// <item><description>If NetworkInterface.N.InstanceType is set to Primary, and the instance type supports physical network cards, you can only set this parameter to 0.</description></item>
            /// <item><description>If NetworkInterface.N.InstanceType is set to Secondary or left empty, and the instance type supports physical network cards, you can set this parameter based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetworkCardIndex")]
            [Validation(Required=false)]
            public int? NetworkCardIndex { get; set; }

            /// <summary>
            /// <para>The ID of the Elastic Network Interface (ENI) to attach to the instance.</para>
            /// <para>If this parameter is set, <c>Amount</c> can only be set to 1.</para>
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
            /// <para>The name of the Elastic Network Interface (ENI). The name must be 2 to 128 characters in length and can contain Unicode characters in the letter categorization, including letters in English, Chinese, and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N must not exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</para>
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
            /// <para>The communication pattern of the Elastic Network Interface (ENI). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: uses the TCP communication mode.</description></item>
            /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication mode.</description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para>The number of ENIs in RDMA mode cannot exceed the limit for the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The primary IP address of the Elastic Network Interface (ENI) to add.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N must not exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</para>
            /// <list type="bullet">
            /// <item><description>When you add one ENI, you can add one primary ENI or one secondary ENI. If <c>Amount</c> is greater than 1 and you configure a primary ENI with this parameter, the system assigns consecutive primary IP addresses to multiple ECS instances starting from the specified IP address in batch. In this case, you cannot attach a secondary ENI to the instances.</description></item>
            /// <item><description>If <c>Amount</c> is greater than 1 and this parameter is set for the primary ENI, you cannot configure a secondary ENI (that is, you cannot set <c>NetworkInterface.2.InstanceType=Secondary</c>).</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, this parameter has the same effect as <c>PrivateIpAddress</c>. However, you cannot set both <c>PrivateIpAddress</c> and this parameter at the same time.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter specifies the primary IP address of the secondary ENI. By default, a random IP address is allocated from the CIDR block of the vSwitch to which the ENI belongs.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The first and last three IP addresses of each vSwitch CIDR block are system reserved IP addresses and cannot be specified. For example, if the vSwitch CIDR block is 192.168.1.0/24, the addresses 192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255 are reserved.</para>
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
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N must not exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>The value cannot exceed the maximum number of queues per ENI allowed by the instance type.</para>
            /// </description></item>
            /// <item><description><para>The total number of queues across all ENIs on the instance cannot exceed the total queue quota for the instance type. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the <c>MaximumQueueNumberPerEni</c> and <c>TotalEniQueueQuantity</c> fields for the maximum number of queues per ENI and the total queue quota.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c> and this parameter is set, you cannot set <c>NetworkInterfaceQueueNumber</c> at the same time.</para>
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
            /// <para>The number of queue pairs for the RDMA ENI.</para>
            /// <para>If you plan to attach multiple RDMA ENIs to the instance, set QueuePairNumber for each ENI based on the maximum QueuePairNumber supported by the instance type and the number of ENIs you plan to use. Make sure the total QueuePairNumber across all ENIs does not exceed the maximum allowed for the instance type. Call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the limit for the instance type.</para>
            /// <remarks>
            /// <para>Notice: If QueuePairNumber is not specified for an RDMA ENI, the maximum QueuePairNumber supported by the instance type is used by default. Therefore, once you attach an RDMA ENI without specifying QueuePairNumber, you cannot attach additional RDMA ENIs (this restriction does not apply to standard ENIs).</notice></para>
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
            /// <para>This parameter is in invitational preview and is not available for general use. To use this parameter, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a>.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available for general use. To use this parameter, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a>.</para>
            /// </remarks>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter applies only to seventh-generation and later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter currently applies only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger inbound queue depth improves inbound throughput and reduces packet loss, but consumes more memory.</para>
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
            /// <para>The number of secondary private IPv4 addresses to assign to the network interface controller (NIC). Valid values: 1 to 49.</para>
            /// <list type="bullet">
            /// <item><description>The value cannot exceed the IP address limit for the instance type. For more information, see <a href="~~~25378~~">Instance families</a>.</description></item>
            /// <item><description><c>NetworkInterface.N.SecondaryPrivateIpAddressCount</c> specifies the number of secondary private IPv4 addresses to allocate to the ENI (excluding the primary private IP address of the ENI). The system randomly allocates the addresses from the available CIDR block of the vSwitch (<c>NetworkInterface.N.VSwitchId</c>) to which the ENI belongs.</description></item>
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
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N must not exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, this parameter is required. It has the same effect as <c>SecurityGroupId</c>. However, you cannot set <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupIds.N</c> at the same time.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter is optional. The default value is the security group of the ECS instance.</para>
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
            /// <item><description>The valid values of N must not exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</description></item>
            /// <item><description>The second N indicates that you can specify one or more security group IDs. The valid values of the second N depend on the maximum number of security groups to which an instance can belong. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
            /// </list>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you must set this parameter or <c>NetworkInterface.N.SecurityGroupId</c>. This parameter has the same effect as <c>SecurityGroupIds.N</c>. However, you cannot set <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupId</c> at the same time.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter is optional. The default value is the security group of the ECS instance.</para>
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
            /// <item><description><para>true: yes.</para>
            /// </description></item>
            /// <item><description><para>false: no.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>This feature is supported only in certain regions. Before using it, read <a href="https://help.aliyun.com/document_detail/2863210.html">Source/destination checking</a> carefully.</para>
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
            /// <para>This parameter is in invitational preview and is not available for general use. To use this parameter, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a>.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available for general use. To use this parameter, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a>.</para>
            /// </remarks>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter applies only to seventh-generation and later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter currently applies only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger outbound queue depth improves outbound throughput and reduces packet loss, but consumes more memory.</para>
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
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>The valid values of N must not exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, this parameter is required. It has the same effect as <c>VSwitchId</c>. However, you cannot set <c>VSwitchId</c> at the same time.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter is optional. The default value is the vSwitch of the ECS instance.</para>
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
        /// <para>The number of queues for the primary ENI. Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot exceed the maximum number of queues per ENI allowed by the instance type.</para>
        /// </description></item>
        /// <item><description><para>The total number of queues across all ENIs on the instance cannot exceed the total queue quota for the instance type. To query the maximum number of queues per ENI and the total queue quota for an instance type, call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> and check the <c>MaximumQueueNumberPerEni</c> and <c>TotalEniQueueQuantity</c> fields.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>NetworkInterfaceQueueNumber</c>. Use <c>NetworkInterface.N.QueueNumber</c> instead.</para>
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
        /// <para>The network-related parameters.</para>
        /// </summary>
        [NameInMap("NetworkOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestNetworkOptions NetworkOptions { get; set; }
        public class RunInstancesRequestNetworkOptions : TeaModel {
            /// <summary>
            /// <para>The bandwidth weight of the instance. The valid values vary by instance type. To query the bandwidth weight tiers supported by a specific instance type, call DescribeInstanceTypes. The BandwidthWeighting field in the response lists the supported tiers. You can use the name field values from the response, such as Vpc-L1 and Ebs-L1.</para>
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
            /// <item><description><para>false: disables Jumbo Frame. The MTU of all ENIs on the instance (including the primary ENI and secondary ENIs) is set to 1500.</para>
            /// </description></item>
            /// <item><description><para>true: enables Jumbo Frame. The MTU of all ENIs on the instance (including the primary ENI and secondary ENIs) is set to 8500.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para>Only some eighth-generation and later instance types support the Jumbo Frame feature. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">ECS instance MTU</a>.</para>
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
            /// <para>This parameter is in invitational preview and is not available for general use.</para>
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
        /// <para>The logon password of the instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify <c>Password</c>, use HTTPS to send the request to prevent password leakage.</para>
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
        /// <item><description>true: uses the preset password.</description></item>
        /// <item><description>false: does not use the preset password.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>When you use this parameter, the Password parameter must be empty, and the image you use must have a password configured.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription period of the resource. The unit is specified by <c>PeriodUnit</c>. This parameter takes effect and is required only when <c>InstanceChargeType</c> is set to <c>PrePaid</c>. If <c>DedicatedHostId</c> is specified, the value cannot exceed the subscription period of the dedicated host. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>When PeriodUnit=Week: 1, 2, 3, 4.</description></item>
        /// <item><description>When PeriodUnit=Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;When PeriodUnit=Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription billing period. Valid values:</para>
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
        /// <para>The private DNS name configuration for the instance.</para>
        /// <para>For information about private Private domain resolution, see <a href="https://help.aliyun.com/document_detail/2844797.html">ECS private Private domain resolution</a>.</para>
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class RunInstancesRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable DNS resolution from the instance ID-based domain name to an IPv6 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enabled.</para>
            /// </description></item>
            /// <item><description><para>false: disabled.</para>
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
            /// <para>Specifies whether to enable DNS resolution from the instance ID-based domain name to an IPv4 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enabled.</para>
            /// </description></item>
            /// <item><description><para>false: disabled.</para>
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
            /// <para>Specifies whether to enable DNS resolution from the IP-based domain name to an IPv4 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled.</description></item>
            /// <item><description>false: disabled.</description></item>
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
            /// <para>Specifies whether to enable reverse DNS resolution from an IPv4 address to the IP-based domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled.</description></item>
            /// <item><description>false: disabled.</description></item>
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
            /// <item><description>Custom: custom hostname.</description></item>
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
        /// <para>The private IP address of the instance. When setting a private IP address for a VPC-type ECS instance, you must select an available IP address from the CIDR block of the vSwitch (VSwitchId).</para>
        /// <para>Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>After you set PrivateIpAddress:</para>
        /// <list type="bullet">
        /// <item><description>If Amount is set to 1, a private IP address is assigned to the created ECS instance.</description></item>
        /// <item><description>If Amount is set to a value greater than 1, the specified private IP address is used as the starting address, and consecutive private IP addresses are assigned to multiple ECS instances in sequence. In this case, secondary ENIs cannot be attached to the instances (that is, NetworkInterface.N.* parameters are not supported).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you cannot set PrivateIpAddress. Set NetworkInterface.N.PrimaryIpAddress instead.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The first IP address and the last three IP addresses of each vSwitch are reserved by the system and cannot be specified.
        /// For example, if the CIDR block of a vSwitch is 192.168.1.0/24, the addresses 192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255 are reserved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role. You can call the RAM API <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query the instance RAM roles you have created.</para>
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
        /// <item><description>Active: enables security hardening. This value applies only to public images.</description></item>
        /// <item><description>Deactive: disables security hardening. This value applies to all image types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the new instance belongs. Instances in the same security group can communicate with each other. The maximum number of instances a security group can contain depends on the security group type. For more information, see the security group section in <a href="~~25412#SecurityGroupQuota~~">Limits</a>.</para>
        /// <remarks>
        /// <para>The network type of the instance is determined by <c>SecurityGroupId</c>. For example, if the security group uses a VPC network, the instance is also VPC-type, and you must also specify <c>VSwitchId</c>.</para>
        /// </remarks>
        /// <para>If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to identify a launch template, the security group ID is required. Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>You can specify one security group using <c>SecurityGroupId</c>, or one or more security groups using <c>SecurityGroupIds.N</c>. You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c> at the same time.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, do not set <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c>. Use <c>NetworkInterface.N.SecurityGroupId</c> or <c>NetworkInterface.N.SecurityGroupIds.N</c> instead.</para>
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
        /// <para>Adds the instance to multiple security groups at the same time. The valid values of N depend on the maximum number of security groups to which an instance can belong. For more information, see <a href="https://help.aliyun.com/document_detail/101348.html">Security group limits</a>.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description>You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c> at the same time.</description></item>
        /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c>. Set <c>NetworkInterface.N.SecurityGroupId</c> or <c>NetworkInterface.N.SecurityGroupIds.N</c> instead.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The retention period of the spot instance. Unit: hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Alibaba Cloud guarantees that the instance runs for 1 hour after creation without being automatically released. After 1 hour, the system compares the bid price against the market price and checks resource inventory in real time to determine whether to retain or revoke the instance.</description></item>
        /// <item><description>0: Alibaba Cloud does not guarantee the runtime of the instance after creation. The system compares the bid price against the market price and checks resource inventory in real time to determine whether to retain or revoke the instance.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter currently supports only the values 0 and 1.</description></item>
        /// <item><description>Spot instances are billed by the second. Choose a retention period based on the expected execution duration of your task.</description></item>
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
        /// <para>The interruption mode for spot instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Terminate: releases the instance immediately.</para>
        /// </description></item>
        /// <item><description><para>Stop: puts the instance into economical mode.</para>
        /// <para>For more information about economical mode, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode for pay-as-you-go instances</a>.</para>
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
        /// <para>The maximum hourly price for the instance. This parameter supports up to three decimal places and takes effect when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.97</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding strategy for pay-as-you-go instances. This parameter takes effect when <c>InstanceChargeType</c> is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: spot instance with a maximum price.</description></item>
        /// <item><description>SpotAsPriceGo: spot instance where the system automatically bids at the current market price.</description></item>
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
        /// <para>The maximum number of partitions in the storage set. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The tags of the instance, disk, and primary ENI.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesRequestTag> Tag { get; set; }
        public class RunInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance, disk, and primary ENI. Valid values of N: 1 to 20. If this parameter is specified, it cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance, disk, and primary ENI. Valid values of N: 1 to 20. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
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
        /// <item><description><para>default: creates a non-dedicated-host instance.</para>
        /// </description></item>
        /// <item><description><para>host: creates a dedicated host instance. If you do not specify <c>DedicatedHostId</c>, Alibaba Cloud automatically selects a dedicated host for the instance.</para>
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
        /// <para>Specifies whether to automatically append a sequential suffix to <c>HostName</c> and <c>InstanceName</c> when creating multiple instances. The sequential suffix starts from 001 and cannot exceed 999. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: appends the suffix.</description></item>
        /// <item><description>false: does not append the suffix.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>If <c>HostName</c> or <c>InstanceName</c> is set in a specified sort format without a name suffix (<c>name_suffix</c>), that is, the naming format is <c>name_prefix[begin_number,bits]</c>, UniqueSuffix does not take effect and names are sorted only in the specified order.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Set sequential instance names or hostnames in batch</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>The custom data of the instance. The data must be Base64-encoded, and the size of the data before Base64 encoding cannot exceed 32 KB.</para>
        /// <para>For information about the limits, formats, and execution frequency of instance user data, see <a href="https://help.aliyun.com/document_detail/49121.html">Instance user data</a>.</para>
        /// <remarks>
        /// <para>To protect the security of UserData during transmission, avoid passing sensitive data such as passwords and private keys in plaintext. If you need to pass such information, encrypt it first and then Base64-encode it. Decrypt the data inside the instance to ensure security.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. If you are creating a VPC-type ECS instance, you must specify a vSwitch ID. The security group and vSwitch must belong to the same VPC. You can call <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> to query information about existing vSwitches.</para>
        /// <para>Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify <c>VSwitchId</c>, the <c>ZoneId</c> you specify must match the zone where the vSwitch resides. You can also omit <c>ZoneId</c>, and the system automatically selects the zone where the specified vSwitch resides.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, do not set <c>VSwitchId</c>. Use <c>NetworkInterface.N.VSwitchId</c> instead.</para>
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
        /// <para>The ID of the zone where the instance resides. You can call <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> to query the list of zones.</para>
        /// <remarks>
        /// <para>If you specify <c>VSwitchId</c>, the <c>ZoneId</c> you specify must match the zone where the vSwitch resides. You can also omit <c>ZoneId</c>, and the system automatically selects the zone where the specified vSwitch resides.</para>
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
