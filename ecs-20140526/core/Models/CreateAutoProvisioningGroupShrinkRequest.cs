// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoProvisioningGroupShrinkRequest : TeaModel {
        [NameInMap("LaunchConfiguration")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupShrinkRequestLaunchConfiguration LaunchConfiguration { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestLaunchConfiguration : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not supported.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationArn> Arn { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationArn : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para>This parameter is in invitational preview and is not supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123456789012****</para>
                /// </summary>
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public long? AssumeRoleFor { get; set; }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is in invitational preview and is not supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>34458433936495****:alice</para>
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is in invitational preview and is not supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::123456789012****:role/adminrole</para>
                /// </summary>
                [NameInMap("Rolearn")]
                [Validation(Required=false)]
                public string Rolearn { get; set; }

            }

            /// <summary>
            /// <para>The automatic release time for pay-as-you-go instances. Specify the time in <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> format using UTC+0 time. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>If seconds (<c>ss</c>) are not <c>00</c>, the time is rounded down to the start of the current minute (<c>mm</c>).</para>
            /// </description></item>
            /// <item><description><para>The earliest release time is 30 minutes after the current time.</para>
            /// </description></item>
            /// <item><description><para>The latest release time cannot exceed three years from the current time.</para>
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
            /// <para>The running mode of burstable instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Standard: Standard mode. For more information, see the &quot;Performance-constrained mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances?</a></para>
            /// </description></item>
            /// <item><description><para>Unlimited: Unlimited mode. For more information, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances?</a></para>
            /// </description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// <para>The list of data disk configurations for the extended launch template.</para>
            /// </summary>
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationDataDisk> DataDisk { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationDataDisk : TeaModel {
                /// <summary>
                /// <para>The automatic snapshot policy ID applied to the data disk.</para>
                /// <para>Note:</para>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only when creating an auto provisioning group with AutoProvisioningGroupType=instant.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable performance burst. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enables performance burst.</para>
                /// </description></item>
                /// <item><description><para>false: Disables performance burst.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The category of data disk N. N ranges from 1 to 16. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>cloud_efficiency: Ultra disk.</para>
                /// </description></item>
                /// <item><description><para>cloud_ssd: Standard SSD.</para>
                /// </description></item>
                /// <item><description><para>cloud_essd: ESSD.</para>
                /// </description></item>
                /// <item><description><para>cloud: Basic disk.</para>
                /// </description></item>
                /// </list>
                /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
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
                /// <item><description><para>true: Releases the data disk with the instance.</para>
                /// </description></item>
                /// <item><description><para>false: Does not release the data disk with the instance.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: true.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The description of the data disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataDisk_Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The mount point of the data disk. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/vd1</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The name of the data disk. The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
                /// <para>Default value: empty.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssdData</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is not yet available.</para>
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
                /// <item><description><para>true: Encrypts the disk.</para>
                /// </description></item>
                /// <item><description><para>false: Does not encrypt the disk.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The KMS key ID for the data disk. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD used as a data disk. The value of N must match the N in <c>LaunchConfiguration.DataDisk.N.Category</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PL0: Up to 10,000 random read/write IOPS per disk.</para>
                /// </description></item>
                /// <item><description><para>PL1 (default): Up to 50,000 random read/write IOPS per disk.</para>
                /// </description></item>
                /// <item><description><para>PL2: Up to 100,000 random read/write IOPS per disk.</para>
                /// </description></item>
                /// <item><description><para>PL3: Up to 1,000,000 random read/write IOPS per disk.</para>
                /// </description></item>
                /// </list>
                /// <para>For more information about selecting ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS for ESSD AutoPL disks. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}.</para>
                /// <para>Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
                /// <remarks>
                /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>40000</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The size of data disk N, in GiB. N ranges from 1 to 16. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>cloud_efficiency: 20–32768.</para>
                /// </description></item>
                /// <item><description><para>cloud_ssd: 20–32768.</para>
                /// </description></item>
                /// <item><description><para>cloud_essd: The valid range depends on the value of <c>LaunchConfiguration.DataDisk.N.PerformanceLevel</c>.</para>
                /// <list type="bullet">
                /// <item><description><para>PL0: 40–32768.</para>
                /// </description></item>
                /// <item><description><para>PL1: 20–32768.</para>
                /// </description></item>
                /// <item><description><para>PL2: 461–32768.</para>
                /// </description></item>
                /// <item><description><para>PL3: 1261–32768</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>cloud: 5–2000.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The value must be greater than or equal to the size of the snapshot specified by <c>LaunchConfiguration.DataDisk.N.SnapshotId</c>.</para>
                /// </remarks>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The snapshot used to create data disk N. N ranges from 1 to 16.</para>
                /// <para>After this parameter is specified, <c>LaunchConfiguration.DataDisk.N.Size</c> is ignored. The actual disk size equals the size of the specified snapshot. Snapshots created on or before July 15, 2013 are not supported and will cause the request to fail.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp17441ohwka0yuh****</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

            /// <summary>
            /// <para>The deployment set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1frxuzdg87zh4p****</para>
            /// </summary>
            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// <para>The hostname of the instance. Requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>Periods (.) and hyphens (-) cannot be the first or last character and cannot appear consecutively.</para>
            /// </description></item>
            /// <item><description><para>Windows instances: 2–15 characters. Periods (.) are not supported. Cannot consist of only digits. Can contain letters, digits, and hyphens (-).</para>
            /// </description></item>
            /// <item><description><para>Other instances (such as Linux): 2–64 characters. Multiple periods (.) are supported. Each segment between periods can contain letters, digits, and hyphens (-).</para>
            /// </description></item>
            /// <item><description><para>Do not set both <c>LaunchConfiguration.HostName</c> and <c>LaunchConfiguration.HostNames.N</c>. Otherwise, an error is returned.</para>
            /// </description></item>
            /// <item><description><para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-node-[1,4]-ecshost</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The list of hostnames for one or more instances. Requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when creating an auto provisioning group with <c>AutoProvisioningGroupType=instant</c>.</para>
            /// </description></item>
            /// <item><description><para>N indicates the number of instances. Valid values: 1 to 1000. The value must match TotalTargetCapacity.</para>
            /// </description></item>
            /// <item><description><para>Periods (.) and hyphens (-) cannot be the first or last character and cannot appear consecutively.</para>
            /// </description></item>
            /// <item><description><para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-host-01</para>
            /// </summary>
            [NameInMap("HostNames")]
            [Validation(Required=false)]
            public List<string> HostNames { get; set; }

            /// <summary>
            /// <para>The image family name. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>aliyun</c> or <c>acs:</c>. It also cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou-daily-update</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The image ID. This is the image used when launching instances. Call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available images. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp1g7004ksh0oeuc****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance_Description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The instance name. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// <para>Default value: The instance <c>InstanceId</c>.</para>
            /// <para>To create multiple ECS instances, you can batch configure sequential instance names. For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential instance names or hostnames</a>.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-node-[1,4]-alibabacloud</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The network billing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PayByBandwidth: Pay-by-bandwidth.</para>
            /// </description></item>
            /// <item><description><para>PayByTraffic: Pay-by-traffic.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For pay-by-traffic, inbound and outbound bandwidth peaks represent upper limits and are not service-level commitments. Bandwidth may be throttled during resource contention. Use pay-by-bandwidth if your workload requires guaranteed bandwidth.</para>
            /// </remarks>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
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
            /// <item><description><para>When outbound public bandwidth is ≤ 10 Mbit/s: 1–10. Default: 10.</para>
            /// </description></item>
            /// <item><description><para>When outbound public bandwidth is &gt; 10 Mbit/s: 1–<c>LaunchConfiguration.InternetMaxBandwidthOut</c>. Default: <c>LaunchConfiguration.InternetMaxBandwidthOut</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthIn { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth, in Mbit/s. Valid values: 0–100.</para>
            /// <para>Default value: 0.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance is I/O optimized. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>none: Not I/O optimized.</para>
            /// </description></item>
            /// <item><description><para>optimized: I/O optimized.</para>
            /// </description></item>
            /// </list>
            /// <para>For retired instance types, the default value is none. For other instance types, the default value is optimized.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>optimized</para>
            /// </summary>
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            /// <summary>
            /// <para>The key pair name.</para>
            /// <list type="bullet">
            /// <item><description><para>For Windows instances, this parameter is ignored. Default value: empty.</para>
            /// </description></item>
            /// <item><description><para>For Linux instances, password logon is disabled after initialization.</para>
            /// </description></item>
            /// </list>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyPair_Name</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The instance password. The password must be 8 to 30 characters in length and include at least three of the following: uppercase letters, lowercase letters, digits, and special characters. Valid special characters:</para>
            /// <para><c>()`~!@#$%^&amp;*-_+=|{}`[]`:;\\&quot;&lt;&gt;,.?/</c></para>
            /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
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
            /// <item><description><para>true: Uses the preset password.</para>
            /// </description></item>
            /// <item><description><para>false: Does not use the preset password.</para>
            /// </description></item>
            /// </list>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// <para>The RAM role name of the instance. Use the RAM API <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query your created RAM roles. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM_Name</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The resource group ID of the instance. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Active: Enables security hardening. Applies only to public images.</para>
            /// </description></item>
            /// <item><description><para>Deactive: Disables security hardening. Applies to all image types.</para>
            /// </description></item>
            /// </list>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// <para>The security group ID of the instance. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp15ed6xe1yxeycg****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The list of security groups to which the instance belongs.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>System disk information for the instance. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSystemDisk SystemDisk { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSystemDisk : TeaModel {
                /// <summary>
                /// <para>The automatic snapshot policy ID applied to the system disk.</para>
                /// <para>Note:</para>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only when creating an auto provisioning group with AutoProvisioningGroupType=instant.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable performance burst. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enables performance burst.</para>
                /// </description></item>
                /// <item><description><para>false: Disables performance burst.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is supported only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The encryption algorithm for the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>aes-256.</para>
                /// </description></item>
                /// <item><description><para>sm4-128.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: aes-256.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// <remarks>
                /// <para>This parameter is not yet available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>aes-256</para>
                /// </summary>
                [NameInMap("EncryptAlgorithm")]
                [Validation(Required=false)]
                public string EncryptAlgorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt system disk N. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Encrypts the disk.</para>
                /// </description></item>
                /// <item><description><para>false: Does not encrypt the disk.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// <para>The KMS key ID for the system disk.</para>
                /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS for ESSD AutoPL disks. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}.</para>
                /// <para>Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
                /// <remarks>
                /// <para>This parameter is supported only when SystemDisk.Category is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>40000</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

            }

            /// <summary>
            /// <para>The category of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud_efficiency: Ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: Standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// <item><description><para>cloud: Basic disk.</para>
            /// </description></item>
            /// </list>
            /// <para>For retired instance types that are not I/O optimized, the default value is cloud. Otherwise, the default value is cloud_efficiency.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDisk_Description</para>
            /// </summary>
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// <para>Default value: empty.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD used as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0 (default): Up to 10,000 random read/write IOPS per disk.</para>
            /// </description></item>
            /// <item><description><para>PL1: Up to 50,000 random read/write IOPS per disk.</para>
            /// </description></item>
            /// <item><description><para>PL2: Up to 100,000 random read/write IOPS per disk.</para>
            /// </description></item>
            /// <item><description><para>PL3: Up to 1,000,000 random read/write IOPS per disk.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about selecting ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk, in GiB. Valid values: 20–500. The value must be greater than or equal to max{20, size of the image specified by LaunchConfiguration.ImageId}.</para>
            /// <para>Default value: max{40, size of the image specified by LaunchConfiguration.ImageId}.</para>
            /// <para>When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The list of tags for the extended launch template.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationTag> Tag { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationTag : TeaModel {
                /// <summary>
                /// <para>The tag key of the instance. N ranges from 1 to 20. If specified, the value cannot be an empty string. The key can be up to 128 characters in length and cannot start with aliyun or acs:. It also cannot contain <c>http://</c> or <c>https://</c>. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the instance. N ranges from 1 to 20. If specified, the value can be an empty string. The value can be up to 128 characters in length and cannot start with acs:. It also cannot contain <c>http://</c> or <c>https://</c>. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The instance user data. Encode the data in Base64. The raw data cannot exceed 32 KB. When both a launch template and launch configuration parameters are specified, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. Takes effect when creating subscription instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables auto-renewal.</para>
            /// </description></item>
            /// <item><description><para>false (default): Disables auto-renewal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal duration per cycle. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para>When PeriodUnit=Week: 1, 2, 3.</para>
            /// </description></item>
            /// <item><description><para>When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, 60.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>When PeriodUnit=Month: 1, 2, 3, 6, 12, 24, 36, 48, 60.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>CPU configuration.</para>
            /// </summary>
            [NameInMap("CpuOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationCpuOptions CpuOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationCpuOptions : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// <para>Default value: See <a href="https://help.aliyun.com/zh/ecs/user-guide/specify-and-view-cpu-options?spm=a2c4g.11186623.0.0.734f769asTEobd">Customize CPU options</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Core")]
                [Validation(Required=false)]
                public int? Core { get; set; }

                /// <summary>
                /// <para>The number of CPU threads. The vCPU count of an ECS instance equals CpuOptions.Core × CpuOptions.ThreadsPerCore.</para>
                /// <para>CpuOptions.ThreadsPerCore=1 disables CPU hyper-threading.</para>
                /// <para>Only specific instance types support setting the number of CPU threads.</para>
                /// <para>Valid values and default values: See <a href="https://help.aliyun.com/zh/ecs/user-guide/specify-and-view-cpu-options?spm=a2c4g.11186623.0.0.734f769aeIFsoj">Customize CPU options</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ThreadsPerCore")]
                [Validation(Required=false)]
                public int? ThreadsPerCore { get; set; }

            }

            /// <summary>
            /// <para>Image-related properties.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when creating an auto provisioning group with AutoProvisioningGroupType=instant.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ImageOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationImageOptions ImageOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationImageOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether instances using this image support logging on as the ecs-user. Valid values:</para>
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
            /// <para>The subscription duration. The unit is specified by <c>PeriodUnit</c>. Required when creating subscription instances. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para>When PeriodUnit=Week, Period values: 1, 2, 3, 4.</para>
            /// </description></item>
            /// <item><description><para>When PeriodUnit=Month, Period values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, 60.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>When PeriodUnit=Month, Period values: 1, 2, 3, 6, 12.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;</para>
            /// <para>When PeriodUnit=Month, Period values: 1, 2, 3, 6, 12.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The time unit for subscription billing. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para>Week.</para>
            /// </description></item>
            /// <item><description><para>Month (default).</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>Month (default).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("SchedulerOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSchedulerOptions SchedulerOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSchedulerOptions : TeaModel {
                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }

                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

            }

            [NameInMap("SecurityOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSecurityOptions SecurityOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSecurityOptions : TeaModel {
                [NameInMap("TrustedSystemMode")]
                [Validation(Required=false)]
                public string TrustedSystemMode { get; set; }

            }

            /// <summary>
            /// <para>The reserved duration for spot instances, in hours. Default value: 1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Alibaba Cloud guarantees that the instance runs for 1 hour without being automatically released. After 1 hour, the system compares your bid price with the market price and checks inventory to decide whether to retain or reclaim the instance.</para>
            /// </description></item>
            /// <item><description><para>0: Alibaba Cloud does not guarantee that the instance runs for 1 hour. The system immediately compares your bid price with the market price and checks inventory to decide whether to retain or reclaim the instance.</para>
            /// </description></item>
            /// </list>
            /// <para>Alibaba Cloud sends an ECS system event notification 5 minutes before reclaiming a spot instance. Spot instances are billed per second. Choose the reserved duration based on your task execution time.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when creating an auto provisioning group with AutoProvisioningGroupType=instant.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// <para>The interruption behavior for spot instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Terminate: Releases the instance immediately.</para>
            /// </description></item>
            /// <item><description><para>Stop: Puts the instance into economical mode.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about economical mode, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
            /// <para>Default value: Terminate.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when creating an auto provisioning group with AutoProvisioningGroupType=instant.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Terminate</para>
            /// </summary>
            [NameInMap("SpotInterruptionBehavior")]
            [Validation(Required=false)]
            public string SpotInterruptionBehavior { get; set; }

        }

        /// <summary>
        /// <para>The name of the auto provisioning group. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apg-test</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupName")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupName { get; set; }

        /// <summary>
        /// <para>The delivery type of the auto provisioning group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>request: One-time asynchronous delivery. The group delivers the instance cluster only at startup. If scheduling fails, no retry occurs.</para>
        /// </description></item>
        /// <item><description><para>instant: One-time synchronous delivery. The group creates instances synchronously at startup and returns the list of successfully created instances and reasons for failures in the response.</para>
        /// </description></item>
        /// <item><description><para>maintain: Continuous provisioning. The group attempts to deliver the instance cluster at startup and monitors real-time capacity. If the target capacity is not met, it continues creating ECS instances.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: maintain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maintain</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupType")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupType { get; set; }

        [NameInMap("CandidateOptions")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupShrinkRequestCandidateOptions CandidateOptions { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestCandidateOptions : TeaModel {
            [NameInMap("Evaluate")]
            [Validation(Required=false)]
            public bool? Evaluate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TimeoutMinutes")]
            [Validation(Required=false)]
            public int? TimeoutMinutes { get; set; }

        }

        /// <summary>
        /// <para>Ensures request idempotence. Generate a unique value from your client for this parameter to ensure uniqueness across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of data disk configurations for instances.</para>
        /// </summary>
        [NameInMap("DataDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestDataDiskConfig> DataDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestDataDiskConfig : TeaModel {
            /// <summary>
            /// <para>The data disk type. You can specify multiple candidate disk types. The order specifies their priority. If one disk type is unavailable, the system automatically switches to the next type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud_efficiency: Ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: Standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// <item><description><para>cloud: Basic disk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

        }

        /// <summary>
        /// <para>Specifies the billing method for the capacity difference when the sum of <c>PayAsYouGoTargetCapacity</c> and <c>SpotTargetCapacity</c> is less than <c>TotalTargetCapacity</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PayAsYouGo: Pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>Spot: Spot instances.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Spot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Spot</para>
        /// </summary>
        [NameInMap("DefaultTargetCapacityType")]
        [Validation(Required=false)]
        public string DefaultTargetCapacityType { get; set; }

        /// <summary>
        /// <para>The description of the auto provisioning group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to release instances when the real-time capacity of the auto provisioning group exceeds the target capacity and scale-in is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>termination: Releases scaled-in instances.</para>
        /// </description></item>
        /// <item><description><para>no-termination: Only removes scaled-in instances from the auto provisioning group.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: no-termination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>termination</para>
        /// </summary>
        [NameInMap("ExcessCapacityTerminationPolicy")]
        [Validation(Required=false)]
        public string ExcessCapacityTerminationPolicy { get; set; }

        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HibernationOptionsConfigured")]
        [Validation(Required=false)]
        public bool? HibernationOptionsConfigured { get; set; }

        /// <summary>
        /// <para>The list of extended launch template configurations.</para>
        /// </summary>
        [NameInMap("LaunchTemplateConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestLaunchTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The list of architecture types for instance types.</para>
            /// </summary>
            [NameInMap("Architectures")]
            [Validation(Required=false)]
            public List<string> Architectures { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance type supports performance bursts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Exclude: Excludes burstable instance types.</para>
            /// </description></item>
            /// <item><description><para>Include: Includes burstable instance types.</para>
            /// </description></item>
            /// <item><description><para>Required: Includes only burstable instance types.</para>
            /// </description></item>
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
            /// <para>The list of vCPU counts for instance types.</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public List<int?> Cores { get; set; }

            /// <summary>
            /// <para>The list of instance types to exclude.</para>
            /// </summary>
            [NameInMap("ExcludedInstanceTypes")]
            [Validation(Required=false)]
            public List<string> ExcludedInstanceTypes { get; set; }

            /// <summary>
            /// <para>The image ID. Use this parameter to specify the image for the current resource pool. If not set, the image specified in <c>LaunchConfiguration.ImageId</c> or the launch template is used by default. Call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available images.
            /// Note: This parameter is supported only when <c>AutoProvisioningGroupType = instant</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20210425.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance family level, used to filter eligible instance types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>EntryLevel: Entry-level, or shared-resource instances. Lower cost but no guaranteed stable computing performance. Suitable for workloads with low average CPU usage. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared-resource instances</a>.</para>
            /// </description></item>
            /// <item><description><para>EnterpriseLevel: Enterprise-level. Stable performance with dedicated resources. Suitable for workloads requiring high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </description></item>
            /// <item><description><para>CreditEntryLevel: Credit entry-level, or burstable instances. Uses CPU credits to guarantee computing performance. Suitable for workloads with low average CPU usage and occasional bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instances</a>.</para>
            /// </description></item>
            /// </list>
            /// <para>N ranges from 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EnterpriseLevel</para>
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// <para>The instance type corresponding to the extended launch template. N ranges from 1 to 20. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum hourly price for spot instances in the extended launch template.</para>
            /// <remarks>
            /// <para>After <c>LaunchTemplateConfig</c> is set, <c>LaunchTemplateConfig.N.MaxPrice</c> is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public double? MaxPrice { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MaxQuantity")]
            [Validation(Required=false)]
            public int? MaxQuantity { get; set; }

            /// <summary>
            /// <para>The list of memory sizes for instance types.</para>
            /// </summary>
            [NameInMap("Memories")]
            [Validation(Required=false)]
            public List<float?> Memories { get; set; }

            /// <summary>
            /// <para>The priority of the extended launch template. A value of 0 indicates the highest priority. Valid values: 0 to +∞.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the virtual switch to which the ECS instance belongs in the extended launch template. The zone of the ECS instance launched from this template is determined by the virtual switch.</para>
            /// <remarks>
            /// <para>After <c>LaunchTemplateConfig</c> is set, <c>LaunchTemplateConfig.N.VSwitchId</c> is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sn5bsitu4lfzgc5o7****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The weight of the instance type in the extended launch template. A higher value indicates greater computing power per instance and fewer instances needed. Valid values: Greater than 0.</para>
            /// <para>You can calculate the weight based on the computing power of the specified instance type and the minimum computing power required per node in the cluster. For example, if the minimum computing power per node is 8 vCPUs and 60 GiB memory:</para>
            /// <list type="bullet">
            /// <item><description><para>An instance type with 8 vCPUs and 60 GiB memory can have a weight of 1.</para>
            /// </description></item>
            /// <item><description><para>An instance type with 16 vCPUs and 120 GiB memory can have a weight of 2.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public double? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The ID of the launch template associated with the auto provisioning group. Call <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a> to query available launch templates. When both a launch template and launch configuration parameters (<c>LaunchConfiguration.*</c>) are specified, the launch template takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1fgzds4bdogu03****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The version of the launch template associated with the auto provisioning group. Call <a href="https://help.aliyun.com/document_detail/73761.html">DescribeLaunchTemplateVersions</a> to query available launch template versions.</para>
        /// <para>Default value: The default version of the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The maximum price for spot instances in the auto provisioning group.</para>
        /// <remarks>
        /// <para>If both <c>MaxSpotPrice</c> and <c>LaunchTemplateConfig.N.MaxPrice</c> are set, the lower value takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxSpotPrice")]
        [Validation(Required=false)]
        public float? MaxSpotPrice { get; set; }

        /// <summary>
        /// <para>The minimum target capacity of the auto provisioning group. Valid values: Positive integers.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when creating an auto provisioning group with <c>AutoProvisioningGroupType=instant</c>.</para>
        /// </description></item>
        /// <item><description><para>If the instance inventory in the region is less than this value, the API call fails and no instances are created.</para>
        /// </description></item>
        /// <item><description><para>If the instance inventory in the region is greater than this value, instances are created based on other configured parameters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MinTargetCapacity")]
        [Validation(Required=false)]
        public string MinTargetCapacity { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The strategy for creating pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>lowest-price: Cost optimization strategy. Selects the instance type with the lowest price.</para>
        /// </description></item>
        /// <item><description><para>prioritized: Priority-based strategy. Creates instances based on the priority specified in <c>LaunchTemplateConfig.N.Priority</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: lowest-price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prioritized</para>
        /// </summary>
        [NameInMap("PayAsYouGoAllocationStrategy")]
        [Validation(Required=false)]
        public string PayAsYouGoAllocationStrategy { get; set; }

        /// <summary>
        /// <para>The target capacity for pay-as-you-go instances in the auto provisioning group. Valid values: Integers less than or equal to the value of <c>TotalTargetCapacity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PayAsYouGoTargetCapacity")]
        [Validation(Required=false)]
        public string PayAsYouGoTargetCapacity { get; set; }

        /// <summary>
        /// <para>Detailed capacity configuration for subscription instances.</para>
        /// </summary>
        [NameInMap("PrePaidOptions")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupShrinkRequestPrePaidOptions PrePaidOptions { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestPrePaidOptions : TeaModel {
            /// <summary>
            /// <para>The minimum capacity set for different instance types. This parameter is supported only when <c>AutoProvisioningGroupType = request</c>.</para>
            /// </summary>
            [NameInMap("SpecifyCapacityDistribution")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestPrePaidOptionsSpecifyCapacityDistribution> SpecifyCapacityDistribution { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestPrePaidOptionsSpecifyCapacityDistribution : TeaModel {
                /// <summary>
                /// <para>The set of instance types. Duplicates are not allowed, and the types must be within the range of LaunchTemplateConfig.InstanceType.</para>
                /// </summary>
                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>The minimum number of instances to deliver within the <c>InstanceTypes</c> range.</para>
                /// <remarks>
                /// <para><c>sum(MinTargetCapacity)&lt;= TotalTargetCapacity</c>. The sum of MinTargetCapacity across all instance type sets cannot exceed TotalTargetCapacity. If any instance type set fails to meet its MinTargetCapacity due to inventory issues, the entire request fails.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MinTargetCapacity")]
                [Validation(Required=false)]
                public int? MinTargetCapacity { get; set; }

            }

        }

        /// <summary>
        /// <para>The region ID of the auto provisioning group. Call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest Alibaba Cloud region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID of the auto provisioning group.</para>
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
        /// <para>The resource pool strategy used when creating instances. Note:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when creating pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only when creating an auto provisioning group with <c>AutoProvisioningGroupType=instant</c>.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public string ResourcePoolOptionsShrink { get; set; }

        /// <summary>
        /// <para>The strategy for creating spot instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>lowest-price: Cost optimization strategy. Selects the instance type with the lowest price.</para>
        /// </description></item>
        /// <item><description><para>diversified: Balanced zone distribution strategy. Creates instances across the zones specified in the launch template configurations and distributes them evenly.</para>
        /// </description></item>
        /// <item><description><para>capacity-optimized: Capacity optimization strategy. Selects the optimal instance type and zone based on inventory availability.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: lowest-price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>diversified</para>
        /// </summary>
        [NameInMap("SpotAllocationStrategy")]
        [Validation(Required=false)]
        public string SpotAllocationStrategy { get; set; }

        /// <summary>
        /// <para>The behavior when a spot instance is interrupted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>stop: Stops the instance.</para>
        /// </description></item>
        /// <item><description><para>terminate: Releases the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: terminate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terminate</para>
        /// </summary>
        [NameInMap("SpotInstanceInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>Takes effect only when <c>SpotAllocationStrategy</c> is set to <c>lowest-price</c>. Specifies the number of lowest-priced instance types from which the auto provisioning group creates instances.</para>
        /// <para>Valid values: Less than the value of N in <c>LaunchTemplateConfig.N</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SpotInstancePoolsToUseCount")]
        [Validation(Required=false)]
        public int? SpotInstancePoolsToUseCount { get; set; }

        /// <summary>
        /// <para>The target capacity for spot instances in the auto provisioning group. Valid values: Integers less than or equal to the value of <c>TotalTargetCapacity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SpotTargetCapacity")]
        [Validation(Required=false)]
        public string SpotTargetCapacity { get; set; }

        /// <summary>
        /// <para>The list of system disk configurations for instances.</para>
        /// </summary>
        [NameInMap("SystemDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestSystemDiskConfig> SystemDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestSystemDiskConfig : TeaModel {
            /// <summary>
            /// <para>The system disk type. You can specify multiple candidate disk types. The order specifies their priority. If one disk type is unavailable, the system automatically switches to the next type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud_efficiency: Ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: Standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// <item><description><para>cloud: Basic disk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

        }

        /// <summary>
        /// <para>The list of tags bound to the auto provisioning group.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestTag> Tag { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the auto provisioning group.</para>
            /// <para>N ranges from 1 to 20. If specified, the value cannot be an empty string. The key can be up to 128 characters in length and cannot start with aliyun or acs:. It also cannot contain http\:// or https\://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the auto provisioning group.</para>
            /// <para>N ranges from 1 to 20. If specified, the value can be an empty string. The value can be up to 128 characters in length and cannot contain http\:// or https\://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to release instances in the group when you delete the auto provisioning group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Releases instances in the group.</para>
        /// </description></item>
        /// <item><description><para>false: Retains instances in the group.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TerminateInstances")]
        [Validation(Required=false)]
        public bool? TerminateInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to release instances in the group when the auto provisioning group expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Releases instances in the group.</para>
        /// </description></item>
        /// <item><description><para>false: Only removes instances from the auto provisioning group.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TerminateInstancesWithExpiration")]
        [Validation(Required=false)]
        public bool? TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// <para>The total target capacity of the auto provisioning group. Valid values: Positive integers.</para>
        /// <para>The total capacity must be greater than or equal to the sum of <c>PayAsYouGoTargetCapacity</c> (target capacity for pay-as-you-go instances) and <c>SpotTargetCapacity</c> (target capacity for spot instances).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=false)]
        public string TotalTargetCapacity { get; set; }

        /// <summary>
        /// <para>The start time of the auto provisioning group. Used together with <c>ValidUntil</c> to define the validity period.</para>
        /// <para>Specify the time in <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> format using UTC+0 time. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>Default value: The timestamp when the API call takes effect immediately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-04-01T15:10:20Z</para>
        /// </summary>
        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// <para>The expiration time of the auto provisioning group. Used together with <c>ValidFrom</c> to define the validity period.</para>
        /// <para>Specify the time in <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> format using UTC+0 time. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>Default value: 2099-12-31T23:59:59Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-01T15:10:20Z</para>
        /// </summary>
        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public string ValidUntil { get; set; }

    }

}
