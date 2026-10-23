// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("HibernationOptions")]
        [Validation(Required=false)]
        public CreateInstanceRequestHibernationOptions HibernationOptions { get; set; }
        public class CreateInstanceRequestHibernationOptions : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not supported.</para>
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
        public CreateInstanceRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateInstanceRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool. It is the ID of the elasticity assurance or capacity reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The private pool options for starting spot instance. After an elasticity assurance or a capacity reservation takes effect, a private pool is generated for you to select when you start spot instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open mode. The system automatically matches an open private pool. If no matching private pool is available, the system uses resources from the public pool to start spot instance. In this mode, you do not need to specify the PrivatePoolOptions.Id parameter.</description></item>
            /// <item><description>Target: specified mode. The system uses the specified private pool to start spot instance. If the specified private pool is unavailable, spot instance fails to start. In this mode, you must specify the private pool ID, which means the PrivatePoolOptions.Id parameter is required.</description></item>
            /// <item><description>None: no private pool. Spot instance is started without using private pool capacity.</description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// <para>In any of the following scenarios, the private pool option for starting spot instance can only be set to None or left empty:</para>
            /// <list type="bullet">
            /// <item><description>Create a preemptible instance.</description></item>
            /// <item><description>Create an ECS instance on a dedicated host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateInstanceRequestSystemDisk SystemDisk { get; set; }
        public class CreateInstanceRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The category of the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>cloud: basic cloud disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.<remarks>
            /// <para>This parameter supports the cloud_essd_entry value only when the InstanceType Settings are <a href="https://help.aliyun.com/document_detail/457079.html">general computing power instance family u1</a> (ecs.u1) or <a href="https://help.aliyun.com/document_detail/108489.html">Economy instance family e</a> (ecs.e).</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>For phased-out instance types that are not I/O optimized instances, the default value is cloud. For other instance types, the default value is cloud_efficiency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the system cloud disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// <para>Default value: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system cloud disk. The name must be 2 to 128 characters in length and can contain letters and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>Default value: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDiskName</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Settings of the performance level of the ESSD used as the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS. This is the default value.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more information about how to select the performance level of an ESSD, see <a href="https://help.aliyun.com/document_detail/122389.html">standard SSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Basic cloud disk: 20 to 500.</para>
            /// </description></item>
            /// <item><description><para>Other cloud disk types: 20 to 2048.</para>
            /// </description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to max{20, ImageSize}.</para>
            /// <para>Default value: max{40, ImageSize}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The dedicated block storage cluster ID. If you need to use a cloud disk in a dedicated block storage cluster as the system cloud disk when creating an ECS instance, specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
            /// </summary>
            [NameInMap("StorageClusterId")]
            [Validation(Required=false)]
            public string StorageClusterId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to associate the instance on a dedicated host with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The instance is not associated with the dedicated host. If an instance in the economical mode is stopped and then started, and the original dedicated host has insufficient resources, the instance is deployed on another dedicated host in the automatic deployment resource pool.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with the dedicated host. If an instance in the economical mode is stopped and then started, it is still deployed on the original dedicated host. If the original dedicated host has insufficient resources, the instance fails to start.</para>
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
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestArn> Arn { get; set; }
        public class CreateInstanceRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
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
            /// <para>Primary</para>
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
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when InstanceChargeType is set to PrePaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: disables auto-renewal. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. This parameter is required when AutoRenew is set to true.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;When PeriodUnit is set to Week, valid values of AutoRenewPeriod are 1, 2, and 3.</para>
        /// <para>When PeriodUnit is set to Month, valid values of AutoRenewPeriod are 1, 2, 3, 6, and 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the cluster to which the instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is about to be deprecated. To improve compatibility, use other parameters instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

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
        /// <para>The data cloud disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestDataDisk> DataDisk { get; set; }
        public class CreateInstanceRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The category of data cloud disk N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>cloud: basic cloud disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry.<remarks>
            /// <para>The cloud_essd_entry value is supported only when InstanceType is set to the ecs.u1 or ecs.e instance family.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>elastic_ephemeral_disk_standard: standard ESSD Entry disk.</description></item>
            /// <item><description>elastic_ephemeral_disk_premium: premium ESSD Entry disk.</description></item>
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
            /// <para>Specifies whether to release data cloud disk N when the instance is released.</para>
            /// <list type="bullet">
            /// <item><description>true: releases the data cloud disk.</description></item>
            /// <item><description>false: does not release the data cloud disk.</description></item>
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
            /// <para>The description of data cloud disk N. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of data cloud disk N.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to full images. You can set this parameter to the mount point of the data cloud disk in the full image, and modify the DataDisk.N.Size and DataDisk.N.Category parameters to change the category and size of the data cloud disk in the full image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of data cloud disk N. The name must be 2 to 128 characters in length and can contain letters and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataDiskName</para>
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
            /// <para>Specifies whether to encrypt data cloud disk N.</para>
            /// <list type="bullet">
            /// <item><description><para>true: encrypts the data cloud disk.</para>
            /// </description></item>
            /// <item><description><para>false: does not encrypt the data cloud disk.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used by the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>Settings of the performance level of the ESSD used as data cloud disk N. The value of N must be the same as the value of N in DataDisk.N.Category=cloud_essd. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS. This is the default value.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more information about how to select the performance level of an ESSD, see <a href="https://help.aliyun.com/document_detail/122389.html">standard SSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL2</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of data cloud disk N. Valid values of N: 1 to 16. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: 20 to 32768.</description></item>
            /// <item><description>cloud_ssd: 20 to 32768.</description></item>
            /// <item><description>cloud_essd: The valid values depend on the value of DataDisk.N.PerformanceLevel.<list type="bullet">
            /// <item><description>PL0: 1 to 65,536.</description></item>
            /// <item><description>PL1: 20 to 65,536.</description></item>
            /// <item><description>PL2: 461 to 65,536.</description></item>
            /// <item><description>PL3: 1261 to 65,536.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>cloud: 5 to 2000.</description></item>
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
            /// <para>The ID of the snapshot used to create data cloud disk N. Valid values of N: 1 to 16.</para>
            /// <list type="bullet">
            /// <item><description><para>If you specify the DataDisk.N.SnapshotId parameter, the DataDisk.N.Size parameter is ignored, and the actual size of the created cloud disk is the size of the specified snapshot.</para>
            /// </description></item>
            /// <item><description><para>You cannot use snapshots created on or before July 15, 2013. Otherwise, the request is rejected with an error.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster. If you want to use cloud disk resources in a dedicated block storage cluster as data cloud disks when you create an ECS instance, specify this parameter.</para>
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
        /// &lt;props=&quot;china&quot;&gt;You can call the <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> operation to query the list of dedicated host IDs.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;You can call the <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> operation to query the list of dedicated host IDs.</para>
        /// <remarks>
        /// <para>Notice: Dedicated hosts do not support spot instance. If you specify the DedicatedHostId parameter, the SpotStrategy and SpotPriceLimit Settings in the request are automatically ignored.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The release protection attribute of the instance. It specifies whether the instance can be released through the console or by calling the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>true: enables release protection for the instance.</description></item>
        /// <item><description>false: disables release protection for the instance. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This attribute applies only to pay-as-you-go instances and restricts only manual release operations. It does not take effect on system release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The group number of the instance in the deployment set. This parameter is valid when the deployment set uses the high availability group strategy (AvailabilityGroup). Valid values: 1 to 7.</para>
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
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceTest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run and does not create the instance. The system checks whether required parameters are specified, the request format, service limits, and ECS inventory. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false: performs a dry run and creates the instance if the check succeeds. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The hostname of the instance.</para>
        /// <list type="bullet">
        /// <item><description>The hostname cannot start or end with a period (.) or a hyphen (-), and cannot contain consecutive periods (.) or hyphens (-).</description></item>
        /// <item><description>For Windows instances: The hostname must be 2 to 15 characters in length and cannot contain periods (.). It cannot contain only digits. It can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>For other instances such as Linux instances: The hostname must be 2 to 64 characters in length and can contain multiple periods (.). The string between two consecutive periods is a segment, which can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LocalHostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

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
        /// <para>Specifies whether to forcibly use the security hardening mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcibly use IMDSv2.</description></item>
        /// <item><description>required: forcibly uses IMDSv2. After you set this value, you cannot access instance metadata in normal mode.</description></item>
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
        /// <para>The name of the image family. You can set this parameter to use the latest available image in the image family to create the instance.</para>
        /// <list type="bullet">
        /// <item><description>If ImageId is specified, you cannot specify this parameter.</description></item>
        /// <item><description>If ImageId is not specified, you can specify this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image used to start the instance. To use an Alibaba Cloud Marketplace image, you can view the ImageId on the image details page in Alibaba Cloud Marketplace. This parameter is required unless you specify ImageFamily to use the latest available image in the image family.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ubuntu_18_04_64_20G_alibase_20190624.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The internal IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.168.**.**</c></para>
        /// </summary>
        [NameInMap("InnerIpAddress")]
        [Validation(Required=false)]
        public string InnerIpAddress { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. If you select this billing method, make sure that your account supports balance payment or credit payment. Otherwise, an InvalidPayMethod error is returned.</description></item>
        /// <item><description>PostPaid: pay-as-you-go. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 128 characters in length and can contain letters and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-). If this parameter is not specified, the default value is the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <list type="bullet">
        /// <item><description>Instance type selection: See <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to view the performance data of the target instance type. Alternatively, see <a href="https://help.aliyun.com/document_detail/58291.html">Instance type selection</a> to learn how to select an instance type.</description></item>
        /// <item><description>Inventory query: Call the <a href="https://help.aliyun.com/document_detail/66186.html">DescribeAvailableResource</a> operation to check the resource availability in a specified region or zone.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <item><description>PayByTraffic: pay-by-traffic. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>In <b>pay-by-traffic</b> mode, the peak inbound and outbound bandwidths are upper limits and are not guaranteed. When resource contention occurs, the peak bandwidths may be limited. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
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
        /// <item><description>When the purchased outbound bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
        /// <item><description>When the purchased outbound bandwidth is greater than 10 Mbit/s: 1 to the value of InternetMaxBandwidthOut. Default value: the value of InternetMaxBandwidthOut.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
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
        /// <para>For <a href="https://help.aliyun.com/document_detail/55263.html">phased-out instance types</a>, the default value is none.</para>
        /// <para>For other instance types, the default value is optimized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// <remarks>
        /// <para>For Windows instances, this parameter is ignored. Default value: empty. Even if you specify this parameter, only the Password parameter takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPairTestName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

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
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("NodeControllerId")]
        [Validation(Required=false)]
        public string NodeControllerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description>If you specify the Password parameter, send requests over HTTPS to prevent password leaks.</description></item>
        /// <item><description>For Windows instances, the password cannot start with a forward slash (/).</description></item>
        /// <item><description>Instances running certain operating systems do not support password configuration and only support key pair configuration, such as Others Linux and Fedora CoreOS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TestEcs123!</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the preset password of the image. When you use this parameter, leave the Password parameter empty and make sure that the selected image has a preset password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription period of the resource. The unit is specified by PeriodUnit. This parameter is required and takes effect only when InstanceChargeType is set to PrePaid. If DedicatedHostId is specified, the subscription period cannot exceed the subscription period of the dedicated host. Valid values:</para>
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
        /// <para>The unit of the subscription period. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Week</description></item>
        /// <item><description>Month</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;Month.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;Month.</para>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance. The IP address must be an available IP address within the CIDR block of the vSwitch specified by VSwitchId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.236.*</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role. You can use the RAM API operation <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query the instance RAM roles that you have created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAMTestName</para>
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
        /// <item><description>Active: enables security hardening. This value is applicable only to public images.</description></item>
        /// <item><description>Deactive: disables security hardening. This value is applicable to all image types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the new instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The protection period of the preemptible instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Alibaba Cloud guarantees that spot instance will not undergo automatic release within 1 hour after it is created. After 1 hour, the system automatically compares the bid price with the marketplace price and checks resource inventory to determine whether to retain or revoke spot instance.</description></item>
        /// <item><description>0: Alibaba Cloud does not guarantee that spot instance runs for 1 hour after it is created. The system automatically compares the bid price with the marketplace price and checks resource inventory to determine whether to retain or revoke spot instance.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The Settings of this parameter can only be 0 or 1.</description></item>
        /// <item><description>Spot instances are billed by the second. Select an appropriate protection period based on the execution duration of your node.</description></item>
        /// <item><description>Alibaba Cloud sends you a notification through ECS system events 5 minutes before spot instance is revoked.</description></item>
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
        /// <para>The interruption behavior of the preemptible instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Terminate: releases the instance.</para>
        /// </description></item>
        /// <item><description><para>Stop: puts the instance into the break mode.</para>
        /// <para>For more information about the break mode, see <a href="https://help.aliyun.com/document_detail/63353.html">Break mode for pay-as-you-go instances</a>.</para>
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
        /// <para>The maximum hourly price of the instance. The value can be accurate to three decimal places. This parameter takes effect when SpotStrategy is set to SpotWithPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.98</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The preemption policy for spot instance. This parameter takes effect when InstanceChargeType is set to PostPaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: Spot instance is a regular pay-as-you-go instance. This is the default value.</description></item>
        /// <item><description>SpotWithPriceLimit: Spot instance is a preemptible instance with a maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: Spot instance is a preemptible instance for which the market price is automatically used as the bid price.</description></item>
        /// </list>
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
        /// <para>ss-bp1j4i2jdf3owlhe****</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTag> Tag { get; set; }
        public class CreateInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance, cloud disk, and primary ENI. Valid values of N: 1 to 20. If this parameter is specified, it cannot be an empty string. The tag key can be up to 128 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance, cloud disk, and primary ENI. Valid values of N: 1 to 20. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description><para>default: The instance is created on a non-dedicated host.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is created on a dedicated host. If you do not specify DedicatedHostId, Alibaba Cloud automatically selects a dedicated host to deploy the instance.</para>
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
        /// <para>Specifies whether to use the virtual machine system configurations provided by Alibaba Cloud (Windows: NTP and KMS; Linux: NTP and YUM).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseAdditionalService")]
        [Validation(Required=false)]
        public bool? UseAdditionalService { get; set; }

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
        /// <para>The ID of the vSwitch. This parameter is required when you create a VPC-type instance. You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query the information of created vSwitches.</para>
        /// <remarks>
        /// <para>If you specify the VSwitchId parameter, the ZoneId parameter must match the zone of the vSwitch. You can also leave the ZoneId parameter empty, and the system automatically selects the zone of the specified vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The virtual local area network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public string VlanId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> to obtain the zone list.</para>
        /// <remarks>
        /// <para>If you specify the VSwitchId parameter, the ZoneId parameter must match the zone of the vSwitch. You can also leave the ZoneId parameter empty, and the system automatically selects the zone of the specified vSwitch.</para>
        /// </remarks>
        /// <para>Default value: empty. The system automatically selects a zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
