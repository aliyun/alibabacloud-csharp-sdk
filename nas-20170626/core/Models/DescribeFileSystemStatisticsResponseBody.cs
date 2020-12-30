// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemStatisticsResponseBody : TeaModel {
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
