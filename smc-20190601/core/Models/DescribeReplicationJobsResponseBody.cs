// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeReplicationJobsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The details of migration jobs.
        /// </summary>
        [NameInMap("ReplicationJobs")]
        [Validation(Required=false)]
        public DescribeReplicationJobsResponseBodyReplicationJobs ReplicationJobs { get; set; }
        public class DescribeReplicationJobsResponseBodyReplicationJobs : TeaModel {
            [NameInMap("ReplicationJob")]
            [Validation(Required=false)]
            public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJob> ReplicationJob { get; set; }
            public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJob : TeaModel {
                /// <summary>
                /// The business status of the migration job. Valid values:
                /// 
                /// *   Preparing: The migration is being prepared.
                /// *   Syncing: Data is being synchronized.
                /// *   Processing: The migration is in progress.
                /// *   Cleaning: Intermediate resources are being released.
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The namespace of the destination Docker container image.
                /// </summary>
                [NameInMap("ContainerNamespace")]
                [Validation(Required=false)]
                public string ContainerNamespace { get; set; }

                /// <summary>
                /// The repository that stores the destination Docker container image.
                /// </summary>
                [NameInMap("ContainerRepository")]
                [Validation(Required=false)]
                public string ContainerRepository { get; set; }

                /// <summary>
                /// The tag of the destination Docker container image.
                /// </summary>
                [NameInMap("ContainerTag")]
                [Validation(Required=false)]
                public string ContainerTag { get; set; }

                /// <summary>
                /// The time when the migration job was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The data disks on the destination ECS instance.
                /// </summary>
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisks DataDisks { get; set; }
                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisks : TeaModel {
                    [NameInMap("DataDisk")]
                    [Validation(Required=false)]
                    public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDisk> DataDisk { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDisk : TeaModel {
                        /// <summary>
                        /// The index number of the data disk.
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// The data disk partitions.
                        /// </summary>
                        [NameInMap("Parts")]
                        [Validation(Required=false)]
                        public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskParts Parts { get; set; }
                        public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskParts : TeaModel {
                            [NameInMap("Part")]
                            [Validation(Required=false)]
                            public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskPartsPart> Part { get; set; }
                            public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskPartsPart : TeaModel {
                                /// <summary>
                                /// Indicates whether block replication is enabled for the data disk partition.
                                /// </summary>
                                [NameInMap("Block")]
                                [Validation(Required=false)]
                                public bool? Block { get; set; }

                                /// <summary>
                                /// The device ID of the data disk partition.
                                /// </summary>
                                [NameInMap("Device")]
                                [Validation(Required=false)]
                                public string Device { get; set; }

                                /// <summary>
                                /// The size of the data disk partition. Unit: bytes.
                                /// </summary>
                                [NameInMap("SizeBytes")]
                                [Validation(Required=false)]
                                public long? SizeBytes { get; set; }

                            }

                        }

                        /// <summary>
                        /// The size of the data disk. Unit: GiB.
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                    }

                }

                /// <summary>
                /// The description of the migration job.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the migration job was complete. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// 
                /// >  The time displayed in the SMC console is in the format of UTC+8.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The error code returned if an error occurred in the migration job.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The interval at which the incremental migration job runs. Unit: hour. Valid values: 1 to 168.
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public int? Frequency { get; set; }

                /// <summary>
                /// The ID of the destination image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The name of the destination image.
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
                /// The instance type of the intermediate instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The ID of the migration job.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

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
                /// The versions of the launch template.
                /// </summary>
                [NameInMap("LaunchTemplateVersion")]
                [Validation(Required=false)]
                public string LaunchTemplateVersion { get; set; }

                /// <summary>
                /// The type of license for the migration job. Valid values:
                /// 
                /// *   An empty value indicates no license.
                /// *   A value of BYOL indicates Bring Your Own License (BYOL).
                /// </summary>
                [NameInMap("LicenseType")]
                [Validation(Required=false)]
                public string LicenseType { get; set; }

                /// <summary>
                /// The maximum number of images retained for the incremental migration job. Valid values: 1 to 10.
                /// </summary>
                [NameInMap("MaxNumberOfImageToKeep")]
                [Validation(Required=false)]
                public int? MaxNumberOfImageToKeep { get; set; }

                /// <summary>
                /// The name of the migration job.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of network used for the migration.
                /// </summary>
                [NameInMap("NetMode")]
                [Validation(Required=false)]
                public int? NetMode { get; set; }

                /// <summary>
                /// The progress of the migration job.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public float? Progress { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud region to which the source server is migrated.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The execution records of the migration job.
                /// </summary>
                [NameInMap("ReplicationJobRuns")]
                [Validation(Required=false)]
                public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobReplicationJobRuns ReplicationJobRuns { get; set; }
                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobReplicationJobRuns : TeaModel {
                    [NameInMap("ReplicationJobRun")]
                    [Validation(Required=false)]
                    public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobReplicationJobRunsReplicationJobRun> ReplicationJobRun { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobReplicationJobRunsReplicationJobRun : TeaModel {
                        /// <summary>
                        /// The time when the migration job ended. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                        /// 
                        /// >  The time displayed in the SMC console is in the format of UTC+8.
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// The ID of the destination image.
                        /// </summary>
                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                        /// <summary>
                        /// The time when the migration job was started. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                        /// 
                        /// >  The time displayed in the SMC console is in the format of UTC+8.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The method used to run the migration job. Valid values:
                        /// 
                        /// *   Manual: The migration job was manually started.
                        /// *   Schedule: The migration job was started at a scheduled time or at a specific interval.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// The string of key-value pairs configured for the replication driver.
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

                /// <summary>
                /// Indicates whether incremental migration is disabled for the source server. Valid values:
                /// 
                /// *   true: Incremental migration is disabled. A migration job runs only once after the job is created.
                /// *   false: Incremental migration is enabled. For an incremental migration job, SMC synchronizes incremental data to Alibaba Cloud at the interval specified by the `Frequency` parameter.
                /// </summary>
                [NameInMap("RunOnce")]
                [Validation(Required=false)]
                public bool? RunOnce { get; set; }

                /// <summary>
                /// The time when the migration job is scheduled to run. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. The time must meet the following requirements:
                /// 
                /// *   The value must be within 30 days after the current time.
                /// *   If you do not specify this parameter, you must manually start the migration job after the migration job is created. You can call the [StartReplicationJob](~~121823~~) operation to start the migration job.
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
                /// The time when the migration job was started. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// 
                /// >  The time displayed in the SMC console is in the format of UTC+8.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status of the migration job. Valid values:
                /// 
                /// *   Ready: The migration job is not started.
                /// *   Running: The migration job is running.
                /// *   Stopped: The migration job is paused.
                /// *   InError: An error occurs in the migration job.
                /// *   Finished: The migration job is complete.
                /// *   Waiting: The migration job is waiting to run.
                /// *   Expired: The migration job has expired.
                /// *   Deleting: The migration job is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The status information about the migration job.
                /// </summary>
                [NameInMap("StatusInfo")]
                [Validation(Required=false)]
                public string StatusInfo { get; set; }

                /// <summary>
                /// The system disk partitions.
                /// </summary>
                [NameInMap("SystemDiskParts")]
                [Validation(Required=false)]
                public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobSystemDiskParts SystemDiskParts { get; set; }
                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobSystemDiskParts : TeaModel {
                    [NameInMap("SystemDiskPart")]
                    [Validation(Required=false)]
                    public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobSystemDiskPartsSystemDiskPart> SystemDiskPart { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobSystemDiskPartsSystemDiskPart : TeaModel {
                        /// <summary>
                        /// Indicates whether block replication is enabled for the system disk partition.
                        /// </summary>
                        [NameInMap("Block")]
                        [Validation(Required=false)]
                        public bool? Block { get; set; }

                        /// <summary>
                        /// The device ID of the system disk partition.
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// The size of the system disk partition. Unit: bytes.
                        /// </summary>
                        [NameInMap("SizeBytes")]
                        [Validation(Required=false)]
                        public long? SizeBytes { get; set; }

                    }

                }

                /// <summary>
                /// The size of the system disk of the destination ECS instance.
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// The information about tags that are attached to the SMC resource.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobTags Tags { get; set; }
                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobTagsTag> Tag { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag N that is added to the SMC resource. Valid values of N: 1 to 20.
                        /// 
                        /// The tag key can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.[](http://https://。)
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N that is added to the SMC resource. Valid values of N: 1 to 20.
                        /// 
                        /// The tag value can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.[](http://https://。)
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The type of destination to which the source server is migrated. Valid values:
                /// 
                /// *   Image: After the migration job is complete, SMC generates an ECS image for the source server.
                /// *   ContainerImage: After the migration job is complete, SMC generates a Docker container image for the source server.
                /// *   TargetInstance: After the migration job is complete, SMC migrates the source server to the destination instance. If you set this parameter to TargetInstance, you must set the InstanceId parameter.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// The ID of the intermediate instance.
                /// </summary>
                [NameInMap("TransitionInstanceId")]
                [Validation(Required=false)]
                public string TransitionInstanceId { get; set; }

                /// <summary>
                /// The ID of the vSwitch in the specified VPC.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The time when the migration job expired. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// 
                /// >  The time displayed in the SMC console is in the format of UTC+8.
                /// </summary>
                [NameInMap("ValidTime")]
                [Validation(Required=false)]
                public string ValidTime { get; set; }

                /// <summary>
                /// The ID of a virtual private cloud (VPC) for which you have configured an Express Connect circuit or a VPN gateway.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of migration jobs returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
