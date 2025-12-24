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
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationArn> Arn { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationArn : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
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
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
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
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
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
            /// <para>The automatic release time of the pay-as-you-go instance. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in Coordinated Universal Time (UTC).</para>
            /// <list type="bullet">
            /// <item><description>If the value of <c>ss</c> is not <c>00</c>, the start time is automatically rounded down to the nearest minute based on the value of <c>mm</c>.</description></item>
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
            /// <para>The performance mode of the burstable instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: the standard mode. For more information, see the &quot;Standard mode&quot; section in the <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a> topic.</description></item>
            /// <item><description>Unlimited: the unlimited mode. For more information, see the &quot;Unlimited mode&quot; section in the <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a> topic.</description></item>
            /// </list>
            /// <para>This parameter is empty by default.</para>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// <para>The cloud disks in the extended configurations of the launch template.</para>
            /// </summary>
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationDataDisk> DataDisk { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationDataDisk : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy to apply to data disk N.</para>
                /// <para>When you specify this parameter, take note of the following items:</para>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only when the AutoProvisioningGroupType parameter is set to instant.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the performance burst feature for the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: force attaches the disk to the instance.</description></item>
                /// <item><description>false: disables the performance burst feature for the system disk.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is available only if you set LaunchConfiguration.DataDisk.N.Category to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
                /// <item><description>cloud_efficiency: utra disk.</description></item>
                /// <item><description>cloud_ssd: standard SSD.</description></item>
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// <item><description>cloud: basic disk.</description></item>
                /// </list>
                /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Specifies whether to release data disk N when the instance to which the data disk is attached is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: releases data disk N when the associated instance is released.</description></item>
                /// <item><description>false: does not release data disk N when the associated instance is released.</description></item>
                /// </list>
                /// <para>Default value: true.</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The description of data disk N. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataDisk_Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The mount point of data disk N. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/vd1</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The name of data disk N. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
                /// <para>This parameter is left empty by default.</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
                /// <para>null</para>
                /// </summary>
                [NameInMap("EncryptAlgorithm")]
                [Validation(Required=false)]
                public string EncryptAlgorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt data disk N. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: encrypts system disk N.</description></item>
                /// <item><description>false: does not encrypt system disk N.</description></item>
                /// </list>
                /// <para>Default value: false. Valid values:</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The ID of the Key Management Service (KMS) key to use for data disk N. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the Enterprise SSD (ESSD) to use as data disk N. The value of N in this parameter must be the same as the value of N in <c>LaunchConfiguration.DataDisk.N.Category</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: A single ESSD can deliver up to 10000 random read/write IOPS.</description></item>
                /// <item><description>PL1 (default): A single ESSD can deliver up to 50000 random read/write IOPS.</description></item>
                /// <item><description>PL2: A single ESSD can deliver up to 100000 random read/write IOPS.</description></item>
                /// <item><description>PL3: A single ESSD can deliver up to 1000000 random read/write IOPS.</description></item>
                /// </list>
                /// <para>For information about ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk to use as the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
                /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
                /// <remarks>
                /// <para> This parameter is available only if you set LaunchConfiguration.DataDisk.N.Category to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
                /// <item><description><para>Valid values if you set LaunchConfiguration.DataDisk.N.Category to cloud_efficiency: 20 to 32768.</para>
                /// </description></item>
                /// <item><description><para>Valid values if you set LaunchConfiguration.DataDisk.N.Category to cloud_ssd: 20 to 32768.</para>
                /// </description></item>
                /// <item><description><para>Valid values if you set LaunchConfiguration.DataDisk.N.Category to cloud_essd: vary based on the <c>LaunchConfiguration.DataDisk.N.PerformanceLevel</c> value.</para>
                /// <list type="bullet">
                /// <item><description>Valid values if you set LaunchConfiguration.DataDisk.N.PerformanceLevel to PL0: 40 to 32768.</description></item>
                /// <item><description>Valid values if you set LaunchConfiguration.DataDisk.N.PerformanceLevel to PL1: 20 to 32768.</description></item>
                /// <item><description>Valid values if you set LaunchConfiguration.DataDisk.N.PerformanceLevel to PL2: 461 to 32768.</description></item>
                /// <item><description>Valid values if you set LaunchConfiguration.DataDisk.N.PerformanceLevel to PL3: 1261 to 32768.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Valid values if you set LaunchConfiguration.DataDisk.N.Category to cloud: 5 to 2000.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para> The value of this parameter must be greater than or equal to the size of the snapshot specified by <c>LaunchConfiguration.DataDisk.N.SnapshotId</c>.</para>
                /// </remarks>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot to use to create data disk N. Valid values of N: 1 to 16.</para>
                /// <para>If you specify this parameter, <c>LaunchConfiguration.DataDisk.N.Size</c> is ignored. The size of data disk N is the same as that of the snapshot specified by this parameter. Use snapshots created after July 15, 2013. Otherwise, an error is returned and your request is rejected.</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
            /// <para>The instance hostname. Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The hostname cannot start or end with a period (.) or hyphen (-). The hostname cannot contain consecutive periods (.) or hyphens (-).</description></item>
            /// <item><description>For Windows instances, the hostname must be 2 to 15 characters in length and cannot contain periods (.) or contain only digits. It can contain letters, digits, and hyphens (-).</description></item>
            /// <item><description>For instances that run other operating systems such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate a hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).</description></item>
            /// <item><description>You cannot specify both <c>LaunchConfiguration.HostName</c> and <c>LaunchConfiguration.HostNames.N</c>. Otherwise, an error is returned.</description></item>
            /// <item><description>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-node-[1,4]-ecshost</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The hostname of instance N. You can use this parameter to specify different hostnames for multiple instances. Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when <c>AutoProvisioningGroupType</c> is set to instant. </description></item>
            /// <item><description>The value of N indicates the number of instances. Valid values of N: 1 to 1000. The value of N must be the same as the TotalTargetCapacity value. </description></item>
            /// <item><description>The hostname cannot start or end with a period (.) or hyphen (-). The hostname cannot contain consecutive periods (.) or hyphens (-). </description></item>
            /// <item><description>For Windows instances, the hostname must be 2 to 15 characters in length and cannot contain periods (.) or contain only digits. The hostname can contain letters, digits, and hyphens (-). </description></item>
            /// <item><description>For instances that run other operating systems such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-). </description></item>
            /// <item><description>You cannot specify both <c>LaunchConfiguration.HostName</c> and <c>LaunchConfiguration.HostNames.N</c>. Otherwise, an error is returned. </description></item>
            /// <item><description>When both LaunchTemplateId and LaunchConfiguration.* parameters are specified, LaunchTemplateId takes precedence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-host-01</para>
            /// </summary>
            [NameInMap("HostNames")]
            [Validation(Required=false)]
            public List<string> HostNames { get; set; }

            /// <summary>
            /// <para>The name of the image family. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>aliyun</c> or <c>acs:</c>. The name cannot contain <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou-daily-update</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The ID of the image to be used to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query available image resources. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp1g7004ksh0oeuc****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance description. The description must be 2 to 256 characters in length. The description can contain letters and cannot start with <c>http://</c> or <c>https://</c>. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance_Description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The instance name. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>The default value of this parameter is the <c>InstanceId</c> value.</para>
            /// <para>When you batch create instances, you can batch configure sequential names for the instances. For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for multiple instances</a>.</para>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
            /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
            /// <item><description>PayByTraffic: pay-by-traffic</description></item>
            /// </list>
            /// <remarks>
            /// <para> When the pay-by-traffic billing method for network usage is used, the maximum inbound and outbound bandwidth values are used as the upper limits of bandwidth instead of guaranteed performance specifications. When demands outstrip resource supplies, the maximum bandwidths may be limited. If you want guaranteed bandwidth for your instance, use the pay-by-bandwidth billing method.</para>
            /// </remarks>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
            /// <item><description>When the maximum outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of this parameter are 1 to 10 and the default value is 10.</description></item>
            /// <item><description>When the maximum outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the value of <c>LaunchConfiguration.InternetMaxBandwidthOut</c>, and the default value is the value of <c>LaunchConfiguration.InternetMaxBandwidthOut</c>.</description></item>
            /// </list>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
            /// <item><description>none: The instance is not I/O optimized.</description></item>
            /// <item><description>optimized: The instance is I/O optimized.</description></item>
            /// </list>
            /// <para>For instances of retired instance types, the default value is none. For instances of other instance types, the default value is optimized.</para>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
            /// <item><description>For Windows instances, this parameter is ignored. This parameter is empty by default.</description></item>
            /// <item><description>By default, password-based logon is disabled for Linux instances.</description></item>
            /// </list>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyPair_Name</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The instance password. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The password can contain the following special characters:</para>
            /// <para><c>( ) ` ~ ! @ # $ % ^ &amp; * - _ + = | { }  </c>: ; \&quot; &lt; &gt; , . ? /``  For Windows instances, the password cannot start with a forward slash (/). When both LaunchTemplateId and LaunchConfiguration.* parameters are specified, LaunchTemplateId takes precedence. `</para>
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
            /// <item><description>true: uses the password preset in the image.</description></item>
            /// <item><description>false: does not use the password preset in the image.</description></item>
            /// </list>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// <para>The name of the instance Resource Access Management (RAM) role. You can call the <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> operation provided by RAM to query the instance RAM roles that you created. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM_Name</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which to assign the instance. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which to assign the instance. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp15ed6xe1yxeycg****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of the security groups to which the new ECS instances belong.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The system disk information of instances. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSystemDisk SystemDisk { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationSystemDisk : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy to apply to the system disk.</para>
                /// <para>When you specify this parameter, take note of the following items:</para>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only when the AutoProvisioningGroupType parameter is set to instant.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the performance burst feature for the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: force attaches the disk to the instance.</description></item>
                /// <item><description>false: disables the performance burst feature for the system disk.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is available only if you set <c>LaunchConfiguration.SystemDisk.Category</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The algorithm to use to encrypt the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>aes-256</description></item>
                /// <item><description>sm4-128</description></item>
                /// </list>
                /// <para>Default value: aes-256.</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
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
                /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: encrypts system disk N.</description></item>
                /// <item><description>false: does not encrypt system disk N.</description></item>
                /// </list>
                /// <para>Default value: false. Valid values:</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// <para>The ID of the KMS key to use for system disk N.</para>
                /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk to use as the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
                /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
                /// <remarks>
                /// <para> This parameter is available only if you set LaunchConfiguration.SystemDisk.Category to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>cloud_essd: enhanced SSD (ESSD)</description></item>
            /// <item><description>cloud: basic disk</description></item>
            /// </list>
            /// <para>For non-I/O optimized instances of retired instance types, the default value is cloud. For other instances, the default value is cloud_efficiency.</para>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length. The description can contain letters and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDisk_Description</para>
            /// </summary>
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
            /// <para>This parameter is empty by default.</para>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD to be used as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0 (default): A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more information about ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Valid values: 20 to 500. Unit: GiB. The value must be at least 20 and greater than or equal to the size of the image specified by LaunchConfiguration.ImageId.</para>
            /// <para>Default value: 40 or the size of the image specified by LaunchConfiguration.ImageId, whichever is greater.</para>
            /// <para>When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The tag in the extended configurations of the launch template.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationTag> Tag { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationTag : TeaModel {
                /// <summary>
                /// <para>The key of the tag. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain <c>http://</c> or <c>https://</c>. If both the LaunchTemplateId and LaunchConfiguration.* parameters are specified, the LaunchTemplateId parameter takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length. It cannot start with acs: or contain <c>http://</c> or <c>https://</c>. If both the LaunchTemplateId and LaunchConfiguration.* parameters are specified, the LaunchTemplateId parameter takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The instance user data. The user data must be encoded in Base64. The raw data can be up to 32 KB in size. When both LaunchTemplateId and LaunchConfiguration.\* parameters are specified, LaunchTemplateId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the reserved instance. This parameter is required only when the instance uses the subscription billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal period of the instance. Valid values:</para>
            /// <para>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            [NameInMap("CpuOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationCpuOptions CpuOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationCpuOptions : TeaModel {
                [NameInMap("Core")]
                [Validation(Required=false)]
                public int? Core { get; set; }

                [NameInMap("ThreadsPerCore")]
                [Validation(Required=false)]
                public int? ThreadsPerCore { get; set; }

            }

            /// <summary>
            /// <para>The image options.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when the AutoProvisioningGroupType parameter is set to instant.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ImageOptions")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationImageOptions ImageOptions { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestLaunchConfigurationImageOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether the instance that uses the image supports logons of the ecs-user user. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>true: The instance that uses the image supports logons of the ecs-user user.</description></item>
                /// <item><description>false: The instance that uses the image does not support logons of the ecs-user user.</description></item>
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
            /// <para>The subscription period of the instance. The unit is specified by <c>PeriodUnit</c>. This parameter takes effect and is required only if the subscription billing method is selected. Valid values:</para>
            /// <para>Valid values if PeriodUnit is set to Month: 1, 2, 3, 6, and 12.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription period. Default value: Month. Valid values:</para>
            /// <para>Month</para>
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
            /// <para>The protection period of the spot instance. Unit: hours. Default value: 1. Valid values: Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: After a spot instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
            /// <item><description>0: After a spot instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
            /// </list>
            /// <para>Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. The spot instance is billed by second. We recommend that you specify an appropriate protection period based on your business requirements.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when the AutoProvisioningGroupType parameter is set to instant.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// <para>The interruption event of the spot instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Terminate: The instance is released.</description></item>
            /// <item><description>Stop: The instance is stopped in economical mode.</description></item>
            /// </list>
            /// <para>For information about the economical mode, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
            /// <para>Default value: Terminate.</para>
            /// <para>When you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when the AutoProvisioningGroupType parameter is set to instant.</description></item>
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
        /// <para>The name of the auto provisioning group. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
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
        /// <item><description>request: one-time asynchronous delivery. When the auto provisioning group is started, it attempts to asynchronously deliver an instance cluster that meets the target capacity only once. The group does not retry the operation regardless of whether all the instances are delivered.</description></item>
        /// <item><description>instant: one-time synchronous delivery. When the auto provisioning group is started, it attempts to synchronously deliver an instance cluster that meets the target capacity only once. The list of delivered instances and the causes of delivery failures are returned in the response.</description></item>
        /// <item><description>maintain: continuous delivery. When the auto provisioning group is started, it attempts to deliver an instance cluster that meets the target capacity, and monitors the real-time capacity. If the target capacity of the auto provisioning group is not reached, the auto provisioning group continues to create instances until the target capacity is reached.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The information of data disks on the instance.</para>
        /// </summary>
        [NameInMap("DataDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestDataDiskConfig> DataDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestDataDiskConfig : TeaModel {
            /// <summary>
            /// <para>The category of data disk N. You can use this parameter to specify multiple disk categories, and the disk categories are prioritized in the order in which they are specified. If a specified disk category is unavailable, the system uses the next available disk category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>cloud_essd: ESSD</description></item>
            /// <item><description>cloud: basic disk</description></item>
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
        /// <para>The type of supplemental instances. When the sum of the <c>PayAsYouGoTargetCapacity</c> and <c>SpotTargetCapacity</c> values is smaller than the <c>TotalTargetCapacity</c> value, the auto provisioning group creates instances of the specified type to meet the total target capacity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
        /// <item><description>Spot: spot instance</description></item>
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
        /// <para>Specifies whether to release scaled-in instances when the real-time capacity of the auto provisioning group exceeds the target capacity and the group is triggered to scale in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>termination: releases the scaled-in instances in the auto provisioning group.</description></item>
        /// <item><description>no-termination: removes the scaled-in instances from the auto provisioning group but does not release the instances.</description></item>
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
        /// <para>The extended configurations of the launch template.</para>
        /// </summary>
        [NameInMap("LaunchTemplateConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestLaunchTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The architectures of the instance types.</para>
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
            /// <para>The numbers of vCPUs of instance types.</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public List<int?> Cores { get; set; }

            /// <summary>
            /// <para>The instance types that you want to exclude.</para>
            /// </summary>
            [NameInMap("ExcludedInstanceTypes")]
            [Validation(Required=false)]
            public List<string> ExcludedInstanceTypes { get; set; }

            /// <summary>
            /// <para>The ID of the image. You can use this parameter to specify the image that is used by the current resource pool. If you do not specify this parameter, the image that is configured in <c>LaunchConfiguration.ImageId</c> or the launch template is used by default. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query the available images. Note: This parameter is supported only when <c>AutoProvisioningGroupType</c> is set to instant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20210425.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance family level of the instance type in extended configuration N. This parameter is used to filter instance types. Valid values of Nextended configuration N, Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: entry level (shared instance types). Instance types of this level are the most cost-effective but may not ensure stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise level. Instance types of this level provide stable performance and dedicated resources and are suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: credit entry level. This value is valid only for burstable instances. CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For information about burstable instances, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview</a>.</description></item>
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
            /// <para>The instance type in extended configuration N. Valid values of N: 1 to 20. For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum price of spot instances in extended configuration N.</para>
            /// <remarks>
            /// <para> If you specify one or more <c>LaunchTemplateConfig.N.*</c> parameters, you must also specify <c>LaunchTemplateConfig.N.MaxPrice</c>.</para>
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
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MaxQuantity")]
            [Validation(Required=false)]
            public int? MaxQuantity { get; set; }

            /// <summary>
            /// <para>The memory sizes of instance types.</para>
            /// </summary>
            [NameInMap("Memories")]
            [Validation(Required=false)]
            public List<float?> Memories { get; set; }

            /// <summary>
            /// <para>The priority of extended configuration N. A value of 0 indicates the highest priority. Valid values: 0 to ∞.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch in extended configuration N. The zone of the ECS instances created from the extended configuration is determined by the vSwitch.</para>
            /// <remarks>
            /// <para> If you specify one or more <c>LaunchTemplateConfig.N.*</c> parameters, you must also specify <c>LaunchTemplateConfig.N.VSwitchId</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sn5bsitu4lfzgc5o7****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The weight of the instance type in extended configuration N. A greater weight indicates that a single instance has more computing power and fewer instances are required. The value must be greater than 0.</para>
            /// <para>The weight is calculated based on the computing power of the specified instance type and the minimum computing power of a single instance in the cluster to be created by the auto provisioning group. For example, assume that the minimum computing power of a single instance is 8 vCPUs and 60 GiB of memory.</para>
            /// <list type="bullet">
            /// <item><description>For an instance type with 8 vCPUs and 60 GiB of memory, you can set the weight to 1.</description></item>
            /// <item><description>For an instance type with 16 vCPUs and 120 GiB of memory, you can set the weight to 2.</description></item>
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
        /// <para>The ID of the launch template associated with the auto provisioning group. You can call the <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a> operation to query available launch templates. When both LaunchTemplateId and <c>LaunchConfiguration.*</c> parameters are specified, LaunchTemplateId takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp1fgzds4bdogu03****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The version of the launch template associated with the auto provisioning group. You can call the <a href="https://help.aliyun.com/document_detail/73761.html">DescribeLaunchTemplateVersions</a> operation to query the versions of available launch templates.</para>
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
        /// <para> When both <c>MaxSpotPrice</c> and <c>LaunchTemplateConfig.N.MaxPrice</c> are specified, the smaller one of the two parameter values is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxSpotPrice")]
        [Validation(Required=false)]
        public float? MaxSpotPrice { get; set; }

        /// <summary>
        /// <para>The minimum target capacity of the auto provisioning group. The value must be a positive integer. When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <c>AutoProvisioningGroupType</c> is set to instant. </description></item>
        /// <item><description>If the number of instances that can be created in the current region is smaller than the value of this parameter, the operation cannot be called and no instances are created. </description></item>
        /// <item><description>If the number of instances that can be created in the current region is greater than the value of this parameter, instances can be created based on the specified parameters.</description></item>
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
        /// <item><description>lowest-price: cost optimization policy. The auto provisioning group selects the lowest-priced instance type to create instances.</description></item>
        /// <item><description>prioritized: priority-based policy. The auto provisioning group creates instances based on the priority specified by <c>LaunchTemplateConfig.N.Priority</c>.</description></item>
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
        /// <para>The target capacity of pay-as-you-go instances in the auto provisioning group. The value must be less than or equal to the <c>TotalTargetCapacity</c> value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PayAsYouGoTargetCapacity")]
        [Validation(Required=false)]
        public string PayAsYouGoTargetCapacity { get; set; }

        /// <summary>
        /// <para>The capacity details of the subscription instance.</para>
        /// </summary>
        [NameInMap("PrePaidOptions")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupShrinkRequestPrePaidOptions PrePaidOptions { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestPrePaidOptions : TeaModel {
            /// <summary>
            /// <para>The minimum capacity set for different instance types. This parameter is valid only when <c>AutoProvisioningGroupType</c> is set to request.</para>
            /// </summary>
            [NameInMap("SpecifyCapacityDistribution")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupShrinkRequestPrePaidOptionsSpecifyCapacityDistribution> SpecifyCapacityDistribution { get; set; }
            public class CreateAutoProvisioningGroupShrinkRequestPrePaidOptionsSpecifyCapacityDistribution : TeaModel {
                /// <summary>
                /// <para>Details about the instance types. Duplicate instance types are not allowed and the instance types are within the LaunchTemplateConfig.InstanceType range.</para>
                /// </summary>
                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>The minimum number of instances to be delivered within the <c>InstanceTypes</c> range.</para>
                /// <remarks>
                /// <para> <c>sum(MinTargetCapacity)&lt;= TotalTargetCapacity</c> indicates that the sum of MinTargetCapacity values of all instance types cannot exceed the TotalTargetCapacity value. If any instance type set cannot meet the MinTargetCapacity requirement due to insufficient inventory or other reasons, the entire request fails.</para>
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
        /// <para>The ID of the region in which to create the auto provisioning group. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the auto provisioning group.</para>
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
        /// <para>The resource pool options to use to create instances. When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when the auto provisioning group creates pay-as-you-go instances.</description></item>
        /// <item><description>This parameter takes effect only if you set <c>AutoProvisioningGroupType</c> to instant.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public string ResourcePoolOptionsShrink { get; set; }

        /// <summary>
        /// <para>The policy for creating spot instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>lowest-price: cost optimization policy. The auto provisioning group selects the lowest-priced instance type to create instances.</description></item>
        /// <item><description>diversified: balanced distribution policy. The auto provisioning group creates instances in zones that are specified in extended configurations and then evenly distributes the instances across the zones.</description></item>
        /// <item><description>capacity-optimized: capacity-optimized distribution policy. The auto provisioning group creates instances of the optimal instance types across the optimal zones based on resource availability.</description></item>
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
        /// <para>The operation to be performed on the spot instance when it is interrupted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>stop: stops the spot instance.</description></item>
        /// <item><description>terminate: releases the spot instance.</description></item>
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
        /// <para>The number of spot instances of the lowest-priced instance type to be created by the auto provisioning group. This parameter takes effect when <c>SpotAllocationStrategy</c> is set to <c>lowest-price</c>.</para>
        /// <para>The value must be smaller than the N value specified in <c>LaunchTemplateConfig.N</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SpotInstancePoolsToUseCount")]
        [Validation(Required=false)]
        public int? SpotInstancePoolsToUseCount { get; set; }

        /// <summary>
        /// <para>The target capacity of spot instances in the auto provisioning group. The value must be less than or equal to the <c>TotalTargetCapacity</c> value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SpotTargetCapacity")]
        [Validation(Required=false)]
        public string SpotTargetCapacity { get; set; }

        /// <summary>
        /// <para>The information of system disks on the instance.</para>
        /// </summary>
        [NameInMap("SystemDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestSystemDiskConfig> SystemDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestSystemDiskConfig : TeaModel {
            /// <summary>
            /// <para>The category of the system disk. You can specify multiple disk categories, and the disk categories are prioritized in the order in which they are specified. If a specified disk category is unavailable, the system uses the next available disk category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD</description></item>
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
        /// <para>The tags to add to the auto provisioning group.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupShrinkRequestTag> Tag { get; set; }
        public class CreateAutoProvisioningGroupShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the auto provisioning group.</para>
            /// <para>Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the auto provisioning group.</para>
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
        /// <para>Specifies whether to release instances in the auto provisioning group when the auto provisioning group is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the instances.</description></item>
        /// <item><description>false: retains the instances.</description></item>
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
        /// <para>Specifies whether to release instances in the auto provisioning group when the group expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the instances.</description></item>
        /// <item><description>false: only removes the instances from the auto provisioning group but does not release them.</description></item>
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
        /// <para>The total target capacity of the auto provisioning group. The value must be a positive integer.</para>
        /// <para>The total target capacity of the auto provisioning group must be greater than or equal to the sum of the target capacity of pay-as-you-go instances specified by <c>PayAsYouGoTargetCapacity</c> and the target capacity of spot instances specified by <c>SpotTargetCapacity</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=false)]
        public string TotalTargetCapacity { get; set; }

        /// <summary>
        /// <para>The time at which to start the auto provisioning group. The period of time between this point in time and the point in time specified by <c>ValidUntil</c> is the validity period of the auto provisioning group.</para>
        /// <para>Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>By default, an auto provisioning group is started immediately after it is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-04-01T15:10:20Z</para>
        /// </summary>
        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// <para>The time at which the auto provisioning group expires. The period of time between this point in time and the point in time specified by <c>ValidFrom</c> is the validity period of the auto provisioning group.</para>
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
