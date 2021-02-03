// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=true)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=true)]
        public int? TotalPages { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("AddrPools")]
        [Validation(Required=true)]
        public DescribeDnsGtmInstanceAddressPoolsResponseAddrPools AddrPools { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolsResponseAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmInstanceAddressPoolsResponseAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolsResponseAddrPoolsAddrPool : TeaModel {
                public string AddrPoolId { get; set; }
                public string CreateTime { get; set; }
                public long? CreateTimestamp { get; set; }
                public string UpdateTime { get; set; }
                public long? UpdateTimestamp { get; set; }
                public int? AddrCount { get; set; }
                public string MonitorConfigId { get; set; }
                public string MonitorStatus { get; set; }
                public string Name { get; set; }
                public string Type { get; set; }
                public string LbaStrategy { get; set; }
            }
        };

    }

}
