// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyAvailableConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("SuggestSetDefaultLine")]
        [Validation(Required=true)]
        public bool? SuggestSetDefaultLine { get; set; }

        [NameInMap("Ipv4AddrPools")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseIpv4AddrPools Ipv4AddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseIpv4AddrPools : TeaModel {
            [NameInMap("Ipv4AddrPool")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseIpv4AddrPoolsIpv4AddrPool> Ipv4AddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseIpv4AddrPoolsIpv4AddrPool : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
                public int? AddrCount { get; set; }
            }
        };

        [NameInMap("Lines")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseLines Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseLinesLine> Line { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseLinesLine : TeaModel {
                public string LineCode { get; set; }
                public string LineName { get; set; }
                public string GroupCode { get; set; }
                public string GroupName { get; set; }
                public string FatherCode { get; set; }
            }
        };

        [NameInMap("Ipv6AddrPools")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseIpv6AddrPools Ipv6AddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseIpv6AddrPools : TeaModel {
            [NameInMap("Ipv6AddrPool")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseIpv6AddrPoolsIpv6AddrPool> Ipv6AddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseIpv6AddrPoolsIpv6AddrPool : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
                public int? AddrCount { get; set; }
            }
        };

        [NameInMap("DomainAddrPools")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseDomainAddrPools DomainAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseDomainAddrPools : TeaModel {
            [NameInMap("DomainAddrPool")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseDomainAddrPoolsDomainAddrPool> DomainAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseDomainAddrPoolsDomainAddrPool : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
                public int? AddrCount { get; set; }
            }
        };

        [NameInMap("SelectedIpv4Lines")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseSelectedIpv4Lines SelectedIpv4Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseSelectedIpv4Lines : TeaModel {
            [NameInMap("SelectedIpv4Line")]
            [Validation(Required=true)]
            public List<string> SelectedIpv4Line { get; set; }
        };

        [NameInMap("SelectedIpv6Lines")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseSelectedIpv6Lines SelectedIpv6Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseSelectedIpv6Lines : TeaModel {
            [NameInMap("SelectedIpv6Line")]
            [Validation(Required=true)]
            public List<string> SelectedIpv6Line { get; set; }
        };

        [NameInMap("SelectedDomainLines")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseSelectedDomainLines SelectedDomainLines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseSelectedDomainLines : TeaModel {
            [NameInMap("SelectedDomainLine")]
            [Validation(Required=true)]
            public List<string> SelectedDomainLine { get; set; }
        };

    }

}
