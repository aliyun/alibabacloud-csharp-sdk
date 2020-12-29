// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolsResponseBody : TeaModel {
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
        public List<DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPools> AddrPools { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPools : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            [NameInMap("MonitorStatus")]
            [Validation(Required=false)]
            public string MonitorStatus { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("AddrPoolId")]
            [Validation(Required=false)]
            public string AddrPoolId { get; set; }

            [NameInMap("LbaStrategy")]
            [Validation(Required=false)]
            public string LbaStrategy { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("AddrCount")]
            [Validation(Required=false)]
            public int? AddrCount { get; set; }

            [NameInMap("MonitorConfigId")]
            [Validation(Required=false)]
            public string MonitorConfigId { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

        }

    }

}
