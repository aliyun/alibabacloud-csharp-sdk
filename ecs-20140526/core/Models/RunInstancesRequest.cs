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
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Numa")]
            [Validation(Required=false)]
            public string Numa { get; set; }

            /// <summary>
            /// <para>The number of threads per CPU core. The number of vCPUs of an ECS instance = <c>CpuOptions.Core</c> value × <c>CpuOptions.ThreadsPerCore</c> value.</para>
            /// <list type="bullet">
            /// <item><description><para><c>CpuOptions.ThreadsPerCore=1</c> indicates that hyper-threading is disabled.</para>
            /// </description></item>
            /// <item><description><para>Only specific instance types support custom CPU thread counts.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;For the valid values and default value, see <a href="https://help.aliyun.com/document_detail/145895.html">Custom CPU options</a>.</para>
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
            /// <item><description>ContinuousCoreToHTMapping: The hyper-threads (HTs) within the same core in the CPU topology of the instance are continuous.</description></item>
            /// <item><description>DiscreteCoreToHTMapping: The HTs within the same core in the CPU topology of the instance are discrete.</description></item>
            /// </list>
            /// <para>Default value: null.</para>
            /// <remarks>
            /// <para>Only specific instance families support this parameter. For more information about the supported instance families, see <a href="https://help.aliyun.com/document_detail/2636059.html">View and modify CPU topology</a>.</para>
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
            /// <para>The private pool ID, which is the ID of the elasticity assurance or capacity reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The private pool options for instance startup. A private pool is generated after an elasticity assurance or capacity reservation takes effect. You can select a private pool when you start an instance. Valid values:</para>
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
            /// <para>Specifies the dedicated host cluster for the ECS instance. The system automatically selects a dedicated host from the specified cluster to deploy the ECS instance.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <c>Tenancy</c> is set to <c>host</c>.</para>
            /// </remarks>
            /// <para>If you specify both a dedicated host (<c>DedicatedHostId</c>) and a dedicated host cluster (<c>SchedulerOptions.DedicatedHostClusterId</c>):</para>
            /// <list type="bullet">
            /// <item><description>If the dedicated host belongs to the dedicated host cluster, the ECS instance is preferentially deployed on the specified dedicated host.</description></item>
            /// <item><description>If the dedicated host does not belong to the dedicated host cluster, the ECS instance fails to be created.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;You can call <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a> to query the list of dedicated host cluster IDs.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;You can call <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a> to query the list of dedicated host cluster IDs.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;You can call <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a> to query the list of dedicated host cluster IDs.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>Enclave</para>
            /// </summary>
            [NameInMap("ConfidentialComputingMode")]
            [Validation(Required=false)]
            public string ConfidentialComputingMode { get; set; }

            /// <summary>
            /// <para>The trusted system mode. Valid value: vTPM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vTPM</para>
            /// </summary>
            [NameInMap("TrustedSystemMode")]
            [Validation(Required=false)]
            public string TrustedSystemMode { get; set; }

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
            /// <item><description>If InstanceType is set to a retired instance type that is not I/O optimized, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, for instance types that support only cloud_essd, the default value is changed from cloud_efficiency to cloud_essd PL0. For more information, see <a href="https://www.aliyun.com/notice/117844">Change announcement</a>.</description></item>
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
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length and can contain characters from the Unicode letter category (including English and Chinese characters and digits). The name can contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The performance level of the enterprise SSD used as the system disk. Settings for the performance level when you create an enterprise SSD (standard SSD not applicable). Valid values:</para>
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
            /// <item><description>Enterprise SSD (ESSD):<list type="bullet">
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
            /// <para>Default value: max{40, size of the image specified by ImageId}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature. Valid values:</para>
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
            /// <item><description><para>true: encrypts the system disk.</para>
            /// </description></item>
            /// <item><description><para>false: does not encrypt the system disk.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>China (Hong Kong) Zone D and Singapore Zone A do not support encrypting the system disk when you create an instance.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a disk based on an encrypted snapshot, you must set the Encrypted parameter to true for the disk to ensure that the created disk uses the key of the account with which the image is shared.</para>
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
            /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>The disk is created from a non-shared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>The disk is created from a shared encrypted snapshot: The service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>The disk is created in a region where block storage account-level default encryption is enabled: The specified account-level key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>Other cases: The service key is used by default.</description></item>
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
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × Capacity - baseline performance}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. If you want to use a disk in a dedicated block storage cluster as the system disk when you create an ECS instance, specify this parameter.</para>
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
        /// <item><description><para>default: The instance is not associated with a dedicated host. When an instance that has economical mode enabled is restarted after it is stopped, the instance is deployed to another dedicated host in the automatic deployment resource pool if the resources of the original dedicated host are insufficient.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with a dedicated host. When an instance that has economical mode enabled is restarted after it is stopped, the instance remains on the original dedicated host. If the resources of the original dedicated host are insufficient, the instance fails to restart.</para>
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
        /// <para>The number of ECS instances that are created depends on the values of Amount and MinAmount:</para>
        /// <list type="bullet">
        /// <item><description><para>If MinAmount is not specified, instances are created based on the value of Amount. If the inventory is insufficient, the API returns a failure and no instances are created.</para>
        /// </description></item>
        /// <item><description><para>If MinAmount is specified:</para>
        /// <list type="bullet">
        /// <item><description>If the available inventory &lt; MinAmount, no ECS instances are created and the API returns a failure.</description></item>
        /// <item><description>If MinAmount ≤ available inventory &lt; Amount, instances are created based on the available inventory and the API returns a success.</description></item>
        /// <item><description>If the available inventory ≥ Amount, instances are created based on the value of Amount and the API returns a success.</description></item>
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
        /// <para>Specifies whether to automatically complete the payment when you create the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The payment is automatically completed.</para>
        /// <remarks>
        /// <para>If the balance of your payment method is insufficient, an abnormal order is generated and can only be canceled. If your payment method has an insufficient balance, set <c>AutoPay</c> to <c>false</c>. An unpaid order is generated, and you can log on to the ECS console to complete the payment.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: An order is generated but the payment is not completed.</para>
        /// <remarks>
        /// <para>When <c>InstanceChargeType</c> is set to <c>PostPaid</c>, <c>AutoPay</c> cannot be set to <c>false</c>.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-01T12:05:00Z</para>
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PrePaid</c>. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>PeriodUnit=Week: 1, 2, and 3.</description></item>
        /// <item><description>PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
            /// <para>The ID of the automatic snapshot policy to apply to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature. Valid values:</para>
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
            /// <para>The <c>cloud_essd_entry</c> value is supported only when <c>InstanceType</c> is set to an instance type in the <c>ecs.u1</c> or <c>ecs.e</c> instance family.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>elastic_ephemeral_disk_standard: elastic ephemeral disk - Standard.</description></item>
            /// <item><description>elastic_ephemeral_disk_premium: elastic ephemeral disk - Premium.</description></item>
            /// </list>
            /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.
            /// Default value description:</para>
            /// <list type="bullet">
            /// <item><description>If InstanceType is set to a retired instance type that is not I/O optimized, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, if the I/O optimized instance type does not support cloud_auto, the default value is cloud_efficiency. Otherwise, the default value is cloud_auto, and performance burst is enabled by default (which incurs additional fees. For more information, see <a href="~~368372#p_75k_2hp_7gp~~">Billing examples</a>). For more information, see <a href="https://www.aliyun.com/notice/117844">Change announcement</a>.</description></item>
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
            /// <para>The mount point of the data disk. The naming conventions for mount points vary based on the number of data disks attached:</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the data disk. The name must be 2 to 128 characters in length and can contain letters, digits, and characters categorized as letter in Unicode. The name can contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key for the data disk.</para>
            /// <remarks>
            /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>The disk is created from a non-shared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>The disk is created from a shared encrypted snapshot: The service key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>The disk is created in a region where block storage account-level default encryption is enabled: The specified account-level key is used by default.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>Other cases: The service key is used by default.</description></item>
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
            /// <para>Settings for the performance level of the data disk when you create an enterprise SSD as a data disk. The value of N must be the same as that in <c>DataDisk.N.Category=cloud_essd</c>. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × Capacity - baseline performance}.</para>
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
            /// <item><description>cloud_essd: The valid values depend on the value of <c>DataDisk.N.PerformanceLevel</c>. <list type="bullet">
            /// <item><description>PL0: 1 to 65536.</description></item>
            /// <item><description>PL1: 20 to 65536.</description></item>
            /// <item><description>PL2: 461 to 65536.</description></item>
            /// <item><description>PL3: 1261 to 65536.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>cloud: 5 to 2000.</description></item>
            /// <item><description>cloud_auto: 1 to 65536.</description></item>
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
            /// <para>The ID of the snapshot to use to create data disk N. Valid values of N: 1 to 16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. If you want to use a disk in a dedicated block storage cluster as the data disk when you create an ECS instance, specify this parameter.</para>
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
        /// <para>Notice: Dedicated hosts do not support the creation of spot instances. If you specify the <c>DedicatedHostId</c> parameter, the <c>SpotStrategy</c> and <c>SpotPriceLimit</c> settings in the request are automatically ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The release protection property of the instance. Specifies whether the instance can be released from the console or by calling the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables release protection for the instance.</description></item>
        /// <item><description>false: Disables release protection for the instance.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This property applies only to pay-as-you-go instances and only restricts manual release operations. It does not take effect on system-initiated release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>If the deployment set uses the high availability group strategy (AvailabilityGroup), you can use this parameter to specify the group number of the instance in the deployment set. Valid values: 1 to 7.</para>
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
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run without creating the instance. The system checks the required parameters, request syntax, business restrictions, and ECS inventory. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description>false (default): performs a dry run and sends the request. If the check passes, the instance is created.</description></item>
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
        /// <para>The ID of the HPC cluster to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hpc-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the access channel for instance metadata. Valid values:</para>
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
        /// <para>Specifies whether to forcefully use the China Reinforced mode (IMDSv2) for accessing instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcefully use the China Reinforced mode.</description></item>
        /// <item><description>required: forcefully uses the China Reinforced mode. After this value is set, the normal mode cannot be used to access instance metadata.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about the modes for accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/150575.html">Instance metadata access mode</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. You can set this parameter to obtain the latest available image from the specified image family to create the instance.</para>
        /// <para>The name must be 2 to 128 characters in length. The name cannot start with a special character, a digit, http://, or https://. The name can contain only the following special characters: periods (.), underscores (_), hyphens (-), and colons (:).</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you set the ImageId parameter, you cannot set this parameter.</description></item>
        /// <item><description>If you do not set the ImageId parameter but the launch template specified by LaunchTemplateId or LaunchTemplateName has ImageId configured, you cannot set this parameter.</description></item>
        /// <item><description>If you do not set ImageId and the launch template specified by LaunchTemplateId or LaunchTemplateName does not have ImageId configured, you can set this parameter.</description></item>
        /// <item><description>If you do not set ImageId and do not set LaunchTemplateId or LaunchTemplateName, you can set this parameter.<remarks>
        /// <para>For information about image families associated with Alibaba Cloud public images, see <a href="https://help.aliyun.com/document_detail/108393.html">Overview of public images</a>.</para>
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
        /// <para>The image ID. Specifies the image resource used to start the instance. You can call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available image resources. If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to determine a launch template, and do not specify <c>ImageFamily</c> to use the latest available image from an image family, <c>ImageId</c> is required.</para>
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
            /// <para>Indicates whether instances that use this image support logon as the ecs-user user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: supported.</para>
            /// </description></item>
            /// <item><description><para>false: not supported.</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;If you set this parameter to PrePaid, make sure that your account supports balance payment or credit payment. Otherwise, the <c>InvalidPayMethod</c> error is returned.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;If you set this parameter to PrePaid, make sure that your account supports credit payment. Otherwise, the <c>InvalidPayMethod</c> error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 128 characters in length and can contain characters from the Unicode letter category (including English and Chinese characters) and digits. The name can contain colons (:), underscores (_), periods (.), or hyphens (-). Default value: the <c>InstanceId</c> of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type of the instance. If you do not specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to determine the launch template, <c>InstanceType</c> is required.  </para>
        /// <list type="bullet">
        /// <item><description>Instance type selection: See <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the performance data of an instance type. You can also see <a href="https://help.aliyun.com/document_detail/58291.html">Best practices for instance type selection</a> to learn how to select instance types.</description></item>
        /// <item><description>Stock query: Call <a href="https://help.aliyun.com/document_detail/66186.html">DescribeAvailableResource</a> to query the resource availability in a specific region or zone.</description></item>
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
        /// <para>In <b>pay-by-traffic</b> mode, the peak inbound and outbound bandwidths are both upper limits and are not guaranteed. When resource contention occurs, the peak bandwidth may be throttled. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth, in Mbit/s. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is an I/O optimized instance. The default value for <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a> is none, which indicates that I/O optimization is disabled. The default value for other instance types is optimized. Valid values:</para>
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
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>Ipv6Address.N</c>, you must set <c>Amount</c> to 1 and cannot set <c>Ipv6AddressCount</c>.</para>
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
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPair_Name</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The launch template ID. For more information, call <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1apo0bbbkuy0rj****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The launch template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LaunchTemplate_Name</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The launch template version. If you specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> but do not specify the launch template version, the default version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public long? LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The minimum number of ECS instances to purchase. Valid values: 1 to 100.</para>
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
            /// <para>Specifies whether to retain the network interface when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The network interface is not retained.</para>
            /// </description></item>
            /// <item><description><para>false: The network interface is retained.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para>This parameter takes effect only on secondary ENIs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteOnRelease")]
            [Validation(Required=false)]
            public bool? DeleteOnRelease { get; set; }

            /// <summary>
            /// <para>The description of the network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Network_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the network interface controller (NIC). The valid values of N cannot exceed the number of network interface controllers (NICs) supported by the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or invoke <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the number of network interface controllers (NICs) supported by the target instance type.</para>
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
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>. If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter cannot be specified.</para>
            /// </description></item>
            /// <item><description><para>If you specify this parameter, <c>Amount</c> can only be set to 1, and you cannot specify <c>Ipv6AddressCount</c>, <c>Ipv6Address.N</c>, or <c>NetworkInterface.N.Ipv6AddressCount</c>.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<string> Ipv6Address { get; set; }

            /// <summary>
            /// <para>The number of randomly generated IPv6 addresses for the primary ENI. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public long? Ipv6AddressCount { get; set; }

            /// <summary>
            /// <para>The index of the physical network card specified for the ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetworkCardIndex")]
            [Validation(Required=false)]
            public int? NetworkCardIndex { get; set; }

            /// <summary>
            /// <para>The ID of the ENI to attach to the instance.</para>
            /// <para>After you set this parameter, the value of <c>Amount</c> can only be 1.</para>
            /// <remarks>
            /// <para>This parameter takes effect only for secondary ENIs. After you specify an existing secondary ENI, you cannot configure other ENI creation parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1gn106np8jhxhj****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The name of the ENI. The name must be 2 to 128 characters in length and can contain characters that are categorized as letter in Unicode, including but not limited to English letters, Chinese characters, and digits. The name can contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N cannot exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</para>
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
            /// <para>The communication mode of the ENI. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: Uses the TCP communication mode.</description></item>
            /// <item><description>HighPerformance: Enables the Elastic RDMA Interface (ERI) and uses the RDMA communication mode.</description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para>The number of ENIs in RDMA mode cannot exceed the limit of the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>Adds a network interface controller (NIC) and sets the primary IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>172.16.**.**</c></para>
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// <para>The number of queues supported by the ENI.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>The value of N cannot exceed the maximum number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the maximum number of ENIs supported by the target instance type.</para>
            /// </description></item>
            /// <item><description><para>The value cannot exceed the maximum number of queues per ENI allowed by the instance type.</para>
            /// </description></item>
            /// <item><description><para>The total number of queues across all ENIs on the instance cannot exceed the total queue quota allowed by the instance type. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields for the maximum number of queues per ENI and the total queue quota of the instance type.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary and this parameter is specified, you cannot specify the NetworkInterfaceQueueNumber parameter.</para>
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
            /// <para>The number of queue pairs for the RDMA network interface.</para>
            /// <para>If you want to attach multiple RDMA network interfaces to the instance being created, we recommend that you manually specify QueuePairNumber for each network interface based on the upper limit of <c>QueuePairNumber</c> supported by the instance type and the number of network interfaces you plan to use. Ensure that the total QueuePairNumber across all network interfaces does not exceed the maximum value allowed by the instance type. Call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the upper limits of the instance type.</para>
            /// <remarks>
            /// <para>Notice: If QueuePairNumber is not specified for an RDMA network interface, the upper limit of QueuePairNumber for all RDMA network interfaces supported by the instance type is used by default. Therefore, once an RDMA network interface without QueuePairNumber specified is attached, no more RDMA network interfaces can be added (regular network interfaces are not affected by this restriction).</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public long? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The inbound queue depth of the network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("RxQueueSize")]
            [Validation(Required=false)]
            public int? RxQueueSize { get; set; }

            /// <summary>
            /// <para>The number of secondary private IPv4 addresses for the ENI. Valid values: 1 to 49.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SecondaryPrivateIpAddressCount")]
            [Validation(Required=false)]
            public int? SecondaryPrivateIpAddressCount { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the network interface controller (NIC) belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>One or more security group IDs to which the ENI belongs.</para>
            /// <list type="bullet">
            /// <item><description>The valid values of N for the first index do not exceed the number of ENIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the number of ENIs supported by the target instance type.</description></item>
            /// <item><description>The second N indicates that you can specify one or more security group IDs. The valid values of N are related to the quota of security groups that an instance can join. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
            /// </list>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you must specify this parameter or <c>NetworkInterface.N.SecurityGroupId</c>. In this case, this parameter has the same effect as <c>SecurityGroupIds.N</c>, but you cannot specify <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupId</c> at the same time.</para>
            /// </description></item>
            /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Secondary</c> or left empty, this parameter is optional. Default value: the security group to which the ECS instance belongs.</para>
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
            /// <para>Specifies whether to enable source/destination checking. Enable this feature to improve network security. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Not enabled.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Only some regions support this feature. Before you use this feature, read <a href="https://help.aliyun.com/document_detail/2863210.html">Source/destination checking</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SourceDestCheck")]
            [Validation(Required=false)]
            public bool? SourceDestCheck { get; set; }

            /// <summary>
            /// <para>The outbound queue depth of the network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("TxQueueSize")]
            [Validation(Required=false)]
            public int? TxQueueSize { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the network interface controller (NIC) belongs.</para>
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
        /// <item><description><para>The total number of queues for all ENIs on the instance cannot exceed the queue quota allowed by the instance type. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields for the maximum number of queues per ENI and the total queue quota of an instance type.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>NetworkInterfaceQueueNumber</c>. Set <c>NetworkInterface.N.QueueNumber</c> instead.</para>
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
            /// <para>The bandwidth weight value of the instance. The valid values vary by instance type. To query the supported bandwidth weight levels for a specific instance type, call DescribeInstanceTypes. The BandwidthWeighting field in the response indicates the supported bandwidth weight levels. You can use the name field in the returned values as the dictionary value, such as Vpc-L1 or Ebs-L1.</para>
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
            /// <item><description><para>false: does not enable Jumbo Frame. The MTU of all NICs (including the primary ENI and secondary ENIs) on the instance is set to 1500.</para>
            /// </description></item>
            /// <item><description><para>true: enables Jumbo Frame. The MTU of all NICs (including the primary ENI and secondary ENIs) on the instance is set to 8500.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para>Only some instance types of the eighth generation or later support the Jumbo Frame feature. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">ECS instance MTU</a>.</para>
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
        /// <item><description>true: The preset password of the image is used.</description></item>
        /// <item><description>false: The preset password of the image is not used.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>When you use this parameter, the Password parameter must be empty. Make sure that the image has a preset password.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The duration of the subscription. Unit: specified by PeriodUnit. This parameter is required and takes effect only when InstanceChargeType is set to PrePaid. If DedicatedHostId is specified, the value of this parameter cannot exceed the remaining subscription duration of the dedicated host. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is set to Week, valid values of Period: 1, 2, 3, and 4.</description></item>
        /// <item><description>If PeriodUnit is set to Month, valid values of Period: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;If PeriodUnit is set to Month, valid values of Period: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Week</description></item>
        /// <item><description>Month (default)</description></item>
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
        /// <para>The private DNS name configuration of the instance.</para>
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class RunInstancesRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// <para>Enables or disables DNS AAAA record resolution from the instance ID-based domain name to the IPv6 address. Valid values:</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIpDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsARecord { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable reverse DNS resolution from IPv4 addresses to domain names. Valid values:</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("HostnameType")]
            [Validation(Required=false)]
            public string HostnameType { get; set; }

        }

        /// <summary>
        /// <para>The private IP address of the instance. For a VPC-type ECS instance, the private IP address must be from the idle CIDR block of the vSwitch specified by <c>VSwitchId</c>.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the new instance belongs. Instances within the same security group can communicate with each other. The maximum number of instances that a security group can contain depends on the security group type. For more information, see the security group section in <a href="~~25412#SecurityGroupQuota~~">Limits</a>.</para>
        /// <remarks>
        /// <para>The <c>SecurityGroupId</c> parameter determines the network type of the instance. For example, if the specified security group is of the Virtual Private Cloud (VPC) type, the instance is a VPC-type instance, and you must also specify the <c>VSwitchId</c> parameter.</para>
        /// </remarks>
        /// <para>If you do not set <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to specify a launch template, the security group ID is required. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>You can set <c>SecurityGroupId</c> to specify a single security group, or set <c>SecurityGroupIds.N</c> to specify one or more security groups. However, you cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c> at the same time.</para>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c>. In this case, you can only set <c>NetworkInterface.N.SecurityGroupId</c> or <c>NetworkInterface.N.SecurityGroupIds.N</c>.</para>
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
        /// <para>Adds the instance to multiple security groups. The valid values of N depend on the maximum number of security groups to which an instance can belong. For more information, see <a href="https://help.aliyun.com/document_detail/101348.html">Security group limits</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The retention period of the spot instance, in hours. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The interruption pattern of the spot instance. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the instance. This value supports up to three decimal places. This parameter takes effect when the <c>SpotStrategy</c> parameter is set to <c>SpotWithPriceLimit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.97</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding policy for the pay-as-you-go instance. This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: a spot instance with a maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: a spot instance for which the system automatically bids, following the current market price.</description></item>
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
        /// <para>The tag information for the instance, disks, and primary ENI.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesRequestTag> Tag { get; set; }
        public class RunInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key for the instance, disks, and primary ENI. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. The tag key cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value for the instance, disks, and primary ENI. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically append sequential suffixes to <c>HostName</c> and <c>InstanceName</c> when you create multiple instances. The sequential suffix ranges from 001 to 999. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>The instance user data. The data must be Base64-encoded. The maximum size of the raw data before Base64 encoding is 32 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. If you are creating a VPC-type ECS instance, you must specify a vSwitch ID. The security group and the vSwitch must belong to the same VPC. You can call <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> to query created vSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> to query the zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
