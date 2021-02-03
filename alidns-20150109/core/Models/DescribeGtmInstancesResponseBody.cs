// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstancesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("GtmInstances")]
        [Validation(Required=false)]
        public DescribeGtmInstancesResponseBodyGtmInstances GtmInstances { get; set; }
        public class DescribeGtmInstancesResponseBodyGtmInstances : TeaModel {
            [NameInMap("GtmInstance")]
            [Validation(Required=false)]
            public List<DescribeGtmInstancesResponseBodyGtmInstancesGtmInstance> GtmInstance { get; set; }
            public class DescribeGtmInstancesResponseBodyGtmInstancesGtmInstance : TeaModel {
                public string ExpireTime { get; set; }
                public int? AccessStrategyNum { get; set; }
                public string CreateTime { get; set; }
                public string CnameMode { get; set; }
                public string InstanceId { get; set; }
                public long? ExpireTimestamp { get; set; }
                public int? Ttl { get; set; }
                public string AlertGroup { get; set; }
                public int? AddressPoolNum { get; set; }
                public string InstanceName { get; set; }
                public string LbaStrategy { get; set; }
                public string Cname { get; set; }
                public string VersionCode { get; set; }
                public string UserDomainName { get; set; }
                public long? CreateTimestamp { get; set; }
            }
        };

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}
