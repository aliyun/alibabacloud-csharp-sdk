// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The statistics of file systems.
        /// </summary>
        [NameInMap("FileSystemStatistics")]
        [Validation(Required=false)]
        public DescribeFileSystemStatisticsResponseBodyFileSystemStatistics FileSystemStatistics { get; set; }
        public class DescribeFileSystemStatisticsResponseBodyFileSystemStatistics : TeaModel {
            [NameInMap("FileSystemStatistic")]
            [Validation(Required=false)]
            public List<DescribeFileSystemStatisticsResponseBodyFileSystemStatisticsFileSystemStatistic> FileSystemStatistic { get; set; }
            public class DescribeFileSystemStatisticsResponseBodyFileSystemStatisticsFileSystemStatistic : TeaModel {
                /// <summary>
                /// The number of expired file systems.
                /// </summary>
                [NameInMap("ExpiredCount")]
                [Validation(Required=false)]
                public int? ExpiredCount { get; set; }

                /// <summary>
                /// The number of expiring file systems.
                /// 
                /// File systems whose expiration time is less than or equal to seven days away from the current time are counted.
                /// </summary>
                [NameInMap("ExpiringCount")]
                [Validation(Required=false)]
                public int? ExpiringCount { get; set; }

                /// <summary>
                /// The type of the file system.
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// The storage usage of the file system.
                /// 
                /// The value of this parameter is the maximum storage usage of the file system over the last hour.
                /// 
                /// Unit: bytes.
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                /// <summary>
                /// The number of file systems of the current type.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// The queried file systems.
        /// </summary>
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public DescribeFileSystemStatisticsResponseBodyFileSystems FileSystems { get; set; }
        public class DescribeFileSystemStatisticsResponseBodyFileSystems : TeaModel {
            [NameInMap("FileSystem")]
            [Validation(Required=false)]
            public List<DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystem> FileSystem { get; set; }
            public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystem : TeaModel {
                /// <summary>
                /// The capacity of the file system.
                /// 
                /// Unit: GiB.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                /// <summary>
                /// The billing method.
                /// 
                /// Valid values:
                /// 
                /// *   Subscription: The subscription billing method is used.
                /// *   PayAsYouGo: The pay-as-you-go billing method is used.
                /// *   Package: A storage plan is attached to the file system.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The time when the NAS file system was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the file system.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the file system expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The ID of the file system.
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// The type of the file system.
                /// 
                /// Valid values:
                /// 
                /// *   standard: General-purpose NAS file system
                /// *   extreme: Extreme NAS file system
                /// *   cpfs: CPFS file system
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// The storage usage of the Infrequent Access (IA) storage medium.
                /// 
                /// Unit: bytes.
                /// </summary>
                [NameInMap("MeteredIASize")]
                [Validation(Required=false)]
                public long? MeteredIASize { get; set; }

                /// <summary>
                /// The storage usage of the file system.
                /// 
                /// The value of this parameter is the maximum storage usage of the file system over the last hour. Unit: bytes.
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                /// <summary>
                /// The information about storage plans.
                /// </summary>
                [NameInMap("Packages")]
                [Validation(Required=false)]
                public DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackages Packages { get; set; }
                public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackages : TeaModel {
                    [NameInMap("Package")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackagesPackage> Package { get; set; }
                    public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackagesPackage : TeaModel {
                        /// <summary>
                        /// The end time of the validity period for the storage plan.
                        /// </summary>
                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        /// <summary>
                        /// The ID of the storage plan.
                        /// </summary>
                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                        /// <summary>
                        /// The capacity of the storage plan.
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public long? Size { get; set; }

                        /// <summary>
                        /// The start time of the validity period for the storage plan.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// The protocol type of the file system.
                /// 
                /// Valid values:
                /// 
                /// *   NFS: Network File System (NFS)
                /// *   SMB: Server Message Block (SMB)
                /// *   cpfs: the protocol type supported by the CPFS file system
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The status of the file system.
                /// 
                /// This parameter is returned for Extreme NAS file systems and Cloud Parallel File Storage (CPFS) file systems. Valid values:
                /// 
                /// *   Pending: The file system is being created or modified.
                /// *   Running: The file system is available. Before you create a mount target for the file system, make sure that the file system is in the Running state.
                /// *   Stopped: The file system is unavailable.
                /// *   Extending: The file system is being scaled out.
                /// *   Stopping: The file system is being disabled.
                /// *   Deleting: The file system is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The storage type.
                /// 
                /// Valid values:
                /// 
                /// *   Valid values for General-purpose NAS file systems: Capacity and Performance.
                /// *   Valid values for Extreme NAS file systems: standard and advance.
                /// *   Valid values for CPFS file systems: advance\_100 (100 MB/s/TiB baseline) and advance\_200 (200 MB/s/TiB baseline).
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of file system entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
