// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateLaunchTemplateRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateLaunchTemplateRequestSystemDisk SystemDisk { get; set; }
        public class CreateLaunchTemplateRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-gc7c37d4ylw7mtnk****</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The category of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk.</description></item>
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD. You can use the SystemDisk.PerformanceLevel parameter to set the performance level of the disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
            /// </list>
            /// <para>Default value: cloud for retired instance types that are not I/O optimized instances, and cloud_efficiency for other instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to release the system disk when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: releases the system disk when the instance is released.</description></item>
            /// <item><description>false: does not release the system disk when the instance is released.</description></item>
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
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length and can contain letters and Chinese characters. It cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSystemDiskDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length and can contain letters and Chinese characters. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSystemDiskName</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: encrypts the system disk.</description></item>
            /// <item><description>false: does not encrypt the system disk.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>You cannot encrypt the system disk when you create an instance in Zone D of the Hong Kong (China) region or Zone A of the Singapore region.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public int? Iops { get; set; }

            /// <summary>
            /// <para>The KMS key ID of the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD used as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0 (default): A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more details about how to select the performance level of an ESSD, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1800 + 50 × Capacity, 50000}.</para>
            /// <remarks>
            /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the provisioned information of an ESSD AutoPL disk</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: 20 to 500.</description></item>
            /// <item><description>Other disk categories: 20 to 2048.</description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to max{20, ImageSize}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The automatic release time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>If the ss value is not 00, the time is automatically rounded down to the current minute (mm).</description></item>
        /// <item><description>The earliest release time is half an hour after the current time.</description></item>
        /// <item><description>The latest release time cannot be more than three years after the current time.
        /// <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-01T12:05:00Z</para>
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the InstanceChargeType parameter is set to PrePaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Valid values: </para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PeriodUnit is set to Week: 1, 2, and 3.</description></item>
        /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The performance mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard mode. For more information about the performance of the instance, see the &quot;Standard mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// <item><description>Unlimited: unlimited mode. For more information about the performance of the instance, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The list of data disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestDataDisk> DataDisk { get; set; }
        public class CreateLaunchTemplateRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-m5e7fa9ute44ssa****</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>This parameter can be set to cloud_essd_entry only when InstanceType is set to an instance type in the ecs.u1 or ecs.e instance family.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>elastic_ephemeral_disk_standard: standard elastic ephemeral disk.</description></item>
            /// <item><description>elastic_ephemeral_disk_premium: Premium Edition elastic ephemeral disk.</description></item>
            /// </list>
            /// <para>Default values: cloud_efficiency for I/O optimized instances, and cloud for non-I/O optimized instances.
            /// Default value description:</para>
            /// <list type="bullet">
            /// <item><description>If the instance type is a retired and non-I/O optimized instance type, the default value is cloud.</description></item>
            /// <item><description>In other cases, the default value is cloud_efficiency. &lt;props=&quot;china&quot;&gt;After January 30, 2026, if the I/O optimized instance type does not support cloud_auto, the default value is cloud_efficiency. Otherwise, the default value is cloud_auto, and the performance burst feature is enabled by default (which incurs additional fees. For more details, see <a href="~~368372#p_75k_2hp_7gp~~">Billing examples</a>). For more details, see <a href="https://www.aliyun.com/notice/117844">Announcement</a>.</description></item>
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
            /// <item><description>true: releases the data disk when the instance is released.</description></item>
            /// <item><description>false: does not release the data disk when the instance is released.</description></item>
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
            /// <para>The description of the data disk. The description must be 2 to 256 characters in length and can contain letters and Chinese characters. It cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDataDiskDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the data disk. The naming convention for mount points varies based on the number of attached data disks:</para>
            /// <list type="bullet">
            /// <item><description><para>1 to 25 data disks: /dev/xvd[b-z].</para>
            /// </description></item>
            /// <item><description><para>More than 25 data disks: /dev/xvd[aa-zz]. For example, the 26th data disk is named /dev/xvdaa, and the 27th data disk is named /dev/xvdab.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is applicable only to full images. You can set this parameter to the mount point of the data disk in the full image and modify the DataDisk.N.Size and DataDisk.N.Category parameters to change the category and size of the data disk in the full image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the data disk. The name must be 2 to 128 characters in length and can contain letters and Chinese characters. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDataDiskName</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key used to encrypt the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD used as the data disk. The value of N must be the same as the value of N in DataDisk.N.Category=cloud_essd. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1 (default): A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more details about how to select the performance level of an ESSD, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1800 + 50 × Capacity, 50000}.</para>
            /// <remarks>
            /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the provisioned information of an ESSD AutoPL disk</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of data disk N. Valid values of N: 1 to 16. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: 5 to 2000.</description></item>
            /// <item><description>cloud_efficiency: 20 to 32768.</description></item>
            /// <item><description>cloud_ssd: 20 to 32768.</description></item>
            /// <item><description>cloud_essd: The valid values are subject to the value of DataDisk.N.PerformanceLevel.<list type="bullet">
            /// <item><description>PL0: 1 to 32768.</description></item>
            /// <item><description>PL1: 20 to 32768.</description></item>
            /// <item><description>PL2: 461 to 32768.</description></item>
            /// <item><description>PL3: 1261 to 32768.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>cloud_auto: 1 to 32768.</description></item>
            /// <item><description>cloud_essd_entry: 10 to 32768.</description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to the size of the snapshot specified by the SnapshotId parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot used to create data disk N. Valid values of N: 1 to 16. If you specify the DataDisk.N.SnapshotId parameter, the DataDisk.N.Size parameter is ignored. The actual size of the created disk is the size of the specified snapshot.</para>
            /// <remarks>
            /// <para>You cannot use snapshots created on or before July 15, 2013. Otherwise, the request is rejected.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>The release protection property of the instance. It specifies whether the instance can be released by using the console or by calling the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables release protection for the instance.</para>
        /// </description></item>
        /// <item><description><para>false: disables release protection for the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This property applies only to pay-as-you-go instances. It can prevent only manual release operations, but not system release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

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
        /// <para>The instance description. The description must be 2 to 256 characters in length and can contain letters and Chinese characters. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testECSDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the operating system configuration of the instance.</para>
        /// <remarks>
        /// <para>This parameter will be deprecated. To improve compatibility, we recommend that you use other parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableVmOsConfig")]
        [Validation(Required=false)]
        public bool? EnableVmOsConfig { get; set; }

        /// <summary>
        /// <para>The hostname of the Elastic Compute Service server.</para>
        /// <list type="bullet">
        /// <item><description>The hostname cannot start or end with a period (.) or a hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).</description></item>
        /// <item><description>For Windows instances, the hostname must be 2 to 15 characters in length and cannot contain periods (.). It cannot contain only digits. It can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>For instances of other operating systems such as Linux, the hostname must be 2 to 64 characters in length. It can contain multiple segments separated by periods (.). Each segment can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testHostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the access channel for instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: enables the access channel.</description></item>
        /// <item><description>disabled: disables the access channel.</description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para>For more information about instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Overview of instance metadata</a>.</para>
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
        /// <para>3</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly use the security hardening mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcibly use the security hardening mode.</description></item>
        /// <item><description>required: forcibly uses the security hardening mode. After you set this parameter to required, you cannot access instance metadata in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about the modes of accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Overview of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The image ID. This is the image resource selected when the instance is started. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query the available image resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>win2008r2_64_ent_sp1_en-us_40G_alibase_20170915.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image-related property information.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateLaunchTemplateRequestImageOptions ImageOptions { get; set; }
        public class CreateLaunchTemplateRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether the instance that uses this image supports logon as the ecs-user user. Valid values:</para>
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
        /// <para>The source of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: public images provided by Alibaba Cloud.</description></item>
        /// <item><description>self: custom images that you created.</description></item>
        /// <item><description>others: shared images from other Alibaba Cloud accounts.</description></item>
        /// <item><description>marketplace: images provided by &lt;props=&quot;china&quot;&gt;<ph><a href="https://market.aliyun.com/">Alibaba Cloud Marketplace</a></ph>&lt;props=&quot;intl&quot;&gt;<ph><a href="https://marketplace.alibabacloud.com/">Alibaba Cloud Marketplace</a></ph>. You can use the Alibaba Cloud Marketplace images that you queried without subscribing to them in advance. You must pay attention to the billing details of the Alibaba Cloud Marketplace images.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. If you select this billing method, &lt;props=&quot;china&quot;&gt;<ph>you must confirm that your account supports balance payment and credit payment</ph>&lt;props=&quot;intl&quot;&gt;<ph>you must confirm that your account supports credit payment</ph>. Otherwise, an InvalidPayMethod fault is returned.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 128 characters in length and can contain characters in the Letter category of Unicode, including letters and digits. It can contain colons (:), underscores (_), periods (.), and hyphens (-). Default value: the InstanceId of the instance.</para>
        /// <para>When you create multiple ECS instances, you can batch specify sequential instance names, which can contain square brackets ([]) and commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Batch specify sequential instance names or hostnames</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The resource specifications of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>. You can also invoke the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to obtain the most recent instance type list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
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
        /// <remarks>
        /// <para>In the pay-by-traffic pattern, the peak inbound and outbound bandwidths are used as upper limits of bandwidths instead of guaranteed performance specifications. In the event of resource contention, the peak bandwidths cannot be guaranteed. If your business requires guaranteed bandwidths, use the pay-by-bandwidth billing method.</para>
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
        /// <para>The number of IPv6 addresses to be randomly generated for the primary ENI. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// <list type="bullet">
        /// <item><description>For Windows instances, this parameter is ignored. Even if you specify this parameter, only the Password parameter takes effect.</description></item>
        /// <item><description>For Linux instances, the password logon method is disabled by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The name of the instance launch template. The name must be 2 to 128 characters in length and can contain letters and Chinese characters. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testLaunchTemplateName</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The Elastic Network Interface (ENI) information.</para>
        /// </summary>
        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestNetworkInterface> NetworkInterface { get; set; }
        public class CreateLaunchTemplateRequestNetworkInterface : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retain the ENI when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: does not retain the ENI.</para>
            /// </description></item>
            /// <item><description><para>false: retains the ENI.</para>
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
            /// <para>The description of the secondary ENI. The description must be 2 to 256 characters in length and cannot start with http:// or https://. The value of N in NetworkInterface.N cannot be greater than 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testEniDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the ENI. Valid values of N: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</para>
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
            /// <para>The name of the ENI.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you do not need to specify this parameter.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testEniName</para>
            /// </summary>
            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            /// <summary>
            /// <para>The communication mode of the primary ENI. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: uses the TCP communication mode.</description></item>
            /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication mode.</description></item>
            /// </list>
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
            /// <item><description><para>Valid values of N: 1 to 2:</para>
            /// <list type="bullet">
            /// <item><description>When you configure one ENI, you can configure one primary ENI or one secondary ENI. If the Amount parameter is set to a value greater than 1, and you configure a primary ENI and specify this parameter, consecutive primary IP addresses starting from the specified primary IP address are allocated to multiple ECS instances that are created in a batch. Note that you cannot bind secondary ENIs to the instances in this case.</description></item>
            /// <item><description>When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time. Note that if the Amount parameter is set to a value greater than 1 and you specify this parameter for the primary ENI, you cannot configure a secondary ENI (that is, you cannot set NetworkInterface.2.InstanceType=Secondary).</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, this parameter serves the same purpose as PrivateIpAddress, but you cannot specify both PrivateIpAddress and this parameter at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Secondary or left empty, this parameter specifies the primary IP address for the secondary ENI. By default, an IP address is randomly selected from the vSwitch CIDR block to which the ENI belongs.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>When you create an ECS instance, you can add only one secondary ENI. After the instance is created, you can call the <a href="https://help.aliyun.com/document_detail/58504.html">CreateNetworkInterface</a> and <a href="https://help.aliyun.com/document_detail/58515.html">AttachNetworkInterface</a> operations to add more secondary ENIs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><c>192.168.**.**</c></para>
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the ENI belongs.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you must specify this parameter. In this case, this parameter serves the same purpose as SecurityGroupId, but you cannot specify SecurityGroupId, SecurityGroupIds.N, or NetworkInterface.N.SecurityGroupIds.N at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Secondary or left empty, this parameter is optional. The default value is the security group to which the ECS instance belongs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp15ed6xe1yxeycg****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of one or more security groups to which the ENI belongs.</para>
            /// <list type="bullet">
            /// <item><description>The valid values of the first N are 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</description></item>
            /// <item><description>The second N specifies one or more security group IDs. The valid values of N depend on the quota of security groups to which an instance can be added. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
            /// </list>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you must specify this parameter or NetworkInterface.N.SecurityGroupId. In this case, this parameter serves the same purpose as SecurityGroupIds.N, but you cannot specify SecurityGroupId, SecurityGroupIds.N, or NetworkInterface.N.SecurityGroupId at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Secondary or left empty, this parameter is optional. The default value is the security group to which the ECS instance belongs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the ENI belongs.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Primary, you must specify this parameter. In this case, this parameter serves the same purpose as VSwitchId, but you cannot specify both VSwitchId and this parameter at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to Secondary or left empty, this parameter is optional. The default value is the vSwitch to which the ECS instance belongs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>classic: classic network. This network type is phased out. For more information, see <a href="https://help.aliyun.com/document_detail/2833134.html">Phasing-out notice</a>.</description></item>
        /// <item><description>vpc: VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the preset password of the image.</para>
        /// <remarks>
        /// <para>When you specify this parameter, leave Password empty and make sure that the selected image has a preset password.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription period of the instance. Unit: months. This parameter is valid and required only when InstanceChargeType is set to PrePaid. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The time unit for the subscription Billable methods. Valid values: </para>
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
        /// <para>The private IP address of the instance.</para>
        /// <para>When you specify the private IP address for an ECS instance in a VPC, the IP address must be selected from the idle CIDR block of the vSwitch specified by VSwitchId.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role. You can call the <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> operation provided by RAM to query the instance RAM roles that you have created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRamRoleName</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the instance, block storage, and elastic network interface (ENI) belong.</para>
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
        /// <para>Specifies whether to enable security hardening for the operating system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: enables security hardening. This value is applicable only to public images.</description></item>
        /// <item><description>Deactive: disables security hardening. This value is applicable to all image types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deactive</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the new instance belongs. Instances in the same security group can access each other. A security group can manage up to 1,000 instances.</para>
        /// <remarks>
        /// <para>You cannot specify both SecurityGroupId and SecurityGroupIds.N at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of one or more security groups to which the instance is added. The valid values of N depend on the quota of security groups to which an instance can be added. For more information, see <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para>You cannot specify both SecurityGroupId and SecurityGroupIds.N.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The security options.</para>
        /// </summary>
        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public CreateLaunchTemplateRequestSecurityOptions SecurityOptions { get; set; }
        public class CreateLaunchTemplateRequestSecurityOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable secure boot.</para>
            /// </summary>
            [NameInMap("EnableSecureBoot")]
            [Validation(Required=false)]
            public bool? EnableSecureBoot { get; set; }

            /// <summary>
            /// <para>The trusted system pattern. Valid value: vTPM.</para>
            /// <para>Currently, the trusted system pattern supports the following instance families:</para>
            /// <list type="bullet">
            /// <item><description>g7, c7, and r7.</description></item>
            /// <item><description>security-enhanced instance families (g7t, c7t, and r7t).</description></item>
            /// </list>
            /// <para>When you create an ECS instance of the preceding instance families, you must configure this parameter. Details:</para>
            /// <list type="bullet">
            /// <item><description>If you use the Alibaba Cloud trusted system, configure this parameter to vTPM. This way, the Alibaba Cloud trusted system performs trusted verification when the instance starts.</description></item>
            /// <item><description>If you do not use the Alibaba Cloud trusted system, you can leave this parameter empty. However, if the ECS instance that you create uses the Enclave confidential computing pattern (SecurityOptions.ConfidentialComputingMode=Enclave), the trusted system is also enabled for the ECS instance.</description></item>
            /// <item><description>When you create an ECS instance with the trusted system enabled by calling an API operation, you can only call the RunInstances operation. The CreateInstance operation does not support configuring the SecurityOptions.TrustedSystemMode parameter.<remarks>
            /// <para>If you specify an instance as a trusted instance when you create it, you can only use an image that supports the trusted system when you replace the system disk.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>For more information about the trusted system, see <a href="https://help.aliyun.com/document_detail/201394.html">Overview of the trusted feature for security-enhanced instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vTPM</para>
            /// </summary>
            [NameInMap("TrustedSystemMode")]
            [Validation(Required=false)]
            public string TrustedSystemMode { get; set; }

        }

        /// <summary>
        /// <para>The protection period of the spot instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Alibaba Cloud guarantees that the instance is not subject to automatic release within 1 hour after it is created. After 1 hour, the system automatically compares the bid price with the marketplace price and checks resource inventory to determine whether to retain or revoke the instance.</description></item>
        /// <item><description>0: Alibaba Cloud does not guarantee that the instance is retained for 1 hour after it is created. The system automatically compares the bid price with the marketplace price and checks resource inventory to determine whether to retain or revoke the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends you a notification by using an ECS system event 5 minutes before the instance is revoked. Spot instances use the billing method by second. We recommend that you select an appropriate protection period based on the execution duration of your tasks.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the instance. The value can be accurate to three decimal places. This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.97</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The preemption policy for the pay-as-you-go instance. This parameter takes effect only when InstanceChargeType is set to PostPaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is a spot instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is a spot instance for which the market price is automatically used as the bid price.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The tag information of the instances, cloud disks, and primary ENIs that are created by using this version of the launch template.</para>
        /// <details>
        /// <summary>Scenarios</summary>
        /// After you call the CreateLaunchTemplate operation to create a launch template and use the automatically generated default version to create instances, this tag is used to tag the instances, cloud disks, and primary ENIs.
        /// </details>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestTag> Tag { get; set; }
        public class CreateLaunchTemplateRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instances, cloud disks, and primary ENIs that are created by using this version of the launch template. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instances, cloud disks, and primary ENIs that are created by using this version of the launch template. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the launch template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("TemplateResourceGroupId")]
        [Validation(Required=false)]
        public string TemplateResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the launch template.</para>
        /// <remarks>
        /// <para>You can only create and query the tags of launch templates by calling API operations. You cannot create or view the tags in the console.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TemplateTag")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestTemplateTag> TemplateTag { get; set; }
        public class CreateLaunchTemplateRequestTemplateTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the launch template. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the launch template. Valid values of N: 1 to 20. If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Instance user data of the instance. Instance user data must be encoded in Base64. The maximum size of the raw data is 32 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is required when you create a VPC instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The description of the instance launch template version. The description must be 2 to 256 characters in length and can contain letters and Chinese characters. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testVersionDescription</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp12433upq1y5scen****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
