// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBody : TeaModel {
        [NameInMap("SelectedDomainLines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedDomainLines SelectedDomainLines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedDomainLines : TeaModel {
            [NameInMap("SelectedDomainLine")]
            [Validation(Required=false)]
            public List<string> SelectedDomainLine { get; set; }
        };

        [NameInMap("DomainAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPools DomainAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPools : TeaModel {
            [NameInMap("DomainAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPoolsDomainAddrPool> DomainAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPoolsDomainAddrPool : TeaModel {
                public string Name { get; set; }
                public int? AddrCount { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("Ipv4AddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPools Ipv4AddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPools : TeaModel {
            [NameInMap("Ipv4AddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPoolsIpv4AddrPool> Ipv4AddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPoolsIpv4AddrPool : TeaModel {
                public string Name { get; set; }
                public int? AddrCount { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SelectedIpv4Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedIpv4Lines SelectedIpv4Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedIpv4Lines : TeaModel {
            [NameInMap("SelectedIpv4Line")]
            [Validation(Required=false)]
            public List<string> SelectedIpv4Line { get; set; }
        };

        [NameInMap("Ipv6AddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPools Ipv6AddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPools : TeaModel {
            [NameInMap("Ipv6AddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPoolsIpv6AddrPool> Ipv6AddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPoolsIpv6AddrPool : TeaModel {
                public string Name { get; set; }
                public int? AddrCount { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("SuggestSetDefaultLine")]
        [Validation(Required=false)]
        public bool? SuggestSetDefaultLine { get; set; }

        [NameInMap("SelectedIpv6Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedIpv6Lines SelectedIpv6Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedIpv6Lines : TeaModel {
            [NameInMap("SelectedIpv6Line")]
            [Validation(Required=false)]
            public List<string> SelectedIpv6Line { get; set; }
        };

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLines Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLinesLine> Line { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLinesLine : TeaModel {
                public string FatherCode { get; set; }
                public string GroupName { get; set; }
                public string LineCode { get; set; }
                public string LineName { get; set; }
                public string GroupCode { get; set; }
            }
        };

    }

}
