// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeReplicationJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The details of migration jobs.</para>
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
                /// <para>The business status of the migration job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Preparing: The migration is being prepared.</description></item>
                /// <item><description>Syncing: Data is being synchronized.</description></item>
                /// <item><description>Processing: The migration is in progress.</description></item>
                /// <item><description>Cleaning: Intermediate resources are being released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Preparing</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The namespace of the destination Docker container image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testNamespace</para>
                /// </summary>
                [NameInMap("ContainerNamespace")]
                [Validation(Required=false)]
                public string ContainerNamespace { get; set; }

                /// <summary>
                /// <para>The repository that stores the destination Docker container image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testRepository</para>
                /// </summary>
                [NameInMap("ContainerRepository")]
                [Validation(Required=false)]
                public string ContainerRepository { get; set; }

                /// <summary>
                /// <para>The tag of the destination Docker container image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS:v1</para>
                /// </summary>
                [NameInMap("ContainerTag")]
                [Validation(Required=false)]
                public string ContainerTag { get; set; }

                /// <summary>
                /// <para>The time when the migration job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-07-24T13:00:52Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The data disks on the destination ECS instance.</para>
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
                        /// <para>The index number of the data disk.</para>
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
                        [NameInMap("Parts")]
                        [Validation(Required=false)]
                        public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskParts Parts { get; set; }
                        public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskParts : TeaModel {
                            [NameInMap("Part")]
                            [Validation(Required=false)]
                            public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskPartsPart> Part { get; set; }
                            public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskPartsPart : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether block replication is enabled for the data disk partition.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("Block")]
                                [Validation(Required=false)]
                                public bool? Block { get; set; }

                                /// <summary>
                                /// <para>The device ID of the data disk partition.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0_1</para>
                                /// </summary>
                                [NameInMap("Device")]
                                [Validation(Required=false)]
                                public string Device { get; set; }

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

                        }

                        /// <summary>
                        /// <para>The size of the data disk. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>40</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                    }

                }

                /// <summary>
                /// <para>The description of the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is my migration task.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The information about the disk.</para>
                /// </summary>
                [NameInMap("Disks")]
                [Validation(Required=false)]
                public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisks Disks { get; set; }
                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisks : TeaModel {
                    /// <summary>
                    /// <para>The information about the data disk.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksData Data { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksData : TeaModel {
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksDataData> Data { get; set; }
                        public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksDataData : TeaModel {
                            /// <summary>
                            /// <para>The ID of the data disk.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>d-2zeh4twm100qskw7z41z</para>
                            /// </summary>
                            [NameInMap("DiskId")]
                            [Validation(Required=false)]
                            public string DiskId { get; set; }

                            /// <summary>
                            /// <para>Specifies whether to use LVM. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true: Use LVM.</description></item>
                            /// <item><description>false: Not use LVM.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("LVM")]
                            [Validation(Required=false)]
                            public bool? LVM { get; set; }

                            /// <summary>
                            /// <para>The information about the data disk partition.</para>
                            /// </summary>
                            [NameInMap("Parts")]
                            [Validation(Required=false)]
                            public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksDataDataParts Parts { get; set; }
                            public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksDataDataParts : TeaModel {
                                [NameInMap("Part")]
                                [Validation(Required=false)]
                                public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksDataDataPartsPart> Part { get; set; }
                                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksDataDataPartsPart : TeaModel {
                                    /// <summary>
                                    /// <para>Whether block replication is enabled for the data disk partition. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description>true: Block replication is enabled for the data disk partition.</description></item>
                                    /// <item><description>false: Block replication is disabled for the data disk partition.</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>false</para>
                                    /// </summary>
                                    [NameInMap("Block")]
                                    [Validation(Required=false)]
                                    public bool? Block { get; set; }

                                    /// <summary>
                                    /// <para>The path of the data disk partition.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>/home/data</para>
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

                            }

                            /// <summary>
                            /// <para>The size of a data disk on the destination ECS instance. Unit: GiB. Valid values: 20 to 32768.</para>
                            /// <remarks>
                            /// <para> The size of a destination data disk must be larger than the size of data in the corresponding source data disk. For example, if the size of the source disk is 500 GiB but the actual used space is 100 GiB, you must set this parameter to a value greater than 100 GiB.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>22548578304</para>
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public int? Size { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The information about the system disk.</para>
                    /// </summary>
                    [NameInMap("System")]
                    [Validation(Required=false)]
                    public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksSystem System { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksSystem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the system disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d-2zeh4twm100qskw7z41z</para>
                        /// </summary>
                        [NameInMap("DiskId")]
                        [Validation(Required=false)]
                        public string DiskId { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to use LVM. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: Use LVM.</description></item>
                        /// <item><description>false: Not use LVM.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("LVM")]
                        [Validation(Required=false)]
                        public bool? LVM { get; set; }

                        /// <summary>
                        /// <para>The information about the system disk partition.</para>
                        /// </summary>
                        [NameInMap("Parts")]
                        [Validation(Required=false)]
                        public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksSystemParts Parts { get; set; }
                        public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksSystemParts : TeaModel {
                            [NameInMap("Part")]
                            [Validation(Required=false)]
                            public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksSystemPartsPart> Part { get; set; }
                            public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDisksSystemPartsPart : TeaModel {
                                /// <summary>
                                /// <para>Specifies whether block replication is enabled for the system disk partition. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: Block replication is enabled for the system disk partition.</description></item>
                                /// <item><description>false: Block replication is disabled for the system disk partition.</description></item>
                                /// </list>
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
                                /// <para>21474836480</para>
                                /// </summary>
                                [NameInMap("SizeBytes")]
                                [Validation(Required=false)]
                                public long? SizeBytes { get; set; }

                            }

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
                /// <para>The time when the migration job was complete. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// <remarks>
                /// <para> The time displayed in the SMC console is in the format of UTC+8.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-04T16:00:52Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The error code returned if an error occurred in the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InternalError</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The interval at which the incremental migration job runs. Unit: hour. Valid values: 1 to 168.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public int? Frequency { get; set; }

                /// <summary>
                /// <para>The ID of the destination image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-o6w3gy99qf89rkga****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The name of the destination image.</para>
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
                /// <para>i-bp1ff25rzvnul6kr****</para>
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
                /// <para>The instance type of the intermediate instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.sn1ne.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The ID of the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>j-bp19vlwm0tyigbmj****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

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
                /// <para>lt-launchtemplateid</para>
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// <para>The versions of the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LaunchTemplateVersion")]
                [Validation(Required=false)]
                public string LaunchTemplateVersion { get; set; }

                /// <summary>
                /// <para>The type of license for the migration job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>An empty value indicates no license.</description></item>
                /// <item><description>A value of BYOL indicates Bring Your Own License (BYOL).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BYOL</para>
                /// </summary>
                [NameInMap("LicenseType")]
                [Validation(Required=false)]
                public string LicenseType { get; set; }

                /// <summary>
                /// <para>The maximum number of images retained for the incremental migration job. Valid values: 1 to 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("MaxNumberOfImageToKeep")]
                [Validation(Required=false)]
                public int? MaxNumberOfImageToKeep { get; set; }

                /// <summary>
                /// <para>The name of the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testMigrationTaskName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of network used for the migration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetMode")]
                [Validation(Required=false)]
                public int? NetMode { get; set; }

                /// <summary>
                /// <para>The progress of the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public float? Progress { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud region to which the source server is migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The execution records of the migration job.</para>
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
                        /// <para>The time when the migration job ended. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                        /// <remarks>
                        /// <para> The time displayed in the SMC console is in the format of UTC+8.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-10-04T13:35:00Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The ID of the destination image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>m-o6w3gy99qf89rkga****</para>
                        /// </summary>
                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                        /// <summary>
                        /// <para>The time when the migration job was started. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                        /// <remarks>
                        /// <para> The time displayed in the SMC console is in the format of UTC+8.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-10-01T13:35:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The method used to run the migration job. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Manual: The migration job was manually started.</description></item>
                        /// <item><description>Schedule: The migration job was started at a scheduled time or at a specific interval.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Schedule</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The string of key-value pairs configured for the replication driver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BandWidthLimit:0</para>
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

                /// <summary>
                /// <para>Indicates whether incremental migration is disabled for the source server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Incremental migration is disabled. A migration job runs only once after the job is created.</description></item>
                /// <item><description>false: Incremental migration is enabled. For an incremental migration job, SMC synchronizes incremental data to Alibaba Cloud at the interval specified by the <c>Frequency</c> parameter.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RunOnce")]
                [Validation(Required=false)]
                public bool? RunOnce { get; set; }

                /// <summary>
                /// <para>The time when the migration job is scheduled to run. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. The time must meet the following requirements:</para>
                /// <list type="bullet">
                /// <item><description>The value must be within 30 days after the current time.</description></item>
                /// <item><description>If you do not specify this parameter, you must manually start the migration job after the migration job is created. You can call the <a href="https://help.aliyun.com/document_detail/121823.html">StartReplicationJob</a> operation to start the migration job.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-04T13:35:00Z</para>
                /// </summary>
                [NameInMap("ScheduledStartTime")]
                [Validation(Required=false)]
                public string ScheduledStartTime { get; set; }

                /// <summary>
                /// <para>The ID of the source server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp1e2fsl57knvuug****</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The time when the migration job was started. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// <remarks>
                /// <para> The time displayed in the SMC console is in the format of UTC+8.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-04T14:40:52Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the migration job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Ready: The migration job is not started.</description></item>
                /// <item><description>Running: The migration job is running.</description></item>
                /// <item><description>Stopped: The migration job is paused.</description></item>
                /// <item><description>InError: An error occurs in the migration job.</description></item>
                /// <item><description>Finished: The migration job is complete.</description></item>
                /// <item><description>Waiting: The migration job is waiting to run.</description></item>
                /// <item><description>Expired: The migration job has expired.</description></item>
                /// <item><description>Deleting: The migration job is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The status information about the migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>statusinfo</para>
                /// </summary>
                [NameInMap("StatusInfo")]
                [Validation(Required=false)]
                public string StatusInfo { get; set; }

                /// <summary>
                /// <para>The system disk partitions.</para>
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
                        /// <para>Indicates whether block replication is enabled for the system disk partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Block")]
                        [Validation(Required=false)]
                        public bool? Block { get; set; }

                        /// <summary>
                        /// <para>The device ID of the system disk partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0_1</para>
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

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

                }

                /// <summary>
                /// <para>The size of the system disk of the destination ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The information about tags that are attached to the SMC resource.</para>
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
                        /// <para>The key of the tag N that is added to the SMC resource. Valid values of N: 1 to 20.</para>
                        /// <para>The tag key can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.<a href="http://https://%E3%80%82"></a></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N that is added to the SMC resource. Valid values of N: 1 to 20.</para>
                        /// <para>The tag value can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.<a href="http://https://%E3%80%82"></a></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of destination to which the source server is migrated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Image: After the migration job is complete, SMC generates an ECS image for the source server.</description></item>
                /// <item><description>ContainerImage: After the migration job is complete, SMC generates a Docker container image for the source server.</description></item>
                /// <item><description>TargetInstance: After the migration job is complete, SMC migrates the source server to the destination instance. If you set this parameter to TargetInstance, you must set the InstanceId parameter.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Image</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>The ID of the intermediate instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1ff25rzvnul6kr****</para>
                /// </summary>
                [NameInMap("TransitionInstanceId")]
                [Validation(Required=false)]
                public string TransitionInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch in the specified VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1ddbrxdlrcbim46****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The time when the migration job expired. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// <remarks>
                /// <para> The time displayed in the SMC console is in the format of UTC+8.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-08T14:40:52Z</para>
                /// </summary>
                [NameInMap("ValidTime")]
                [Validation(Required=false)]
                public string ValidTime { get; set; }

                /// <summary>
                /// <para>The ID of a virtual private cloud (VPC) for which you have configured an Express Connect circuit or a VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1vwnn14rqpyiczj****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("WorkgroupId")]
                [Validation(Required=false)]
                public string WorkgroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E1187E8-843A-4850-B97E-2F17F00D48F7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of migration jobs returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
