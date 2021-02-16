// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemStatisticsResponseBody : TeaModel {
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public DescribeFileSystemStatisticsResponseBodyFileSystems FileSystems { get; set; }
        public class DescribeFileSystemStatisticsResponseBodyFileSystems : TeaModel {
            [NameInMap("FileSystem")]
            [Validation(Required=false)]
            public List<DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystem> FileSystem { get; set; }
            public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystem : TeaModel {
                public string Status { get; set; }
                public long? Capacity { get; set; }
                public long? MeteredIASize { get; set; }
                public string CreateTime { get; set; }
                public string ChargeType { get; set; }
                public string StorageType { get; set; }
                public string RegionId { get; set; }
                public string FileSystemType { get; set; }
                public string FileSystemId { get; set; }
                public long? MeteredSize { get; set; }
                public string Description { get; set; }
                public string ExpiredTime { get; set; }
                public string ZoneId { get; set; }
                public DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackages Packages { get; set; }
                public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackages : TeaModel {
                    [NameInMap("Package")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackagesPackage> Package { get; set; }
                    public class DescribeFileSystemStatisticsResponseBodyFileSystemsFileSystemPackagesPackage : TeaModel {
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public long? Size { get; set; }

                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                    }

                }
                public string ProtocolType { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("FileSystemStatistics")]
        [Validation(Required=false)]
        public DescribeFileSystemStatisticsResponseBodyFileSystemStatistics FileSystemStatistics { get; set; }
        public class DescribeFileSystemStatisticsResponseBodyFileSystemStatistics : TeaModel {
            [NameInMap("FileSystemStatistic")]
            [Validation(Required=false)]
            public List<DescribeFileSystemStatisticsResponseBodyFileSystemStatisticsFileSystemStatistic> FileSystemStatistic { get; set; }
            public class DescribeFileSystemStatisticsResponseBodyFileSystemStatisticsFileSystemStatistic : TeaModel {
                public string FileSystemType { get; set; }
                public long? MeteredSize { get; set; }
                public int? ExpiringCount { get; set; }
                public int? TotalCount { get; set; }
                public int? ExpiredCount { get; set; }
            }
        };

    }

}
