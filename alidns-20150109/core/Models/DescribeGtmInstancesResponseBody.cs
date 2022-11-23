// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstancesResponseBody : TeaModel {
        [NameInMap("GtmInstances")]
        [Validation(Required=false)]
        public DescribeGtmInstancesResponseBodyGtmInstances GtmInstances { get; set; }
        public class DescribeGtmInstancesResponseBodyGtmInstances : TeaModel {
            [NameInMap("GtmInstance")]
            [Validation(Required=false)]
            public List<DescribeGtmInstancesResponseBodyGtmInstancesGtmInstance> GtmInstance { get; set; }
            public class DescribeGtmInstancesResponseBodyGtmInstancesGtmInstance : TeaModel {
                [NameInMap("AccessStrategyNum")]
                [Validation(Required=false)]
                public int? AccessStrategyNum { get; set; }

                [NameInMap("AddressPoolNum")]
                [Validation(Required=false)]
                public int? AddressPoolNum { get; set; }

                [NameInMap("AlertGroup")]
                [Validation(Required=false)]
                public string AlertGroup { get; set; }

                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("CnameMode")]
                [Validation(Required=false)]
                public string CnameMode { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

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

                [NameInMap("LbaStrategy")]
                [Validation(Required=false)]
                public string LbaStrategy { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                [NameInMap("UserDomainName")]
                [Validation(Required=false)]
                public string UserDomainName { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

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
