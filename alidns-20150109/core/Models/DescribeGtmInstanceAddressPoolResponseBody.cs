// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceAddressPoolResponseBody : TeaModel {
        [NameInMap("AddrCount")]
        [Validation(Required=false)]
        public int? AddrCount { get; set; }

        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public DescribeGtmInstanceAddressPoolResponseBodyAddrs Addrs { get; set; }
        public class DescribeGtmInstanceAddressPoolResponseBodyAddrs : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeGtmInstanceAddressPoolResponseBodyAddrsAddr> Addr { get; set; }
            public class DescribeGtmInstanceAddressPoolResponseBodyAddrsAddr : TeaModel {
                [NameInMap("AddrId")]
                [Validation(Required=false)]
                public long? AddrId { get; set; }

                [NameInMap("AlertStatus")]
                [Validation(Required=false)]
                public string AlertStatus { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("LbaWeight")]
                [Validation(Required=false)]
                public int? LbaWeight { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("MinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? MinAvailableAddrNum { get; set; }

        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        [NameInMap("MonitorStatus")]
        [Validation(Required=false)]
        public string MonitorStatus { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

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
