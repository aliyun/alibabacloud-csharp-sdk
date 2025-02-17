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
            /// <para>The number of CPU cores. This parameter cannot be specified but only uses its default value.</para>
            /// <para>For information about the default value, see <a href="https://help.aliyun.com/document_detail/145895.html">Customize CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Numa")]
            [Validation(Required=false)]
            public string Numa { get; set; }

            /// <summary>
            /// <para>The number of threads per CPU core. The following formula is used to calculate the number of vCPUs of the instance: <c>CpuOptions.Core</c> value × <c>CpuOptions.ThreadsPerCore</c> value.</para>
            /// <list type="bullet">
            /// <item><description>If <c>CpuOptionsThreadPerCore</c> is set to 1, Hyper-Threading (HT) is disabled.</description></item>
            /// <item><description>This parameter is applicable only to specific instance types.</description></item>
            /// </list>
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
            /// <item><description>ContinuousCoreToHTMapping: The HT technology allows continuous threads to run on the same core in the CPU topology of the instance.``</description></item>
            /// <item><description>DiscreteCoreToHTMapping: The HT technology allows discrete threads to run on the same core in the CPU topology of the instance.``</description></item>
            /// </list>
            /// <para>This parameter is empty by default.</para>
            /// <remarks>
            /// <para> This parameter is supported only for specific instance families. For more information about the supported instance families, see <a href="https://help.aliyun.com/document_detail/2636059.html">View and modify the CPU topology</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DiscreteCoreToHTMapping</para>
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

        }

        [NameInMap("HibernationOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestHibernationOptions HibernationOptions { get; set; }
        public class RunInstancesRequestHibernationOptions : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is unavailable.</para>
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
            /// <para>The ID of the private pool. The ID of a private pool is the same as that of the elasticity assurance or capacity reservation for which the private pool is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The type of the private pool to use to create the instance. A private pool is generated after an elasticity assurance or a capacity reservation takes effect. You can select the private pool when you start an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open private pool. The system selects a matching open private pool to create the instance. If no matching open private pools are found, resources in the public pool are used. When you set this parameter to Open, you can leave the <c>PrivatePoolOptions.Id</c> parameter empty.</description></item>
            /// <item><description>Target: specified private pool. The system uses the capacity in a specified private pool to create the instance. If the specified private pool is unavailable, the instance cannot be created. If you set this parameter to Target, you must specify the <c>PrivatePoolOptions.Id</c> parameter.</description></item>
            /// <item><description>None: no private pool. The capacity in private pools is not used.</description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// <para>In the following scenarios, the PrivatePoolOptions.MatchCriteria parameter can be set only to <c>None</c> or left empty:</para>
            /// <list type="bullet">
            /// <item><description>A preemptible instance is created.</description></item>
            /// <item><description>The instance is created in the classic network.</description></item>
            /// <item><description>The instance is created on a dedicated host.</description></item>
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
            /// <para>The ID of the dedicated host cluster in which to create the instance. After this parameter is specified, the system selects one dedicated host from the specified cluster to create the instance.</para>
            /// <remarks>
            /// <para>This parameter is valid only when the <c>Tenancy</c> parameter is set to <c>host</c>.</para>
            /// </remarks>
            /// <para>When you specify both the <c>DedicatedHostId</c> and <c>SchedulerOptions.DedicatedHostClusterId</c> parameters, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>If the specified dedicated host belongs to the specified dedicated host cluster, the instance is preferentially deployed on the specified dedicated host.</description></item>
            /// <item><description>If the specified dedicated host does not belong to the specified dedicated host cluster, the instance cannot be created.</description></item>
            /// </list>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/184145.html">DescribeDedicatedHostClusters</a> operation to query the list of dedicated host cluster IDs.</para>
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
            /// <para>A value of Enclave indicates that an enclave-based confidential computing environment is built on the instance. When you call the <c>RunInstances</c> operation, you can set this parameter only for c7, g7, or r7 instances to use enclave-based confidential computing. Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The confidential computing feature is in invitational preview.</description></item>
            /// <item><description>When you use the ECS API to create instances that support enclave-based confidential computing, you can call only the <c>RunInstances</c> operation. The <c>CreateInstance</c> operation does not support the <c>SecurityOptions.ConfidentialComputingMode</c> parameter.</description></item>
            /// <item><description>Enclave-based confidential computing is implemented based on Alibaba Cloud Trusted System (vTPM). When you build a confidential computing environment on an instance by using Enclave, Alibaba Cloud Trusted System is enabled for the instance. If you set <c>SecurityOptions.ConfidentialComputingMode</c> to Enclave when you call this operation, the created instances use enclave-based confidential computing and Alibaba Cloud Trusted System regardless of whether <c>SecurityOptions.TrustedSystemMode</c> is set to vTPM.</description></item>
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
            /// <para>The trusted system mode supports the following instance families:</para>
            /// <list type="bullet">
            /// <item><description>g7, c7, and r7</description></item>
            /// <item><description>Security-enhanced instance families: g7t, c7t, and r7t</description></item>
            /// </list>
            /// <para>When you create instances of the preceding instance families, you must set this parameter. Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>To use the Alibaba Cloud trusted system, set this parameter to vTPM. Then, the Alibaba Cloud trusted system performs trust verifications when the instances start.</description></item>
            /// <item><description>If you do not want to use the Alibaba Cloud trusted system, leave this parameter empty. Note that if your created instances use an enclave-based confidential computing environment (with <c>SecurityOptions.ConfidentialComputingMode</c> set to Enclave), the Alibaba Cloud trusted system is enabled for the instances.</description></item>
            /// <item><description>When you use the ECS API to create instances that use the trusted system, you can call only the <c>RunInstances</c> operation. The <c>CreateInstance</c> operation does not support the <c>SecurityOptions.TrustedSystemMode</c> parameter.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If you have configured an instance as a trusted one when you created the instance, you can use only an image that support the trusted system to replace the system disk of the instance.</para>
            /// </remarks>
            /// <para>For more information about the trusted system, see <a href="https://help.aliyun.com/document_detail/201394.html">Overview</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vTPM</para>
            /// </summary>
            [NameInMap("TrustedSystemMode")]
            [Validation(Required=false)]
            public string TrustedSystemMode { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public RunInstancesRequestSystemDisk SystemDisk { get; set; }
        public class RunInstancesRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy to apply to the system disk.</para>
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
            /// <item><description>cloud_efficiency: utra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>cloud_essd: enhanced SSD (ESSD)</description></item>
            /// <item><description>cloud: basic disk</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk</description></item>
            /// </list>
            /// <remarks>
            /// <para> The value of this parameter can be <c>cloud_essd_entry</c> only when <c>InstanceType</c> is set to <c>ecs.u1</c> or <c>ecs.e</c>. ecs.u1 indicates the u1 universal instance family and ecs.e indicates the e economy instance family. For information about the u1 and e instance families, see the <a href="https://help.aliyun.com/document_detail/457079.html">u1, universal instance family</a> section in the &quot;Universal instance families&quot; topic and the <a href="https://help.aliyun.com/document_detail/108489.html">e, economy instance family</a> section in the &quot;Shared instance families&quot; topic.</para>
            /// </remarks>
            /// <para>For non-I/O optimized instances of retired instance types, the default value is cloud. For other types of instances, the default value is cloud_efficiency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length. The description can contain letters but cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDisk_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length and support Unicode characters under the Decimal Number category and the categories whose names contain Letter. The name can contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD to use as the system disk. Default value: PL1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more information about ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
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
            /// <item><description><para>Basic disk: 20 to 500.</para>
            /// </description></item>
            /// <item><description><para>ESSD: Valid values vary based on the performance level of the ESSD.</para>
            /// <list type="bullet">
            /// <item><description>PL0 ESSD: 1 to 2048.</description></item>
            /// <item><description>PL1 ESSD: 20 to 2048.</description></item>
            /// <item><description>PL2 ESSD: 461 to 2048.</description></item>
            /// <item><description>PL3 ESSD: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ESSD AutoPL disk: 1 to 2048.</para>
            /// </description></item>
            /// <item><description><para>Other disk categories: 20 to 2048.</para>
            /// </description></item>
            /// </list>
            /// <para>The value of this parameter must be at least 1 and greater than or equal to the image size.</para>
            /// <para>Default value: 40 or the image size, whichever is greater.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the performance burst feature for the system disk.</description></item>
            /// <item><description>false: disables the performance burst feature for the system disk.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is available only if you set <c>SystemDisk.Category</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ase-256</para>
            /// </summary>
            [NameInMap("EncryptAlgorithm")]
            [Validation(Required=false)]
            public string EncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: encrypts the system disk.</description></item>
            /// <item><description>false: does not encrypt the system disk.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para> The system disks of instances cannot be encrypted during instance creation in Hong Kong Zone D or Singapore Zone A.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key to use for the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk to use as the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
            /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}</para>
            /// <remarks>
            /// <para> This parameter is available only if you set <c>SystemDisk.Category</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster to which the system disk belongs. If you want to use disks in a dedicated block storage cluster as system disks when you create instances, specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
            /// </summary>
            [NameInMap("StorageClusterId")]
            [Validation(Required=false)]
            public string StorageClusterId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to associate an instance on a dedicated host with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: does not associate the instance with the dedicated host. When you start an instance that was stopped in economical mode, the instance is automatically deployed to another dedicated host in the automatic deployment resource pool if the available resources of the original dedicated host are insufficient.</description></item>
        /// <item><description>host: associates the instance with the dedicated host. When you start an instance that was stopped in economical mode, the instance remains on the original dedicated host. If the available resources of the original dedicated host are insufficient, the instance cannot be started.</description></item>
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
        /// <para>The desired number of ECS instances that you want to create. Valid values: 1 to 100.</para>
        /// <para>The number of ECS instances that can be created varies based on the Amount and MinAmount values.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify MinAmount, the RunInstances operation creates ECS instances based on the Amount value. If the available resources are insufficient to create the desired number of ECS instances, the RunInstances operation returns an error response and no ECS instances are created.</para>
        /// </description></item>
        /// <item><description><para>If you specify MinAmount, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If the available resources are insufficient to create the minimum number of ECS instances, no ECS instances are created and the RunInstances operation returns an error response.</description></item>
        /// <item><description>If the available resources are insufficient to create the desired number of ECS instances but are sufficient to create the minimum number of ECS instances, the RunInstances operation uses the available resources to create ECS instances and returns a success response. In this case, the number of ECS instances that can be created is less than the desired number of ECS instances.</description></item>
        /// <item><description>If the available resources are sufficient to create the desired number of ECS instances, the RunInstances operation uses the available resources to create the desired number of ECS instances and returns a success response.</description></item>
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
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<RunInstancesRequestArn> Arn { get; set; }
        public class RunInstancesRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
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
            /// <para> This parameter is not publicly available.</para>
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
        /// <para>Specifies whether to automatically complete the payment for instance creation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The payment is automatically completed.</para>
        /// <para>**</para>
        /// <para><b>Note</b> Make sure that your account balance is sufficient. Otherwise, your order becomes invalid and is canceled. If your account balance is insufficient, you can set <c>AutoPay</c> to <c>false</c> to generate an unpaid order. Then, you can log on to the ECS console to pay for the order.</para>
        /// </description></item>
        /// <item><description><para>false: An order is generated but no payment is made.</para>
        /// <para>**</para>
        /// <para><b>Note</b> When <c>InstanceChargeType</c> is set to <c>PostPaid</c>, <c>AutoPay</c> cannot be set to <c>false</c>.</para>
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
        /// <para>The time when to automatically release the pay-as-you-go instance. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601 standard</a> in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>If the value of seconds (<c>ss</c>) is not <c>00</c>, the start time is automatically rounded to the nearest minute based on the value of minutes (<c>mm</c>).</description></item>
        /// <item><description>The specified time must be at least 30 minutes later than the current time.</description></item>
        /// <item><description>The specified time can be at most three years later than the current time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-01T12:05:00Z</para>
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. This parameter is valid only when the <c>InstanceChargeType</c> parameter is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: does not enable auto-renewal.</description></item>
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
        /// <para>The auto-renewal period of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PeriodUnit is set to Week: 1, 2, and 3.</description></item>
        /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.**** For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The performance mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: the standard mode. For more information, see the &quot;Standard mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// <item><description>Unlimited: the unlimited mode. For more information, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The data disks.</para>
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
            /// <para>Specifies whether to enable the performance burst feature for data disk N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is available only if you set DataDisk.N.Category to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
            /// <item><description><para>cloud_efficiency: ultra disk</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD</para>
            /// </description></item>
            /// <item><description><para>cloud: basic disk</para>
            /// </description></item>
            /// <item><description><para>cloud_auto: ESSD AutoPL disk</para>
            /// </description></item>
            /// <item><description><para>cloud_essd_entry: ESSD Entry disk</para>
            /// <para>**</para>
            /// <para><b>Note</b> This parameter can be set to <c>cloud_essd_entry</c> only when <c>InstanceType</c> is set to <c>ecs.u1</c> or <c>ecs.e</c>.</para>
            /// </description></item>
            /// <item><description><para>elastic_ephemeral_disk_standard: standard elastic ephemeral disk</para>
            /// </description></item>
            /// <item><description><para>elastic_ephemeral_disk_premium: premium elastic ephemeral disk</para>
            /// </description></item>
            /// </list>
            /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to release data disk N when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>The description of data disk N. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataDisk_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of data disk N. The mount points are named based on the number of data disks:</para>
            /// <list type="bullet">
            /// <item><description>1st to 25th data disks: /dev/xvd<c>[b-z]</c>.</description></item>
            /// <item><description>From the 26th data disk on: /dev/xvd<c>[aa-zz]</c>. For example, the 26th data disk is named /dev/xvdaa, the 27th data disk is named /dev/xvdab, and so on.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is applicable to scenarios in which a full image is used to create instances. A full image is an image that contains an operating system, application software, and business data. For these scenarios, you can set the parameter to the mount point of data disk N contained in the full image and modify the <c>DataDisk.N.Size</c> and <c>DataDisk.N.Category</c> parameters to change the category and size of data disk N created based on the image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of data disk N. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdData</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("EncryptAlgorithm")]
            [Validation(Required=false)]
            public string EncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt data disk N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key to use for data disk N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD to use as data disk N. The value of N must be the same as that in <c>DataDisk.N.Category</c> when DataDisk.N.Category is set to cloud_essd. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1 (default): A single ESSD can deliver up to 50000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1000000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For information about ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk to use as data disk N. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
            /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}</para>
            /// <remarks>
            /// <para> This parameter is available only if you set DataDisk.N.Category to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud_efficiency: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud_ssd: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud_essd: vary based on the value of <c>DataDisk.N.PerformanceLevel</c>.</para>
            /// <list type="bullet">
            /// <item><description>Valid values when DataDisk.N.PerformanceLevel is set to PL0: 1 to 65536.</description></item>
            /// <item><description>Valid values when DataDisk.N.PerformanceLevel is set to PL1: 20 to 65536.</description></item>
            /// <item><description>Valid values when DataDisk.N.PerformanceLevel is set to PL2: 461 to 65536.</description></item>
            /// <item><description>Valid values when DataDisk.N.PerformanceLevel is set to PL3: 1261 to 65536.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud: 5 to 2000.</para>
            /// </description></item>
            /// <item><description><para>Valid values when DiskCategory is set to cloud_auto: 1 to 65536.</para>
            /// </description></item>
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud_essd_entry: 10 to 32768.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> The value of this parameter must be greater than or equal to the size of the snapshot specified by <c>DataDisk.N.SnapshotId</c>.</para>
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
            /// <para>When the <c>DataDisk.N.SnapshotId</c> parameter is specified, the <c>DataDisk.N.Size</c> parameter is ignored. The data disk is created with the size of the specified snapshot. Use snapshots created on or after July 15, 2013. Otherwise, an error is returned and your request is rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster to which data disk N belongs. If you want to use a disk in a dedicated block storage cluster as data disk N when you create the instance, you must specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
            /// </summary>
            [NameInMap("StorageClusterId")]
            [Validation(Required=false)]
            public string StorageClusterId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the dedicated host on which to create the instance. Preemptible instances cannot be created on dedicated hosts. If you specify <c>DedicatedHostId</c>, <c>SpotStrategy</c> and <c>SpotPriceLimit</c> are ignored.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> operation to query the list of dedicated host IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable release protection for the instance. This parameter determines whether you can use the ECS console or call the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation to release the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables release protection for the instance.</description></item>
        /// <item><description>false: disables release protection for the instance.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter is applicable to only pay-as-you-go instances. It can protect instances against manual releases, but not against automatic releases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The number of the deployment set group to which to deploy the instance. If the deployment set specified by the DeploymentSetId parameter uses the high availability group strategy (AvailabilityGroup), you can use the DeploymentSetGroupNo parameter to specify a deployment set group in the deployment set. Valid values: 1 to 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DeploymentSetGroupNo")]
        [Validation(Required=false)]
        public int? DeploymentSetGroupNo { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set to which to deploy the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp1brhwhoqinyjd6****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The description of the instance. The description must be 2 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance_Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the validity of the request without actually making the request. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The validity of the request is checked but the request is not made. Check items include whether required parameters are specified, the request format, service limits, and available ECS resources. If the check fails, the corresponding error code is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false: The validity of the request is checked, and the request is made if the check succeeds.</description></item>
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
        /// <item><description><para>The hostname cannot start or end with a period (.) or hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>For Windows instances, the hostname must be 2 to 15 characters in length and cannot contain periods (.) or contain only digits. It can contain letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>For instances that run other operating systems such as Linux, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The hostname must be 2 to 64 characters in length. You can use periods (.) to separate a hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).</description></item>
        /// <item><description>You can use the <c>${instance_id}</c> placeholder to pass instance IDs into the hostname specified by <c>HostName</c>. For example, if you set <c>HostName</c> to k8s-${instance_id} and the instance is assigned an ID of <c>i-123abc****</c>, the hostname of the instance is <c>k8s-i-123abc****</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>When you create multiple instances, you can perform the following operations:</para>
        /// <list type="bullet">
        /// <item><description>Batch configure sequential hostnames for the instances. For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for multiple instances</a>.</description></item>
        /// <item><description>Use the <c>HostNames.N</c> parameter to configure different hostnames for instances. You cannot specify both the <c>HostName</c> and <c>HostNames.N</c> parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-ecshost</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The hostname of instance N. You can use this parameter to specify different hostnames for multiple instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-host-01</para>
        /// </summary>
        [NameInMap("HostNames")]
        [Validation(Required=false)]
        public List<string> HostNames { get; set; }

        /// <summary>
        /// <para>The ID of the high performance computing (HPC) cluster to which the instance belongs.</para>
        /// <para>This parameter is required when you create instances of a Supper Computing Cluster (SCC) instance type. For information about how to create an HPC cluster, see <a href="https://help.aliyun.com/document_detail/109138.html">CreateHpcCluster</a>.</para>
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
        /// <item><description>enabled</description></item>
        /// <item><description>disabled</description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para>For more information about instance metadata, see <a href="https://help.aliyun.com/document_detail/49122.html">Overview of ECS instance metadata</a>.</para>
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
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully use the security-enhanced mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcefully use the security-enhanced mode (IMDSv2).</description></item>
        /// <item><description>required: forcefully uses the security-enhanced mode (IMDSv2). After you set this parameter to required, you cannot access instance metadata in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about the modes of accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/150575.html">Access mode of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. You can set this parameter to obtain the latest available custom image from the specified image family to create instances.</para>
        /// <para>The name must be 2 to 128 characters in length. The name cannot start with a digit, a special character, http://, or https://. The name can contain letters, digits, periods (.), underscores (_), hyphens (-), and colons (:).</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you specify <c>ImageId</c>, you cannot specify ImageFamily.</description></item>
        /// <item><description>If you do not specify <c>ImageId</c> but use <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to specify a launch template that has <c>ImageId</c> specified, you cannot specify ImageFamily.</description></item>
        /// <item><description>If you do not specify <c>ImageId</c> but use <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to specify a launch template that does not have <c>ImageId</c> specified, you can specify ImageFamily.</description></item>
        /// <item><description>If you do not specify <c>ImageId</c>, <c>LaunchTemplateId</c>, or <c>LaunchTemplateName</c>, you can specify ImageFamily.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For information about image families that are associated with Alibaba Cloud official images, see <a href="https://help.aliyun.com/document_detail/108393.html">Overview of public images</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query available images. If you do not use <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to specify a launch template and do not set <c>ImageFamily</c> to obtain the latest available custom image from a specified image family, you must specify <c>ImageId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_2_1903_x64_20G_alibase_20200324.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>Details about the image options.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestImageOptions ImageOptions { get; set; }
        public class RunInstancesRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether the instance that uses the image supports logons of the ecs-user user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
        /// <item><description>PrePaid: subscription</description></item>
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// <para>If you set this parameter to PrePaid, make sure that your account has sufficient balance or credit. Otherwise, an <c>InvalidPayMethod</c> error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the ECS instance. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-). The default value of this parameter is the <c>InstanceId</c> value.</para>
        /// <para>When you batch create instances, you can batch configure sequential names for the instances. The sequential names can contain brackets ([ ]) and commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for multiple instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. If you do not use <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to specify a launch template, you must set the <c>InstanceType</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description>Select an instance type. See <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the performance data of an instance type, or see <a href="https://help.aliyun.com/document_detail/58291.html">Best practices for instance type selection</a> to learn about how to select instance types.</description></item>
        /// <item><description>Query available resources. Call the <a href="https://help.aliyun.com/document_detail/66186.html">DescribeAvailableResource</a> operation to query available resources in a specific region or zone.</description></item>
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
        /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic</description></item>
        /// </list>
        /// <para>Default value: PayByTraffic.</para>
        /// <remarks>
        /// <para>When the <b>pay-by-traffic</b> billing method for network usage is used, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios where demand outstrips resource supplies, these maximum bandwidth values may not be reached. If you want guaranteed bandwidths for your instance, use the <b>pay-by-bandwidth</b> billing method for network usage.</para>
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
        /// <item><description>When the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of InternetMaxBandwidthIn are 1 to 10, and the default value is 10.</description></item>
        /// <item><description>When the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the <c>InternetMaxBandwidthOut</c> value and the default value is the <c>InternetMaxBandwidthOut</c> value.</description></item>
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
        /// <para>Specifies whether the instance is I/O optimized. For instances of <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a>, the default value is none. For instances of other instance types, the default value is optimized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: The instance is not I/O optimized.</description></item>
        /// <item><description>optimized: The instance is I/O optimized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>IPv6 address N to be assigned to the primary ENI. Valid values of N: 1 to 10.</para>
        /// <para>Example: <c>Ipv6Address.1=2001:db8:1234:1a00::***</c>.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If the <c>Ipv6Address.N</c> parameter is specified, you must set the <c>Amount</c> parameter to 1 and leave the <c>Ipv6AddressCount</c> parameter empty.</description></item>
        /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot set <c>Ipv6Addresses.N</c> or <c>Ipv6AddressCount</c> and must set <c>NetworkInterface.N.Ipv6Addresses.N</c> or <c>NetworkInterface.N.Ipv6AddressCount</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ipv6Address.1=2001:db8:1234:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses to randomly generate for the primary ENI. Valid values: 1 to 10.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You cannot specify both the <c>Ipv6Addresses.N</c> and <c>Ipv6AddressCount</c> parameters.</description></item>
        /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot specify <c>Ipv6Address.N</c> or <c>Ipv6AddressCount</c> but can specify <c>NetworkInterface.N.Ipv6Address.N</c> or <c>NetworkInterface.N.Ipv6AddressCount</c>.</description></item>
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
        /// <para>This parameter is in invitational preview and is unavailable.</para>
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
        /// <remarks>
        /// <para>For Windows instances, this parameter is ignored. This parameter is empty by default. The <c>Password</c> parameter takes effect even if the KeyPairName parameter is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPair_Name</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The ID of the launch template. For more information, call the <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a> operation.</para>
        /// <para>To use a launch template to create an instance, you must use the <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> parameter to specify the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1apo0bbbkuy0rj****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the launch template.</para>
        /// <para>To use a launch template to create an instance, you must use the <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> parameter to specify the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LaunchTemplate_Name</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The version of the launch template. If you set the <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> parameter but do not set the version number of the launch template, the default template version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public long? LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The minimum number of ECS instances that you want to create. Valid values: 1 to 100.</para>
        /// <para>The number of ECS instances that can be created varies based on the Amount and MinAmount values.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify MinAmount, the RunInstances operation creates ECS instances based on the Amount value. If the available resources are insufficient to create the desired number of ECS instances, the RunInstances operation returns an error response and no ECS instances are created.</para>
        /// </description></item>
        /// <item><description><para>If you specify MinAmount, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If the available resources are insufficient to create the minimum number of ECS instances, no ECS instances are created and the RunInstances operation returns an error response.</description></item>
        /// <item><description>If the available resources are insufficient to create the desired number of ECS instances but are sufficient to create the minimum number of ECS instances, the RunInstances operation uses the available resources to create ECS instances and returns a success response. In this case, the number of ECS instances that can be created is less than the desired number of ECS instances.</description></item>
        /// <item><description>If the available resources are sufficient to create the desired number of ECS instances, the RunInstances operation uses the available resources to create the desired number of ECS instances and returns a success response.</description></item>
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
        /// <para>The information of the elastic network interfaces (ENIs).</para>
        /// </summary>
        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<RunInstancesRequestNetworkInterface> NetworkInterface { get; set; }
        public class RunInstancesRequestNetworkInterface : TeaModel {
            /// <summary>
            /// <para>Specifies whether to release ENI N when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para> This parameter takes effect only for secondary ENIs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteOnRelease")]
            [Validation(Required=false)]
            public bool? DeleteOnRelease { get; set; }

            /// <summary>
            /// <para>The description of ENI N.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The value of N cannot exceed the maximum number of ENIs per instance that the instance type supports. For the maximum number of ENIs per instance that an instance type supports, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation.</description></item>
            /// <item><description>The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Primary</c>, you do not need to specify this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Network_Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of ENI N. The value of N cannot exceed the maximum number of ENIs per instance that the instance type supports. For the maximum number of ENIs per instance that an instance type supports, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Primary</description></item>
            /// <item><description>Secondary</description></item>
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
            /// <para>The IPv6 addresses to assign to the primary ENI. You can assign up to 10 IPv6 addresses to the primary ENI. Valid values of the second N: 1 to 10.</para>
            /// <para>Example: <c>Ipv6Address.1=2001:db8:1234:1a00::***</c>.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>. If you set <c>NetworkInterface.N.InstanceType</c> to <c>Secondary</c> or leave NetworkInterface.N.InstanceType empty, you cannot specify this parameter.</description></item>
            /// <item><description>If you specify this parameter, you must set <c>Amount</c> to 1 and cannot specify <c>Ipv6AddressCount</c>, <c>Ipv6Address.N</c>, or <c>NetworkInterface.N.Ipv6AddressCount</c>.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<string> Ipv6Address { get; set; }

            /// <summary>
            /// <para>The number of IPv6 addresses to randomly generate for the primary ENI. Valid values: 1 to 10.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>. If you set <c>NetworkInterface.N.InstanceType</c> to <c>Secondary</c> or leave NetworkInterface.N.InstanceType empty, you cannot specify this parameter.</description></item>
            /// <item><description>If you specify this parameter, you cannot specify <c>Ipv6AddressCount</c>, <c>Ipv6Address.N</c>, or <c>NetworkInterface.N.Ipv6Address.N</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public long? Ipv6AddressCount { get; set; }

            /// <summary>
            /// <para>The index of the network card for ENI N.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>You can specify network card indexes only for instances of specific instance types.</description></item>
            /// <item><description>If you set NetworkInterface.N.InstanceType to Primary, you can set NetworkInterface.N.NetworkCardIndex only to 0 for instance types that support network cards.</description></item>
            /// <item><description>If you set NetworkInterface.N.InstanceType to Secondary or leave NetworkInterface.N.InstanceType empty, you can specify NetworkInterface.N.NetworkCardIndex based on instance types if the instance types support network cards. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetworkCardIndex")]
            [Validation(Required=false)]
            public int? NetworkCardIndex { get; set; }

            /// <summary>
            /// <para>The ID of the ENI to attach to the instance.</para>
            /// <para>If you specify this parameter, you must set <c>Amount</c> to 1.</para>
            /// <remarks>
            /// <para> This parameter takes effect only for secondary ENIs. After you specify an existing secondary ENI, you cannot specify other ENI creation parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1gn106np8jhxhj****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The name of ENI N. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The value of N cannot exceed the maximum number of ENIs per instance that the instance type supports. For the maximum number of ENIs per instance that an instance type supports, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation.</description></item>
            /// <item><description>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Primary</c>, you do not need to specify this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Network_Name</para>
            /// </summary>
            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            /// <summary>
            /// <para>The communication mode of ENI N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: uses the TCP communication mode.</description></item>
            /// <item><description>HighPerformance: uses the remote direct memory access (RDMA) communication mode with Elastic RDMA Interface (ERI) enabled.</description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para> The number of ERIs on an instance cannot exceed the maximum number of ERIs that the instance type supports. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The primary IP address to assign to ENI N.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>The value of N cannot exceed the maximum number of ENIs per instance that the instance type supports. For the maximum number of ENIs per instance that an instance type supports, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation.</para>
            /// <list type="bullet">
            /// <item><description>If the value of N is 1, you can configure a primary or secondary ENI. If you specify this parameter, set <c>Amount</c> to a numeric value greater than 1, and set NetworkInterface.N.InstanceType to Primary, the specified number of instances are created and consecutive primary IP addresses starting from the specified IP address are assigned to the instances. In this case, you cannot attach secondary ENIs to the instances.</description></item>
            /// <item><description>If you specify this parameter, set <c>Amount</c> to a numeric value greater than 1, and set NetworkInterface.N.InstanceType to Primary, you cannot set <c>NetworkInterface.2.InstanceType</c> to Secondary to attach a secondary ENI.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Primary</c>, this parameter is equivalent to <c>PrivateIpAddress</c>. You cannot specify this parameter and <c>PrivateIpAddress</c> in the same request.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Secondary</c> or leave NetworkInterface.N.InstanceType empty, the specified primary IP address is assigned to the secondary ENI. The default value is an IP address that is randomly selected from within the CIDR block of the vSwitch to which to connect the secondary ENI.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>The first IP address and last three IP addresses of each vSwitch CIDR block are reserved. You cannot specify the IP addresses. For example, if a vSwitch CIDR block is 192.168.1.0/24, the following IP addresses are reserved: 192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><c>172.16.**.**</c></para>
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// <para>The number of queues supported by ENI N.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The value of N cannot exceed the maximum number of ENIs per instance that the instance type supports. For the maximum number of ENIs per instance that an instance type supports, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation.</description></item>
            /// <item><description>The value of this parameter cannot exceed the maximum number of queues allowed per ENI.</description></item>
            /// <item><description>The total number of queues for all ENIs on an instance cannot exceed the queue quota for the instance type. To query the maximum number of queues per ENI and the queue quota for an instance type, you can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation and check the <c>MaximumQueueNumberPerEni</c> and <c>TotalEniQueueQuantity</c> values in the response.</description></item>
            /// <item><description>If you specify this parameter and set <c>NetworkInterface.N.InstanceType</c> to <c>Primary</c>, you cannot specify <c>NetworkInterfaceQueueNumber</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queue pairs (QPs) supported by the ERI.</para>
            /// <para>If you want to attach multiple ERIs to a created instance, we recommend that you specify QueuePairNumber for each ERI based on the value of <c>QueuePairNumber</c> supported by the instance type and the number of ERIs that you want to use. Make sure that the total number of QPs of all ERIs does not exceed the maximum number of QPs supported by the instance type. For information about the maximum number of QPs supported by an instance type, see <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a>.</para>
            /// <remarks>
            /// <para> If you do not specify QueuePairNumber for an ERI, the maximum number of QPs supported by the instance type is used as the number of QPs supported by the ERI. In this case, you cannot attach an additional ERI to the instance. However, you can attach other types of ENIs to the instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public long? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The receive (Rx) queue depth of ENI N.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The Rx queue depth of an ENI must be the same as the transmit (Tx) queue depth of the ENI. Valid values: powers of 2 in the range of 8192 to 16384.</description></item>
            /// <item><description>A larger Rx queue depth yields higher inbound throughput but consumes more memory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("RxQueueSize")]
            [Validation(Required=false)]
            public int? RxQueueSize { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which to assign ENI N.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The value of N cannot exceed the maximum number of ENIs per instance that the instance type supports. For the maximum number of ENIs per instance that an instance type supports, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation.</description></item>
            /// <item><description>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Primary</c>, you must specify this parameter. In this case, this parameter is equivalent to <c>SecurityGroupId</c>, and you cannot specify <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupIds.N</c>.</description></item>
            /// <item><description>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Secondary</c> or leave NetworkInterface.N.InstanceType empty, you do not need to specify this parameter. The default value is the ID of the security group to which to assign the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of security groups to which to assign ENI N.</para>
            /// <list type="bullet">
            /// <item><description>The value of the first N in this parameter cannot exceed the maximum number of ENIs per instance that the instance type supports. For the maximum number of ENIs per instance that an instance type supports, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation.</description></item>
            /// <item><description>The second N in this parameter indicates that one or more security group IDs can be specified. The valid values of the second N vary based on the maximum number of security groups to which an instance can belong. For more information, see the <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a> section of the &quot;Limits&quot; topic.</description></item>
            /// </list>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Primary</c>, you must specify this parameter or <c>NetworkInterface.N.SecurityGroupId</c>. In this case, this parameter is equivalent to <c>SecurityGroupIds.N</c>, and you cannot specify <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupId</c>.</description></item>
            /// <item><description>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Secondary</c> or leave NetworkInterface.N.InstanceType empty, you do not need to specify this parameter. The default value is the ID of the security group to which to assign the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp15ed6xe1yxeycg7****</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SourceDestCheck")]
            [Validation(Required=false)]
            public bool? SourceDestCheck { get; set; }

            /// <summary>
            /// <para>The Tx queue depth of ENI N.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The Tx queue depth of an ENI must be the same as the Rx queue depth of the ENI. Valid values: powers of 2 in the range of 8192 to 16384.</description></item>
            /// <item><description>A larger Tx queue depth yields higher outbound throughput but consumes more memory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("TxQueueSize")]
            [Validation(Required=false)]
            public int? TxQueueSize { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which to connect ENI N.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The value of N cannot exceed the maximum number of ENIs per instance that the instance type supports. For the maximum number of ENIs per instance that an instance type supports, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation.</description></item>
            /// <item><description>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Primary</c>, you must specify this parameter. In this case, this parameter is equivalent to <c>VSwitchId</c>. You cannot specify both NetworkInterface.N.VSwitchId and <c>VSwitchId</c> in the same request.</description></item>
            /// <item><description>If you set <c>NetworkInterface.N.InstanceType</c> to <c>Secondary</c> or leave NetworkInterface.N.InstanceType empty, you do not need to specify this parameter. The default value is the VSwitchId value.</description></item>
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
        /// <item><description>The value of this parameter cannot exceed the maximum number of queues per ENI allowed for the instance type.</description></item>
        /// <item><description>The total number of queues for all ENIs on the instance cannot exceed the queue quota for the instance type. To query the maximum number of queues per ENI and the queue quota for an instance type, you can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the <c>MaximumQueueNumberPerEni</c> and <c>TotalEniQueueQuantity</c> values.</description></item>
        /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot specify <c>NetworkInterfaceQueueNumber</c> but can specify <c>NetworkInterface.N.QueueNumber</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("NetworkInterfaceQueueNumber")]
        [Validation(Required=false)]
        public int? NetworkInterfaceQueueNumber { get; set; }

        /// <summary>
        /// <para>Details about network options.</para>
        /// </summary>
        [NameInMap("NetworkOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestNetworkOptions NetworkOptions { get; set; }
        public class RunInstancesRequestNetworkOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the Jumbo Frames feature for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: does not enable the Jumbo Frames feature for the instance. The maximum transmission unit (MTU) value of all ENIs on the instance is set to 1500.</description></item>
            /// <item><description>true: enables the Jumbo Frames feature for the instance. The MTU value of all ENIs on the instance is set to 8500.</description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para> The Jumbo Frames feature is supported by only 8th-generation or later instance types. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">MTUs</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableJumboFrame")]
            [Validation(Required=false)]
            public bool? EnableJumboFrame { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If the <c>Password</c> parameter is specified, we recommend that you send requests over HTTPS to prevent password leaks.</para>
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
        /// <para>If you set this parameter to true, make sure that you leave the Password parameter empty and the selected image has a preset password.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription period of the instance. The unit is specified by the <c>PeriodUnit</c> parameter. This parameter is valid and required only when <c>InstanceChargeType</c> is set to <c>PrePaid</c>. If the <c>DedicatedHostId</c> parameter is specified, the value of Period must not exceed the subscription period of the specified dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PeriodUnit is set to Week: 1, 2, 3, and 4.</description></item>
        /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period. Default value: Month. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Week</description></item>
        /// <item><description>Month</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class RunInstancesRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableInstanceIdDnsAAAARecord")]
            [Validation(Required=false)]
            public bool? EnableInstanceIdDnsAAAARecord { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInstanceIdDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableInstanceIdDnsARecord { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIpDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsARecord { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableIpDnsPtrRecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsPtrRecord { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("HostnameType")]
            [Validation(Required=false)]
            public string HostnameType { get; set; }

        }

        /// <summary>
        /// <para>The private IP address to assign to the instance. To assign a private IP address to an instance that resides in a VPC, make sure that the IP address is an idle IP address within the CIDR block of the vSwitch specified by <c>VSwitchId</c>.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PrivateIpAddress</c> is specified, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If <c>Amount</c> is set to 1, a single instance is created and the specified private IP address is assigned to the instance.</description></item>
        /// <item><description>If <c>Amount</c> is set to a numeric value greater than 1, the specified number of instances are created and consecutive private IP addresses starting from the specified one are assigned to the instances. In this case, you cannot specify parameters that start with <c>NetworkInterface.N</c> to attach secondary ENIs to the instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot specify <c>PrivateIpAddress</c> but can specify <c>NetworkInterface.N.PrimaryIpAddress</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> The first IP address and last three IP addresses of each vSwitch CIDR block are reserved. You cannot specify the IP addresses. For example, if a vSwitch CIDR block is 192.168.1.0/24, the IP addresses 192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255 are reserved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role. You can call the <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> operation provided by RAM to query the instance RAM roles that you created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM_Name</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the instance.</para>
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
        /// <item><description>Active: enables security hardening. This value is applicable only to public images.</description></item>
        /// <item><description>Deactive: does not enable security hardening. This value is applicable to all images.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which you want to assign the instance. Instances in the same security group can communicate with each other. The maximum number of instances allowed in a security group varies based on the type of the security group. For more information, see the &quot;Security group limits&quot; section in <a href="~~25412#SecurityGroupQuota~~">Limits and quotas</a>.</para>
        /// <remarks>
        /// <para> The network type of the new instance is the same as the network type of the security group specified by <c>SecurityGroupId</c>. For example, if the specified security group is of the VPC type, the new instance is also of the VPC type and you must specify <c>VSwitchId</c>.</para>
        /// </remarks>
        /// <para>If you do not use <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to specify a launch template, you must specify a security group ID. When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can set <c>SecurityGroupId</c> to specify a single security group or set <c>SecurityGroupIds.N</c> to specify one or more security groups. However, you cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c> in the same request.</description></item>
        /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot specify <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c> but can specify <c>NetworkInterface.N.SecurityGroupId</c> or <c>NetworkInterface.N.SecurityGroupIds.N</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of security groups to which to assign the instance. The valid values of N vary based on the maximum number of security groups to which an instance can belong. For more information, see the <a href="https://help.aliyun.com/document_detail/101348.html">Security group limits</a> section of the &quot;Limits&quot; topic.</para>
        /// <para>When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c> in the same request.</description></item>
        /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot specify <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c> but can specify <c>NetworkInterface.N.SecurityGroupId</c> or <c>NetworkInterface.N.SecurityGroupIds.N</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The protection period of the preemptible instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
        /// <item><description>0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify an appropriate protection period based on your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The interruption mode of the preemptible instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Terminate: The instance is released.</para>
        /// </description></item>
        /// <item><description><para>Stop: The instance is stopped in economical mode.</para>
        /// <para>For information about the economical mode, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
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
        /// <para>The maximum hourly price of the instance. The value is accurate to three decimal places. This parameter is valid only when the <c>SpotStrategy</c> parameter is set to <c>SpotWithPriceLimit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.97</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding policy for the pay-as-you-go instance. This parameter is valid only when the <c>InstanceChargeType</c> parameter is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is created as a pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
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
        /// <para>The maximum number of partitions in the storage set. Valid values: greater than or equal to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The tags to add to the instance, disks, and primary ENI.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesRequestTag> Tag { get; set; }
        public class RunInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the instance, disks, and primary ENI. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the instance, disks, and primary ENI. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
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
        /// <item><description>host: creates the instance on a dedicated host. If you do not set the <c>DedicatedHostId</c> parameter, Alibaba Cloud selects a dedicated host for the instance.</description></item>
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
        /// <para>Specifies whether to automatically append incremental suffixes to the hostname specified by the <c>HostName</c> parameter and to the instance name specified by the <c>InstanceName</c> parameter when you batch create instances. The incremental suffixes can range from 001 to 999. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>When the <c>HostName</c> or <c>InstanceName</c> value is set in the <c>name_prefix[begin_number,bits]</c> format without <c>name_suffix</c>, the <c>UniqueSuffix</c> parameter does not take effect. The names are sorted in the specified sequence.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for multiple instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>The user data of the instance. You must specify Base64-encoded data. The instance user data cannot exceed 32 KB in size before Base64 encoding.</para>
        /// <para>For information about the limits, formats, and running frequencies of instance user data, see <a href="https://help.aliyun.com/document_detail/49121.html">Instance user data</a>.</para>
        /// <remarks>
        /// <para> To ensure security, we recommend that you do not use plaintext to pass in confidential information, such as passwords or private keys, as user data. If you need to pass in confidential information, we recommend that you encrypt and encode the information in Base64 and then decode and decrypt the information in the same manner in the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which to connect to the instance. You must set this parameter when you create an instance of the VPC type. The specified vSwitch and security group must belong to the same VPC. You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query available vSwitches.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you specify the <c>VSwitchId</c> parameter, the zone specified by the <c>ZoneId</c> parameter must be the zone where the specified vSwitch is located. You can also leave the <c>ZoneId</c> parameter empty. Then, the system selects the zone where the specified vSwitch resides.</description></item>
        /// <item><description>If <c>NetworkInterface.N.InstanceType</c> is set to <c>Primary</c>, you cannot specify <c>VSwitchId</c> but can specify <c>NetworkInterface.N.VSwitchId</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the zone in which to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// <remarks>
        /// <para>If you specify the <c>VSwitchId</c> parameter, the zone specified by the <c>ZoneId</c> parameter must be the zone where the vSwitch is located. You can also leave the <c>ZoneId</c> parameter empty. Then, the system selects the zone where the specified vSwitch is located.</para>
        /// </remarks>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
