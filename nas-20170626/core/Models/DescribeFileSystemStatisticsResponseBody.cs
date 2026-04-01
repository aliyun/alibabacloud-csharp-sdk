// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemStatisticsResponseBody : TeaModel {
        [NameInMap("FileSystemStatistics")]
        [Validation(Required=false)]
        public DescribeFileSystemStatisticsResponseBodyFileSystemStatistics FileSystemStatistics { get; set; }
        public class DescribeFileSystemStatisticsResponseBodyFileSystemStatistics : TeaModel {
            [NameInMap("FileSystemStatistic")]
            [Validation(Required=false)]
            public List<DescribeFileSystemStatisticsResponseBodyFileSystemStatisticsFileSystemStatistic> FileSystemStatistic { get; set; }
            public class DescribeFileSystemStatisticsResponseBodyFileSystemStatisticsFileSystemStatistic : TeaModel {
                [NameInMap("ExpiredCount")]
                [Validation(Required=false)]
                public int? ExpiredCount { get; set; }

                [NameInMap("ExpiringCount")]
                [Validation(Required=false)]
                public int? ExpiringCount { get; set; }

                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public DescribeFileSystemStatisticsResponseBodyFileSystems FileSystems { get; set; }
        public class DescribeFileSystemStatisticsResponseBodyFileSystems : TeaModel {
            [NameInMap("FileSystem")]
            [Validation(Required=false)]
            public List<DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystem> FileSystem { get; set; }
            public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystem : TeaModel {
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                [NameInMap("MeteredIASize")]
                [Validation(Required=false)]
                public long? MeteredIASize { get; set; }

                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                [NameInMap("Packages")]
                [Validation(Required=false)]
                public DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackages Packages { get; set; }
                public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackages : TeaModel {
                    [NameInMap("Package")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackagesPackage> Package { get; set; }
                    public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackagesPackage : TeaModel {
                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public long? Size { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

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
