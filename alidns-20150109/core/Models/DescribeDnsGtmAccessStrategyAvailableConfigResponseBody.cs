// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBody : TeaModel {
        [NameInMap("DomainAddrPools")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPools> DomainAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPools : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("AddrCount")]
            [Validation(Required=false)]
            public int? AddrCount { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("Ipv4AddrPools")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPools> Ipv4AddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPools : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("AddrCount")]
            [Validation(Required=false)]
            public int? AddrCount { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Ipv6AddrPools")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPools> Ipv6AddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPools : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("AddrCount")]
            [Validation(Required=false)]
            public int? AddrCount { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("SuggestSetDefaultLine")]
        [Validation(Required=false)]
        public bool? SuggestSetDefaultLine { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLines> Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLines : TeaModel {
            [NameInMap("FatherCode")]
            [Validation(Required=false)]
            public string FatherCode { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("LineCode")]
            [Validation(Required=false)]
            public string LineCode { get; set; }

            [NameInMap("LineName")]
            [Validation(Required=false)]
            public string LineName { get; set; }

            [NameInMap("GroupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

        }

    }

}
