// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class ModifyReplicationJobAttributeRequest : TeaModel {
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
        /// <para>The information about the data disk.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<ModifyReplicationJobAttributeRequestDataDisk> DataDisk { get; set; }
        public class ModifyReplicationJobAttributeRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The index of data disk N on the destination ECS instance. Valid values of N: 1 to 16.</para>
            /// <para>Data disks on a destination ECS instance are arranged in a sequential order that starts from 1.</para>
            /// <remarks>
            /// <para> You can create a destination data disk only for a source server that has data disks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The information about partitions.</para>
            /// </summary>
            [NameInMap("Part")]
            [Validation(Required=false)]
            public List<ModifyReplicationJobAttributeRequestDataDiskPart> Part { get; set; }
            public class ModifyReplicationJobAttributeRequestDataDiskPart : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable block replication for partition N in the destination data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Block")]
                [Validation(Required=false)]
                public bool? Block { get; set; }

                /// <summary>
                /// <para>The ID of partition N in the destination data disk.</para>
                /// <remarks>
                /// <para> The partitions in the destination data disk are arranged in the same sequential order as those in the source data disk.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0_1</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The size of partition N in the destination data disk. Unit: bytes. The default value is equal to the corresponding size of the partition in the source data disk.</para>
                /// <remarks>
                /// <para> The total size of all partitions in the destination data disk cannot exceed the size of the destination data disk.</para>
                /// </remarks>
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
            /// <para> The size of a destination data disk must be greater than the size of data in the source data disk. For example, if the source data disk has 500 GiB of storage space and 100 GiB of data, you must set this parameter to a value greater than 100.</para>
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
        /// <para>The description must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This_is_my_migration_task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The interval at which an incremental migration job runs. Unit: hour. Valid values: 1 to 168.</para>
        /// <para>This parameter is required if you set the <c>RunOnce</c> parameter to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public int? Frequency { get; set; }

        /// <summary>
        /// <para>The name of the destination image. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be unique within an Alibaba Cloud region.</description></item>
        /// <item><description>The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If an image whose name is the same as that of the destination image already exists in the current region when the migration job is in progress, the system adds the migration job ID to the end of the image name by default. Example: ImageName-JobId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testAliCloudImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The destination instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1f1dvfto1sigz5****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role that is attached to the intermediate instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMCAdmin</para>
        /// </summary>
        [NameInMap("InstanceRamRole")]
        [Validation(Required=false)]
        public string InstanceRamRole { get; set; }

        /// <summary>
        /// <para>The type of the intermediate instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the ECS instance types.</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, SMC creates an intermediate instance of the specified instance type. If the specified instance type is unavailable, you cannot create the migration job.</description></item>
        /// <item><description>If you do not specify this parameter, SMC selects an available instance type in a specific order to create an intermediate instance. For more information,</description></item>
        /// </list>
        /// <para>see the &quot;How does SMC create an intermediate instance?&quot; section of the &quot;FAQ&quot; topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The migration job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j-bp19vlwm0tyigbmj****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The launch template ID.</para>
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
        /// <para>Latest</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The maximum number of images that are retained for an incremental migration job. Valid values: 1 to 10.</para>
        /// <para>This parameter is required if you set the <c>RunOnce</c> parameter to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxNumberOfImageToKeep")]
        [Validation(Required=false)]
        public int? MaxNumberOfImageToKeep { get; set; }

        /// <summary>
        /// <para>The name of the migration job. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be unique.</description></item>
        /// <item><description>The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
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
        /// <item><description>2: Data is transmitted over a virtual private cloud (VPC). If you set this parameter to 2, you must specify the VSwitchId parameter. You can leave the VpcId parameter empty, the VPC ID can be queried by calling an operation.</description></item>
        /// </list>
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
        /// <para>The parameters of the replication driver. The parameters are fixed key-value pairs of the JSON format. The value can be up to 2,048 characters in length.</para>
        /// <para>A replication driver is a tool that is used to replicate the data of a source server to an intermediate instance. The parameters vary based on the replication driver type. If you use a Server Migration Tool (SMT) driver, you can set the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>bandwidth_limit: the maximum bandwidth for data transmission.</description></item>
        /// <item><description>compress_level: the compression ratio of data to be transmitted.</description></item>
        /// <item><description>checksum: specifies whether to enable checksum verification</description></item>
        /// </list>
        /// <para>For more information about the replication driver, see the response parameter <c>SourceServers.ReplicationDriver</c> of the <a href="https://help.aliyun.com/document_detail/2402126.html">DescribeSourceServers</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bandwidth_limit&quot;:0,&quot;compress_level&quot;:1,&quot;checksum&quot;:true}</para>
        /// </summary>
        [NameInMap("ReplicationParameters")]
        [Validation(Required=false)]
        public string ReplicationParameters { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The time when the migration job is executed. SMC starts the migration job at the specified time.</para>
        /// <para>Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC. For example, 2018-01-01T12:00:00Z indicates 20:00:00 on January 1, 2018 (UTC+8).</para>
        /// <remarks>
        /// <para> If ScheduledStartTime is left empty, SMC does not automatically start the migration job. In this case, you must call the <a href="https://help.aliyun.com/document_detail/121823.html">StartReplicationJob</a> operation to start the migration job.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-04T13:35:00Z</para>
        /// </summary>
        [NameInMap("ScheduledStartTime")]
        [Validation(Required=false)]
        public string ScheduledStartTime { get; set; }

        /// <summary>
        /// <para>The partition information of the system disk.</para>
        /// </summary>
        [NameInMap("SystemDiskPart")]
        [Validation(Required=false)]
        public List<ModifyReplicationJobAttributeRequestSystemDiskPart> SystemDiskPart { get; set; }
        public class ModifyReplicationJobAttributeRequestSystemDiskPart : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable block replication for partition N in the destination system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Block")]
            [Validation(Required=false)]
            public bool? Block { get; set; }

            /// <summary>
            /// <para>The ID of partition N in the destination system disk.</para>
            /// <remarks>
            /// <para> The partitions in the destination system disk are arranged in the same sequential order as those in the source system disk.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0_1</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The size of partition N in the destination system disk. Unit: bytes. The default value is equal to the partition size of the source system disk.</para>
            /// <remarks>
            /// <para> The total size of all partitions in the destination system disk cannot exceed the size of the destination system disk.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>254803968</para>
            /// </summary>
            [NameInMap("SizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

        }

        /// <summary>
        /// <para>The system disk size of the destination ECS instance. Unit: GiB. Valid values: 20 to 500.</para>
        /// <remarks>
        /// <para> The size of a destination data disk must be greater than the size of data in the source data disk. For example, if the source data disk has 500 GiB of storage space and 100 GiB of data, you must set this parameter to a value greater than 100.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The type of destination to which the source server is migrated. You can modify the value only before the migration job starts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Image: After the migration job is complete, Server Migration Center (SMC) generates a destination Elastic Compute Service (ECS) image for the source server. You can use the image to create an ECS instance.</description></item>
        /// <item><description>ContainerImage: After the migration job is complete, SMC generates a container image for the source server. You can use the container image in Container Registry.</description></item>
        /// <item><description>TargetInstance: After the migration job is complete, SMC migrates the source server to the destination instance. If you set this parameter to TargetInstance, you must set the <c>InstanceId</c> parameter.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The value of this parameter is not case-sensitive.</para>
        /// </description></item>
        /// <item><description><para>SMC does not allow you to migrate Windows servers or servers that run operating systems on the ARM architecture to Container Registry.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Image</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the VPC.</para>
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
        /// <item><description>This parameter can be modified only if the migration job is in the Ready, Running, Stopped, InError, or Waiting state.</description></item>
        /// <item><description>Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC. For example, 2018-01-01T12:00:00Z indicates 20:00:00 on January 1, 2018 (UTC+8).</description></item>
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
        /// <para>The ID of the VPC for which an Express Connect circuit or VPN gateway is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1vwnn14rqpyiczj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
