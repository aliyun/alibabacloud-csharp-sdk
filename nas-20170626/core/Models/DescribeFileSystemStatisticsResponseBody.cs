// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics of file systems.</para>
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
                /// <para>The number of expired file systems.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExpiredCount")]
                [Validation(Required=false)]
                public int? ExpiredCount { get; set; }

                /// <summary>
                /// <para>The number of expiring file systems.</para>
                /// <para>File systems whose expiration time is less than or equal to seven days away from the current time are counted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExpiringCount")]
                [Validation(Required=false)]
                public int? ExpiringCount { get; set; }

                /// <summary>
                /// <para>The type of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// <para>The storage usage of the file system.</para>
                /// <para>The value of this parameter is the maximum storage usage of the file system over the last hour.</para>
                /// <para>Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611</para>
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                /// <summary>
                /// <para>The number of file systems of the current type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The queried file systems.</para>
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
                /// <para>The capacity of the file system.</para>
                /// <para>Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                /// <summary>
                /// <para>The billing method.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Subscription: The subscription billing method is used.</description></item>
                /// <item><description>PayAsYouGo: The pay-as-you-go billing method is used.</description></item>
                /// <item><description>Package: A storage plan is attached to the file system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The time when the NAS file system was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-05-27T15:43:06CST</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31a8e48eda</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the file system expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-27T15:43:06CST</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>109c04****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The type of the file system.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard: General-purpose NAS file system</description></item>
                /// <item><description>extreme: Extreme NAS file system</description></item>
                /// <item><description>cpfs: CPFS file system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// <para>The storage usage of the Infrequent Access (IA) storage medium.</para>
                /// <para>Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>362832</para>
                /// </summary>
                [NameInMap("MeteredIASize")]
                [Validation(Required=false)]
                public long? MeteredIASize { get; set; }

                /// <summary>
                /// <para>The storage usage of the file system.</para>
                /// <para>The value of this parameter is the maximum storage usage of the file system over the last hour. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611661312</para>
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                /// <summary>
                /// <para>The information about storage plans.</para>
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
                        /// <para>The end time of the validity period for the storage plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-01-05T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        /// <summary>
                        /// <para>The ID of the storage plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>naspackage-0be9c4b624-37****</para>
                        /// </summary>
                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                        /// <summary>
                        /// <para>The capacity of the storage plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>107374182400</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public long? Size { get; set; }

                        /// <summary>
                        /// <para>The start time of the validity period for the storage plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-05T01:40:56Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The protocol type of the file system.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NFS: Network File System (NFS)</description></item>
                /// <item><description>SMB: Server Message Block (SMB)</description></item>
                /// <item><description>cpfs: the protocol type supported by the CPFS file system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NFS</para>
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of the file system.</para>
                /// <para>This parameter is returned for Extreme NAS file systems and Cloud Parallel File Storage (CPFS) file systems. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The file system is being created or modified.</description></item>
                /// <item><description>Running: The file system is available. Before you create a mount target for the file system, make sure that the file system is in the Running state.</description></item>
                /// <item><description>Stopped: The file system is unavailable.</description></item>
                /// <item><description>Extending: The file system is being scaled out.</description></item>
                /// <item><description>Stopping: The file system is being disabled.</description></item>
                /// <item><description>Deleting: The file system is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Valid values for General-purpose NAS file systems: Capacity and Performance.</description></item>
                /// <item><description>Valid values for Extreme NAS file systems: standard and advance.</description></item>
                /// <item><description>Valid values for CPFS file systems: advance_100 (100 MB/s/TiB baseline) and advance_200 (200 MB/s/TiB baseline).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Performance</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F088138-FD73-4B68-95CC-DFAD4D85****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of file system entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
