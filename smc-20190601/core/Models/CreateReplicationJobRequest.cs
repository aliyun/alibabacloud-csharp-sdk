// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CreateReplicationJobRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The namespace of the destination Docker container image. For more information about Docker container images, see [Terms](~~60744~~).
        /// </summary>
        [NameInMap("ContainerNamespace")]
        [Validation(Required=false)]
        public string ContainerNamespace { get; set; }

        /// <summary>
        /// The repository that stores the destination Docker container image. For more information about Docker container images, see [Terms](~~60744~~).
        /// </summary>
        [NameInMap("ContainerRepository")]
        [Validation(Required=false)]
        public string ContainerRepository { get; set; }

        /// <summary>
        /// The tag of the destination Docker container image. For more information about Docker container images, see [Terms](~~60744~~).
        /// </summary>
        [NameInMap("ContainerTag")]
        [Validation(Required=false)]
        public string ContainerTag { get; set; }

        /// <summary>
        /// The data disks.
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestDataDisk> DataDisk { get; set; }
        public class CreateReplicationJobRequestDataDisk : TeaModel {
            /// <summary>
            /// The index of data disk N on the destination ECS instance. Data disks on a destination ECS instance are arranged in a sequential order that starts from 1. Valid values: 1 to 16.
            /// 
            /// >  To create a destination data disk for a source server, make sure that the source server has data disks.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// The data disk partitions.
            /// </summary>
            [NameInMap("Part")]
            [Validation(Required=false)]
            public List<CreateReplicationJobRequestDataDiskPart> Part { get; set; }
            public class CreateReplicationJobRequestDataDiskPart : TeaModel {
                /// <summary>
                /// Specifies whether to enable block replication for partition N in the destination data disk. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// Default value: true
                /// </summary>
                [NameInMap("Block")]
                [Validation(Required=false)]
                public bool? Block { get; set; }

                /// <summary>
                /// The device ID of partition N in the destination data disk. The partitions in the destination data disk are arranged in the same sequential order as those in the source data disk.
                /// 
                /// >  You must set both the DataDisk.N.Part.N.Device and `DataDisk.N.Part.N.SizeBytes` parameters or leave both parameters empty.
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// The size of partition N in the destination data disk. Unit: bytes. The default value is equal to the corresponding partition size of the source data disk.
                /// 
                /// > 
                /// 
                /// *   The total size of all partitions in a destination data disk cannot exceed the size of the destination data disk.
                /// 
                /// *   You must set both the `DataDisk.N.Part.N.Device` and DataDisk.N.Part.N.SizeBytes parameters or leave both parameters empty.
                /// </summary>
                [NameInMap("SizeBytes")]
                [Validation(Required=false)]
                public long? SizeBytes { get; set; }

            }

            /// <summary>
            /// The size of the data disk on the destination ECS instance. Unit: GiB. Valid values: 20 to 32768.
            /// 
            /// >  The size of a destination data disk must be larger than the size of data in the source data disk. For example, if the size of the source data disk is 500 GiB and the used space is 100 GiB, you must set this parameter to a value greater than 100.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// The description of the migration job.
        /// 
        /// The description must be 2 to 128 characters in length, and can contain digits, colons (:), underscores (\_), and hyphens (-). The description must start with a letter, but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The interval at which SMC synchronizes incremental data to Alibaba Cloud. Unit: hour. Valid values: 1 to 168.
        /// 
        /// This parameter is required if you set the `RunOnce` parameter to false.
        /// 
        /// By default, this parameter is empty.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public int? Frequency { get; set; }

        /// <summary>
        /// The name of the destination image. The name must meet the following requirements:
        /// 
        /// *   The name must be unique within an Alibaba Cloud region.
        /// *   The name must be 2 to 128 characters in length, and can contain digits, colons (:), underscores (\_), and hyphens (-). The name must start with a letter, but cannot start with `http://` or `https://`.
        /// 
        /// >  If you specify an image name that already exists in the destination region, the migration job ID is appended to the image name as a suffix. Example: ImageName_j-2zexxxxxxxxxxxxx.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The ID of the destination ECS instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the Resource Access Management (RAM) role that is assigned to the instance.
        /// </summary>
        [NameInMap("InstanceRamRole")]
        [Validation(Required=false)]
        public string InstanceRamRole { get; set; }

        /// <summary>
        /// The type of the intermediate instance.
        /// 
        /// You can call the [DescribeInstanceTypes](~~25620~~) operation to query the ECS instance types.
        /// 
        /// *   If you specify this parameter, SMC creates an intermediate instance of the specified instance type. If the specified instance type is unavailable, the migration job fails to be created.
        /// *   If you do not specify this parameter, SMC selects an available instance type in a specific order to create an intermediate instance. For more information, see the "How does SMC create an intermediate instance?" section of the SMC FAQ topic.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The type of the migration job. Valid values:
        /// 
        /// *   0: server migration.
        /// *   1: operating system migration.
        /// *   2: cross-zone migration.
        /// *   3: agentless migration for a VMware VM.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public int? JobType { get; set; }

        /// <summary>
        /// The ID of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// The version number of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// The license type. Valid values:
        /// 
        /// *   An empty value specifies no license.
        /// *   A value of BYOL specifies Bring Your Own License (BYOL).
        /// 
        /// For more information, see [SMC FAQ](~~121707~~).
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// The maximum number of images retained for the incremental migration job. Valid values: 1 to 10.
        /// 
        /// This parameter is required if you set the `RunOnce` parameter to false.
        /// 
        /// By default, this parameter is empty.
        /// </summary>
        [NameInMap("MaxNumberOfImageToKeep")]
        [Validation(Required=false)]
        public int? MaxNumberOfImageToKeep { get; set; }

        /// <summary>
        /// The name of the migration job. The name must meet the following requirements:
        /// 
        /// *   The name must be unique.
        /// *   The name must be 2 to 128 characters in length, and can contain digits, colons (:), underscores (\_), and hyphens (-). The name must start with a letter, but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The network mode for data transmission. Valid values:
        /// 
        /// *   0: Data is transmitted over the Internet. Make sure that the source server can access the Internet.
        /// *   2: Data is transmitted over a VPC. If you specify this value, you must specify the VSwitchId parameter. You do not need to specify the VpcId parameter because the value of the VpcId parameter can be retrieved based on the value of the VSwitchId parameter.
        /// 
        /// Default value: 0
        /// </summary>
        [NameInMap("NetMode")]
        [Validation(Required=false)]
        public int? NetMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud region to which you want to migrate the source server.
        /// 
        /// For example, if you want to migrate the source server to the China (Hangzhou) region, set this parameter to `cn-hangzhou`. You can call the [DescribeRegions](~~25609~~) operation to query the latest regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The parameters of the replication driver. The parameters must be specified as key-value pairs in the JSON format. The keys are fixed for each type of replication driver. The JSON string can be up to 2,048 characters in length.
        /// 
        /// A replication driver is a tool that is used to migrate a source server to an intermediate instance. The parameters vary based on the replication driver type. If you use a Server Migration Tool (SMT) driver, you can specify the following parameters:
        /// 
        /// *   bandwidth_limit: the maximum bandwidth for data transmission.
        /// *   compress_level: the compression ratio of data to be transmitted.
        /// *   checksum: specifies whether to enable checksum verification.
        /// 
        /// For more information about replication drivers, see the response parameter `SourceServers.ReplicationDriver` of the [DescribeSourceServers](~~121818~~) operation.
        /// </summary>
        [NameInMap("ReplicationParameters")]
        [Validation(Required=false)]
        public string ReplicationParameters { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// Specifies whether to disable incremental migration for the source server. Valid values:
        /// 
        /// *   true: creates a migration job that runs only once. This is the default value. Incremental data of the source server is not synchronized.
        /// *   false: creates an incremental migration job. In this case, you must specify the `Frequency` parameter. SMC synchronizes incremental data of the source server to Alibaba Cloud at the specified frequency. You can use an incremental migration job to synchronize incremental data from the source server to Alibaba Cloud without the need to interrupt your business. A full data image is generated for the source server when the job is running.
        /// 
        /// >  You can specify this parameter only when you create a migration job. The parameter value cannot be changed after the migration job is created.
        /// </summary>
        [NameInMap("RunOnce")]
        [Validation(Required=false)]
        public bool? RunOnce { get; set; }

        /// <summary>
        /// The time when you want to run the migration job. The time must meet the following requirements:
        /// 
        /// *   The time must be specified in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. For example, 2018-01-01T12:00:00Z specifies 20:00:00 on January 1, 2018 (UTC+8).
        /// *   The value must be within 30 days after the current time.
        /// 
        /// >  If you do not specify this parameter, you must manually start the migration job after the job is created. You can call the [StartReplicationJob](~~121823~~) operation to start the migration job.
        /// </summary>
        [NameInMap("ScheduledStartTime")]
        [Validation(Required=false)]
        public string ScheduledStartTime { get; set; }

        /// <summary>
        /// The ID of the source server.
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The information about system disk partitions.
        /// </summary>
        [NameInMap("SystemDiskPart")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestSystemDiskPart> SystemDiskPart { get; set; }
        public class CreateReplicationJobRequestSystemDiskPart : TeaModel {
            /// <summary>
            /// Specifies whether to enable block replication for partition N in the destination system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// Default value: true
            /// </summary>
            [NameInMap("Block")]
            [Validation(Required=false)]
            public bool? Block { get; set; }

            /// <summary>
            /// The ID of partition N in the destination system disk. The partitions in the destination system disk are arranged in the same sequential order as those in the source system disk.
            /// 
            /// >  You must set both the SystemDiskPart.N.Device and `SystemDiskPart.N.SizeBytes` parameters or leave both parameters empty.
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// The size of the partition N in the destination system disk. Unit: bytes. The default value is equal to the partition size of the source system disk.
            /// 
            /// > 
            /// 
            /// *   The total size of all partitions in the destination system disk cannot exceed the size of the destination system disk.
            /// 
            /// *   You must set both the `SystemDiskPart.N.Device` and SystemDiskPart.N.SizeBytes parameters or leave both parameters empty.
            /// </summary>
            [NameInMap("SizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

        }

        /// <summary>
        /// The system disk size of the destination ECS instance. Unit: GiB. Valid values: 20 to 2048.
        /// 
        /// >  The value must be greater than the used space of the system disk on the source server. For example, if the total size of the source disk is 500 GiB and the used space is 100 GiB, the value of this parameter must be greater than 100 GiB.
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateReplicationJobRequestTag> Tag { get; set; }
        public class CreateReplicationJobRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag for the migration job. Valid values of N: 1 to 20.
            /// 
            /// The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with `aliyun`, `acs:`, `http://`, or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag for the migration job. Valid values of N: 1 to 20.
            /// 
            /// The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with `aliyun`, `acs:`, `http://`, or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of destination to which you want to migrate the source server. Valid values:
        /// 
        /// *   Image: After the migration job is complete, SMC generates an Elastic Compute Service (ECS) image for the source server.
        /// *   ContainerImage: After the migration job is complete, SMC generates a Docker container image for the source server.
        /// *   TargetInstance: After the migration job is completed, SMC migrates the source server to the destination instance. If you set this parameter to TargetInstance, you must set the `InstanceId` parameter.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The ID of the vSwitch in the specified VPC.
        /// 
        /// You must set this parameter if you use a VPC to migrate data.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The time when the migration job expires. You can schedule the migration job to expire 7 to 90 days after the job is created.
        /// 
        /// *   The time must be specified in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. For example, 2018-01-01T12:00:00Z specifies 20:00:00 on January 1, 2018 (UTC+8).
        /// *   If you do not specify this parameter, the migration job does not expire.
        /// *   After a migration job expires, the job state changes to Expired. SMC retains the migration job for seven days after the job expires. After the job is retained for seven days, SMC deletes the migration job.
        /// 
        /// By default, a migration job is valid for 30 days after it is created.
        /// </summary>
        [NameInMap("ValidTime")]
        [Validation(Required=false)]
        public string ValidTime { get; set; }

        /// <summary>
        /// The ID of a VPC for which you have configured an Express Connect circuit or a VPN gateway.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
