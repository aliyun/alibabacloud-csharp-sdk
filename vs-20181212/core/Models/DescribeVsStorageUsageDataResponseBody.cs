// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStorageUsageDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public DescribeVsStorageUsageDataResponseBodyStorageUsage StorageUsage { get; set; }
        public class DescribeVsStorageUsageDataResponseBodyStorageUsage : TeaModel {
            [NameInMap("StorageUsageDataModule")]
            [Validation(Required=false)]
            public List<DescribeVsStorageUsageDataResponseBodyStorageUsageStorageUsageDataModule> StorageUsageDataModule { get; set; }
            public class DescribeVsStorageUsageDataResponseBodyStorageUsageStorageUsageDataModule : TeaModel {
                public string Bucket { get; set; }
                public int? StorageDataValue { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
