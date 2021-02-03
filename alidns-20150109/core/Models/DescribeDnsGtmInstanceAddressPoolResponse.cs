// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("AddrPoolId")]
        [Validation(Required=true)]
        public string AddrPoolId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=true)]
        public string CreateTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=true)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=true)]
        public string UpdateTime { get; set; }

        [NameInMap("UpdateTimestamp")]
        [Validation(Required=true)]
        public long? UpdateTimestamp { get; set; }

        [NameInMap("AddrCount")]
        [Validation(Required=true)]
        public int? AddrCount { get; set; }

        [NameInMap("MonitorConfigId")]
        [Validation(Required=true)]
        public string MonitorConfigId { get; set; }

        [NameInMap("MonitorStatus")]
        [Validation(Required=true)]
        public string MonitorStatus { get; set; }

        [NameInMap("Name")]
        [Validation(Required=true)]
        public string Name { get; set; }

        [NameInMap("Type")]
        [Validation(Required=true)]
        public string Type { get; set; }

        [NameInMap("LbaStrategy")]
        [Validation(Required=true)]
        public string LbaStrategy { get; set; }

        [NameInMap("Addrs")]
        [Validation(Required=true)]
        public DescribeDnsGtmInstanceAddressPoolResponseAddrs Addrs { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolResponseAddrs : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmInstanceAddressPoolResponseAddrsAddr> Addr { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolResponseAddrsAddr : TeaModel {
                public string CreateTime { get; set; }
                public long? CreateTimestamp { get; set; }
                public string UpdateTime { get; set; }
                public long? UpdateTimestamp { get; set; }
                public string Addr { get; set; }
                public int? LbaWeight { get; set; }
                public string Mode { get; set; }
                public string AlertStatus { get; set; }
                public string Remark { get; set; }
                public string AttributeInfo { get; set; }
            }
        };

    }

}
