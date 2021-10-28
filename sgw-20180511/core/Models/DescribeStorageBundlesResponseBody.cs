// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeStorageBundlesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageBundles")]
        [Validation(Required=false)]
        public DescribeStorageBundlesResponseBodyStorageBundles StorageBundles { get; set; }
        public class DescribeStorageBundlesResponseBodyStorageBundles : TeaModel {
            [NameInMap("StorageBundle")]
            [Validation(Required=false)]
            public List<DescribeStorageBundlesResponseBodyStorageBundlesStorageBundle> StorageBundle { get; set; }
            public class DescribeStorageBundlesResponseBodyStorageBundlesStorageBundle : TeaModel {
                public string BackendBucketRegionId { get; set; }
                public long? CreatedTime { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
                public string StorageBundleId { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
