// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeReplicationJobsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ReplicationJobs")]
        [Validation(Required=false)]
        public DescribeReplicationJobsResponseBodyReplicationJobs ReplicationJobs { get; set; }
        public class DescribeReplicationJobsResponseBodyReplicationJobs : TeaModel {
            [NameInMap("ReplicationJob")]
            [Validation(Required=false)]
            public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJob> ReplicationJob { get; set; }
            public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJob : TeaModel {
                public int? Frequency { get; set; }
                public string VpcId { get; set; }
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string ScheduledStartTime { get; set; }
                public int? MaxNumberOfImageToKeep { get; set; }
                public string ContainerNamespace { get; set; }
                public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisks DataDisks { get; set; }
                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisks : TeaModel {
                    [NameInMap("DataDisk")]
                    [Validation(Required=false)]
                    public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDisk> DataDisk { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDisk : TeaModel {
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        [NameInMap("Parts")]
                        [Validation(Required=false)]
                        public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskParts Parts { get; set; }
                        public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskParts : TeaModel {
                            [NameInMap("Part")]
                            [Validation(Required=false)]
                            public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskPartsPart> Part { get; set; }
                            public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobDataDisksDataDiskPartsPart : TeaModel {
                                public long? SizeBytes { get; set; }
                                public bool? Block { get; set; }
                                public string Device { get; set; }
                            }
                        };

                    }

                }
                public string StatusInfo { get; set; }
                public string InstanceRamRole { get; set; }
                public int? SystemDiskSize { get; set; }
                public string Description { get; set; }
                public string ReplicationParameters { get; set; }
                public string ErrorCode { get; set; }
                public string ValidTime { get; set; }
                public int? NetMode { get; set; }
                public string ContainerTag { get; set; }
                public string LicenseType { get; set; }
                public string Name { get; set; }
                public string ImageId { get; set; }
                public float? Progress { get; set; }
                public bool? RunOnce { get; set; }
                public string LaunchTemplateId { get; set; }
                public string ContainerRepository { get; set; }
                public string InstanceId { get; set; }
                public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobSystemDiskParts SystemDiskParts { get; set; }
                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobSystemDiskParts : TeaModel {
                    [NameInMap("SystemDiskPart")]
                    [Validation(Required=false)]
                    public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobSystemDiskPartsSystemDiskPart> SystemDiskPart { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobSystemDiskPartsSystemDiskPart : TeaModel {
                        [NameInMap("SizeBytes")]
                        [Validation(Required=false)]
                        public long? SizeBytes { get; set; }

                        [NameInMap("Block")]
                        [Validation(Required=false)]
                        public bool? Block { get; set; }

                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                    }

                }
                public string InstanceType { get; set; }
                public string SourceId { get; set; }
                public string LaunchTemplateVersion { get; set; }
                public string RegionId { get; set; }
                public string TransitionInstanceId { get; set; }
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public string VSwitchId { get; set; }
                public string JobId { get; set; }
                public string ImageName { get; set; }
                public string BusinessStatus { get; set; }
                public DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobReplicationJobRuns ReplicationJobRuns { get; set; }
                public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobReplicationJobRuns : TeaModel {
                    [NameInMap("ReplicationJobRun")]
                    [Validation(Required=false)]
                    public List<DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobReplicationJobRunsReplicationJobRun> ReplicationJobRun { get; set; }
                    public class DescribeReplicationJobsResponseBodyReplicationJobsReplicationJobReplicationJobRunsReplicationJobRun : TeaModel {
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                    }

                }
                public string TargetType { get; set; }
            }
        };

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
