// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeIspFlushCacheInstancesResponseBody : TeaModel {
        [NameInMap("IspFlushCacheInstances")]
        [Validation(Required=false)]
        public List<DescribeIspFlushCacheInstancesResponseBodyIspFlushCacheInstances> IspFlushCacheInstances { get; set; }
        public class DescribeIspFlushCacheInstancesResponseBodyIspFlushCacheInstances : TeaModel {
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("ExpireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("QuotaInfo")]
            [Validation(Required=false)]
            public DescribeIspFlushCacheInstancesResponseBodyIspFlushCacheInstancesQuotaInfo QuotaInfo { get; set; }
            public class DescribeIspFlushCacheInstancesResponseBodyIspFlushCacheInstancesQuotaInfo : TeaModel {
                [NameInMap("InstanceQuota")]
                [Validation(Required=false)]
                public int? InstanceQuota { get; set; }
                [NameInMap("InstanceQuotaUsed")]
                [Validation(Required=false)]
                public int? InstanceQuotaUsed { get; set; }
            };

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
