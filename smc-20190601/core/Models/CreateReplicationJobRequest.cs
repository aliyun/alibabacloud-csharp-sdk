// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CreateReplicationJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The namespace of the destination Docker container image. For more information about Docker container images, see <a href="https://help.aliyun.com/document_detail/60744.html">Terms</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNamespace</para>
        /// </summary>
        [NameInMap("ContainerNamespace")]
        [Validation(Required=false)]
        public string ContainerNamespace { get; set; }

        /// <summary>
        /// <para>The repository that stores the destination Docker container image. For more information about Docker container images, see <a href="https://help.aliyun.com/document_detail/60744.html">Terms</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRepository</para>
        /// </summary>
        [NameInMap("ContainerRepository")]
        [Validation(Required=false)]
        public string ContainerRepository { get; set; }

        /// <summary>
        /// <para>The tag of the destination Docker container image. For more information about Docker container images, see <a href="https://help.aliyun.com/document_detail/60744.html">Terms</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS:v1</para>
        /// </summary>
        [NameInMap("ContainerTag")]
        [Validation(Required=false)]
        public string ContainerTag { get; set; }

        /// <summary>
        /// <para>The data disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestDataDisk> DataDisk { get; set; }
        public class CreateReplicationJobRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The index of data disk N on the destination ECS instance. Data disks on a destination ECS instance are arranged in a sequential order that starts from 1. Valid values: 1 to 16.</para>
            /// <remarks>
            /// <para> To create a destination data disk for a source server, make sure that the source server has data disks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The data disk partitions.</para>
            /// </summary>
            [NameInMap("Part")]
            [Validation(Required=false)]
            public List<CreateReplicationJobRequestDataDiskPart> Part { get; set; }
            public class CreateReplicationJobRequestDataDiskPart : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable block replication for partition N in the destination data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>Default value: true</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Block")]
                [Validation(Required=false)]
                public bool? Block { get; set; }

                /// <summary>
                /// <para>The device ID of partition N in the destination data disk. The partitions in the destination data disk are arranged in the same sequential order as those in the source data disk.</para>
                /// <remarks>
                /// <para> You must set both the DataDisk.N.Part.N.Device and <c>DataDisk.N.Part.N.SizeBytes</c> parameters or leave both parameters empty.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0_1</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The size of partition N in the destination data disk. Unit: bytes. The default value is equal to the corresponding partition size of the source data disk.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>The total size of all partitions in a destination data disk cannot exceed the size of the destination data disk.</para>
                /// </description></item>
                /// <item><description><para>You must set both the <c>DataDisk.N.Part.N.Device</c> and DataDisk.N.Part.N.SizeBytes parameters or leave both parameters empty.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>254803968</para>
                /// </summary>
                [NameInMap("SizeBytes")]
                [Validation(Required=false)]
                public long? SizeBytes { get; set; }

            }

            /// <summary>
            /// <para>The size of the data disk on the destination ECS instance. Unit: GiB. Valid values: 20 to 32768.</para>
            /// <remarks>
            /// <para> The size of a destination data disk must be larger than the size of data in the source data disk. For example, if the size of the source data disk is 500 GiB and the used space is 100 GiB, you must set this parameter to a value greater than 100.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The description of the migration job.</para>
        /// <para>The description must be 2 to 128 characters in length, and can contain digits, colons (:), underscores (_), and hyphens (-). The description must start with a letter, but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This_is_a_migration_task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the disk.</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public CreateReplicationJobRequestDisks Disks { get; set; }
        public class CreateReplicationJobRequestDisks : TeaModel {
            /// <summary>
            /// <para>The information about the data disk partition.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<CreateReplicationJobRequestDisksData> Data { get; set; }
            public class CreateReplicationJobRequestDisksData : TeaModel {
                /// <summary>
                /// <para>The ID of the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-2ze8hyowhdgd6ou2m5z6</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>Specifies whether the data disk uses LVM. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Use LVM.</description></item>
                /// <item><description>false: Not use LVM.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("LVM")]
                [Validation(Required=false)]
                public bool? LVM { get; set; }

                /// <summary>
                /// <para>The information about the data disk partition.</para>
                /// </summary>
                [NameInMap("Part")]
                [Validation(Required=false)]
                public List<CreateReplicationJobRequestDisksDataPart> Part { get; set; }
                public class CreateReplicationJobRequestDisksDataPart : TeaModel {
                    /// <summary>
                    /// <para>Whether block replication is enabled for the data disk partition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Block replication is enabled for the data disk partition.</description></item>
                    /// <item><description>false: Block replication is disabled for the data disk partition.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Block")]
                    [Validation(Required=false)]
                    public bool? Block { get; set; }

                    /// <summary>
                    /// <para>The path of the data disk partition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/home/date</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The size of the data disk partition. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>21474836480</para>
                    /// </summary>
                    [NameInMap("SizeBytes")]
                    [Validation(Required=false)]
                    public long? SizeBytes { get; set; }

                }

                /// <summary>
                /// <para>The size of the data disk of the migration source. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The information about the system disk.</para>
            /// </summary>
            [NameInMap("System")]
            [Validation(Required=false)]
            public CreateReplicationJobRequestDisksSystem System { get; set; }
            public class CreateReplicationJobRequestDisksSystem : TeaModel {
                /// <summary>
                /// <para>Specifies whether to use LVM. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Use LVM.</description></item>
                /// <item><description>false: Not use LVM.</description></item>
                /// </list>
                /// <para>LVM is not supported:</para>
                /// <list type="bullet">
                /// <item><description>If your source server runs Windows, LVM is not supported.</description></item>
                /// <item><description>The system disk does not have a boot partition, and LVM is not supported.</description></item>
                /// </list>
                /// <para>After LVM is enabled, this feature does not take effect in the following scenarios:</para>
                /// <list type="bullet">
                /// <item><description>LVM2 is not supported on your source server and the software package is not installed.</description></item>
                /// <item><description>Your source server runs Debian with a kernel version of 3.x or earlier and XFS file systems are mounted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LVM")]
                [Validation(Required=false)]
                public bool? LVM { get; set; }

                /// <summary>
                /// <para>The information about the system disk partition.</para>
                /// </summary>
                [NameInMap("Part")]
                [Validation(Required=false)]
                public List<CreateReplicationJobRequestDisksSystemPart> Part { get; set; }
                public class CreateReplicationJobRequestDisksSystemPart : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether block replication is enabled for the system disk partition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Block")]
                    [Validation(Required=false)]
                    public bool? Block { get; set; }

                    /// <summary>
                    /// <para>The path of the system disk partition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/boot</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The size of the system disk partition. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>254803968</para>
                    /// </summary>
                    [NameInMap("SizeBytes")]
                    [Validation(Required=false)]
                    public long? SizeBytes { get; set; }

                }

                /// <summary>
                /// <para>The size of the source system disk. Unit: GiB. Valid values: 20 to 32768.</para>
                /// <remarks>
                /// <para> The parameter value must be greater than the actual used space of the data disk on the source server. For example, if the size of the source disk is 500 GiB but the actual used space is 100 GiB, you must set this parameter to a value greater than 100 GiB.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

        }

        /// <summary>
        /// <para>The interval at which SMC synchronizes incremental data to Alibaba Cloud. Unit: hour. Valid values: 1 to 168.</para>
        /// <para>This parameter is required if you set the <c>RunOnce</c> parameter to false.</para>
        /// <para>By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public int? Frequency { get; set; }

        /// <summary>
        /// <para>The name of the destination image. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be unique within an Alibaba Cloud region.</description></item>
        /// <item><description>The name must be 2 to 128 characters in length, and can contain digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter, but cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify an image name that already exists in the destination region, the migration job ID is appended to the image name as a suffix. Example: ImageName_j-2zexxxxxxxxxxxxx.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testAliCloudImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The ID of the destination ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1f1dvfto1sigz5****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role that is assigned to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMCAdmin</para>
        /// </summary>
        [NameInMap("InstanceRamRole")]
        [Validation(Required=false)]
        public string InstanceRamRole { get; set; }

        /// <summary>
        /// <para>The type of the intermediate instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to obtain the ECS instance types.</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, SMC creates an intermediate instance of the specified instance type. If the specified instance type is unavailable, you cannot create the migration job.</description></item>
        /// <item><description>If you do not specify this parameter, SMC selects an available instance type in a specific order to create an intermediate instance. For more information, see <a href="https://help.aliyun.com/document_detail/121707.html">SMC FAQ</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The type of the migration job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: server migration.</description></item>
        /// <item><description>1: operating system migration.</description></item>
        /// <item><description>2: cross-zone migration.</description></item>
        /// <item><description>3: agentless migration for a VMware VM.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public int? JobType { get; set; }

        /// <summary>
        /// <para>The ID of the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp16jovvln1cgaaq****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The version number of the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The license type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>An empty value specifies no license.</description></item>
        /// <item><description>A value of BYOL specifies Bring Your Own License (BYOL).</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/121707.html">SMC FAQ</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BYOL</para>
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// <para>The maximum number of images retained for the incremental migration job. Valid values: 1 to 10.</para>
        /// <para>This parameter is required if you set the <c>RunOnce</c> parameter to false.</para>
        /// <para>By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxNumberOfImageToKeep")]
        [Validation(Required=false)]
        public int? MaxNumberOfImageToKeep { get; set; }

        /// <summary>
        /// <para>The name of the migration job. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be unique.</description></item>
        /// <item><description>The name must be 2 to 128 characters in length, and can contain digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter, but cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testMigrationTaskName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network mode for data transmission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Data is transmitted over the Internet. Make sure that the source server can access the Internet.</description></item>
        /// <item><description>2: Data is transmitted over a VPC. If you specify this value, you must specify the VSwitchId parameter. You do not need to specify the VpcId parameter because the value of the VpcId parameter can be retrieved based on the value of the VSwitchId parameter.</description></item>
        /// </list>
        /// <para>Default value: 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NetMode")]
        [Validation(Required=false)]
        public int? NetMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud region to which you want to migrate the source server.</para>
        /// <para>For example, if you want to migrate the source server to the China (Hangzhou) region, set this parameter to <c>cn-hangzhou</c>. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The parameters of the replication driver. The parameters must be specified as key-value pairs in the JSON format. The keys are fixed for each type of replication driver. The JSON string can be up to 2,048 characters in length.</para>
        /// <para>A replication driver is a tool that is used to migrate a source server to an intermediate instance. The parameters vary based on the replication driver type. If you use a Server Migration Tool (SMT) driver, you can specify the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>bandwidth_limit: the maximum bandwidth for data transmission.</description></item>
        /// <item><description>compress_level: the compression ratio of data to be transmitted.</description></item>
        /// <item><description>checksum: specifies whether to enable checksum verification.</description></item>
        /// </list>
        /// <para>For more information about replication drivers, see the response parameter <c>SourceServers.ReplicationDriver</c> of the <a href="https://help.aliyun.com/document_detail/121818.html">DescribeSourceServers</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bandwidth_limit&quot;:0,&quot;compress_level&quot;:1,&quot;checksum&quot;:true}</para>
        /// </summary>
        [NameInMap("ReplicationParameters")]
        [Validation(Required=false)]
        public string ReplicationParameters { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw3ty5y7****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable incremental migration for the source server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: creates a migration job that runs only once. This is the default value. Incremental data of the source server is not synchronized.</description></item>
        /// <item><description>false: creates an incremental migration job. In this case, you must specify the <c>Frequency</c> parameter. SMC synchronizes incremental data of the source server to Alibaba Cloud at the specified frequency. You can use an incremental migration job to synchronize incremental data from the source server to Alibaba Cloud without the need to interrupt your business. A full data image is generated for the source server when the job is running.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can specify this parameter only when you create a migration job. The parameter value cannot be changed after the migration job is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RunOnce")]
        [Validation(Required=false)]
        public bool? RunOnce { get; set; }

        /// <summary>
        /// <para>The time when you want to run the migration job. The time must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The time must be specified in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. For example, 2018-01-01T12:00:00Z specifies 20:00:00 on January 1, 2018 (UTC+8).</description></item>
        /// <item><description>The value must be within 30 days after the current time.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, you must manually start the migration job after the job is created. You can call the <a href="https://help.aliyun.com/document_detail/121823.html">StartReplicationJob</a> operation to start the migration job.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-04T13:35:00Z</para>
        /// </summary>
        [NameInMap("ScheduledStartTime")]
        [Validation(Required=false)]
        public string ScheduledStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the source server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp1e2fsl57knvuug****</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The information about system disk partitions.</para>
        /// </summary>
        [NameInMap("SystemDiskPart")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestSystemDiskPart> SystemDiskPart { get; set; }
        public class CreateReplicationJobRequestSystemDiskPart : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable block replication for partition N in the destination system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>Default value: true</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Block")]
            [Validation(Required=false)]
            public bool? Block { get; set; }

            /// <summary>
            /// <para>The ID of partition N in the destination system disk. The partitions in the destination system disk are arranged in the same sequential order as those in the source system disk.</para>
            /// <remarks>
            /// <para> You must set both the SystemDiskPart.N.Device and <c>SystemDiskPart.N.SizeBytes</c> parameters or leave both parameters empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0_1</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The size of the partition N in the destination system disk. Unit: bytes. The default value is equal to the partition size of the source system disk.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The total size of all partitions in the destination system disk cannot exceed the size of the destination system disk.</para>
            /// </description></item>
            /// <item><description><para>You must set both the <c>SystemDiskPart.N.Device</c> and SystemDiskPart.N.SizeBytes parameters or leave both parameters empty.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>254803968</para>
            /// </summary>
            [NameInMap("SizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

        }

        /// <summary>
        /// <para>The system disk size of the destination ECS instance. Unit: GiB. Valid values: 20 to 2048.</para>
        /// <remarks>
        /// <para> The value must be greater than the used space of the system disk on the source server. For example, if the total size of the source disk is 500 GiB and the used space is 100 GiB, the value of this parameter must be greater than 100 GiB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestTag> Tag { get; set; }
        public class CreateReplicationJobRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag for the migration job. Valid values of N: 1 to 20.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag for the migration job. Valid values of N: 1 to 20.</para>
            /// <para>The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of destination to which you want to migrate the source server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Image: After the migration job is complete, SMC generates an Elastic Compute Service (ECS) image for the source server.</description></item>
        /// <item><description>ContainerImage: After the migration job is complete, SMC generates a Docker container image for the source server.</description></item>
        /// <item><description>TargetInstance: After the migration job is completed, SMC migrates the source server to the destination instance. If you set this parameter to TargetInstance, you must set the <c>InstanceId</c> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Image</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the specified VPC.</para>
        /// <para>You must set this parameter if you use a VPC to migrate data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1ddbrxdlrcbim46****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The time when the migration job expires. You can schedule the migration job to expire 7 to 90 days after the job is created.</para>
        /// <list type="bullet">
        /// <item><description>The time must be specified in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. For example, 2018-01-01T12:00:00Z specifies 20:00:00 on January 1, 2018 (UTC+8).</description></item>
        /// <item><description>If you do not specify this parameter, the migration job does not expire.</description></item>
        /// <item><description>After a migration job expires, the job state changes to Expired. SMC retains the migration job for seven days after the job expires. After the job is retained for seven days, SMC deletes the migration job.</description></item>
        /// </list>
        /// <para>By default, a migration job is valid for 30 days after it is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-04T13:35:00Z</para>
        /// </summary>
        [NameInMap("ValidTime")]
        [Validation(Required=false)]
        public string ValidTime { get; set; }

        /// <summary>
        /// <para>The ID of a VPC for which you have configured an Express Connect circuit or a VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1vwnn14rqpyiczj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
