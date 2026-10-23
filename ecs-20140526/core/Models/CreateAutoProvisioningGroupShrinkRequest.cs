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
            /// <para>The automatic release time of the pay-as-you-go instance. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// <list type="bullet">
            /// <item><description><para>If the value of seconds (ss) is not 00, the release time is automatically set to the start of the current minute (mm).</para>
            /// </description></item>
            /// <item><description><para>The earliest release time is half an hour after the current time.</para>
            /// </description></item>
            /// <item><description><para>The latest release time cannot be more than three years after the current time.</para>
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
            /// <para>The performance mode of the burstable instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: standard mode. For more information about the performance of the instance, see the &quot;Standard mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
            /// <item><description>Unlimited: unlimited mode. For more information about the performance of the instance, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
            /// </list>
            /// <para>Default value: null.</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// <para>The extended data disk configurations for the launch template.</para>
            /// </summary>
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationDataDisk> DataDisk { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationDataDisk : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy applied to the data disk.</para>
                /// <para>Take note of the following items when you configure this parameter:</para>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only when you create an auto provisioning group of the instant delivery type (AutoProvisioningGroupType=instant).</description></item>
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
                /// <item><description>true: yes.</description></item>
                /// <item><description>false: no.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is supported only when the DiskCategory parameter is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
                /// <item><description>cloud_essd: enterprise SSD.</description></item>
                /// <item><description>cloud: basic disk.</description></item>
                /// </list>
                /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.</para>
                /// <para>If both the launch template and the launch configuration are specified, the launch template takes precedence.</para>
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
                /// <para>If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The description of the data disk. The description must be 2 to 256 characters in length and cannot start with http:// or https://. If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataDisk_Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The mount point of the data disk. If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/vd1</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The name of the data disk. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with http:// or https://. It can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
                /// <para>Default value: null.</para>
                /// <para>If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
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
                /// <item><description>true: The data disk is encrypted.</description></item>
                /// <item><description>false: The data disk is not encrypted.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <para>If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
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
                /// <para>When you create an enterprise SSD as a data disk, set the performance level of the disk. The value of N must be the same as the value of N in LaunchConfiguration.DataDisk.N.Category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: A single enterprise SSD can deliver up to 10,000 random read/write IOPS.</description></item>
                /// <item><description>PL1 (default): A single enterprise SSD can deliver up to 50,000 random read/write IOPS.</description></item>
                /// <item><description>PL2: A single enterprise SSD can deliver up to 100,000 random read/write IOPS.</description></item>
                /// <item><description>PL3: A single enterprise SSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
                /// </list>
                /// <para>For more information about how to select the performance level of an enterprise SSD, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSD</a>.</para>
                /// <para>If both the launch template and the launch configuration are specified, the launch template takes precedence.</para>
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
                /// <para>This parameter is supported only when the DiskCategory parameter is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>40000</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The size of data disk N. Unit: GiB. Valid values of N: 1 to 16. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency: 20 to 32768.</description></item>
                /// <item><description>cloud_ssd: 20 to 32768.</description></item>
                /// <item><description>cloud_essd: The valid values vary based on the value of LaunchConfiguration.DataDisk.N.PerformanceLevel.<list type="bullet">
                /// <item><description>PL0: 40 to 32768.</description></item>
                /// <item><description>PL1: 20 to 32768.</description></item>
                /// <item><description>PL2: 461 to 32768.</description></item>
                /// <item><description>PL3: 1261 to 32768.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>cloud: 5 to 2000.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The value of this parameter must be greater than or equal to the size of the snapshot specified by the LaunchConfiguration.DataDisk.N.SnapshotId parameter.</para>
                /// </remarks>
                /// <para>If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot used to create data disk N. Valid values of N: 1 to 16.</para>
                /// <para>If this parameter is specified, the LaunchConfiguration.DataDisk.N.Size parameter is ignored, and the size of the created disk is the same as the size of the specified snapshot. You cannot use snapshots that were created on or before July 15, 2013. Otherwise, the request is rejected and an error is returned.</para>
                /// <para>If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
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
            /// <para>The hostname of the instance. Limits:</para>
            /// <list type="bullet">
            /// <item><description>The hostname cannot start or end with a period (.) or a hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).</description></item>
            /// <item><description>For Windows instances, the hostname must be 2 to 15 characters in length. It cannot contain periods (.) and cannot contain only digits. It can contain letters, digits, and hyphens (-).</description></item>
            /// <item><description>For other instances such as Linux instances, the hostname must be 2 to 64 characters in length. It can contain multiple periods (.). The characters between two consecutive periods are considered a segment. Each segment can contain letters, digits, and hyphens (-).</description></item>
            /// <item><description>You cannot specify both <c>LaunchConfiguration.HostName</c> and <c>LaunchConfiguration.HostNames.N</c>. Otherwise, an error is returned.</description></item>
            /// <item><description>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-node-[1,4]-ecshost</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The list of hostnames for one or more instances. Limits:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when you create an auto provisioning group of the instant delivery type (AutoProvisioningGroupType=instant).</description></item>
            /// <item><description>N indicates the number of instances. Valid values of N: 1 to 1000. The value of N must be the same as the value of the TotalTargetCapacity parameter.</description></item>
            /// <item><description>Periods (.) and hyphens (-) cannot be used as the first or last characters, and cannot be used consecutively.</description></item>
            /// <item><description>If both the launch template and the launch configurations are specified, the launch template takes precedence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-host-01</para>
            /// </summary>
            [NameInMap("HostNames")]
            [Validation(Required=false)]
            public List<string> HostNames { get; set; }

            /// <summary>
            /// <para>The name of the image family. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with aliyun or acs:. It cannot contain http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou-daily-update</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The ID of the image. The image resource selected when the instance is started. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query available image resources. If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp1g7004ksh0oeuc****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The description of the instance. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance_Description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The name of the instance. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>Default value: the <c>InstanceId</c> of the instance.</para>
            /// <para>When you create multiple ECS instances, you can batch configure sequential instance names. For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Configure sequential instance names or hostnames</a>.</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <para>In pay-by-traffic mode, the peak inbound and outbound bandwidths are upper limits and are not guaranteed service level indicators. When resource contention occurs, the peak bandwidths may be limited. If your business requires guaranteed bandwidth, use the pay-by-bandwidth mode.</para>
            /// </remarks>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <item><description>When the outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
            /// <item><description>When the outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>LaunchConfiguration.InternetMaxBandwidthOut</c>. Default value: the value of <c>LaunchConfiguration.InternetMaxBandwidthOut</c>.</description></item>
            /// </list>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <para>The default value is cloud for retired instance types and non-I/O optimized instances, and optimized for other instance types.</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <item><description>For Windows instances, this parameter is ignored. Default value: null.</description></item>
            /// <item><description>For Linux instances, password logon is disabled by default.</description></item>
            /// </list>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyPair_Name</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The password of the instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:</para>
            /// <para><c>()`~!@#$%^&amp;*-_+=|{}`[]`:;\\&quot;&lt;&gt;,.?/</c></para>
            /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// <para>The name of the instance RAM role. You can use the RAM API operation <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query the instance RAM roles that you have created. If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM_Name</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs. If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <para>The system disk configuration of the instance. If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSystemDisk SystemDisk { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSystemDisk : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy applied to the system disk.</para>
                /// <para>Take note of the following items when you configure this parameter:</para>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only when you create an auto provisioning group of the instant delivery type (AutoProvisioningGroupType=instant).</description></item>
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
                /// <item><description>true: yes.</description></item>
                /// <item><description>false: no.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is supported only when the SystemDisk.Category parameter is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The encryption algorithm of the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>aes-256.</para>
                /// </description></item>
                /// <item><description><para>sm4-128.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: aes-256.</para>
                /// <para>If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
                /// <remarks>
                /// <para>This parameter is not available.</para>
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
                /// <item><description><para>true: The system disk is encrypted.</para>
                /// </description></item>
                /// <item><description><para>false: The system disk is not encrypted.</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <para>If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
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
                /// <para>This parameter is supported only when the SystemDisk.Category parameter is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
            /// <item><description>cloud_essd: enterprise SSD.</description></item>
            /// <item><description>cloud: basic disk.</description></item>
            /// </list>
            /// <para>The default value is cloud for retired instance types and non-I/O optimized instances, and cloud_efficiency for other instance types.</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDisk_Description</para>
            /// </summary>
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
            /// <para>Default value: null.</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }

            /// <summary>
            /// <para>The settings for the performance level of the enterprise SSD used as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0 (default): A single enterprise SSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single enterprise SSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single enterprise SSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single enterprise SSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more information about how to select enterprise SSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">enterprise SSDs</a>.</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values: 20 to 500. The value of this parameter must be greater than or equal to max{20, the size of the image specified by LaunchConfiguration.ImageId}.</para>
            /// <para>Default value: max{40, the size of the image specified by LaunchConfiguration.ImageId}.</para>
            /// <para>If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The extended list of tags for the launch template.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationTag> Tag { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationTag : TeaModel {
                /// <summary>
                /// <para>The tag key of the instance. Valid values of N: 1 to 20. If this parameter is specified, it cannot be left empty. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://. If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the instance. Valid values of N: 1 to 20. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with acs:, and cannot contain http:// or https://. If both the launch template and the launch configurations are specified, the launch template takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Instance user data of the instance. Instance user data must be encoded in Base64. The maximum size of the raw data is 32 KB. If you specify both a launch template and launch configurations, the system preferentially uses the launch template.</para>
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
            /// <item><description>true: Auto-renewal is enabled.</description></item>
            /// <item><description>false (default): Auto-renewal is disabled.</description></item>
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
            /// <para>The CPU configurations.</para>
            /// </summary>
            [NameInMap("CpuOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationCpuOptions CpuOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationCpuOptions : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// <para>Default value: For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/specify-and-view-cpu-options">Customize CPU options</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Core")]
                [Validation(Required=false)]
                public int? Core { get; set; }

                /// <summary>
                /// <para>The number of threads per core. The number of vCPUs of the ECS instance = the value of CpuOptions.Core × the value of CpuOptions.ThreadsPerCore.</para>
                /// <para>A value of 1 for CpuOptions.ThreadsPerCore indicates that CPU hyper-threading is disabled.</para>
                /// <para>Only specific instance types support the configuration of the number of threads per core.</para>
                /// <para>Valid values and default value: For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/specify-and-view-cpu-options">Customize CPU options</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ThreadsPerCore")]
                [Validation(Required=false)]
                public int? ThreadsPerCore { get; set; }

            }

            /// <summary>
            /// <para>The image properties.</para>
            /// <para>Take note of the following items when you configure this parameter:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when you create an auto provisioning group of the instant delivery type (AutoProvisioningGroupType=instant).</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ImageOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationImageOptions ImageOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationImageOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether the instance that uses this image supports logons by using the ecs-user username. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: yes.</description></item>
                /// <item><description>false: no.</description></item>
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
            /// <para>The subscription period of the resource. The unit is specified by PeriodUnit. This parameter is required and takes effect only when you create subscription instances. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>When PeriodUnit is set to Week, valid values of Period are 1, 2, 3, and 4.</description></item>
            /// <item><description>When PeriodUnit is set to Month, valid values of Period are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;When PeriodUnit is set to Month, valid values of Period are 1, 2, 3, 6, and 12.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;When PeriodUnit is set to Month, valid values of Period are 1, 2, 3, 6, and 12.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription period. Valid values: </para>
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
            /// <para>The scheduling options.</para>
            /// </summary>
            [NameInMap("SchedulerOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSchedulerOptions SchedulerOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSchedulerOptions : TeaModel {
                /// <summary>
                /// <para>The ID of the dedicated host cluster.</para>
                /// </summary>
                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated host.</para>
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

            }

            /// <summary>
            /// <para>The security options of the instance.</para>
            /// </summary>
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
            /// <item><description>1: The instance is protected from automatic release for 1 hour after it is created. After the 1-hour protection period ends, the system compares your bid with the marketplace price and checks resource inventory to determine whether to retain or revoke the instance.</description></item>
            /// <item><description>0: The instance is not protected after it is created. The system compares your bid with the marketplace price and checks resource inventory to determine whether to retain or revoke the instance.</description></item>
            /// </list>
            /// <para>Alibaba Cloud sends you a notification by using an ECS system event 5 minutes before the instance is revoked. Spot instances use billing by the second. We recommend that you select an appropriate protection period based on the execution duration of your specific tasks.</para>
            /// <para>Take note of the following items when you set this parameter:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when you create an auto provisioning group of the one-time synchronization delivery type (AutoProvisioningGroupType=instant).</description></item>
            /// </list>
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
            /// <item><description><para>Terminate: The instance is released.</para>
            /// </description></item>
            /// <item><description><para>Stop: The instance enters the economical mode.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about the economical mode, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
            /// <para>Default value: Terminate.</para>
            /// <para>Take note of the following items when you set this parameter:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when you create an auto provisioning group of the one-time synchronization delivery type (AutoProvisioningGroupType=instant).</description></item>
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
        /// <para>The name of the auto provisioning group. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
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
        /// <item><description><para>request: one-time asynchronous delivery. The auto provisioning group asynchronously delivers the instance cluster only at startup and does not retry if the scheduling failed.</para>
        /// </description></item>
        /// <item><description><para>instant: one-time synchronization delivery. The auto provisioning group creates instances in synchronization only at startup and returns the list of created instances and the reasons why creation failed in the response.</para>
        /// </description></item>
        /// <item><description><para>maintain: continuous delivery. The auto provisioning group attempts to deliver the instance cluster at startup, performs monitoring on the real-time capacity, and continues to create ECS instances if the target capacity is not reached.</para>
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

        /// <summary>
        /// <para>The configuration options when AutoProvisioningGroupType is set to candidate.</para>
        /// </summary>
        [NameInMap("CandidateOptions")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupShrinkRequestCandidateOptions CandidateOptions { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestCandidateOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to only evaluate the success rate of delivering the target capacity for candidate instance types in the current request. If you set this parameter to true, no scale-out is performed. The system only evaluates the delivery success rate and returns the result in the LaunchResult.CandidateEvaluateLevel field of the response. Default value: false.</para>
            /// </summary>
            [NameInMap("Evaluate")]
            [Validation(Required=false)]
            public bool? Evaluate { get; set; }

            /// <summary>
            /// <para>The timeout period for the auto provisioning group to scale out to the target capacity. After the timeout period elapses, no further scale-out attempts are made. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TimeoutMinutes")]
            [Validation(Required=false)]
            public int? TimeoutMinutes { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of data disk configurations for the instance.</para>
        /// </summary>
        [NameInMap("DataDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestDataDiskConfig> DataDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestDataDiskConfig : TeaModel {
            /// <summary>
            /// <para>The category of the data disk for the instance. You can use this parameter to specify multiple candidate disk categories. The specified order determines the priority of the disk categories. If a disk category is not active, the system automatically switches to the next disk category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: enterprise SSD.</description></item>
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
        /// <para>Specifies whether to release the instances that are removed during a scale-down event when the real-time capacity of the auto provisioning group exceeds the target capacity and triggers a scale-down. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>termination: releases the removed instances.</description></item>
        /// <item><description>no-termination: only removes the instances from the auto provisioning group.</description></item>
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
        /// <para>This parameter is in invitational preview and is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HibernationOptionsConfigured")]
        [Validation(Required=false)]
        public bool? HibernationOptionsConfigured { get; set; }

        /// <summary>
        /// <para>The extended launch templates.</para>
        /// </summary>
        [NameInMap("LaunchTemplateConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestLaunchTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The list of architecture types for the instance types.</para>
            /// </summary>
            [NameInMap("Architectures")]
            [Validation(Required=false)]
            public List<string> Architectures { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance type is a burstable instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exclude: does not include burstable instance types.</description></item>
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
            /// <para>The list of vCPU counts for the instance types.</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public List<int?> Cores { get; set; }

            /// <summary>
            /// <para>The list of instance types to be excluded.</para>
            /// </summary>
            [NameInMap("ExcludedInstanceTypes")]
            [Validation(Required=false)]
            public List<string> ExcludedInstanceTypes { get; set; }

            /// <summary>
            /// <para>The ID of the image. You can use this parameter to specify the image used by the current resource pool. If this parameter is not specified, the image specified by <c>LaunchConfiguration.ImageId</c> or the image configured in the launch template is used by default. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query available image resources.
            /// Note: This parameter is supported only when <c>AutoProvisioningGroupType</c> is set to <c>instant</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20210425.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The level of the instance family. This parameter is used to filter the instance types that meet the requirements. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: entry-level, which refers to shared instance types. These instance types are more cost-effective but cannot guarantee stable computing performance. They are suitable for business scenarios with low CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise-level. These instance types provide stable performance and dedicated resources, and are suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: credit entry-level, which refers to burstable instances. These instance types use CPU credits to guarantee computing performance and are suitable for business scenarios with low CPU utilization but occasional CPU bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instances</a>.</description></item>
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
            /// <para>The instance type in the extended launch template. Valid values of N: 1 to 20. For more information about valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum price of spot instances in the extended launch template.</para>
            /// <remarks>
            /// <para>After <c>LaunchTemplateConfig</c> is specified, <c>LaunchTemplateConfig.N.MaxPrice</c> is required.</para>
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
            /// <para>The list of memory sizes for the instance types.</para>
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
            /// <para>The weight of the instance type in the extended launch template. A higher weight indicates that a single instance has more computing power and fewer instances are required. Valid values: greater than 0.</para>
            /// <para>You can calculate the weight based on the computing power of the specified instance type and the minimum computing power of a single node in the cluster. For example, if the minimum computing power of a single node is 8 vCPUs and 60 GiB of memory:</para>
            /// <list type="bullet">
            /// <item><description>You can set the weight of the instance type with 8 vCPUs and 60 GiB of memory to 1.</description></item>
            /// <item><description>You can set the weight of the instance type with 16 vCPUs and 120 GiB of memory to 2.</description></item>
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
        /// <para>The ID of the instance launch template associated with the auto provisioning group. You can invoke the <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a> operation to query active instance launch templates. If you specify both a launch template and launch configurations (<c>LaunchConfiguration.*</c>), the system preferentially uses the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1fgzds4bdogu03****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The version of the instance launch template associated with the auto provisioning group. You can invoke the <a href="https://help.aliyun.com/document_detail/73761.html">DescribeLaunchTemplateVersions</a> operation to query active instance launch template versions.</para>
        /// <para>Default value: the default version of the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The maximum price of spot instances in the auto provisioning group.</para>
        /// <remarks>
        /// <para>If the settings include both <c>MaxSpotPrice</c> and <c>LaunchTemplateConfig.N.MaxPrice</c>, the lower value is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxSpotPrice")]
        [Validation(Required=false)]
        public float? MaxSpotPrice { get; set; }

        /// <summary>
        /// <para>The minimum target capacity of the auto provisioning group. Valid values: positive integers.</para>
        /// <para>Take note of the following items when you configure this parameter:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when you create an auto provisioning group of the instant delivery type (AutoProvisioningGroupType=instant).</description></item>
        /// <item><description>If the instance inventory in the current region is less than the value of this parameter, the API call fails and no instances are created.</description></item>
        /// <item><description>If the instance inventory in the current region is greater than the value of this parameter, instances are created based on the values of other configured parameters.</description></item>
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
        /// <para>The policy for creating pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>lowest-price: the cost optimization policy. The instance type with the lowest price is selected.</para>
        /// </description></item>
        /// <item><description><para>prioritized: the priority-based policy. Instances are created based on the priorities specified by <c>LaunchTemplateConfig.N.Priority</c>.</para>
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
        /// <para>The detailed capacity configurations for subscription instances.</para>
        /// </summary>
        [NameInMap("PrePaidOptions")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupShrinkRequestPrePaidOptions PrePaidOptions { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestPrePaidOptions : TeaModel {
            /// <summary>
            /// <para>The minimum capacity set for different instance types. This parameter is supported only when AutoProvisioningGroupType is set to request.</para>
            /// </summary>
            [NameInMap("SpecifyCapacityDistribution")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestPrePaidOptionsSpecifyCapacityDistribution> SpecifyCapacityDistribution { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestPrePaidOptionsSpecifyCapacityDistribution : TeaModel {
                /// <summary>
                /// <para>The set of instance types. Duplicate instance types are not allowed, and the instance types must be within the scope of LaunchTemplateConfig.InstanceType.</para>
                /// </summary>
                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>The minimum number of instances to be delivered within the scope of InstanceTypes.</para>
                /// <remarks>
                /// <para>sum(MinTargetCapacity) &lt;= TotalTargetCapacity. The sum of MinTargetCapacity for all instance type sets cannot exceed TotalTargetCapacity. If the MinTargetCapacity requirement for any instance type set cannot be met due to inventory or other reasons, the entire request fails.</para>
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
        /// <para>The ID of the region where the auto provisioning group resides. You can invoke the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The resource pool policy used when creating instances. Take note of the following items when you configure this parameter:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when you create pay-as-you-go instances.</description></item>
        /// <item><description>This parameter takes effect only when you create an auto provisioning group of the instant delivery type (AutoProvisioningGroupType=instant).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public string ResourcePoolOptionsShrink { get; set; }

        /// <summary>
        /// <para>The policy for creating spot instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>lowest-price: the cost optimization policy. The instance type with the lowest price is selected.</para>
        /// </description></item>
        /// <item><description><para>diversified: the zone distribution balancing policy. Instances are created in the zones specified by the extended launch templates and evenly distributed across the zones.</para>
        /// </description></item>
        /// <item><description><para>capacity-optimized: the capacity optimization policy. The optimal instance types and zones are selected based on the inventory.</para>
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
        /// <para>The behavior of spot instances when they are interrupted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>stop: stops the instances.</para>
        /// </description></item>
        /// <item><description><para>terminate: releases the instances.</para>
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
        /// <para>The number of instance types with the lowest prices that are selected by the auto provisioning group to create instances. This parameter takes effect only when <c>SpotAllocationStrategy</c> is set to <c>lowest-price</c>.</para>
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
        /// <para>The list of system disk configurations for the instance.</para>
        /// </summary>
        [NameInMap("SystemDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestSystemDiskConfig> SystemDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestSystemDiskConfig : TeaModel {
            /// <summary>
            /// <para>The category of the system disk for the instance. You can use this parameter to specify multiple candidate disk categories. The specified order determines the priority of the disk categories. If a disk category is not active, the system automatically switches to the next disk category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: enterprise SSD.</description></item>
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
        /// <para>The list of tags bound to the auto provisioning group.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestTag> Tag { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the auto provisioning group.</para>
            /// <para>Valid values of N: 1 to 20. If this parameter is specified, it cannot be left empty. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the auto provisioning group.</para>
            /// <para>Valid values of N: 1 to 20. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to release the instances in the auto-provisioning group when the group is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the instances auto provisioning group.</description></item>
        /// <item><description>false: retains the instances auto provisioning group.</description></item>
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
        /// <para>Specifies whether to release the instances in the auto provisioning group when the group expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the instances in the group.</description></item>
        /// <item><description>false: only removes the instances from the group.</description></item>
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
        /// <para>The total target capacity must be greater than or equal to the sum of <c>PayAsYouGoTargetCapacity</c> (the target capacity of pay-as-you-go instances) and <c>SpotTargetCapacity</c> (the target capacity of spot instances).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=false)]
        public string TotalTargetCapacity { get; set; }

        /// <summary>
        /// <para>The time when the auto provisioning group starts. This parameter and <c>ValidUntil</c> determine the validity period.</para>
        /// <para>Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>Default value: the UNIX timestamp when the API operation takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-04-01T15:10:20Z</para>
        /// </summary>
        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// <para>The time when the auto provisioning group expires. This parameter and <c>ValidFrom</c> determine the validity period.</para>
        /// <para>Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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
