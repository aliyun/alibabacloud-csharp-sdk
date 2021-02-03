// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceAddressPoolsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeGtmInstanceAddressPoolsResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeGtmInstanceAddressPoolsResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool : TeaModel {
                public string Type { get; set; }
                public string Status { get; set; }
                public string UpdateTime { get; set; }
                public string CreateTime { get; set; }
                public string MonitorConfigId { get; set; }
                public int? MinAvailableAddrNum { get; set; }
                public long? UpdateTimestamp { get; set; }
                public string MonitorStatus { get; set; }
                public string AddrPoolId { get; set; }
                public string Name { get; set; }
                public int? AddrCount { get; set; }
                public long? CreateTimestamp { get; set; }
            }
        };

    }

}
