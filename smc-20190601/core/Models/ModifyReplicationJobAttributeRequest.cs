// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class ModifyReplicationJobAttributeRequest : TeaModel {
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
        /// The information about the data disk.
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<ModifyReplicationJobAttributeRequestDataDisk> DataDisk { get; set; }
        public class ModifyReplicationJobAttributeRequestDataDisk : TeaModel {
            /// <summary>
            /// The index of data disk N on the destination ECS instance. Valid values of N: 1 to 16.
            /// 
            /// Data disks on a destination ECS instance are arranged in a sequential order that starts from 1.
            /// 
            /// >  You can create a destination data disk only for a source server that has data disks.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// The information about partitions.
            /// </summary>
            [NameInMap("Part")]
            [Validation(Required=false)]
            public List<ModifyReplicationJobAttributeRequestDataDiskPart> Part { get; set; }
            public class ModifyReplicationJobAttributeRequestDataDiskPart : TeaModel {
                /// <summary>
                /// Specifies whether to enable block replication for partition N in the destination data disk. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("Block")]
                [Validation(Required=false)]
                public bool? Block { get; set; }

                /// <summary>
                /// The ID of partition N in the destination data disk.
                /// 
                /// >  The partitions in the destination data disk are arranged in the same sequential order as those in the source data disk.
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// The size of partition N in the destination data disk. Unit: bytes. The default value is equal to the corresponding size of the partition in the source data disk.
                /// 
                /// >  The total size of all partitions in the destination data disk cannot exceed the size of the destination data disk.
                /// </summary>
                [NameInMap("SizeBytes")]
                [Validation(Required=false)]
                public long? SizeBytes { get; set; }

            }

            /// <summary>
            /// The size of the data disk on the destination ECS instance. Unit: GiB. Valid values: 20 to 32768.
            /// 
            /// >  The size of a destination data disk must be greater than the size of data in the source data disk. For example, if the source data disk has 500 GiB of storage space and 100 GiB of data, you must set this parameter to a value greater than 100.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// The description of the migration job.
        /// 
        /// The description must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The interval at which an incremental migration job runs. Unit: hour. Valid values: 1 to 168.
        /// 
        /// This parameter is required if you set the `RunOnce` parameter to false.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public int? Frequency { get; set; }

        /// <summary>
        /// The name of the destination image. The name must meet the following requirements:
        /// 
        /// *   The name must be unique within an Alibaba Cloud region.
        /// *   The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter and cannot start with `http://` or `https://`.
        /// 
        /// >  If an image whose name is the same as that of the destination image already exists in the current region when the migration job is in progress, the system adds the migration job ID to the end of the image name by default. Example: ImageName-JobId.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The destination instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the Resource Access Management (RAM) role that is attached to the intermediate instance.
        /// </summary>
        [NameInMap("InstanceRamRole")]
        [Validation(Required=false)]
        public string InstanceRamRole { get; set; }

        /// <summary>
        /// The type of the intermediate instance.
        /// 
        /// You can call the [DescribeInstanceTypes](~~25620~~) operation to query the ECS instance types.
        /// 
        /// *   If you specify this parameter, SMC creates an intermediate instance of the specified instance type. If the specified instance type is unavailable, you cannot create the migration job.
        /// *   If you do not specify this parameter, SMC selects an available instance type in a specific order to create an intermediate instance. For more information,
        /// 
        /// see the "How does SMC create an intermediate instance?" section of the "FAQ" topic.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The migration job ID.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The launch template ID.
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

        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// The maximum number of images that are retained for an incremental migration job. Valid values: 1 to 10.
        /// 
        /// This parameter is required if you set the `RunOnce` parameter to false.
        /// </summary>
        [NameInMap("MaxNumberOfImageToKeep")]
        [Validation(Required=false)]
        public int? MaxNumberOfImageToKeep { get; set; }

        /// <summary>
        /// The name of the migration job. The name must meet the following requirements:
        /// 
        /// *   The name must be unique.
        /// *   The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetMode")]
        [Validation(Required=false)]
        public int? NetMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ReplicationParameters")]
        [Validation(Required=false)]
        public string ReplicationParameters { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The time when the migration job is executed. SMC starts the migration job at the specified time.
        /// 
        /// Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC. For example, 2018-01-01T12:00:00Z indicates 20:00:00 on January 1, 2018 (UTC+8).
        /// 
        /// >  If ScheduledStartTime is left empty, SMC does not automatically start the migration job. In this case, you must call the [StartReplicationJob](~~121823~~) operation to start the migration job.
        /// </summary>
        [NameInMap("ScheduledStartTime")]
        [Validation(Required=false)]
        public string ScheduledStartTime { get; set; }

        /// <summary>
        /// The partition information of the system disk.
        /// </summary>
        [NameInMap("SystemDiskPart")]
        [Validation(Required=false)]
        public List<ModifyReplicationJobAttributeRequestSystemDiskPart> SystemDiskPart { get; set; }
        public class ModifyReplicationJobAttributeRequestSystemDiskPart : TeaModel {
            /// <summary>
            /// Specifies whether to enable block replication for partition N in the destination system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Block")]
            [Validation(Required=false)]
            public bool? Block { get; set; }

            /// <summary>
            /// The ID of partition N in the destination system disk.
            /// 
            /// >  The partitions in the destination system disk are arranged in the same sequential order as those in the source system disk.
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// The size of partition N in the destination system disk. Unit: bytes. The default value is equal to the partition size of the source system disk.
            /// 
            /// >  The total size of all partitions in the destination system disk cannot exceed the size of the destination system disk.
            /// </summary>
            [NameInMap("SizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

        }

        /// <summary>
        /// The system disk size of the destination ECS instance. Unit: GiB. Valid values: 20 to 500.
        /// 
        /// >  The size of a destination data disk must be greater than the size of data in the source data disk. For example, if the source data disk has 500 GiB of storage space and 100 GiB of data, you must set this parameter to a value greater than 100.
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The type of destination to which the source server is migrated. You can modify the value only before the migration job starts. Valid values:
        /// 
        /// *   Image: After the migration job is complete, Server Migration Center (SMC) generates a destination Elastic Compute Service (ECS) image for the source server. You can use the image to create an ECS instance.
        /// *   ContainerImage: After the migration job is complete, SMC generates a container image for the source server. You can use the container image in Container Registry.
        /// *   TargetInstance: After the migration job is complete, SMC migrates the source server to the destination instance. If you set this parameter to TargetInstance, you must set the `InstanceId` parameter.
        /// 
        /// > 
        /// 
        /// *   The value of this parameter is not case-sensitive.
        /// 
        /// *   SMC does not allow you to migrate Windows servers or servers that run operating systems on the ARM architecture to Container Registry.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The time when the migration job expires. You can schedule the migration job to expire 7 to 90 days after the job is created.
        /// 
        /// *   This parameter can be modified only if the migration job is in the Ready, Running, Stopped, InError, or Waiting state.
        /// *   Specify the time in the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC. For example, 2018-01-01T12:00:00Z indicates 20:00:00 on January 1, 2018 (UTC+8).
        /// *   If you do not specify this parameter, the migration job does not expire.
        /// *   After a migration job expires, the job state changes to Expired. SMC retains the migration job for seven days after the job expires. After the job is retained for seven days, SMC deletes the migration job.
        /// 
        /// By default, a migration job is valid for 30 days after it is created.
        /// </summary>
        [NameInMap("ValidTime")]
        [Validation(Required=false)]
        public string ValidTime { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
