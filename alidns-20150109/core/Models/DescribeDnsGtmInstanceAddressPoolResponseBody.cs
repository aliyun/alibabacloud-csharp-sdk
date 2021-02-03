// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolResponseBody : TeaModel {
        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceAddressPoolResponseBodyAddrs Addrs { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolResponseBodyAddrs : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmInstanceAddressPoolResponseBodyAddrsAddr> Addr { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolResponseBodyAddrsAddr : TeaModel {
                public long? UpdateTimestamp { get; set; }
                public string AttributeInfo { get; set; }
                public string UpdateTime { get; set; }
                public string AlertStatus { get; set; }
                public string Remark { get; set; }
                public int? LbaWeight { get; set; }
                public string Addr { get; set; }
                public string CreateTime { get; set; }
                public string Mode { get; set; }
                public long? CreateTimestamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("AddrCount")]
        [Validation(Required=false)]
        public int? AddrCount { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        [NameInMap("MonitorStatus")]
        [Validation(Required=false)]
        public string MonitorStatus { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

    }

}
