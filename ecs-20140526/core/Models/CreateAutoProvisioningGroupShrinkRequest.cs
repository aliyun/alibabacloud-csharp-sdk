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
            /// <para>This parameter is in invitational preview and is not available for use.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationArn> Arn { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationArn : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para>This parameter is in invitational preview and is not available for use.</para>
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
                /// <para>This parameter is in invitational preview and is not available for use.</para>
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
                /// <para>This parameter is in invitational preview and is not available for use.</para>
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
            /// <para>The automatic release time of the pay-as-you-go instance. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// <list type="bullet">
            /// <item><description><para>If the value of seconds (<c>ss</c>) is not <c>00</c>, the time is automatically rounded down to the start of the current minute (<c>mm</c>).</para>
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
            /// <para>The running mode of the burstable instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: standard mode. For more information about instance performance, see the performance constrained mode section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
            /// <item><description>Unlimited: unlimited mode. For more information about instance performance, see the unlimited mode section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
            /// </list>
            /// <para>Default value: none.</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// <para>The list of data disk configurations in the launch configuration.</para>
            /// </summary>
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationDataDisk> DataDisk { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationDataDisk : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy applied to the data disk.</para>
                /// <para>Note:</para>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only when you create a one-time synchronous delivery auto provisioning group (AutoProvisioningGroupType=instant).</description></item>
                /// </list>
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
                /// <item><description>true: enables the feature.</description></item>
                /// <item><description>false: disables the feature.</description></item>
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
                /// <para>The category of data disk N. Valid values of N: 1 to 16. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: standard SSD.</description></item>
                /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
                /// <item><description>cloud: basic disk.</description></item>
                /// </list>
                /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.</para>
                /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Specifies whether the data disk is released when the instance is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: the data disk is released when the instance is released.</description></item>
                /// <item><description>false: the data disk is not released when the instance is released.</description></item>
                /// </list>
                /// <para>Default value: true.</para>
                /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The description of the data disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataDisk_Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The mount point of the data disk. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/vd1</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The name of the data disk. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
                /// <para>Default value: empty.</para>
                /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
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
                /// <para>Specifies whether data disk N is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: encrypted.</description></item>
                /// <item><description>false: not encrypted.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The ID of the KMS key for the data disk. If both a launch template and launch configuration are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the enterprise SSD used as a data disk. The value of N must be consistent with the N in <c>LaunchConfiguration.DataDisk.N.Category</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: a single disk can deliver up to 10,000 random read/write IOPS.</description></item>
                /// <item><description>PL1 (default): a single disk can deliver up to 50,000 random read/write IOPS.</description></item>
                /// <item><description>PL2: a single disk can deliver up to 100,000 random read/write IOPS.</description></item>
                /// <item><description>PL3: a single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
                /// </list>
                /// <para>For information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
                /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}.</para>
                /// <para>Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
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
                /// <item><description>cloud_essd: depends on the value of <c>LaunchConfiguration.DataDisk.N.PerformanceLevel</c>.<list type="bullet">
                /// <item><description>PL0: 40 to 32768.</description></item>
                /// <item><description>PL1: 20 to 32768.</description></item>
                /// <item><description>PL2: 461 to 32768.</description></item>
                /// <item><description>PL3: 1261 to 32768.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>cloud: 5 to 2000.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The value of this parameter must be greater than or equal to the size of the snapshot specified by <c>LaunchConfiguration.DataDisk.N.SnapshotId</c>.</para>
                /// </remarks>
                /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot used to create data disk N. Valid values of N: 1 to 16.</para>
                /// <para>After you specify this parameter, the <c>LaunchConfiguration.DataDisk.N.Size</c> parameter is ignored. The actual size of the created disk is the size of the specified snapshot. Snapshots created on or before July 15, 2013 cannot be used. Requests that use such snapshots are rejected.</para>
                /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp17441ohwka0yuh****</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the deployment set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1frxuzdg87zh4p****</para>
            /// </summary>
            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// <para>The hostname of the instance. The following limits apply:</para>
            /// <list type="bullet">
            /// <item><description>Periods (.) and hyphens (-) cannot be used as the first or last characters and cannot be used consecutively.</description></item>
            /// <item><description>Windows instances: The hostname must be 2 to 15 characters in length and cannot contain periods (.) or consist entirely of digits. It can contain letters, digits, and hyphens (-).</description></item>
            /// <item><description>Instances of other types (such as Linux): The hostname must be 2 to 64 characters in length and can contain multiple periods (.). Each segment between periods can contain letters, digits, and hyphens (-).</description></item>
            /// <item><description>You cannot specify both <c>LaunchConfiguration.HostName</c> and <c>LaunchConfiguration.HostNames.N</c>. Otherwise, an error is returned.</description></item>
            /// <item><description>If you specify both a launch template and launch configuration information, the launch template takes precedence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-node-[1,4]-ecshost</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The list of hostnames for one or more instances. The following limits apply:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when you create a one-time synchronous delivery auto provisioning group (<c>AutoProvisioningGroupType=instant</c>).</description></item>
            /// <item><description>N indicates the number of instances. Valid values of N: 1 to 1000. The value must be consistent with the TotalTargetCapacity parameter.</description></item>
            /// <item><description>Periods (.) and hyphens (-) cannot be used as the first or last characters and cannot be used consecutively.</description></item>
            /// <item><description>If you specify both a launch template and launch configuration information, the launch template takes precedence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-host-01</para>
            /// </summary>
            [NameInMap("HostNames")]
            [Validation(Required=false)]
            public List<string> HostNames { get; set; }

            /// <summary>
            /// <para>The name of the image family. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>aliyun</c> or <c>acs:</c>. The name cannot contain <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), or hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou-daily-update</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The ID of the image used to launch instances. You can call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available image resources. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp1g7004ksh0oeuc****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The description of the instance. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance_Description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The name of the instance. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>Default value: the <c>InstanceId</c> of the instance.</para>
            /// <para>When you create multiple ECS instances, you can batch configure sequential instance names. For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for multiple instances</a>.</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-node-[1,4]-alibabacloud</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The billing method for network usage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
            /// <item><description>PayByTraffic: pay-by-traffic.</description></item>
            /// </list>
            /// <remarks>
            /// <para>In pay-by-traffic mode, the peak inbound and outbound bandwidths are used as upper limits of bandwidths instead of guaranteed performance metrics. When resources are contended, the peak bandwidths may be limited. If you require guaranteed bandwidth, use pay-by-bandwidth.</para>
            /// </remarks>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
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
            /// <item><description>If the maximum outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
            /// <item><description>If the maximum outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>LaunchConfiguration.InternetMaxBandwidthOut</c>. Default value: the value of <c>LaunchConfiguration.InternetMaxBandwidthOut</c>.</description></item>
            /// </list>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
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
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance is an I/O optimized instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>none: non-I/O optimization.</description></item>
            /// <item><description>optimized: I/O optimization.</description></item>
            /// </list>
            /// <para>For retired instance types, the default value is none. For other instance types, the default value is optimized.</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>optimized</para>
            /// </summary>
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            /// <summary>
            /// <para>The name of the key pair.</para>
            /// <list type="bullet">
            /// <item><description>For Windows instances, this parameter is ignored and is empty by default.</description></item>
            /// <item><description>For Linux instances, password-based logon is disabled during initialization.</description></item>
            /// </list>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyPair_Name</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The password of the instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
            /// <para><c>()`~!@#$%^&amp;*-_+=|{}`[]`:;\\&quot;&lt;&gt;,.?/</c></para>
            /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
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
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// <para>The name of the instance RAM role. You can call the RAM API <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query the instance RAM roles that you have created. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM_Name</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
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
            /// <item><description>Active: enables security hardening. This value is applicable only to public images.</description></item>
            /// <item><description>Deactive: disables security hardening. This value is applicable to all image types.</description></item>
            /// </list>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the instance belongs. If both a launch template and launch configuration information are specified, the launch template takes precedence.</para>
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
            /// <para>The system disk information of the instance. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSystemDisk SystemDisk { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSystemDisk : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy to apply to the system disk.</para>
                /// <para>After you set this parameter, note the following items:</para>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only when you create a one-time synchronization delivery auto provisioning group (AutoProvisioningGroupType=instant).</description></item>
                /// </list>
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
                /// <item><description>true: enables the feature.</description></item>
                /// <item><description>false: does not enable the feature.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is supported only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
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
                /// <item><description>aes-256</description></item>
                /// <item><description>sm4-128</description></item>
                /// </list>
                /// <para>Default value: aes-256.</para>
                /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// <remarks>
                /// <para>This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>aes-256</para>
                /// </summary>
                [NameInMap("EncryptAlgorithm")]
                [Validation(Required=false)]
                public string EncryptAlgorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether the system disk is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: encrypted.</para>
                /// </description></item>
                /// <item><description><para>false: not encrypted.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <para>If you specify both.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// <para>The KMS key ID of the system disk.</para>
                /// <para>When both a launch template and launch configuration information are specified, the launch template takes precedence.</para>
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
                /// <para>This parameter is supported only when SystemDisk.Category is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
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
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
            /// <item><description>cloud: basic disk.</description></item>
            /// </list>
            /// <para>For retired instance types that are non-I/O optimization instances, the default value is cloud. For other instance types, the default value is cloud_efficiency.</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDisk_Description</para>
            /// </summary>
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
            /// <para>Default value: empty.</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the enterprise SSD used as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0 (default): a single disk can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: a single disk can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: a single disk can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: a single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values: 20 to 500. The value of this parameter must be greater than or equal to max{20, size of the image specified by LaunchConfiguration.ImageId}.</para>
            /// <para>Default value: max{40, size of the image specified by LaunchConfiguration.ImageId}.</para>
            /// <para>If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The list of tags in the launch configuration.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationTag> Tag { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationTag : TeaModel {
                /// <summary>
                /// <para>The tag key of the instance. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain <c>http://</c> or <c>https://</c>. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the instance. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot start with acs:. It cannot contain <c>http://</c> or <c>https://</c>. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Instance user data of the instance. Instance user data must be Base64-encoded. The maximum size of the raw data is 32 KB. If you specify both a launch template and launch configuration information, the launch template takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. This parameter takes effect when you create subscription instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables auto-renewal.</description></item>
            /// <item><description>false (default): does not enable auto-renewal.</description></item>
            /// </list>
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
            /// <item><description>If PeriodUnit is set to Week: 1, 2, and 3.</description></item>
            /// <item><description>If PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;If PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The CPU-related configurations.</para>
            /// </summary>
            [NameInMap("CpuOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationCpuOptions CpuOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationCpuOptions : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// <para>Default value: see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/specify-and-view-cpu-options">Specify and view CPU options</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Core")]
                [Validation(Required=false)]
                public int? Core { get; set; }

                /// <summary>
                /// <para>The number of threads per CPU core. The number of vCPUs of the ECS instance = CpuOptions.Core value × CpuOptions.ThreadsPerCore value.</para>
                /// <para>If CpuOptions.ThreadsPerCore is set to 1, CPU hyper-threading is disabled.</para>
                /// <para>Only specific instance types support custom CPU thread counts.</para>
                /// <para>For valid values and default values, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/specify-and-view-cpu-options">Specify and view CPU options</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ThreadsPerCore")]
                [Validation(Required=false)]
                public int? ThreadsPerCore { get; set; }

            }

            /// <summary>
            /// <para>The image-related property information.</para>
            /// <para>After you set this parameter, note the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when you create a one-time synchronization delivery auto provisioning group (AutoProvisioningGroupType=instant).</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ImageOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationImageOptions ImageOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationImageOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether the instance that uses this image supports logon as the ecs-user user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: supported.</description></item>
                /// <item><description>false: not supported.</description></item>
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
            /// <para>The subscription duration of the resource. Unit: specified by <c>PeriodUnit</c>. This parameter is required when you create subscription instances. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>If PeriodUnit is set to Week, valid values of Period: 1, 2, 3, and 4.</description></item>
            /// <item><description>If PeriodUnit is set to Month, valid values of Period: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;If PeriodUnit is set to Month, valid values of Period: 1, 2, 3, 6, and 12.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;If PeriodUnit is set to Month, valid values of Period: 1, 2, 3, 6, and 12.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription billable methods duration. Valid values: </para>
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
            /// <para>The protection period of the spot instance. Unit: hours. Default value: 1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: After a spot instance is created, Alibaba Cloud ensures that the instance is not subject to automatic release within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the marketplace price and checks the resource inventory to determine whether to retain or revoke the instance.</description></item>
            /// <item><description>0: After a spot instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the marketplace price and checks the resource inventory to determine whether to retain or revoke the instance.</description></item>
            /// </list>
            /// <para>Alibaba Cloud sends an ECS system event notification 5 minutes before the instance is released. Spot instances are billed by second. Select an appropriate protection period based on the expected task execution duration.</para>
            /// <para>After you set this parameter, note the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when you create a one-time synchronization delivery auto provisioning group (AutoProvisioningGroupType=instant).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// <para>The spot instance break mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Terminate: directly releases the instance.</para>
            /// </description></item>
            /// <item><description><para>Stop: puts the instance into economical mode.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about economical mode, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
            /// <para>Default value: Terminate.</para>
            /// <para>After you set this parameter, note the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when you create a one-time synchronization delivery auto provisioning group (AutoProvisioningGroupType=instant).</description></item>
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
        /// <para>The name of the auto provisioning group. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
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
        /// <item><description><para>request: one-time asynchronous delivery. The group delivers an instance cluster asynchronously only at startup. If scheduling fails, no retry is performed.</para>
        /// </description></item>
        /// <item><description><para>instant: one-time synchronous delivery. The group synchronously creates instances only at startup and returns the list of successfully created instances and the causes of creation failures in the response.</para>
        /// </description></item>
        /// <item><description><para>maintain: continuous delivery. The group attempts to deliver an instance cluster at startup and monitors real-time capacity. If the target capacity is not reached, the group continues to create ECS instances.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of data disk configurations.</para>
        /// </summary>
        [NameInMap("DataDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestDataDiskConfig> DataDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestDataDiskConfig : TeaModel {
            /// <summary>
            /// <para>The category of the data disk. You can specify multiple candidate disk categories. The specified order determines the priority of each disk category. When a disk category is unavailable, the system automatically switches to the next category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
            /// <item><description>cloud: basic disk.</description></item>
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
        /// <para>The billing method for the capacity difference when the sum of <c>PayAsYouGoTargetCapacity</c> and <c>SpotTargetCapacity</c> is less than <c>TotalTargetCapacity</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: pay-as-you-go instances.</description></item>
        /// <item><description>Spot: spot instances.</description></item>
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
        /// <para>Specifies whether to release instances when the real-time capacity of the auto provisioning group exceeds the target capacity and a scale-in event is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>termination: releases the scaled-in instances.</description></item>
        /// <item><description>no-termination: only removes the scaled-in instances from the auto provisioning group.</description></item>
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
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HibernationOptionsConfigured")]
        [Validation(Required=false)]
        public bool? HibernationOptionsConfigured { get; set; }

        /// <summary>
        /// <para>The list of extended launch templates.</para>
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
            /// <para>The list of vCPU core counts for instance types.</para>
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
            /// <para>The image ID. You can use this parameter to set the image for the current resource pool. If not set, the image specified in <c>LaunchConfiguration.ImageId</c> or the launch template is used by default. You can call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available image resources.
            /// Note: This parameter is supported only when <c>AutoProvisioningGroupType = instant</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20210425.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The level of the instance family, used to filter instance types that meet the requirements. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: entry level, which refers to shared instance types. Lower cost but no guarantee of stable computing performance. Suitable for scenarios with low average CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise level. Stable performance with dedicated resources. Suitable for scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: credit-based entry level, which refers to burstable instances. Uses CPU credits to ensure computing performance. Suitable for scenarios with low average CPU utilization and occasional bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EnterpriseLevel</para>
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// <para>The instance type in the extended launch template. Valid values of N: 1 to 20. For valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum price for spot instances in the extended launch template.</para>
            /// <remarks>
            /// <para>After you set <c>LaunchTemplateConfig</c>, <c>LaunchTemplateConfig.N.MaxPrice</c> is required.</para>
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
            /// <para>This parameter is in invitational preview and is not available for use.</para>
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
            /// <para>The ID of the vSwitch to which the ECS instance in the extended launch template is connected. The zone of the ECS instance created from the extended template is determined by the vSwitch.</para>
            /// <remarks>
            /// <para>If you specify LaunchTemplateConfig, LaunchTemplateConfig.N.VSwitchId is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sn5bsitu4lfzgc5o7****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The weight of the instance type in the extended launch template. A higher value indicates that a single instance can meet more computing power requirements, which reduces the number of instances required. Valid values: greater than 0.</para>
            /// <para>You can calculate the weight based on the computing power of the specified instance type and the minimum computing power of a single node in the cluster. For example, if the minimum computing power of a single node is 8 vCPUs and 60 GiB:</para>
            /// <list type="bullet">
            /// <item><description>The weight of an instance type with 8 vCPUs and 60 GiB can be set to 1.</description></item>
            /// <item><description>The weight of an instance type with 16 vCPUs and 120 GiB can be set to 2.</description></item>
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
        /// <para>The ID of the instance launch template associated with the auto provisioning group. You can invoke <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a> to query active instance launch templates. If you specify both a launch template and launch configuration information (<c>LaunchConfiguration.*</c>), the launch template takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1fgzds4bdogu03****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The version of the instance launch template associated with the auto provisioning group. You can invoke <a href="https://help.aliyun.com/document_detail/73761.html">DescribeLaunchTemplateVersions</a> to query active instance launch template versions.</para>
        /// <para>Default value: the default version of the launch template.</para>
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
        /// <para>If both <c>MaxSpotPrice</c> and <c>LaunchTemplateConfig.N.MaxPrice</c> are specified, the lower value is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxSpotPrice")]
        [Validation(Required=false)]
        public float? MaxSpotPrice { get; set; }

        /// <summary>
        /// <para>The minimum target capacity of the auto provisioning group. Valid values</para>
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
        /// <para>The policy for creating pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>lowest-price: cost optimization policy. Selects the instance type with the lowest price.</para>
        /// </description></item>
        /// <item><description><para>prioritized: priority-based policy. Creates instances based on the priority specified by <c>LaunchTemplateConfig.N.Priority</c>.</para>
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
        /// <para>The target capacity of pay-as-you-go instances in the auto provisioning group. Valid values: less than or equal to the parameter value of <c>TotalTargetCapacity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PayAsYouGoTargetCapacity")]
        [Validation(Required=false)]
        public string PayAsYouGoTargetCapacity { get; set; }

        /// <summary>
        /// <para>The detailed capacity configuration for subscription instances.</para>
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
                /// <para>The set of instance types. Duplicate values are not allowed, and the instance types must be within the range of LaunchTemplateConfig.InstanceType.</para>
                /// </summary>
                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>The minimum number of instances to deliver within the <c>InstanceTypes</c> range.</para>
                /// <remarks>
                /// <para>The sum of all MinTargetCapacity values (<c>sum(MinTargetCapacity) &lt;= TotalTargetCapacity</c>) cannot exceed TotalTargetCapacity. If any instance type set cannot meet the MinTargetCapacity requirement due to insufficient inventory or other reasons, the entire request fails.</para>
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
        /// <para>The ID of the region in which the auto provisioning group resides. You can invoke <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the auto provisioning group belongs.</para>
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
        /// <para>The resource pool policy used to create instances. After you set this parameter, note the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when you create pay-as-you-go instances.</description></item>
        /// <item><description>This parameter takes effect only when you create a one-time synchronization delivery auto provisioning group (<c>AutoProvisioningGroupType=instant</c>).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public string ResourcePoolOptionsShrink { get; set; }

        /// <summary>
        /// <para>The policy for creating spot instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>lowest-price: cost optimization policy. Selects the instance type with the lowest price.</para>
        /// </description></item>
        /// <item><description><para>diversified: balanced zone distribution policy. Creates instances in the zones specified in the extended launch template and evenly distributes them across zones.</para>
        /// </description></item>
        /// <item><description><para>capacity-optimized: capacity optimization distribution policy. Selects the optimal instance type and zone based on inventory availability.</para>
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
        /// <para>The action to take when a spot instance is interrupted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>stop: stops the instance.</para>
        /// </description></item>
        /// <item><description><para>terminate: releases the instance.</para>
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
        /// <para>Takes effect when <c>SpotAllocationStrategy</c> is set to <c>lowest-price</c>. Specifies the number of instance types with the lowest prices from which the auto provisioning group creates instances.</para>
        /// <para>Valid values: less than the value of N in <c>LaunchTemplateConfig.N</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SpotInstancePoolsToUseCount")]
        [Validation(Required=false)]
        public int? SpotInstancePoolsToUseCount { get; set; }

        /// <summary>
        /// <para>The target capacity of spot instances in the auto provisioning group. Valid values: less than or equal to the parameter value of <c>TotalTargetCapacity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SpotTargetCapacity")]
        [Validation(Required=false)]
        public string SpotTargetCapacity { get; set; }

        /// <summary>
        /// <para>The list of system disk configurations.</para>
        /// </summary>
        [NameInMap("SystemDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestSystemDiskConfig> SystemDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestSystemDiskConfig : TeaModel {
            /// <summary>
            /// <para>The category of the system disk. You can specify multiple candidate disk categories. The specified order determines the priority of each disk category. When a disk category is unavailable, the system automatically switches to the next category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
            /// <item><description>cloud: basic disk.</description></item>
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
        /// <para>The tags to attach to the auto provisioning group.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestTag> Tag { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the auto provisioning group.</para>
            /// <para>Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. The tag key cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the auto provisioning group.</para>
            /// <para>Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to release instances auto provisioning group when the auto-provisioning group is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases instances auto provisioning group.</description></item>
        /// <item><description>false: retains instances auto provisioning group.</description></item>
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
        /// <para>Specifies whether to release instances auto provisioning group when the auto-provisioning group expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases instances auto provisioning group.</description></item>
        /// <item><description>false: only removes instances from the auto-provisioning group.</description></item>
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
        /// <para>The total target capacity of the auto provisioning group. Valid values: positive integers.</para>
        /// <para>The total capacity must be greater than or equal to the sum of <c>PayAsYouGoTargetCapacity</c> (the target capacity of pay-as-you-go instances) and <c>SpotTargetCapacity</c> (the target capacity of spot instances).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=false)]
        public string TotalTargetCapacity { get; set; }

        /// <summary>
        /// <para>The time when the auto provisioning group is started. Used together with <c>ValidUntil</c> to determine the valid period.</para>
        /// <para>Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// <para>Default value: the UNIX timestamp at which the request takes effect immediately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-04-01T15:10:20Z</para>
        /// </summary>
        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// <para>The time when the auto provisioning group expires. Used together with <c>ValidFrom</c> to determine the valid period.</para>
        /// <para>Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
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
