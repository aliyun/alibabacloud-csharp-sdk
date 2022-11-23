// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolsResponseBody : TeaModel {
        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool : TeaModel {
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("LbaStrategy")]
                [Validation(Required=false)]
                public string LbaStrategy { get; set; }

                [NameInMap("MonitorConfigId")]
                [Validation(Required=false)]
                public string MonitorConfigId { get; set; }

                [NameInMap("MonitorStatus")]
                [Validation(Required=false)]
                public string MonitorStatus { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

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
